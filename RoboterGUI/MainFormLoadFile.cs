﻿/* MainFormLoadFile
 * Methods to load data (nc, svg, dxf, pictures)
 * Load setups
 * */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace RoboterGUI
{
    public partial class MainForm
    {
        #region MAIN-MENU FILE
        // open a file via dialog
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "gcode files (*.nc)|*.nc|SVG files (*.svg)|*.svg|DXF files (*.dxf)|*.dxf|Drill files (*.drd, *.drl)|*.drd;*.drl|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                loadFile(openFileDialog1.FileName);
                isHeightMapApplied = false;
            }
        }
        // handle MRU List
        private int MRUnumber = 20;
        private List<string> MRUlist = new List<string>();
        private void SaveRecentFile(string path)
        {
            //   recentToolStripMenuItem.DropDownItems.Clear();
            toolStripMenuItem2.DropDownItems.Clear();
            LoadRecentList(); //load list from file
            if (MRUlist.Contains(path)) //prevent duplication on recent list
                MRUlist.Remove(path);
            MRUlist.Insert(0, path);    //insert given path into list on top
                                        //keep list number not exceeded the given value
            while (MRUlist.Count > MRUnumber)
            { MRUlist.RemoveAt(MRUlist.Count - 1); }
            foreach (string item in MRUlist)
            {
                ToolStripMenuItem fileRecent = new ToolStripMenuItem(item, null, RecentFile_click);
                //           recentToolStripMenuItem.DropDownItems.Add(fileRecent);
                toolStripMenuItem2.DropDownItems.Add(fileRecent); //add the menu to "recent" menu
            }
            StreamWriter stringToWrite =
            new StreamWriter(System.Environment.CurrentDirectory + "\\Recent.txt");
            foreach (string item in MRUlist)
            { stringToWrite.WriteLine(item); }
            stringToWrite.Flush(); //write stream to file
            stringToWrite.Close(); //close the stream and reclaim memory
        }
        private void LoadRecentList()
        {
            MRUlist.Clear();
            try
            {
                StreamReader listToRead =
                new StreamReader(System.Environment.CurrentDirectory + "\\Recent.txt");
                string line;
                MRUlist.Clear();
                while ((line = listToRead.ReadLine()) != null) //read each line until end of file
                    MRUlist.Add(line); //insert to list
                listToRead.Close(); //close the stream
            }
            catch (Exception) { }
        }
        private void RecentFile_click(object sender, EventArgs e)
        {
            loadFile(sender.ToString());
        }

        private void preset2DView()
        {   Cursor.Current = Cursors.WaitCursor;
            pictureBox1.BackgroundImage = null;
            visuGCode.setPosMarker(new xyPoint(0, 0));
            visuGCode.createMarkerPath(); ;
            visuGCode.drawMachineLimit(toolTable.getToolCordinates());
        }
        private void loadFile(string fileName)
        {
            if (fileName.IndexOf("http") >= 0)
            {   tBURL.Text = fileName;
                return;
            }
            else
            {   if (!File.Exists(fileName))
                {   MessageBox.Show("File not found: '" + fileName + "'");
                    return;
                }
            }
            preset2DView();

            String ext = Path.GetExtension(fileName).ToLower();
            if (ext == ".svg")
            { startConvertSVG(fileName); }
            else if (ext == ".dxf")
            { startConvertDXF(fileName); }
            else if ((ext == ".drd") || (ext == ".drl") || (ext == ".dri"))
            { startConvertDrill(fileName); }
            else if (ext == ".nc")
            {   tbFile.Text = fileName;
                loadGcode();
            }
            else if ((ext == ".bmp") || (ext == ".gif") || (ext == ".png") || (ext == ".jpg"))
            {   if (_image_form == null)
                {
                    _image_form = new GCodeFromImage(true);
                    _image_form.FormClosed += formClosed_ImageToGCode;
                    _image_form.btnGenerate.Click += getGCodeFromImage;      // assign btn-click event
                }
                else
                {   _image_form.Visible = false;
                }
                _image_form.Show(this);
                _image_form.loadExtern(fileName);
            }
            SaveRecentFile(fileName);
            setLastLoadedFile("Data from file: " + fileName);

            if (ext == ".url")
            { getURL(fileName); }
            Cursor.Current = Cursors.Default;
            pBoxTransform.Reset();
        }

        private void setLastLoadedFile(string text)
        {
            lastLoadSource = text;
            if (_setup_form != null)
            { _setup_form.setLastLoadedFile(lastLoadSource); }
        }
        private void getURL(string filename)
        {
            var MyIni = new IniFile(filename);
            tBURL.Text = MyIni.Read("URL", "InternetShortcut");
        }

        // drag and drop file or URL
        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {   e.Effect = DragDropEffects.All;
        }
        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string s = (string)e.Data.GetData(DataFormats.Text);
            if (files != null)
            {   loadFile(files[0]);}
            else if (s.Length > 0)
            {   tBURL.Text = s; }
            this.WindowState = FormWindowState.Normal;
        }
        private void tBURL_TextChanged(object sender, EventArgs e)
        {
            var parts = tBURL.Text.Split('.');
            string ext = parts[parts.Length - 1];   // get extension
            if (ext.ToLower().IndexOf("svg") >= 0)
            {
                startConvertSVG(tBURL.Text);
                setLastLoadedFile("Data from URL: " + tBURL.Text);
                tBURL.Text = "";
            }
            else if (ext.ToLower().IndexOf("dxf") >= 0)
            {
                startConvertDXF(tBURL.Text);
                setLastLoadedFile("Data from URL: " + tBURL.Text);
                tBURL.Text = "";
            }
            else if ((ext.ToLower().IndexOf("bmp") >= 0) || (ext.ToLower().IndexOf("gif") >= 0) || (ext.ToLower().IndexOf("png") >= 0) || (ext.ToLower().IndexOf("jpg") >= 0))
            {
                if (_image_form == null)
                {
                    _image_form = new GCodeFromImage(true);
                    _image_form.FormClosed += formClosed_ImageToGCode;
                    _image_form.btnGenerate.Click += getGCodeFromImage;      // assign btn-click event
                }
                else
                {
                    _image_form.Visible = false;
                }
                _image_form.Show(this);
                _image_form.loadURL(tBURL.Text);
                setLastLoadedFile("Data from URL: " + tBURL.Text);
                tBURL.Text = "";
            }
            else
            {
                if (tBURL.Text.Length > 5)
                {
                    MessageBox.Show("URL extension is not 'svg' or 'dxf'\r\nTry SVG import anyway, but without setting 'Recent File' list.");
                    startConvertSVG(tBURL.Text);
                }
            }
        }
        private void reloadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {   reStartConvertSVG(sender, e);
        }
        public void reStartConvertSVG(object sender, EventArgs e)   // event from setup form
        {   if (!isStreaming)
            {
                this.Cursor = Cursors.WaitCursor;
                if (lastLoadSource.IndexOf("Clipboard") >= 0)
                { loadFromClipboard(); }
                else
                { loadFile(lastSource); }
                this.Cursor = Cursors.Default;
            }
        }
        public void moveToPickup(object sender, EventArgs e)   // event from setup form
        {   sendCommand(_setup_form.commandToSend);
            _setup_form.commandToSend = "";
        }
        private string lastSource = "";
        private void startConvertSVG(string source)
        {   lastSource = source;                        // store current file-path/name
            preset2DView();
            string gcode = GCodeFromSVG.convertFromFile(source);
            blockFCTB_Events = true;
            if (gcode.Length > 2)
            {
                fCTBCode.Text = gcode;
                fCTBCode.UnbookmarkLine(fCTBCodeClickedLineLast);
                redrawGCodePath();
                SaveRecentFile(source);
                this.Text = appName + " | Source: " + source;
            }
            this.Cursor = Cursors.Default;
            updateControls();
        }

        private void startConvertDXF(string source)
        {   lastSource = source;                        // store current file-path/name
            preset2DView();
            string gcode = GCodeFromDXF.ConvertFromFile(source);
            blockFCTB_Events = true;
            if (gcode.Length > 2)
            {   fCTBCode.Text = gcode;
                fCTBCode.UnbookmarkLine(fCTBCodeClickedLineLast);
                redrawGCodePath();
                SaveRecentFile(source);
                this.Text = appName + " | Source: " + source;
            }
            this.Cursor = Cursors.Default;
            updateControls();
        }

        private void startConvertDrill(string source)
        {   lastSource = source;                        // store current file-path/name
            preset2DView();
            string gcode = GCodeFromDrill.ConvertFile(source);
            blockFCTB_Events = true;
            if (gcode.Length > 2)
            {   fCTBCode.Text = gcode;
                fCTBCode.UnbookmarkLine(fCTBCodeClickedLineLast);
                redrawGCodePath();
                SaveRecentFile(source);
                this.Text = appName + " | Source: " + source;
            }
            this.Cursor = Cursors.Default;
            updateControls();
        }


        bool blockFCTB_Events = true;
        private void loadGcode()
        {
            if (File.Exists(tbFile.Text))
            {
                fCTBCode.UnbookmarkLine(fCTBCodeClickedLineLast);
                fCTBCodeClickedLineNow = 0;
                fCTBCodeClickedLineLast = 0;
                visuGCode.setPosMarker(new xyPoint(0, 0));
                blockFCTB_Events = true;
                fCTBCode.OpenFile(tbFile.Text);
                if (_serial_form.isLasermode && Properties.Settings.Default.ctrlReplaceEnable)
                {
                    if (Properties.Settings.Default.ctrlReplaceM3)
                    {
                        fCTBCode.Text = fCTBCode.Text.Replace("M3", "M4");
                        fCTBCode.Text = "(!!! Replaced M3 by M4 !!!)\r\n" + fCTBCode.Text.Replace("M03", "M04");
                    }
                    else
                    {
                        fCTBCode.Text = fCTBCode.Text.Replace("M4", "M3");
                        fCTBCode.Text = "(!!! Replaced M4 by M3 !!!)\r\n" + fCTBCode.Text.Replace("M04", "M03");
                    }
                }

                redrawGCodePath();
//                blockFCTB_Events = false;
                lbInfo.Text = "G-Code loaded";
                lbInfo.BackColor = SystemColors.Control;
                updateControls();
                SaveRecentFile(tbFile.Text);
                this.Text = appName + " | File: " + tbFile.Text;
            }
        }

        // save content from TextEditor (GCode) to file
        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "GCode|*.nc";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string txt = fCTBCode.Text;
                File.WriteAllText(sfd.FileName, txt);
            }
        }
        // save Properties.Settings.Default... to text-file
        private void saveMachineParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Machine Ini files (*.ini)|*.ini";
            sfd.FileName = "GRBL-Plotter.ini";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var MyIni = new IniFile(sfd.FileName);
                MyIni.WriteAll(_serial_form.GRBLSettings);
            }
        }
        // load Properties.Settings.Default... from text-file
        private void loadMachineParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "GRBL-Plotter.ini";
            openFileDialog1.Filter = "Machine Ini files (*.ini)|*.ini";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var MyIni = new IniFile(openFileDialog1.FileName);
                MyIni.ReadAll();
                loadSettings(sender, e);
            }
        }

        // switch language
        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.language = "en";
            MessageBox.Show("Restart of GRBL-Plotter is needed");
        }
        private void deutschToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.language = "de-DE";
            MessageBox.Show("Ein Neustart von GRBL-Plotter ist erforderlich");
        }
        #endregion

        // Ctrl-V to paste graphics
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)         // ctrl V = paste
            {
                loadFromClipboard();
                e.SuppressKeyPress = true;
            }
            else if ((e.KeyCode == Keys.Space) && (pictureBox1.Focused))    // space = hide pen-up path
            {
                showPathPenUp = false;
                pictureBox1.Invalidate();
            }
            else if (e.KeyCode == Keys.NumLock)
                virtualJoystickXY.Focus();

            if (virtualJoystickXY.Focused || virtualJoystickZ.Focused || virtualJoystickE.Focused)
            {   if ((e.KeyCode == Keys.NumPad4) || (e.KeyCode == Keys.Left))   // 4 = left
                { virtualJoystickXY_move(-virtualJoystickXY_lastIndex, 0); }
                else if ((e.KeyCode == Keys.NumPad6) || (e.KeyCode == Keys.Right))  // 6 = right
                { virtualJoystickXY_move(virtualJoystickXY_lastIndex, 0); }
                else if ((e.KeyCode == Keys.NumPad2) || (e.KeyCode == Keys.Down))   // 2 = down
                { virtualJoystickXY_move(0, -virtualJoystickXY_lastIndex); }
                else if ((e.KeyCode == Keys.NumPad8) || (e.KeyCode == Keys.Up))     // 8 = up
                { virtualJoystickXY_move(0, virtualJoystickXY_lastIndex); }
                else if (e.KeyCode == Keys.NumPad1)                                 // 1 = 
                { virtualJoystickXY_move(-virtualJoystickXY_lastIndex, -virtualJoystickXY_lastIndex); }
                else if (e.KeyCode == Keys.NumPad7)                                 // 7 = 
                { virtualJoystickXY_move(-virtualJoystickXY_lastIndex, virtualJoystickXY_lastIndex); }
                else if (e.KeyCode == Keys.NumPad9)                                 // 9 = 
                { virtualJoystickXY_move(virtualJoystickXY_lastIndex, virtualJoystickXY_lastIndex); }
                else if (e.KeyCode == Keys.NumPad3)                                 // 3 = 
                { virtualJoystickXY_move(virtualJoystickXY_lastIndex, -virtualJoystickXY_lastIndex); }

                else if (e.KeyCode == Keys.NumPad5)                                 // 5 = Stop jogging
                { if (!_serial_form.isGrblVers0) sendRealtimeCommand(133); }    //0x85

                else if (e.KeyCode == Keys.Home)
                {
                    virtualJoystickXY_lastIndex++;
                    if (virtualJoystickXY_lastIndex > virtualJoystickXY.JoystickRaster) virtualJoystickXY_lastIndex = virtualJoystickXY.JoystickRaster;
                    if (virtualJoystickXY_lastIndex < 1) virtualJoystickXY_lastIndex = 1;
                }
                else if (e.KeyCode == Keys.End)
                {
                    virtualJoystickXY_lastIndex--;
                    if (virtualJoystickXY_lastIndex > virtualJoystickXY.JoystickRaster) virtualJoystickXY_lastIndex = virtualJoystickXY.JoystickRaster;
                    if (virtualJoystickXY_lastIndex < 1) virtualJoystickXY_lastIndex = 1;
                }
                else if ((e.KeyCode == Keys.Add))   // 4 = left
                {   virtualJoystickZ_move(-virtualJoystickZ_lastIndex);      }
                else if ((e.KeyCode == Keys.Subtract))   // 4 = left
                {   virtualJoystickZ_move(virtualJoystickZ_lastIndex);       }

                else if (e.KeyCode == Keys.PageUp)
                {    virtualJoystickZ_lastIndex++;
                    if (virtualJoystickZ_lastIndex > virtualJoystickZ.JoystickRaster) virtualJoystickZ_lastIndex = virtualJoystickZ.JoystickRaster;
                    if (virtualJoystickZ_lastIndex < 1) virtualJoystickZ_lastIndex = 1;
                }
                else if (e.KeyCode == Keys.PageDown)
                {    virtualJoystickZ_lastIndex--;
                    if (virtualJoystickZ_lastIndex > virtualJoystickZ.JoystickRaster) virtualJoystickZ_lastIndex = virtualJoystickZ.JoystickRaster;
                    if (virtualJoystickZ_lastIndex < 1) virtualJoystickZ_lastIndex = 1;
                }

                virtualJoystickXY.JoystickRasterMark = virtualJoystickXY_lastIndex;
                virtualJoystickZ.JoystickRasterMark = virtualJoystickZ_lastIndex;
                virtualJoystickE.JoystickRasterMark = virtualJoystickE_lastIndex;
                virtualJoystickA.JoystickRasterMark = virtualJoystickA_lastIndex;
                virtualJoystickB.JoystickRasterMark = virtualJoystickB_lastIndex;
                virtualJoystickC.JoystickRasterMark = virtualJoystickC_lastIndex;

                e.SuppressKeyPress = true;
            }
            //   e.SuppressKeyPress = true;
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)  // KeyDown in MainFormLoadFile 344
        {
            if ((e.KeyCode == Keys.Space))
            {   showPathPenUp = true;
                pictureBox1.Invalidate();
            }
            if (((e.KeyCode >= Keys.NumPad0) && (e.KeyCode <= Keys.NumPad9)) || e.KeyCode <= Keys.Add || e.KeyCode <= Keys.Subtract)     // send jog-stop
                if (!_serial_form.isGrblVers0 && cBSendJogStop.Checked) sendRealtimeCommand(133);
        }

        // paste from clipboard SVG or image
        private void loadFromClipboard()
        {
            preset2DView();
            string svg_format1 = "image/x-inkscape-svg";
            string svg_format2 = "image/svg+xml";
            IDataObject iData = Clipboard.GetDataObject();
            if (iData.GetDataPresent(DataFormats.Text))
            {
                string checkContent = (String)iData.GetData(DataFormats.Text);
                string[] checkLines = checkContent.Split('\n');
                int posSVG = checkContent.IndexOf("<svg ");
                if ((posSVG >= 0) && (posSVG < 2))
                {
                    MemoryStream stream = new MemoryStream();
                    stream = (MemoryStream)iData.GetData("text");
                    byte[] bytes = stream.ToArray();
                    string txt = "";
                    if (!(checkContent.IndexOf("<?xml version") >= 0))
                        txt += "<?xml version=\"1.0\"?>\r\n";
                    txt += System.Text.Encoding.Default.GetString(bytes);
                    if (!(txt.IndexOf("xmlns") >= 0))
                        txt = txt.Replace("<svg", "<svg xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\" ");

                    this.Cursor = Cursors.WaitCursor;
                    //MessageBox.Show(txt);
                    string gcode = GCodeFromSVG.convertFromText(txt.Trim((char)0x00),true);    // import as mm
                    if (gcode.Length > 2)
                    {
                        fCTBCode.Text = gcode;
                        fCTBCode.UnbookmarkLine(fCTBCodeClickedLineLast);
                        redrawGCodePath();
                        this.Text = appName + " | Source: from Clipboard";
                    }
                    this.Cursor = Cursors.Default;
                    updateControls();
                    setLastLoadedFile("Data from Clipboard: SVG");
                }
                else if ((checkLines[0].Trim() == "0") && (checkLines[1].Trim() == "SECTION"))
                {
                    MemoryStream stream = new MemoryStream();
                    stream = (MemoryStream)iData.GetData("text");
                    byte[] bytes = stream.ToArray();
                    string txt = System.Text.Encoding.Default.GetString(bytes);

                    this.Cursor = Cursors.WaitCursor;
                    //MessageBox.Show(txt);
                    string gcode = GCodeFromDXF.convertFromText(txt);
                    if (gcode.Length > 2)
                    {
                        fCTBCode.Text = gcode;
                        fCTBCode.UnbookmarkLine(fCTBCodeClickedLineLast);
                        redrawGCodePath();
                        this.Text = appName + " | Source: from Clipboard";
                    }
                    this.Cursor = Cursors.Default;
                    updateControls();
                    setLastLoadedFile("Data from Clipboard: DXF");
                }
                else
                {
                    fCTBCode.Text = (String)iData.GetData(DataFormats.Text);
                    fCTBCode.UnbookmarkLine(fCTBCodeClickedLineLast);
                    redrawGCodePath();
                    setLastLoadedFile("Data from Clipboard: Text");
                }
            }
            else if (iData.GetDataPresent(svg_format1) || iData.GetDataPresent(svg_format2))
            {
                MemoryStream stream = new MemoryStream();
                if (iData.GetDataPresent(svg_format1))
                    stream = (MemoryStream)iData.GetData(svg_format1);
                else
                    stream = (MemoryStream)iData.GetData(svg_format2);

                byte[] bytes = stream.ToArray();
                string txt = System.Text.Encoding.Default.GetString(bytes);
                this.Cursor = Cursors.WaitCursor;

                string gcode = GCodeFromSVG.convertFromText(txt);
                if (gcode.Length > 2)
                {
                    fCTBCode.Text = gcode;
                    fCTBCode.UnbookmarkLine(fCTBCodeClickedLineLast);
                    redrawGCodePath();
                    this.Text = appName + " | Source: from Clipboard";
                }
                this.Cursor = Cursors.Default;
                updateControls();
                setLastLoadedFile("Data from Clipboard: SVG");
            }
            else if (iData.GetDataPresent(DataFormats.Bitmap))
            {
                if (_image_form == null)
                {
                    _image_form = new GCodeFromImage(true);
                    _image_form.FormClosed += formClosed_ImageToGCode;
                    _image_form.btnGenerate.Click += getGCodeFromImage;      // assign btn-click event
                }
                else
                {
                    _image_form.Visible = false;
                }
                _image_form.Show(this);
                _image_form.loadClipboard();
                setLastLoadedFile("Data from Clipboard: Image");
            }
            else
            {
                string tmp = "";
                foreach (string format in iData.GetFormats())
                { tmp += format + "\r\n"; }
                MessageBox.Show(tmp);
            }
        }

        private void pasteFromClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        { loadFromClipboard(); }

        // load settings
        public void loadSettings(object sender, EventArgs e)
        {
            try
            {
                if (Properties.Settings.Default.UpgradeRequired)
                {
                    Properties.Settings.Default.Upgrade();
                    Properties.Settings.Default.UpgradeRequired = false;
                    Properties.Settings.Default.Save();
                }
                tbFile.Text = Properties.Settings.Default.file;
                setCustomButton(btnCustom1, Properties.Settings.Default.custom1);
                setCustomButton(btnCustom2, Properties.Settings.Default.custom2);
                setCustomButton(btnCustom3, Properties.Settings.Default.custom3);
                setCustomButton(btnCustom4, Properties.Settings.Default.custom4);
                setCustomButton(btnCustom5, Properties.Settings.Default.custom5);
                setCustomButton(btnCustom6, Properties.Settings.Default.custom6);
                setCustomButton(btnCustom7, Properties.Settings.Default.custom7);
                setCustomButton(btnCustom8, Properties.Settings.Default.custom8);
                fCTBCode.BookmarkColor = Properties.Settings.Default.colorMarker; ;
                pictureBox1.BackColor = Properties.Settings.Default.colorBackground;
                //                visuGCode.setColors();
                penUp.Color = Properties.Settings.Default.colorPenUp;
                penDown.Color = Properties.Settings.Default.colorPenDown;
                penHeightMap.Color = Properties.Settings.Default.colorHeightMap;
                penRuler.Color = Properties.Settings.Default.colorRuler;
                penTool.Color = Properties.Settings.Default.colorTool;
                penMarker.Color = Properties.Settings.Default.colorMarker;
                penHeightMap.Width = (float)Properties.Settings.Default.widthHeightMap;
                penRuler.Width = (float)Properties.Settings.Default.widthRuler;
                penUp.Width = (float)Properties.Settings.Default.widthPenUp;
                penDown.Width = (float)Properties.Settings.Default.widthPenDown;
                penTool.Width = (float)Properties.Settings.Default.widthTool;
                penMarker.Width = (float)Properties.Settings.Default.widthMarker;
                brushMachineLimit = new HatchBrush(HatchStyle.DiagonalCross, Properties.Settings.Default.colorMachineLimit,Color.Transparent);
                picBoxBackround = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                commentOut = Properties.Settings.Default.ctrlCommentOut;
                updateDrawing();

                joystickXYStep[0] = 0;
                joystickXYStep[1] = (double)Properties.Settings.Default.joyXYStep1;
                joystickXYStep[2] = (double)Properties.Settings.Default.joyXYStep2;
                joystickXYStep[3] = (double)Properties.Settings.Default.joyXYStep3;
                joystickXYStep[4] = (double)Properties.Settings.Default.joyXYStep4;
                joystickXYStep[5] = (double)Properties.Settings.Default.joyXYStep5;
                joystickZStep[0] = 0;
                joystickZStep[1] = (double)Properties.Settings.Default.joyZStep1;
                joystickZStep[2] = (double)Properties.Settings.Default.joyZStep2;
                joystickZStep[3] = (double)Properties.Settings.Default.joyZStep3;
                joystickZStep[4] = (double)Properties.Settings.Default.joyZStep4;
                joystickZStep[5] = (double)Properties.Settings.Default.joyZStep5;
                joystickXYSpeed[0] = 0.1;
                joystickXYSpeed[1] = (double)Properties.Settings.Default.joyXYSpeed1;
                joystickXYSpeed[2] = (double)Properties.Settings.Default.joyXYSpeed2;
                joystickXYSpeed[3] = (double)Properties.Settings.Default.joyXYSpeed3;
                joystickXYSpeed[4] = (double)Properties.Settings.Default.joyXYSpeed4;
                joystickXYSpeed[5] = (double)Properties.Settings.Default.joyXYSpeed5;
                joystickZSpeed[0] = 0.1;
                joystickZSpeed[1] = (double)Properties.Settings.Default.joyZSpeed1;
                joystickZSpeed[2] = (double)Properties.Settings.Default.joyZSpeed2;
                joystickZSpeed[3] = (double)Properties.Settings.Default.joyZSpeed3;
                joystickZSpeed[4] = (double)Properties.Settings.Default.joyZSpeed4;
                joystickZSpeed[5] = (double)Properties.Settings.Default.joyZSpeed5;
                virtualJoystickXY.JoystickLabel = joystickXYStep;
                virtualJoystickZ.JoystickLabel = joystickZStep;
                virtualJoystickE.JoystickLabel = joystickZStep;
                skaliereXAufDrehachseToolStripMenuItem.Enabled = false;
                skaliereXAufDrehachseToolStripMenuItem.BackColor = SystemColors.Control;
                skaliereXAufDrehachseToolStripMenuItem.ToolTipText = "Enable rotary axis in Setup - Control";
                skaliereAufXUnitsToolStripMenuItem.BackColor = SystemColors.Control;
                skaliereAufXUnitsToolStripMenuItem.ToolTipText = "Enable in Setup - Control";
                skaliereYAufDrehachseToolStripMenuItem.Enabled = false;
                skaliereYAufDrehachseToolStripMenuItem.BackColor = SystemColors.Control;
                skaliereYAufDrehachseToolStripMenuItem.ToolTipText = "Enable rotary axis in Setup - Control";
                skaliereAufYUnitsToolStripMenuItem.BackColor = SystemColors.Control;
                skaliereAufYUnitsToolStripMenuItem.ToolTipText = "Enable in Setup - Control";
                toolStrip_tb_rotary_diameter.Text = string.Format("{0:0.00}", Properties.Settings.Default.rotarySubstitutionDiameter);

                if (Properties.Settings.Default.rotarySubstitutionEnable)
                {
                    string tmp = string.Format("Calculating rotary angle depending on part diameter ({0:0.00} units) and desired size.\r\nSet part diameter in Setup - Control.", Properties.Settings.Default.rotarySubstitutionDiameter);
                    if (Properties.Settings.Default.rotarySubstitutionX)
                    {
                        skaliereXAufDrehachseToolStripMenuItem.Enabled = true;
                        skaliereXAufDrehachseToolStripMenuItem.BackColor = Color.Yellow;
                        skaliereAufXUnitsToolStripMenuItem.BackColor = Color.Yellow;
                        skaliereAufXUnitsToolStripMenuItem.ToolTipText = tmp;
                        skaliereXAufDrehachseToolStripMenuItem.ToolTipText = "";
                    }
                    else
                    {
                        skaliereYAufDrehachseToolStripMenuItem.Enabled = true;
                        skaliereYAufDrehachseToolStripMenuItem.BackColor = Color.Yellow;
                        skaliereAufYUnitsToolStripMenuItem.BackColor = Color.Yellow;
                        skaliereAufYUnitsToolStripMenuItem.ToolTipText = tmp;
                        skaliereYAufDrehachseToolStripMenuItem.ToolTipText = "";
                    }
                }
                if (Properties.Settings.Default.rotarySubstitutionSetupEnable)
                {
                    string[] commands;
                    if (Properties.Settings.Default.rotarySubstitutionEnable)
                    { commands = Properties.Settings.Default.rotarySubstitutionSetupOn.Split(';'); }
                    else
                    { commands = Properties.Settings.Default.rotarySubstitutionSetupOff.Split(';'); }
                    if (_serial_form.serialPortOpen)
                        foreach (string cmd in commands)
                        {
                            sendCommand(cmd.Trim());
                            Thread.Sleep(100);
                        }
                }

                ctrl4thAxis = Properties.Settings.Default.ctrl4thUse;
                ctrl4thName = Properties.Settings.Default.ctrl4thName;
                label_e.Visible = ctrl4thAxis;
                label_e.Text = ctrl4thName;
                label_we.Visible = ctrl4thAxis;
                btnZeroE.Visible = ctrl4thAxis;
                btnZeroE.Text = "Zero " + ctrl4thName;
                if (Properties.Settings.Default.language == "de-DE")
                    btnZeroE.Text = ctrl4thName + " nullen";

                virtualJoystickE.Visible = ctrl4thAxis;
               
                if (ctrl4thAxis)
                {
                    //label_status0.Location = new Point(1, 128);
                    //label_status.Location = new Point(1, 148);
                    //btnHome.Location = new Point(122, 138);
                    //btnHome.Size = new Size(117, 30);
                    virtualJoystickXY.Size = new Size(160, 160);
                    virtualJoystickZ.Size = new Size(30, 160);
                    virtualJoystickZ.Location = new Point(166, 115);
                }
                else
                {
                    //label_status0.Location = new Point(1, 118);
                    //label_status.Location = new Point(1, 138);
                    //btnHome.Location = new Point(122, 111);
                    //btnHome.Size = new Size(117, 57);
                    virtualJoystickXY.Size = new Size(180, 180);
                    virtualJoystickZ.Size = new Size(40, 180);
                    virtualJoystickZ.Location = new Point(186, 115);
                }
                gamePadTimer.Enabled = Properties.Settings.Default.gPEnable;
                checkMachineLimit();
            }
            catch (Exception a)
            {
                MessageBox.Show("Load Settings: " + a);
                //               logError("Loading settings", e);
            }
        }
        // Save settings
        public void saveSettings()
        {
            try
            {
                Properties.Settings.Default.file = tbFile.Text;
                Properties.Settings.Default.Save();
            }
            catch (Exception e)
            {
                MessageBox.Show("Save Settings: " + e);
                //               logError("Saving settings", e);
            }
        }
        // update controls on Main form
        public void updateControls(bool allowControl = false)
        {
            bool isConnected = _serial_form.serialPortOpen;
            virtualJoystickXY.Enabled = isConnected && (!isStreaming || allowControl);
            virtualJoystickZ.Enabled = isConnected && (!isStreaming || allowControl);
            virtualJoystickE.Enabled = isConnected && (!isStreaming || allowControl);
            btnCustom1.Enabled = isConnected && (!isStreaming || allowControl);
            btnCustom2.Enabled = isConnected & !isStreaming | allowControl;
            btnCustom3.Enabled = isConnected & !isStreaming | allowControl;
            btnCustom4.Enabled = isConnected & !isStreaming | allowControl;
            btnCustom5.Enabled = isConnected & !isStreaming | allowControl;
            btnCustom6.Enabled = isConnected & !isStreaming | allowControl;
            btnCustom7.Enabled = isConnected & !isStreaming | allowControl;
            btnCustom8.Enabled = isConnected & !isStreaming | allowControl;
            //btnHome.Enabled = isConnected & !isStreaming | allowControl;
            btnZeroX.Enabled = isConnected & !isStreaming | allowControl;
            btnZeroY.Enabled = isConnected & !isStreaming | allowControl;
            btnZeroZ.Enabled = isConnected & !isStreaming | allowControl;
            btnZeroE.Enabled = isConnected & !isStreaming | allowControl;
            btnZeroA.Enabled = isConnected & !isStreaming | allowControl;
            btnZeroB.Enabled = isConnected & !isStreaming | allowControl;
            btnZeroC.Enabled = isConnected & !isStreaming | allowControl;
            btnZeroXY.Enabled = isConnected & !isStreaming | allowControl;
            btnZeroXYZ.Enabled = isConnected & !isStreaming | allowControl;
            btnZeroABC.Enabled = isConnected & !isStreaming | allowControl;


            btnOffsetApply.Enabled = !isStreaming;
            gCodeToolStripMenuItem.Enabled = !isStreaming;

            cBGreifer.Enabled = isConnected & !isStreaming | allowControl;
            tBSpeed.Enabled = isConnected & !isStreaming | allowControl;
            cBTool.Enabled = isConnected & !isStreaming | allowControl;
            btnReset.Enabled = isConnected;
            btnFeedHold.Enabled = isConnected;
            btnResume.Enabled = isConnected;
            btnKillAlarm.Enabled = isConnected;
            btnStreamStart.Enabled = isConnected;// & isFileLoaded;
            btnStreamStop.Enabled = isConnected; // & isFileLoaded;
            btnStreamCheck.Enabled = isConnected;// & isFileLoaded;

            btnJogStop.Visible = !_serial_form.isGrblVers0;
            btnJogStop.Enabled = isConnected & !isStreaming | allowControl;
            btnOverrideFRGB.Enabled = !_serial_form.isGrblVers0 & isConnected;// & isStreaming | allowControl;
        }
    }
}
