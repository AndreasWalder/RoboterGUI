/*  GRBL-Plotter. Another GCode sender for GRBL.
    This file is part of the GRBL-Plotter application.
   
    Copyright (C) 2015-2018 Sven Hasemann contact: svenhb@web.de

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
using System;

namespace RoboterGUI
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                picBoxBackround.Dispose();
                StyleComment.Dispose();
                StyleFWord.Dispose();
                StyleGWord.Dispose();
                StyleMWord.Dispose();
                StyleSWord.Dispose();
                StyleTool.Dispose();
                StyleXAxis.Dispose();
                StyleYAxis.Dispose();
                StyleZAxis.Dispose();
                StyleEAxis.Dispose();
                StyleAAxis.Dispose();
                StyleBAxis.Dispose();
                StyleCAxis.Dispose();
                penDown.Dispose();
                penMarker.Dispose();
                penRuler.Dispose();
                penTool.Dispose();
                penUp.Dispose();
                pBoxTransform.Dispose();
                penHeightMap.Dispose();
                brushMachineLimit.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.setupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.saveMachineParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMachineParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deutschToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createGCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textWizzardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSimpleShapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mirrorXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mirrorYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.rotate90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate90ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateFreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_tb_rotate = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_tb_XY_scale = new System.Windows.Forms.ToolStripTextBox();
            this.skalierenXYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_tb_XY_X_scale = new System.Windows.Forms.ToolStripTextBox();
            this.skalierenXYUmXUnitsZuErreichenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_tb_XY_Y_scale = new System.Windows.Forms.ToolStripTextBox();
            this.skaliereXUmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_tb_X_scale = new System.Windows.Forms.ToolStripTextBox();
            this.skaliereAufXUnitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_tb_X_X_scale = new System.Windows.Forms.ToolStripTextBox();
            this.skaliereYUmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_tb_Y_scale = new System.Windows.Forms.ToolStripTextBox();
            this.skaliereAufYUnitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_tb_Y_Y_scale = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.rotaryDimaeterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_tb_rotary_diameter = new System.Windows.Forms.ToolStripTextBox();
            this.skaliereXAufDrehachseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_tb_X_A_scale = new System.Windows.Forms.ToolStripTextBox();
            this.skaliereYAufDrehachseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_tb_Y_A_scale = new System.Windows.Forms.ToolStripTextBox();
            this.ersetzteG23DurchLinienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heightMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlStreamingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.control2ndGRBLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_wx = new System.Windows.Forms.Label();
            this.label_wy = new System.Windows.Forms.Label();
            this.label_wz = new System.Windows.Forms.Label();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPause2000 = new System.Windows.Forms.Button();
            this.btnPause1000 = new System.Windows.Forms.Button();
            this.btnTeachen = new System.Windows.Forms.Button();
            this.btnPause300 = new System.Windows.Forms.Button();
            this.btnLimitExceed = new System.Windows.Forms.Button();
            this.btnOverrideFRGB = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblOverrideFRValue = new System.Windows.Forms.Label();
            this.btnOverrideFR1 = new System.Windows.Forms.Button();
            this.btnOverrideFR2 = new System.Windows.Forms.Button();
            this.btnOverrideFR0 = new System.Windows.Forms.Button();
            this.btnOverrideFR4 = new System.Windows.Forms.Button();
            this.btnOverrideFR3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnOffsetApply = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbOffsetY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOffsetX = new System.Windows.Forms.TextBox();
            this.rBOrigin9 = new System.Windows.Forms.RadioButton();
            this.rBOrigin8 = new System.Windows.Forms.RadioButton();
            this.rBOrigin7 = new System.Windows.Forms.RadioButton();
            this.rBOrigin6 = new System.Windows.Forms.RadioButton();
            this.rBOrigin5 = new System.Windows.Forms.RadioButton();
            this.rBOrigin4 = new System.Windows.Forms.RadioButton();
            this.rBOrigin3 = new System.Windows.Forms.RadioButton();
            this.rBOrigin2 = new System.Windows.Forms.RadioButton();
            this.rBOrigin1 = new System.Windows.Forms.RadioButton();
            this.lbDimension = new System.Windows.Forms.TextBox();
            this.pbBuffer = new System.Windows.Forms.ProgressBar();
            this.btnStreamStop = new System.Windows.Forms.Button();
            this.btnStreamCheck = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.pbFile = new System.Windows.Forms.ProgressBar();
            this.lblElapsed = new System.Windows.Forms.Label();
            this.lblFileProgress = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.btnStreamStart = new System.Windows.Forms.Button();
            this.cmsCode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsCodeSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCodeCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCodePaste = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCodeSendLine = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCommentOut = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnZeroABC = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnZeroC = new System.Windows.Forms.Button();
            this.label_wc = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnZeroB = new System.Windows.Forms.Button();
            this.label_wb = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnZeroA = new System.Windows.Forms.Button();
            this.label_wa = new System.Windows.Forms.Label();
            this.label_e = new System.Windows.Forms.Label();
            this.btnZeroE = new System.Windows.Forms.Button();
            this.label_we = new System.Windows.Forms.Label();
            this.btnZeroXYZ = new System.Windows.Forms.Button();
            this.btnZeroXY = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnZeroZ = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnZeroY = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnZeroX = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCustom8 = new System.Windows.Forms.Button();
            this.btnCustom7 = new System.Windows.Forms.Button();
            this.btnCustom6 = new System.Windows.Forms.Button();
            this.btnCustom5 = new System.Windows.Forms.Button();
            this.btnCustom1 = new System.Windows.Forms.Button();
            this.btnCustom2 = new System.Windows.Forms.Button();
            this.btnCustom3 = new System.Windows.Forms.Button();
            this.btnCustom4 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tBURL = new System.Windows.Forms.TextBox();
            this.virtualJoystickC = new virtualJoystick.virtualJoystick();
            this.virtualJoystickB = new virtualJoystick.virtualJoystick();
            this.virtualJoystickA = new virtualJoystick.virtualJoystick();
            this.btnResume = new System.Windows.Forms.Button();
            this.virtualJoystickE = new virtualJoystick.virtualJoystick();
            this.btnJogStop = new System.Windows.Forms.Button();
            this.virtualJoystickZ = new virtualJoystick.virtualJoystick();
            this.virtualJoystickXY = new virtualJoystick.virtualJoystick();
            this.btnKillAlarm = new System.Windows.Forms.Button();
            this.btnFeedHold = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.fCTBCode = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmsPictureBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moveToMarkedPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.resetZoomingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.pasteFromClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletenotMarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteThisCodeLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToFirstPosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tLPAussen = new System.Windows.Forms.TableLayoutPanel();
            this.tLPLinks = new System.Windows.Forms.TableLayoutPanel();
            this.tLPRechts = new System.Windows.Forms.TableLayoutPanel();
            this.tLPRechtsUnten = new System.Windows.Forms.TableLayoutPanel();
            this.tLPMitteUnten = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gB_Jogging = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cBSendJogStop = new System.Windows.Forms.CheckBox();
            this.lblTool = new System.Windows.Forms.Label();
            this.cBTool = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tBSpeed = new System.Windows.Forms.TextBox();
            this.cBGreifer = new System.Windows.Forms.CheckBox();
            this.tLPRechtsOben = new System.Windows.Forms.TableLayoutPanel();
            this.gamePadTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.btnOverrideFRGB.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.cmsCode.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fCTBCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmsPictureBox.SuspendLayout();
            this.tLPAussen.SuspendLayout();
            this.tLPLinks.SuspendLayout();
            this.tLPRechts.SuspendLayout();
            this.tLPRechtsUnten.SuspendLayout();
            this.tLPMitteUnten.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gB_Jogging.SuspendLayout();
            this.tLPRechtsOben.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.createGCodeToolStripMenuItem,
            this.gCodeToolStripMenuItem,
            this.machineToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            this.toolTip1.SetToolTip(this.menuStrip1, resources.GetString("menuStrip1.ToolTip"));
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripSeparator2,
            this.saveToolStripMenuItem,
            this.toolStripSeparator3,
            this.setupToolStripMenuItem1,
            this.toolStripSeparator7,
            this.saveMachineParametersToolStripMenuItem,
            this.loadMachineParametersToolStripMenuItem,
            this.toolStripMenuItem3});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // loadToolStripMenuItem
            // 
            resources.ApplyResources(this.loadToolStripMenuItem, "loadToolStripMenuItem");
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // saveToolStripMenuItem
            // 
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // setupToolStripMenuItem1
            // 
            resources.ApplyResources(this.setupToolStripMenuItem1, "setupToolStripMenuItem1");
            this.setupToolStripMenuItem1.Name = "setupToolStripMenuItem1";
            this.setupToolStripMenuItem1.Click += new System.EventHandler(this.setupToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            // 
            // saveMachineParametersToolStripMenuItem
            // 
            resources.ApplyResources(this.saveMachineParametersToolStripMenuItem, "saveMachineParametersToolStripMenuItem");
            this.saveMachineParametersToolStripMenuItem.Name = "saveMachineParametersToolStripMenuItem";
            this.saveMachineParametersToolStripMenuItem.Click += new System.EventHandler(this.saveMachineParametersToolStripMenuItem_Click);
            // 
            // loadMachineParametersToolStripMenuItem
            // 
            resources.ApplyResources(this.loadMachineParametersToolStripMenuItem, "loadMachineParametersToolStripMenuItem");
            this.loadMachineParametersToolStripMenuItem.Name = "loadMachineParametersToolStripMenuItem";
            this.loadMachineParametersToolStripMenuItem.Click += new System.EventHandler(this.loadMachineParametersToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.deutschToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // deutschToolStripMenuItem
            // 
            resources.ApplyResources(this.deutschToolStripMenuItem, "deutschToolStripMenuItem");
            this.deutschToolStripMenuItem.Name = "deutschToolStripMenuItem";
            this.deutschToolStripMenuItem.Click += new System.EventHandler(this.deutschToolStripMenuItem_Click);
            // 
            // createGCodeToolStripMenuItem
            // 
            resources.ApplyResources(this.createGCodeToolStripMenuItem, "createGCodeToolStripMenuItem");
            this.createGCodeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textWizzardToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.createSimpleShapesToolStripMenuItem});
            this.createGCodeToolStripMenuItem.Name = "createGCodeToolStripMenuItem";
            // 
            // textWizzardToolStripMenuItem
            // 
            resources.ApplyResources(this.textWizzardToolStripMenuItem, "textWizzardToolStripMenuItem");
            this.textWizzardToolStripMenuItem.Name = "textWizzardToolStripMenuItem";
            this.textWizzardToolStripMenuItem.Click += new System.EventHandler(this.textWizzardToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            resources.ApplyResources(this.imageToolStripMenuItem, "imageToolStripMenuItem");
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // createSimpleShapesToolStripMenuItem
            // 
            resources.ApplyResources(this.createSimpleShapesToolStripMenuItem, "createSimpleShapesToolStripMenuItem");
            this.createSimpleShapesToolStripMenuItem.Name = "createSimpleShapesToolStripMenuItem";
            this.createSimpleShapesToolStripMenuItem.Click += new System.EventHandler(this.createSimpleShapesToolStripMenuItem_Click);
            // 
            // gCodeToolStripMenuItem
            // 
            resources.ApplyResources(this.gCodeToolStripMenuItem, "gCodeToolStripMenuItem");
            this.gCodeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mirrorXToolStripMenuItem,
            this.mirrorYToolStripMenuItem,
            this.toolStripSeparator4,
            this.rotate90ToolStripMenuItem,
            this.rotate90ToolStripMenuItem1,
            this.rotateFreeToolStripMenuItem,
            this.toolStripSeparator5,
            this.sToolStripMenuItem,
            this.skalierenXYToolStripMenuItem,
            this.skalierenXYUmXUnitsZuErreichenToolStripMenuItem,
            this.skaliereXUmToolStripMenuItem,
            this.skaliereAufXUnitsToolStripMenuItem,
            this.skaliereYUmToolStripMenuItem,
            this.skaliereAufYUnitsToolStripMenuItem,
            this.toolStripSeparator6,
            this.rotaryDimaeterToolStripMenuItem,
            this.skaliereXAufDrehachseToolStripMenuItem,
            this.skaliereYAufDrehachseToolStripMenuItem,
            this.ersetzteG23DurchLinienToolStripMenuItem});
            this.gCodeToolStripMenuItem.Name = "gCodeToolStripMenuItem";
            // 
            // mirrorXToolStripMenuItem
            // 
            resources.ApplyResources(this.mirrorXToolStripMenuItem, "mirrorXToolStripMenuItem");
            this.mirrorXToolStripMenuItem.Name = "mirrorXToolStripMenuItem";
            this.mirrorXToolStripMenuItem.Click += new System.EventHandler(this.mirrorXToolStripMenuItem_Click);
            // 
            // mirrorYToolStripMenuItem
            // 
            resources.ApplyResources(this.mirrorYToolStripMenuItem, "mirrorYToolStripMenuItem");
            this.mirrorYToolStripMenuItem.Name = "mirrorYToolStripMenuItem";
            this.mirrorYToolStripMenuItem.Click += new System.EventHandler(this.mirrorYToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // rotate90ToolStripMenuItem
            // 
            resources.ApplyResources(this.rotate90ToolStripMenuItem, "rotate90ToolStripMenuItem");
            this.rotate90ToolStripMenuItem.Name = "rotate90ToolStripMenuItem";
            this.rotate90ToolStripMenuItem.Click += new System.EventHandler(this.rotate90ToolStripMenuItem_Click);
            // 
            // rotate90ToolStripMenuItem1
            // 
            resources.ApplyResources(this.rotate90ToolStripMenuItem1, "rotate90ToolStripMenuItem1");
            this.rotate90ToolStripMenuItem1.Name = "rotate90ToolStripMenuItem1";
            this.rotate90ToolStripMenuItem1.Click += new System.EventHandler(this.rotate90ToolStripMenuItem1_Click);
            // 
            // rotateFreeToolStripMenuItem
            // 
            resources.ApplyResources(this.rotateFreeToolStripMenuItem, "rotateFreeToolStripMenuItem");
            this.rotateFreeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_tb_rotate});
            this.rotateFreeToolStripMenuItem.Name = "rotateFreeToolStripMenuItem";
            // 
            // toolStrip_tb_rotate
            // 
            resources.ApplyResources(this.toolStrip_tb_rotate, "toolStrip_tb_rotate");
            this.toolStrip_tb_rotate.Name = "toolStrip_tb_rotate";
            this.toolStrip_tb_rotate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStrip_tb_rotate_KeyDown);
            // 
            // toolStripSeparator5
            // 
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            // 
            // sToolStripMenuItem
            // 
            resources.ApplyResources(this.sToolStripMenuItem, "sToolStripMenuItem");
            this.sToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_tb_XY_scale});
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            // 
            // toolStrip_tb_XY_scale
            // 
            resources.ApplyResources(this.toolStrip_tb_XY_scale, "toolStrip_tb_XY_scale");
            this.toolStrip_tb_XY_scale.Name = "toolStrip_tb_XY_scale";
            this.toolStrip_tb_XY_scale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStrip_tb_XY_scale_KeyDown);
            // 
            // skalierenXYToolStripMenuItem
            // 
            resources.ApplyResources(this.skalierenXYToolStripMenuItem, "skalierenXYToolStripMenuItem");
            this.skalierenXYToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_tb_XY_X_scale});
            this.skalierenXYToolStripMenuItem.Name = "skalierenXYToolStripMenuItem";
            // 
            // toolStrip_tb_XY_X_scale
            // 
            resources.ApplyResources(this.toolStrip_tb_XY_X_scale, "toolStrip_tb_XY_X_scale");
            this.toolStrip_tb_XY_X_scale.Name = "toolStrip_tb_XY_X_scale";
            this.toolStrip_tb_XY_X_scale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStrip_tb_XY_X_scale_KeyDown);
            // 
            // skalierenXYUmXUnitsZuErreichenToolStripMenuItem
            // 
            resources.ApplyResources(this.skalierenXYUmXUnitsZuErreichenToolStripMenuItem, "skalierenXYUmXUnitsZuErreichenToolStripMenuItem");
            this.skalierenXYUmXUnitsZuErreichenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_tb_XY_Y_scale});
            this.skalierenXYUmXUnitsZuErreichenToolStripMenuItem.Name = "skalierenXYUmXUnitsZuErreichenToolStripMenuItem";
            // 
            // toolStrip_tb_XY_Y_scale
            // 
            resources.ApplyResources(this.toolStrip_tb_XY_Y_scale, "toolStrip_tb_XY_Y_scale");
            this.toolStrip_tb_XY_Y_scale.Name = "toolStrip_tb_XY_Y_scale";
            this.toolStrip_tb_XY_Y_scale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStrip_tb_XY_Y_scale_KeyDown);
            // 
            // skaliereXUmToolStripMenuItem
            // 
            resources.ApplyResources(this.skaliereXUmToolStripMenuItem, "skaliereXUmToolStripMenuItem");
            this.skaliereXUmToolStripMenuItem.AutoToolTip = true;
            this.skaliereXUmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_tb_X_scale});
            this.skaliereXUmToolStripMenuItem.Name = "skaliereXUmToolStripMenuItem";
            // 
            // toolStrip_tb_X_scale
            // 
            resources.ApplyResources(this.toolStrip_tb_X_scale, "toolStrip_tb_X_scale");
            this.toolStrip_tb_X_scale.Name = "toolStrip_tb_X_scale";
            this.toolStrip_tb_X_scale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStrip_tb_X_scale_KeyDown);
            // 
            // skaliereAufXUnitsToolStripMenuItem
            // 
            resources.ApplyResources(this.skaliereAufXUnitsToolStripMenuItem, "skaliereAufXUnitsToolStripMenuItem");
            this.skaliereAufXUnitsToolStripMenuItem.AutoToolTip = true;
            this.skaliereAufXUnitsToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.skaliereAufXUnitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_tb_X_X_scale});
            this.skaliereAufXUnitsToolStripMenuItem.Name = "skaliereAufXUnitsToolStripMenuItem";
            // 
            // toolStrip_tb_X_X_scale
            // 
            resources.ApplyResources(this.toolStrip_tb_X_X_scale, "toolStrip_tb_X_X_scale");
            this.toolStrip_tb_X_X_scale.Name = "toolStrip_tb_X_X_scale";
            this.toolStrip_tb_X_X_scale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStrip_tb_X_X_scale_KeyDown);
            // 
            // skaliereYUmToolStripMenuItem
            // 
            resources.ApplyResources(this.skaliereYUmToolStripMenuItem, "skaliereYUmToolStripMenuItem");
            this.skaliereYUmToolStripMenuItem.AutoToolTip = true;
            this.skaliereYUmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_tb_Y_scale});
            this.skaliereYUmToolStripMenuItem.Name = "skaliereYUmToolStripMenuItem";
            // 
            // toolStrip_tb_Y_scale
            // 
            resources.ApplyResources(this.toolStrip_tb_Y_scale, "toolStrip_tb_Y_scale");
            this.toolStrip_tb_Y_scale.Name = "toolStrip_tb_Y_scale";
            this.toolStrip_tb_Y_scale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStrip_tb_Y_scale_KeyDown);
            // 
            // skaliereAufYUnitsToolStripMenuItem
            // 
            resources.ApplyResources(this.skaliereAufYUnitsToolStripMenuItem, "skaliereAufYUnitsToolStripMenuItem");
            this.skaliereAufYUnitsToolStripMenuItem.AutoToolTip = true;
            this.skaliereAufYUnitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_tb_Y_Y_scale});
            this.skaliereAufYUnitsToolStripMenuItem.Name = "skaliereAufYUnitsToolStripMenuItem";
            // 
            // toolStrip_tb_Y_Y_scale
            // 
            resources.ApplyResources(this.toolStrip_tb_Y_Y_scale, "toolStrip_tb_Y_Y_scale");
            this.toolStrip_tb_Y_Y_scale.Name = "toolStrip_tb_Y_Y_scale";
            this.toolStrip_tb_Y_Y_scale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStrip_tb_Y_Y_scale_KeyDown);
            // 
            // toolStripSeparator6
            // 
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            // 
            // rotaryDimaeterToolStripMenuItem
            // 
            resources.ApplyResources(this.rotaryDimaeterToolStripMenuItem, "rotaryDimaeterToolStripMenuItem");
            this.rotaryDimaeterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_tb_rotary_diameter});
            this.rotaryDimaeterToolStripMenuItem.Name = "rotaryDimaeterToolStripMenuItem";
            // 
            // toolStrip_tb_rotary_diameter
            // 
            resources.ApplyResources(this.toolStrip_tb_rotary_diameter, "toolStrip_tb_rotary_diameter");
            this.toolStrip_tb_rotary_diameter.Name = "toolStrip_tb_rotary_diameter";
            this.toolStrip_tb_rotary_diameter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStrip_tb_rotary_diameter_KeyDown);
            // 
            // skaliereXAufDrehachseToolStripMenuItem
            // 
            resources.ApplyResources(this.skaliereXAufDrehachseToolStripMenuItem, "skaliereXAufDrehachseToolStripMenuItem");
            this.skaliereXAufDrehachseToolStripMenuItem.AutoToolTip = true;
            this.skaliereXAufDrehachseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_tb_X_A_scale});
            this.skaliereXAufDrehachseToolStripMenuItem.Name = "skaliereXAufDrehachseToolStripMenuItem";
            // 
            // toolStrip_tb_X_A_scale
            // 
            resources.ApplyResources(this.toolStrip_tb_X_A_scale, "toolStrip_tb_X_A_scale");
            this.toolStrip_tb_X_A_scale.Name = "toolStrip_tb_X_A_scale";
            this.toolStrip_tb_X_A_scale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStrip_tb_X_A_scale_KeyDown);
            // 
            // skaliereYAufDrehachseToolStripMenuItem
            // 
            resources.ApplyResources(this.skaliereYAufDrehachseToolStripMenuItem, "skaliereYAufDrehachseToolStripMenuItem");
            this.skaliereYAufDrehachseToolStripMenuItem.AutoToolTip = true;
            this.skaliereYAufDrehachseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_tb_Y_A_scale});
            this.skaliereYAufDrehachseToolStripMenuItem.Name = "skaliereYAufDrehachseToolStripMenuItem";
            // 
            // toolStrip_tb_Y_A_scale
            // 
            resources.ApplyResources(this.toolStrip_tb_Y_A_scale, "toolStrip_tb_Y_A_scale");
            this.toolStrip_tb_Y_A_scale.Name = "toolStrip_tb_Y_A_scale";
            this.toolStrip_tb_Y_A_scale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStrip_tb_Y_A_scale_KeyDown);
            // 
            // ersetzteG23DurchLinienToolStripMenuItem
            // 
            resources.ApplyResources(this.ersetzteG23DurchLinienToolStripMenuItem, "ersetzteG23DurchLinienToolStripMenuItem");
            this.ersetzteG23DurchLinienToolStripMenuItem.Name = "ersetzteG23DurchLinienToolStripMenuItem";
            this.ersetzteG23DurchLinienToolStripMenuItem.Click += new System.EventHandler(this.ersetzteG23DurchLinienToolStripMenuItem_Click);
            // 
            // machineToolStripMenuItem
            // 
            resources.ApplyResources(this.machineToolStripMenuItem, "machineToolStripMenuItem");
            this.machineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heightMapToolStripMenuItem,
            this.controlStreamingToolStripMenuItem,
            this.control2ndGRBLToolStripMenuItem,
            this.toolStripMenuItem1,
            this.setupToolStripMenuItem});
            this.machineToolStripMenuItem.Name = "machineToolStripMenuItem";
            // 
            // heightMapToolStripMenuItem
            // 
            resources.ApplyResources(this.heightMapToolStripMenuItem, "heightMapToolStripMenuItem");
            this.heightMapToolStripMenuItem.Name = "heightMapToolStripMenuItem";
            this.heightMapToolStripMenuItem.Click += new System.EventHandler(this.heightMapToolStripMenuItem_Click);
            // 
            // controlStreamingToolStripMenuItem
            // 
            resources.ApplyResources(this.controlStreamingToolStripMenuItem, "controlStreamingToolStripMenuItem");
            this.controlStreamingToolStripMenuItem.Name = "controlStreamingToolStripMenuItem";
            this.controlStreamingToolStripMenuItem.Click += new System.EventHandler(this.controlStreamingToolStripMenuItem_Click);
            // 
            // control2ndGRBLToolStripMenuItem
            // 
            resources.ApplyResources(this.control2ndGRBLToolStripMenuItem, "control2ndGRBLToolStripMenuItem");
            this.control2ndGRBLToolStripMenuItem.Name = "control2ndGRBLToolStripMenuItem";
            this.control2ndGRBLToolStripMenuItem.Click += new System.EventHandler(this.control2ndGRBLToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.cameraToolStripMenuItem_Click);
            // 
            // setupToolStripMenuItem
            // 
            resources.ApplyResources(this.setupToolStripMenuItem, "setupToolStripMenuItem");
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Click += new System.EventHandler(this.DIYControlopen);
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label_wx
            // 
            resources.ApplyResources(this.label_wx, "label_wx");
            this.label_wx.Name = "label_wx";
            this.toolTip1.SetToolTip(this.label_wx, resources.GetString("label_wx.ToolTip"));
            // 
            // label_wy
            // 
            resources.ApplyResources(this.label_wy, "label_wy");
            this.label_wy.Name = "label_wy";
            this.toolTip1.SetToolTip(this.label_wy, resources.GetString("label_wy.ToolTip"));
            // 
            // label_wz
            // 
            resources.ApplyResources(this.label_wz, "label_wz");
            this.label_wz.Name = "label_wz";
            this.toolTip1.SetToolTip(this.label_wz, resources.GetString("label_wz.ToolTip"));
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Interval = 500;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnLimitExceed);
            this.groupBox1.Controls.Add(this.btnOverrideFRGB);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.lbDimension);
            this.groupBox1.Controls.Add(this.pbBuffer);
            this.groupBox1.Controls.Add(this.btnStreamStop);
            this.groupBox1.Controls.Add(this.btnStreamCheck);
            this.groupBox1.Controls.Add(this.lbInfo);
            this.groupBox1.Controls.Add(this.lblRemaining);
            this.groupBox1.Controls.Add(this.pbFile);
            this.groupBox1.Controls.Add(this.lblElapsed);
            this.groupBox1.Controls.Add(this.lblFileProgress);
            this.groupBox1.Controls.Add(this.btnOpenFile);
            this.groupBox1.Controls.Add(this.tbFile);
            this.groupBox1.Controls.Add(this.btnStreamStart);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.btnPause2000);
            this.groupBox3.Controls.Add(this.btnPause1000);
            this.groupBox3.Controls.Add(this.btnTeachen);
            this.groupBox3.Controls.Add(this.btnPause300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox3, resources.GetString("groupBox3.ToolTip"));
            // 
            // btnPause2000
            // 
            resources.ApplyResources(this.btnPause2000, "btnPause2000");
            this.btnPause2000.Name = "btnPause2000";
            this.toolTip1.SetToolTip(this.btnPause2000, resources.GetString("btnPause2000.ToolTip"));
            this.btnPause2000.UseVisualStyleBackColor = true;
            this.btnPause2000.Click += new System.EventHandler(this.btnPause2000_Click);
            // 
            // btnPause1000
            // 
            resources.ApplyResources(this.btnPause1000, "btnPause1000");
            this.btnPause1000.Name = "btnPause1000";
            this.toolTip1.SetToolTip(this.btnPause1000, resources.GetString("btnPause1000.ToolTip"));
            this.btnPause1000.UseVisualStyleBackColor = true;
            this.btnPause1000.Click += new System.EventHandler(this.btnPause1000_Click);
            // 
            // btnTeachen
            // 
            resources.ApplyResources(this.btnTeachen, "btnTeachen");
            this.btnTeachen.Name = "btnTeachen";
            this.toolTip1.SetToolTip(this.btnTeachen, resources.GetString("btnTeachen.ToolTip"));
            this.btnTeachen.UseVisualStyleBackColor = true;
            this.btnTeachen.Click += new System.EventHandler(this.btnTeachen_Click);
            // 
            // btnPause300
            // 
            resources.ApplyResources(this.btnPause300, "btnPause300");
            this.btnPause300.Name = "btnPause300";
            this.toolTip1.SetToolTip(this.btnPause300, resources.GetString("btnPause300.ToolTip"));
            this.btnPause300.UseVisualStyleBackColor = true;
            this.btnPause300.Click += new System.EventHandler(this.btnPause300_Click);
            // 
            // btnLimitExceed
            // 
            resources.ApplyResources(this.btnLimitExceed, "btnLimitExceed");
            this.btnLimitExceed.BackColor = System.Drawing.Color.Yellow;
            this.btnLimitExceed.Name = "btnLimitExceed";
            this.toolTip1.SetToolTip(this.btnLimitExceed, resources.GetString("btnLimitExceed.ToolTip"));
            this.btnLimitExceed.UseVisualStyleBackColor = false;
            this.btnLimitExceed.Click += new System.EventHandler(this.btnLimitExceed_Click);
            // 
            // btnOverrideFRGB
            // 
            resources.ApplyResources(this.btnOverrideFRGB, "btnOverrideFRGB");
            this.btnOverrideFRGB.Controls.Add(this.label5);
            this.btnOverrideFRGB.Controls.Add(this.label7);
            this.btnOverrideFRGB.Controls.Add(this.lblOverrideFRValue);
            this.btnOverrideFRGB.Controls.Add(this.btnOverrideFR1);
            this.btnOverrideFRGB.Controls.Add(this.btnOverrideFR2);
            this.btnOverrideFRGB.Controls.Add(this.btnOverrideFR0);
            this.btnOverrideFRGB.Controls.Add(this.btnOverrideFR4);
            this.btnOverrideFRGB.Controls.Add(this.btnOverrideFR3);
            this.btnOverrideFRGB.Name = "btnOverrideFRGB";
            this.btnOverrideFRGB.TabStop = false;
            this.toolTip1.SetToolTip(this.btnOverrideFRGB, resources.GetString("btnOverrideFRGB.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.toolTip1.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.toolTip1.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            // 
            // lblOverrideFRValue
            // 
            resources.ApplyResources(this.lblOverrideFRValue, "lblOverrideFRValue");
            this.lblOverrideFRValue.Name = "lblOverrideFRValue";
            this.toolTip1.SetToolTip(this.lblOverrideFRValue, resources.GetString("lblOverrideFRValue.ToolTip"));
            // 
            // btnOverrideFR1
            // 
            resources.ApplyResources(this.btnOverrideFR1, "btnOverrideFR1");
            this.btnOverrideFR1.Name = "btnOverrideFR1";
            this.toolTip1.SetToolTip(this.btnOverrideFR1, resources.GetString("btnOverrideFR1.ToolTip"));
            this.btnOverrideFR1.UseVisualStyleBackColor = true;
            this.btnOverrideFR1.Click += new System.EventHandler(this.btnOverrideFR1_Click);
            // 
            // btnOverrideFR2
            // 
            resources.ApplyResources(this.btnOverrideFR2, "btnOverrideFR2");
            this.btnOverrideFR2.Name = "btnOverrideFR2";
            this.toolTip1.SetToolTip(this.btnOverrideFR2, resources.GetString("btnOverrideFR2.ToolTip"));
            this.btnOverrideFR2.UseVisualStyleBackColor = true;
            this.btnOverrideFR2.Click += new System.EventHandler(this.btnOverrideFR2_Click);
            // 
            // btnOverrideFR0
            // 
            resources.ApplyResources(this.btnOverrideFR0, "btnOverrideFR0");
            this.btnOverrideFR0.Name = "btnOverrideFR0";
            this.toolTip1.SetToolTip(this.btnOverrideFR0, resources.GetString("btnOverrideFR0.ToolTip"));
            this.btnOverrideFR0.UseVisualStyleBackColor = true;
            this.btnOverrideFR0.Click += new System.EventHandler(this.btnOverrideFR0_Click);
            // 
            // btnOverrideFR4
            // 
            resources.ApplyResources(this.btnOverrideFR4, "btnOverrideFR4");
            this.btnOverrideFR4.Name = "btnOverrideFR4";
            this.toolTip1.SetToolTip(this.btnOverrideFR4, resources.GetString("btnOverrideFR4.ToolTip"));
            this.btnOverrideFR4.UseVisualStyleBackColor = true;
            this.btnOverrideFR4.Click += new System.EventHandler(this.btnOverrideFR4_Click);
            // 
            // btnOverrideFR3
            // 
            resources.ApplyResources(this.btnOverrideFR3, "btnOverrideFR3");
            this.btnOverrideFR3.Name = "btnOverrideFR3";
            this.toolTip1.SetToolTip(this.btnOverrideFR3, resources.GetString("btnOverrideFR3.ToolTip"));
            this.btnOverrideFR3.UseVisualStyleBackColor = true;
            this.btnOverrideFR3.Click += new System.EventHandler(this.btnOverrideFR3_Click);
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.btnOffsetApply);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.tbOffsetY);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.tbOffsetX);
            this.groupBox4.Controls.Add(this.rBOrigin9);
            this.groupBox4.Controls.Add(this.rBOrigin8);
            this.groupBox4.Controls.Add(this.rBOrigin7);
            this.groupBox4.Controls.Add(this.rBOrigin6);
            this.groupBox4.Controls.Add(this.rBOrigin5);
            this.groupBox4.Controls.Add(this.rBOrigin4);
            this.groupBox4.Controls.Add(this.rBOrigin3);
            this.groupBox4.Controls.Add(this.rBOrigin2);
            this.groupBox4.Controls.Add(this.rBOrigin1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox4, resources.GetString("groupBox4.ToolTip"));
            // 
            // btnOffsetApply
            // 
            resources.ApplyResources(this.btnOffsetApply, "btnOffsetApply");
            this.btnOffsetApply.Name = "btnOffsetApply";
            this.toolTip1.SetToolTip(this.btnOffsetApply, resources.GetString("btnOffsetApply.ToolTip"));
            this.btnOffsetApply.UseVisualStyleBackColor = true;
            this.btnOffsetApply.Click += new System.EventHandler(this.btnOffsetApply_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.toolTip1.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // tbOffsetY
            // 
            resources.ApplyResources(this.tbOffsetY, "tbOffsetY");
            this.tbOffsetY.Name = "tbOffsetY";
            this.toolTip1.SetToolTip(this.tbOffsetY, resources.GetString("tbOffsetY.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // tbOffsetX
            // 
            resources.ApplyResources(this.tbOffsetX, "tbOffsetX");
            this.tbOffsetX.Name = "tbOffsetX";
            this.toolTip1.SetToolTip(this.tbOffsetX, resources.GetString("tbOffsetX.ToolTip"));
            // 
            // rBOrigin9
            // 
            resources.ApplyResources(this.rBOrigin9, "rBOrigin9");
            this.rBOrigin9.Name = "rBOrigin9";
            this.toolTip1.SetToolTip(this.rBOrigin9, resources.GetString("rBOrigin9.ToolTip"));
            this.rBOrigin9.UseVisualStyleBackColor = true;
            // 
            // rBOrigin8
            // 
            resources.ApplyResources(this.rBOrigin8, "rBOrigin8");
            this.rBOrigin8.Name = "rBOrigin8";
            this.toolTip1.SetToolTip(this.rBOrigin8, resources.GetString("rBOrigin8.ToolTip"));
            this.rBOrigin8.UseVisualStyleBackColor = true;
            // 
            // rBOrigin7
            // 
            resources.ApplyResources(this.rBOrigin7, "rBOrigin7");
            this.rBOrigin7.Name = "rBOrigin7";
            this.toolTip1.SetToolTip(this.rBOrigin7, resources.GetString("rBOrigin7.ToolTip"));
            this.rBOrigin7.UseVisualStyleBackColor = true;
            // 
            // rBOrigin6
            // 
            resources.ApplyResources(this.rBOrigin6, "rBOrigin6");
            this.rBOrigin6.Name = "rBOrigin6";
            this.toolTip1.SetToolTip(this.rBOrigin6, resources.GetString("rBOrigin6.ToolTip"));
            this.rBOrigin6.UseVisualStyleBackColor = true;
            // 
            // rBOrigin5
            // 
            resources.ApplyResources(this.rBOrigin5, "rBOrigin5");
            this.rBOrigin5.Checked = true;
            this.rBOrigin5.Name = "rBOrigin5";
            this.rBOrigin5.TabStop = true;
            this.toolTip1.SetToolTip(this.rBOrigin5, resources.GetString("rBOrigin5.ToolTip"));
            this.rBOrigin5.UseVisualStyleBackColor = true;
            // 
            // rBOrigin4
            // 
            resources.ApplyResources(this.rBOrigin4, "rBOrigin4");
            this.rBOrigin4.Name = "rBOrigin4";
            this.toolTip1.SetToolTip(this.rBOrigin4, resources.GetString("rBOrigin4.ToolTip"));
            this.rBOrigin4.UseVisualStyleBackColor = true;
            // 
            // rBOrigin3
            // 
            resources.ApplyResources(this.rBOrigin3, "rBOrigin3");
            this.rBOrigin3.Name = "rBOrigin3";
            this.toolTip1.SetToolTip(this.rBOrigin3, resources.GetString("rBOrigin3.ToolTip"));
            this.rBOrigin3.UseVisualStyleBackColor = true;
            // 
            // rBOrigin2
            // 
            resources.ApplyResources(this.rBOrigin2, "rBOrigin2");
            this.rBOrigin2.Name = "rBOrigin2";
            this.toolTip1.SetToolTip(this.rBOrigin2, resources.GetString("rBOrigin2.ToolTip"));
            this.rBOrigin2.UseVisualStyleBackColor = true;
            // 
            // rBOrigin1
            // 
            resources.ApplyResources(this.rBOrigin1, "rBOrigin1");
            this.rBOrigin1.Name = "rBOrigin1";
            this.toolTip1.SetToolTip(this.rBOrigin1, resources.GetString("rBOrigin1.ToolTip"));
            this.rBOrigin1.UseVisualStyleBackColor = true;
            // 
            // lbDimension
            // 
            resources.ApplyResources(this.lbDimension, "lbDimension");
            this.lbDimension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbDimension.HideSelection = false;
            this.lbDimension.Name = "lbDimension";
            this.lbDimension.ReadOnly = true;
            this.toolTip1.SetToolTip(this.lbDimension, resources.GetString("lbDimension.ToolTip"));
            // 
            // pbBuffer
            // 
            resources.ApplyResources(this.pbBuffer, "pbBuffer");
            this.pbBuffer.Name = "pbBuffer";
            this.toolTip1.SetToolTip(this.pbBuffer, resources.GetString("pbBuffer.ToolTip"));
            // 
            // btnStreamStop
            // 
            resources.ApplyResources(this.btnStreamStop, "btnStreamStop");
            this.btnStreamStop.Image = global::RoboterGUI.Properties.Resources.btn_stop;
            this.btnStreamStop.Name = "btnStreamStop";
            this.toolTip1.SetToolTip(this.btnStreamStop, resources.GetString("btnStreamStop.ToolTip"));
            this.btnStreamStop.UseVisualStyleBackColor = true;
            this.btnStreamStop.Click += new System.EventHandler(this.btnStreamStop_Click);
            // 
            // btnStreamCheck
            // 
            resources.ApplyResources(this.btnStreamCheck, "btnStreamCheck");
            this.btnStreamCheck.Name = "btnStreamCheck";
            this.toolTip1.SetToolTip(this.btnStreamCheck, resources.GetString("btnStreamCheck.ToolTip"));
            this.btnStreamCheck.UseVisualStyleBackColor = true;
            this.btnStreamCheck.Click += new System.EventHandler(this.btnStreamCheck_Click);
            // 
            // lbInfo
            // 
            resources.ApplyResources(this.lbInfo, "lbInfo");
            this.lbInfo.Name = "lbInfo";
            this.toolTip1.SetToolTip(this.lbInfo, resources.GetString("lbInfo.ToolTip"));
            // 
            // lblRemaining
            // 
            resources.ApplyResources(this.lblRemaining, "lblRemaining");
            this.lblRemaining.Name = "lblRemaining";
            this.toolTip1.SetToolTip(this.lblRemaining, resources.GetString("lblRemaining.ToolTip"));
            // 
            // pbFile
            // 
            resources.ApplyResources(this.pbFile, "pbFile");
            this.pbFile.Name = "pbFile";
            this.toolTip1.SetToolTip(this.pbFile, resources.GetString("pbFile.ToolTip"));
            // 
            // lblElapsed
            // 
            resources.ApplyResources(this.lblElapsed, "lblElapsed");
            this.lblElapsed.Name = "lblElapsed";
            this.toolTip1.SetToolTip(this.lblElapsed, resources.GetString("lblElapsed.ToolTip"));
            // 
            // lblFileProgress
            // 
            resources.ApplyResources(this.lblFileProgress, "lblFileProgress");
            this.lblFileProgress.Name = "lblFileProgress";
            this.toolTip1.SetToolTip(this.lblFileProgress, resources.GetString("lblFileProgress.ToolTip"));
            // 
            // btnOpenFile
            // 
            resources.ApplyResources(this.btnOpenFile, "btnOpenFile");
            this.btnOpenFile.Name = "btnOpenFile";
            this.toolTip1.SetToolTip(this.btnOpenFile, resources.GetString("btnOpenFile.ToolTip"));
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // tbFile
            // 
            resources.ApplyResources(this.tbFile, "tbFile");
            this.tbFile.Name = "tbFile";
            this.toolTip1.SetToolTip(this.tbFile, resources.GetString("tbFile.ToolTip"));
            // 
            // btnStreamStart
            // 
            resources.ApplyResources(this.btnStreamStart, "btnStreamStart");
            this.btnStreamStart.Image = global::RoboterGUI.Properties.Resources.btn_play;
            this.btnStreamStart.Name = "btnStreamStart";
            this.toolTip1.SetToolTip(this.btnStreamStart, resources.GetString("btnStreamStart.ToolTip"));
            this.btnStreamStart.UseVisualStyleBackColor = true;
            this.btnStreamStart.Click += new System.EventHandler(this.btnStreamStart_Click);
            // 
            // cmsCode
            // 
            resources.ApplyResources(this.cmsCode, "cmsCode");
            this.cmsCode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsCodeSelect,
            this.cmsCodeCopy,
            this.cmsCodePaste,
            this.cmsCodeSendLine,
            this.cmsCommentOut});
            this.cmsCode.Name = "cmsCode";
            this.cmsCode.ShowImageMargin = false;
            this.toolTip1.SetToolTip(this.cmsCode, resources.GetString("cmsCode.ToolTip"));
            this.cmsCode.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsCode_ItemClicked);
            // 
            // cmsCodeSelect
            // 
            resources.ApplyResources(this.cmsCodeSelect, "cmsCodeSelect");
            this.cmsCodeSelect.Name = "cmsCodeSelect";
            // 
            // cmsCodeCopy
            // 
            resources.ApplyResources(this.cmsCodeCopy, "cmsCodeCopy");
            this.cmsCodeCopy.Name = "cmsCodeCopy";
            // 
            // cmsCodePaste
            // 
            resources.ApplyResources(this.cmsCodePaste, "cmsCodePaste");
            this.cmsCodePaste.Name = "cmsCodePaste";
            // 
            // cmsCodeSendLine
            // 
            resources.ApplyResources(this.cmsCodeSendLine, "cmsCodeSendLine");
            this.cmsCodeSendLine.Name = "cmsCodeSendLine";
            // 
            // cmsCommentOut
            // 
            resources.ApplyResources(this.cmsCommentOut, "cmsCommentOut");
            this.cmsCommentOut.Name = "cmsCommentOut";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.btnZeroABC);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.btnZeroC);
            this.groupBox2.Controls.Add(this.label_wc);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnZeroB);
            this.groupBox2.Controls.Add(this.label_wb);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnZeroA);
            this.groupBox2.Controls.Add(this.label_wa);
            this.groupBox2.Controls.Add(this.label_e);
            this.groupBox2.Controls.Add(this.btnZeroE);
            this.groupBox2.Controls.Add(this.label_we);
            this.groupBox2.Controls.Add(this.btnZeroXYZ);
            this.groupBox2.Controls.Add(this.btnZeroXY);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnZeroZ);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnZeroY);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnZeroX);
            this.groupBox2.Controls.Add(this.label_wz);
            this.groupBox2.Controls.Add(this.label_wx);
            this.groupBox2.Controls.Add(this.label_wy);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox2, resources.GetString("groupBox2.ToolTip"));
            // 
            // btnZeroABC
            // 
            resources.ApplyResources(this.btnZeroABC, "btnZeroABC");
            this.btnZeroABC.Name = "btnZeroABC";
            this.toolTip1.SetToolTip(this.btnZeroABC, resources.GetString("btnZeroABC.ToolTip"));
            this.btnZeroABC.UseVisualStyleBackColor = true;
            this.btnZeroABC.Click += new System.EventHandler(this.btnZeroABC_Click);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            this.toolTip1.SetToolTip(this.label15, resources.GetString("label15.ToolTip"));
            // 
            // btnZeroC
            // 
            resources.ApplyResources(this.btnZeroC, "btnZeroC");
            this.btnZeroC.Name = "btnZeroC";
            this.toolTip1.SetToolTip(this.btnZeroC, resources.GetString("btnZeroC.ToolTip"));
            this.btnZeroC.UseVisualStyleBackColor = true;
            this.btnZeroC.Click += new System.EventHandler(this.btnZeroC_Click);
            // 
            // label_wc
            // 
            resources.ApplyResources(this.label_wc, "label_wc");
            this.label_wc.Name = "label_wc";
            this.toolTip1.SetToolTip(this.label_wc, resources.GetString("label_wc.ToolTip"));
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            this.toolTip1.SetToolTip(this.label13, resources.GetString("label13.ToolTip"));
            // 
            // btnZeroB
            // 
            resources.ApplyResources(this.btnZeroB, "btnZeroB");
            this.btnZeroB.Name = "btnZeroB";
            this.toolTip1.SetToolTip(this.btnZeroB, resources.GetString("btnZeroB.ToolTip"));
            this.btnZeroB.UseVisualStyleBackColor = true;
            this.btnZeroB.Click += new System.EventHandler(this.btnZeroB_Click);
            // 
            // label_wb
            // 
            resources.ApplyResources(this.label_wb, "label_wb");
            this.label_wb.Name = "label_wb";
            this.toolTip1.SetToolTip(this.label_wb, resources.GetString("label_wb.ToolTip"));
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            this.toolTip1.SetToolTip(this.label11, resources.GetString("label11.ToolTip"));
            // 
            // btnZeroA
            // 
            resources.ApplyResources(this.btnZeroA, "btnZeroA");
            this.btnZeroA.Name = "btnZeroA";
            this.toolTip1.SetToolTip(this.btnZeroA, resources.GetString("btnZeroA.ToolTip"));
            this.btnZeroA.UseVisualStyleBackColor = true;
            this.btnZeroA.Click += new System.EventHandler(this.btnZeroA_Click);
            // 
            // label_wa
            // 
            resources.ApplyResources(this.label_wa, "label_wa");
            this.label_wa.Name = "label_wa";
            this.toolTip1.SetToolTip(this.label_wa, resources.GetString("label_wa.ToolTip"));
            // 
            // label_e
            // 
            resources.ApplyResources(this.label_e, "label_e");
            this.label_e.Name = "label_e";
            this.toolTip1.SetToolTip(this.label_e, resources.GetString("label_e.ToolTip"));
            // 
            // btnZeroE
            // 
            resources.ApplyResources(this.btnZeroE, "btnZeroE");
            this.btnZeroE.Name = "btnZeroE";
            this.toolTip1.SetToolTip(this.btnZeroE, resources.GetString("btnZeroE.ToolTip"));
            this.btnZeroE.UseVisualStyleBackColor = true;
            this.btnZeroE.Click += new System.EventHandler(this.btnZeroE_Click);
            // 
            // label_we
            // 
            resources.ApplyResources(this.label_we, "label_we");
            this.label_we.Name = "label_we";
            this.toolTip1.SetToolTip(this.label_we, resources.GetString("label_we.ToolTip"));
            // 
            // btnZeroXYZ
            // 
            resources.ApplyResources(this.btnZeroXYZ, "btnZeroXYZ");
            this.btnZeroXYZ.Name = "btnZeroXYZ";
            this.toolTip1.SetToolTip(this.btnZeroXYZ, resources.GetString("btnZeroXYZ.ToolTip"));
            this.btnZeroXYZ.UseVisualStyleBackColor = true;
            this.btnZeroXYZ.Click += new System.EventHandler(this.btnZeroXYZ_Click);
            // 
            // btnZeroXY
            // 
            resources.ApplyResources(this.btnZeroXY, "btnZeroXY");
            this.btnZeroXY.Name = "btnZeroXY";
            this.toolTip1.SetToolTip(this.btnZeroXY, resources.GetString("btnZeroXY.ToolTip"));
            this.btnZeroXY.UseVisualStyleBackColor = true;
            this.btnZeroXY.Click += new System.EventHandler(this.btnZeroXY_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.toolTip1.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // btnZeroZ
            // 
            resources.ApplyResources(this.btnZeroZ, "btnZeroZ");
            this.btnZeroZ.Name = "btnZeroZ";
            this.toolTip1.SetToolTip(this.btnZeroZ, resources.GetString("btnZeroZ.ToolTip"));
            this.btnZeroZ.UseVisualStyleBackColor = true;
            this.btnZeroZ.Click += new System.EventHandler(this.btnZeroZ_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // btnZeroY
            // 
            resources.ApplyResources(this.btnZeroY, "btnZeroY");
            this.btnZeroY.Name = "btnZeroY";
            this.toolTip1.SetToolTip(this.btnZeroY, resources.GetString("btnZeroY.ToolTip"));
            this.btnZeroY.UseVisualStyleBackColor = true;
            this.btnZeroY.Click += new System.EventHandler(this.btnZeroY_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // btnZeroX
            // 
            resources.ApplyResources(this.btnZeroX, "btnZeroX");
            this.btnZeroX.Name = "btnZeroX";
            this.toolTip1.SetToolTip(this.btnZeroX, resources.GetString("btnZeroX.ToolTip"));
            this.btnZeroX.UseVisualStyleBackColor = true;
            this.btnZeroX.Click += new System.EventHandler(this.btnZeroX_Click);
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Controls.Add(this.tableLayoutPanel1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox5, resources.GetString("groupBox5.ToolTip"));
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.btnCustom8, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCustom7, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCustom6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCustom5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCustom1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCustom2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCustom3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCustom4, 0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.toolTip1.SetToolTip(this.tableLayoutPanel1, resources.GetString("tableLayoutPanel1.ToolTip"));
            // 
            // btnCustom8
            // 
            resources.ApplyResources(this.btnCustom8, "btnCustom8");
            this.btnCustom8.Name = "btnCustom8";
            this.toolTip1.SetToolTip(this.btnCustom8, resources.GetString("btnCustom8.ToolTip"));
            this.btnCustom8.UseVisualStyleBackColor = true;
            this.btnCustom8.Click += new System.EventHandler(this.btnCustomButton_Click);
            // 
            // btnCustom7
            // 
            resources.ApplyResources(this.btnCustom7, "btnCustom7");
            this.btnCustom7.Name = "btnCustom7";
            this.toolTip1.SetToolTip(this.btnCustom7, resources.GetString("btnCustom7.ToolTip"));
            this.btnCustom7.UseVisualStyleBackColor = true;
            this.btnCustom7.Click += new System.EventHandler(this.btnCustomButton_Click);
            // 
            // btnCustom6
            // 
            resources.ApplyResources(this.btnCustom6, "btnCustom6");
            this.btnCustom6.Name = "btnCustom6";
            this.toolTip1.SetToolTip(this.btnCustom6, resources.GetString("btnCustom6.ToolTip"));
            this.btnCustom6.UseVisualStyleBackColor = true;
            this.btnCustom6.Click += new System.EventHandler(this.btnCustomButton_Click);
            // 
            // btnCustom5
            // 
            resources.ApplyResources(this.btnCustom5, "btnCustom5");
            this.btnCustom5.Name = "btnCustom5";
            this.toolTip1.SetToolTip(this.btnCustom5, resources.GetString("btnCustom5.ToolTip"));
            this.btnCustom5.UseVisualStyleBackColor = true;
            this.btnCustom5.Click += new System.EventHandler(this.btnCustomButton_Click);
            // 
            // btnCustom1
            // 
            resources.ApplyResources(this.btnCustom1, "btnCustom1");
            this.btnCustom1.Name = "btnCustom1";
            this.toolTip1.SetToolTip(this.btnCustom1, resources.GetString("btnCustom1.ToolTip"));
            this.btnCustom1.UseVisualStyleBackColor = true;
            this.btnCustom1.Click += new System.EventHandler(this.btnCustomButton_Click);
            // 
            // btnCustom2
            // 
            resources.ApplyResources(this.btnCustom2, "btnCustom2");
            this.btnCustom2.Name = "btnCustom2";
            this.toolTip1.SetToolTip(this.btnCustom2, resources.GetString("btnCustom2.ToolTip"));
            this.btnCustom2.UseVisualStyleBackColor = true;
            this.btnCustom2.Click += new System.EventHandler(this.btnCustomButton_Click);
            // 
            // btnCustom3
            // 
            resources.ApplyResources(this.btnCustom3, "btnCustom3");
            this.btnCustom3.Name = "btnCustom3";
            this.toolTip1.SetToolTip(this.btnCustom3, resources.GetString("btnCustom3.ToolTip"));
            this.btnCustom3.UseVisualStyleBackColor = true;
            this.btnCustom3.Click += new System.EventHandler(this.btnCustomButton_Click);
            // 
            // btnCustom4
            // 
            resources.ApplyResources(this.btnCustom4, "btnCustom4");
            this.btnCustom4.Name = "btnCustom4";
            this.toolTip1.SetToolTip(this.btnCustom4, resources.GetString("btnCustom4.ToolTip"));
            this.btnCustom4.UseVisualStyleBackColor = true;
            this.btnCustom4.Click += new System.EventHandler(this.btnCustomButton_Click);
            // 
            // tBURL
            // 
            resources.ApplyResources(this.tBURL, "tBURL");
            this.tBURL.Name = "tBURL";
            this.toolTip1.SetToolTip(this.tBURL, resources.GetString("tBURL.ToolTip"));
            this.tBURL.TextChanged += new System.EventHandler(this.tBURL_TextChanged);
            // 
            // virtualJoystickC
            // 
            resources.ApplyResources(this.virtualJoystickC, "virtualJoystickC");
            this.virtualJoystickC.Joystick2Dimension = false;
            this.virtualJoystickC.JoystickActive = System.Drawing.Color.Red;
            this.virtualJoystickC.JoystickLabel = new double[] {
        0.1D,
        0.5D,
        1D,
        5D,
        10D,
        50D};
            this.virtualJoystickC.JoystickRaster = 5;
            this.virtualJoystickC.JoystickRasterMark = 0;
            this.virtualJoystickC.JoystickStanby = System.Drawing.Color.Cyan;
            this.virtualJoystickC.Name = "virtualJoystickC";
            this.virtualJoystickC.TabStop = false;
            this.toolTip1.SetToolTip(this.virtualJoystickC, resources.GetString("virtualJoystickC.ToolTip"));
            // 
            // virtualJoystickB
            // 
            resources.ApplyResources(this.virtualJoystickB, "virtualJoystickB");
            this.virtualJoystickB.Joystick2Dimension = false;
            this.virtualJoystickB.JoystickActive = System.Drawing.Color.Red;
            this.virtualJoystickB.JoystickLabel = new double[] {
        0.1D,
        0.5D,
        1D,
        5D,
        10D,
        50D};
            this.virtualJoystickB.JoystickRaster = 5;
            this.virtualJoystickB.JoystickRasterMark = 0;
            this.virtualJoystickB.JoystickStanby = System.Drawing.Color.Fuchsia;
            this.virtualJoystickB.Name = "virtualJoystickB";
            this.virtualJoystickB.TabStop = false;
            this.toolTip1.SetToolTip(this.virtualJoystickB, resources.GetString("virtualJoystickB.ToolTip"));
            // 
            // virtualJoystickA
            // 
            resources.ApplyResources(this.virtualJoystickA, "virtualJoystickA");
            this.virtualJoystickA.Joystick2Dimension = false;
            this.virtualJoystickA.JoystickActive = System.Drawing.Color.Red;
            this.virtualJoystickA.JoystickLabel = new double[] {
        0.1D,
        0.5D,
        1D,
        5D,
        10D,
        50D};
            this.virtualJoystickA.JoystickRaster = 5;
            this.virtualJoystickA.JoystickRasterMark = 0;
            this.virtualJoystickA.JoystickStanby = System.Drawing.Color.Lime;
            this.virtualJoystickA.Name = "virtualJoystickA";
            this.virtualJoystickA.TabStop = false;
            this.toolTip1.SetToolTip(this.virtualJoystickA, resources.GetString("virtualJoystickA.ToolTip"));
            // 
            // btnResume
            // 
            resources.ApplyResources(this.btnResume, "btnResume");
            this.btnResume.Name = "btnResume";
            this.toolTip1.SetToolTip(this.btnResume, resources.GetString("btnResume.ToolTip"));
            this.btnResume.UseVisualStyleBackColor = true;
            // 
            // virtualJoystickE
            // 
            resources.ApplyResources(this.virtualJoystickE, "virtualJoystickE");
            this.virtualJoystickE.BackColor = System.Drawing.Color.Fuchsia;
            this.virtualJoystickE.Joystick2Dimension = false;
            this.virtualJoystickE.JoystickActive = System.Drawing.Color.Red;
            this.virtualJoystickE.JoystickLabel = new double[] {
        0.1D,
        0.5D,
        1D,
        5D,
        10D,
        50D};
            this.virtualJoystickE.JoystickRaster = 5;
            this.virtualJoystickE.JoystickRasterMark = 0;
            this.virtualJoystickE.JoystickStanby = System.Drawing.Color.Fuchsia;
            this.virtualJoystickE.Name = "virtualJoystickE";
            this.virtualJoystickE.TabStop = false;
            this.toolTip1.SetToolTip(this.virtualJoystickE, resources.GetString("virtualJoystickE.ToolTip"));
            // 
            // btnJogStop
            // 
            resources.ApplyResources(this.btnJogStop, "btnJogStop");
            this.btnJogStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnJogStop.Name = "btnJogStop";
            this.toolTip1.SetToolTip(this.btnJogStop, resources.GetString("btnJogStop.ToolTip"));
            this.btnJogStop.UseVisualStyleBackColor = false;
            // 
            // virtualJoystickZ
            // 
            resources.ApplyResources(this.virtualJoystickZ, "virtualJoystickZ");
            this.virtualJoystickZ.Joystick2Dimension = false;
            this.virtualJoystickZ.JoystickActive = System.Drawing.Color.Red;
            this.virtualJoystickZ.JoystickLabel = new double[] {
        0.1D,
        0.5D,
        1D,
        5D,
        10D,
        50D};
            this.virtualJoystickZ.JoystickRaster = 5;
            this.virtualJoystickZ.JoystickRasterMark = 0;
            this.virtualJoystickZ.JoystickStanby = System.Drawing.Color.Orange;
            this.virtualJoystickZ.Name = "virtualJoystickZ";
            this.virtualJoystickZ.TabStop = false;
            this.toolTip1.SetToolTip(this.virtualJoystickZ, resources.GetString("virtualJoystickZ.ToolTip"));
            // 
            // virtualJoystickXY
            // 
            resources.ApplyResources(this.virtualJoystickXY, "virtualJoystickXY");
            this.virtualJoystickXY.Joystick2Dimension = true;
            this.virtualJoystickXY.JoystickActive = System.Drawing.Color.Red;
            this.virtualJoystickXY.JoystickLabel = new double[] {
        0.1D,
        0.5D,
        1D,
        5D,
        10D,
        50D};
            this.virtualJoystickXY.JoystickRaster = 5;
            this.virtualJoystickXY.JoystickRasterMark = 0;
            this.virtualJoystickXY.JoystickStanby = System.Drawing.Color.Orange;
            this.virtualJoystickXY.Name = "virtualJoystickXY";
            this.virtualJoystickXY.TabStop = false;
            this.toolTip1.SetToolTip(this.virtualJoystickXY, resources.GetString("virtualJoystickXY.ToolTip"));
            // 
            // btnKillAlarm
            // 
            resources.ApplyResources(this.btnKillAlarm, "btnKillAlarm");
            this.btnKillAlarm.Name = "btnKillAlarm";
            this.toolTip1.SetToolTip(this.btnKillAlarm, resources.GetString("btnKillAlarm.ToolTip"));
            this.btnKillAlarm.UseVisualStyleBackColor = true;
            // 
            // btnFeedHold
            // 
            resources.ApplyResources(this.btnFeedHold, "btnFeedHold");
            this.btnFeedHold.Name = "btnFeedHold";
            this.toolTip1.SetToolTip(this.btnFeedHold, resources.GetString("btnFeedHold.ToolTip"));
            this.btnFeedHold.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.toolTip1.SetToolTip(this.btnReset, resources.GetString("btnReset.ToolTip"));
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // fCTBCode
            // 
            resources.ApplyResources(this.fCTBCode, "fCTBCode");
            this.fCTBCode.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fCTBCode.AutoIndent = false;
            this.fCTBCode.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+\\s*(?<range>=)\\s*(?<range>[^;]+);";
            this.fCTBCode.BackBrush = null;
            this.fCTBCode.CharHeight = 12;
            this.fCTBCode.CharWidth = 7;
            this.fCTBCode.ContextMenuStrip = this.cmsCode;
            this.fCTBCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fCTBCode.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fCTBCode.IsReplaceMode = false;
            this.fCTBCode.Name = "fCTBCode";
            this.fCTBCode.Paddings = new System.Windows.Forms.Padding(0);
            this.fCTBCode.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fCTBCode.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fCTBCode.ServiceColors")));
            this.fCTBCode.ToolTip = null;
            this.toolTip1.SetToolTip(this.fCTBCode, resources.GetString("fCTBCode.ToolTip"));
            this.fCTBCode.Zoom = 100;
            this.fCTBCode.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fCTBCode_TextChanged);
            this.fCTBCode.TextChangedDelayed += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fCTBCode_TextChangedDelayed);
            this.fCTBCode.Load += new System.EventHandler(this.fCTBCode_Load);
            this.fCTBCode.Click += new System.EventHandler(this.fCTBCode_Click);
            this.fCTBCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fCTBCode_KeyDown);
            this.fCTBCode.MouseHover += new System.EventHandler(this.fCTBCode_MouseHover);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = global::RoboterGUI.Properties.Resources.Roboter;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ContextMenuStrip = this.cmsPictureBox;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            this.pictureBox1.SizeChanged += new System.EventHandler(this.pictureBox1_SizeChanged);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseWheel);
            // 
            // cmsPictureBox
            // 
            resources.ApplyResources(this.cmsPictureBox, "cmsPictureBox");
            this.cmsPictureBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveToMarkedPositionToolStripMenuItem,
            this.toolStripSeparator9,
            this.resetZoomingToolStripMenuItem,
            this.toolStripSeparator8,
            this.pasteFromClipboardToolStripMenuItem,
            this.reloadFileToolStripMenuItem,
            this.deletenotMarkToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteThisCodeLineToolStripMenuItem,
            this.moveToFirstPosToolStripMenuItem,
            this.deletePathToolStripMenuItem});
            this.cmsPictureBox.Name = "cmsPictureBox";
            this.toolTip1.SetToolTip(this.cmsPictureBox, resources.GetString("cmsPictureBox.ToolTip"));
            // 
            // moveToMarkedPositionToolStripMenuItem
            // 
            resources.ApplyResources(this.moveToMarkedPositionToolStripMenuItem, "moveToMarkedPositionToolStripMenuItem");
            this.moveToMarkedPositionToolStripMenuItem.Name = "moveToMarkedPositionToolStripMenuItem";
            this.moveToMarkedPositionToolStripMenuItem.Click += new System.EventHandler(this.moveToMarkedPositionToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            resources.ApplyResources(this.toolStripSeparator9, "toolStripSeparator9");
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            // 
            // resetZoomingToolStripMenuItem
            // 
            resources.ApplyResources(this.resetZoomingToolStripMenuItem, "resetZoomingToolStripMenuItem");
            this.resetZoomingToolStripMenuItem.Name = "resetZoomingToolStripMenuItem";
            this.resetZoomingToolStripMenuItem.Click += new System.EventHandler(this.resetZoomingToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            // 
            // pasteFromClipboardToolStripMenuItem
            // 
            resources.ApplyResources(this.pasteFromClipboardToolStripMenuItem, "pasteFromClipboardToolStripMenuItem");
            this.pasteFromClipboardToolStripMenuItem.Name = "pasteFromClipboardToolStripMenuItem";
            this.pasteFromClipboardToolStripMenuItem.Click += new System.EventHandler(this.pasteFromClipboardToolStripMenuItem_Click);
            // 
            // reloadFileToolStripMenuItem
            // 
            resources.ApplyResources(this.reloadFileToolStripMenuItem, "reloadFileToolStripMenuItem");
            this.reloadFileToolStripMenuItem.Name = "reloadFileToolStripMenuItem";
            this.reloadFileToolStripMenuItem.Click += new System.EventHandler(this.reloadFileToolStripMenuItem_Click);
            // 
            // deletenotMarkToolStripMenuItem
            // 
            resources.ApplyResources(this.deletenotMarkToolStripMenuItem, "deletenotMarkToolStripMenuItem");
            this.deletenotMarkToolStripMenuItem.Name = "deletenotMarkToolStripMenuItem";
            this.deletenotMarkToolStripMenuItem.Click += new System.EventHandler(this.deletenotMarkToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // deleteThisCodeLineToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteThisCodeLineToolStripMenuItem, "deleteThisCodeLineToolStripMenuItem");
            this.deleteThisCodeLineToolStripMenuItem.Name = "deleteThisCodeLineToolStripMenuItem";
            this.deleteThisCodeLineToolStripMenuItem.Click += new System.EventHandler(this.deleteThisCodeLineToolStripMenuItem_Click);
            // 
            // moveToFirstPosToolStripMenuItem
            // 
            resources.ApplyResources(this.moveToFirstPosToolStripMenuItem, "moveToFirstPosToolStripMenuItem");
            this.moveToFirstPosToolStripMenuItem.Name = "moveToFirstPosToolStripMenuItem";
            this.moveToFirstPosToolStripMenuItem.Click += new System.EventHandler(this.moveToFirstPosToolStripMenuItem_Click);
            // 
            // deletePathToolStripMenuItem
            // 
            resources.ApplyResources(this.deletePathToolStripMenuItem, "deletePathToolStripMenuItem");
            this.deletePathToolStripMenuItem.Name = "deletePathToolStripMenuItem";
            this.deletePathToolStripMenuItem.Click += new System.EventHandler(this.deletePathToolStripMenuItem_Click);
            // 
            // tLPAussen
            // 
            resources.ApplyResources(this.tLPAussen, "tLPAussen");
            this.tLPAussen.Controls.Add(this.tLPLinks, 0, 0);
            this.tLPAussen.Controls.Add(this.tLPRechts, 1, 0);
            this.tLPAussen.Name = "tLPAussen";
            this.toolTip1.SetToolTip(this.tLPAussen, resources.GetString("tLPAussen.ToolTip"));
            // 
            // tLPLinks
            // 
            resources.ApplyResources(this.tLPLinks, "tLPLinks");
            this.tLPLinks.Controls.Add(this.fCTBCode, 0, 1);
            this.tLPLinks.Controls.Add(this.groupBox1, 0, 0);
            this.tLPLinks.Name = "tLPLinks";
            this.toolTip1.SetToolTip(this.tLPLinks, resources.GetString("tLPLinks.ToolTip"));
            // 
            // tLPRechts
            // 
            resources.ApplyResources(this.tLPRechts, "tLPRechts");
            this.tLPRechts.Controls.Add(this.tLPRechtsUnten, 0, 1);
            this.tLPRechts.Controls.Add(this.tLPRechtsOben, 0, 0);
            this.tLPRechts.Name = "tLPRechts";
            this.toolTip1.SetToolTip(this.tLPRechts, resources.GetString("tLPRechts.ToolTip"));
            // 
            // tLPRechtsUnten
            // 
            resources.ApplyResources(this.tLPRechtsUnten, "tLPRechtsUnten");
            this.tLPRechtsUnten.Controls.Add(this.tLPMitteUnten, 0, 0);
            this.tLPRechtsUnten.Controls.Add(this.panel1, 1, 0);
            this.tLPRechtsUnten.Name = "tLPRechtsUnten";
            this.toolTip1.SetToolTip(this.tLPRechtsUnten, resources.GetString("tLPRechtsUnten.ToolTip"));
            // 
            // tLPMitteUnten
            // 
            resources.ApplyResources(this.tLPMitteUnten, "tLPMitteUnten");
            this.tLPMitteUnten.Controls.Add(this.pictureBox1, 0, 0);
            this.tLPMitteUnten.Controls.Add(this.tBURL, 0, 1);
            this.tLPMitteUnten.Name = "tLPMitteUnten";
            this.toolTip1.SetToolTip(this.tLPMitteUnten, resources.GetString("tLPMitteUnten.ToolTip"));
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.gB_Jogging);
            this.panel1.Name = "panel1";
            this.toolTip1.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            // 
            // gB_Jogging
            // 
            resources.ApplyResources(this.gB_Jogging, "gB_Jogging");
            this.gB_Jogging.Controls.Add(this.label12);
            this.gB_Jogging.Controls.Add(this.virtualJoystickC);
            this.gB_Jogging.Controls.Add(this.virtualJoystickB);
            this.gB_Jogging.Controls.Add(this.virtualJoystickA);
            this.gB_Jogging.Controls.Add(this.cBSendJogStop);
            this.gB_Jogging.Controls.Add(this.btnResume);
            this.gB_Jogging.Controls.Add(this.virtualJoystickE);
            this.gB_Jogging.Controls.Add(this.btnJogStop);
            this.gB_Jogging.Controls.Add(this.lblTool);
            this.gB_Jogging.Controls.Add(this.cBTool);
            this.gB_Jogging.Controls.Add(this.virtualJoystickZ);
            this.gB_Jogging.Controls.Add(this.virtualJoystickXY);
            this.gB_Jogging.Controls.Add(this.label9);
            this.gB_Jogging.Controls.Add(this.tBSpeed);
            this.gB_Jogging.Controls.Add(this.cBGreifer);
            this.gB_Jogging.Controls.Add(this.btnKillAlarm);
            this.gB_Jogging.Controls.Add(this.btnFeedHold);
            this.gB_Jogging.Controls.Add(this.btnReset);
            this.gB_Jogging.Name = "gB_Jogging";
            this.gB_Jogging.TabStop = false;
            this.toolTip1.SetToolTip(this.gB_Jogging, resources.GetString("gB_Jogging.ToolTip"));
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            this.toolTip1.SetToolTip(this.label12, resources.GetString("label12.ToolTip"));
            // 
            // cBSendJogStop
            // 
            resources.ApplyResources(this.cBSendJogStop, "cBSendJogStop");
            this.cBSendJogStop.Checked = global::RoboterGUI.Properties.Settings.Default.ctrlSendStopJog;
            this.cBSendJogStop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBSendJogStop.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RoboterGUI.Properties.Settings.Default, "ctrlSendStopJog", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cBSendJogStop.Name = "cBSendJogStop";
            this.toolTip1.SetToolTip(this.cBSendJogStop, resources.GetString("cBSendJogStop.ToolTip"));
            this.cBSendJogStop.UseVisualStyleBackColor = true;
            // 
            // lblTool
            // 
            resources.ApplyResources(this.lblTool, "lblTool");
            this.lblTool.Name = "lblTool";
            this.toolTip1.SetToolTip(this.lblTool, resources.GetString("lblTool.ToolTip"));
            // 
            // cBTool
            // 
            resources.ApplyResources(this.cBTool, "cBTool");
            this.cBTool.Name = "cBTool";
            this.toolTip1.SetToolTip(this.cBTool, resources.GetString("cBTool.ToolTip"));
            this.cBTool.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            this.toolTip1.SetToolTip(this.label9, resources.GetString("label9.ToolTip"));
            // 
            // tBSpeed
            // 
            resources.ApplyResources(this.tBSpeed, "tBSpeed");
            this.tBSpeed.Name = "tBSpeed";
            this.toolTip1.SetToolTip(this.tBSpeed, resources.GetString("tBSpeed.ToolTip"));
            // 
            // cBGreifer
            // 
            resources.ApplyResources(this.cBGreifer, "cBGreifer");
            this.cBGreifer.Name = "cBGreifer";
            this.toolTip1.SetToolTip(this.cBGreifer, resources.GetString("cBGreifer.ToolTip"));
            this.cBGreifer.UseVisualStyleBackColor = true;
            // 
            // tLPRechtsOben
            // 
            resources.ApplyResources(this.tLPRechtsOben, "tLPRechtsOben");
            this.tLPRechtsOben.Controls.Add(this.groupBox5, 1, 0);
            this.tLPRechtsOben.Controls.Add(this.groupBox2, 0, 0);
            this.tLPRechtsOben.Name = "tLPRechtsOben";
            this.toolTip1.SetToolTip(this.tLPRechtsOben, resources.GetString("tLPRechtsOben.ToolTip"));
            // 
            // gamePadTimer
            // 
            this.gamePadTimer.Tick += new System.EventHandler(this.gamePadTimer_Tick);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tLPAussen);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.btnOverrideFRGB.ResumeLayout(false);
            this.btnOverrideFRGB.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.cmsCode.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fCTBCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmsPictureBox.ResumeLayout(false);
            this.tLPAussen.ResumeLayout(false);
            this.tLPLinks.ResumeLayout(false);
            this.tLPRechts.ResumeLayout(false);
            this.tLPRechtsUnten.ResumeLayout(false);
            this.tLPRechtsUnten.PerformLayout();
            this.tLPMitteUnten.ResumeLayout(false);
            this.tLPMitteUnten.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gB_Jogging.ResumeLayout(false);
            this.gB_Jogging.PerformLayout();
            this.tLPRechtsOben.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void virtualJoystickC_Load(object sender, EventArgs e)
        {
            
        }

        private void virtualJoystickB_Load(object sender, EventArgs e)
        {
            
        }

        private void virtualJoystickXY_Load_1(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label_wx;
        private System.Windows.Forms.Label label_wy;
        private System.Windows.Forms.Label label_wz;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar pbFile;
        private System.Windows.Forms.Label lblElapsed;
        private System.Windows.Forms.Label lblFileProgress;
        private System.Windows.Forms.ProgressBar pbBuffer;
        private System.Windows.Forms.Button btnStreamStart;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnZeroXYZ;
        private System.Windows.Forms.Button btnZeroXY;
        private System.Windows.Forms.Button btnZeroZ;
        private System.Windows.Forms.Button btnZeroY;
        private System.Windows.Forms.Button btnZeroX;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnCustom6;
        private System.Windows.Forms.Button btnCustom5;
        private System.Windows.Forms.Button btnCustom4;
        private System.Windows.Forms.Button btnCustom3;
        private System.Windows.Forms.Button btnCustom2;
        private System.Windows.Forms.Button btnCustom1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.ContextMenuStrip cmsCode;
        private System.Windows.Forms.ToolStripMenuItem cmsCodeSelect;
        private System.Windows.Forms.ToolStripMenuItem cmsCodeCopy;
        private System.Windows.Forms.ToolStripMenuItem cmsCodeSendLine;
        private System.Windows.Forms.ToolStripMenuItem cmsCodePaste;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tLPAussen;
        private System.Windows.Forms.TableLayoutPanel tLPLinks;
        private System.Windows.Forms.TableLayoutPanel tLPRechts;
        private System.Windows.Forms.TableLayoutPanel tLPRechtsUnten;
        private System.Windows.Forms.TableLayoutPanel tLPRechtsOben;
        private FastColoredTextBoxNS.FastColoredTextBox fCTBCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCustom8;
        private System.Windows.Forms.Button btnCustom7;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tLPMitteUnten;
        private System.Windows.Forms.TextBox tBURL;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnStreamCheck;
        private System.Windows.Forms.Button btnStreamStop;
        private System.Windows.Forms.ContextMenuStrip cmsPictureBox;
        private System.Windows.Forms.ToolStripMenuItem moveToFirstPosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteThisCodeLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deletenotMarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem machineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlStreamingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem createGCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textWizzardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createSimpleShapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMachineParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMachineParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem control2ndGRBLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deutschToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mirrorXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mirrorYToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem rotate90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate90ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rotateFreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStrip_tb_rotate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStrip_tb_XY_scale;
        private System.Windows.Forms.ToolStripMenuItem skalierenXYToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStrip_tb_XY_X_scale;
        private System.Windows.Forms.ToolStripMenuItem skalierenXYUmXUnitsZuErreichenToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStrip_tb_XY_Y_scale;
        private System.Windows.Forms.ToolStripMenuItem skaliereXUmToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStrip_tb_X_scale;
        private System.Windows.Forms.ToolStripMenuItem skaliereAufXUnitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStrip_tb_X_X_scale;
        private System.Windows.Forms.ToolStripMenuItem skaliereXAufDrehachseToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStrip_tb_X_A_scale;
        private System.Windows.Forms.ToolStripMenuItem skaliereYUmToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStrip_tb_Y_scale;
        private System.Windows.Forms.ToolStripMenuItem skaliereAufYUnitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStrip_tb_Y_Y_scale;
        private System.Windows.Forms.ToolStripMenuItem skaliereYAufDrehachseToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStrip_tb_Y_A_scale;
        private System.Windows.Forms.TextBox lbDimension;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rBOrigin9;
        private System.Windows.Forms.RadioButton rBOrigin8;
        private System.Windows.Forms.RadioButton rBOrigin7;
        private System.Windows.Forms.RadioButton rBOrigin6;
        private System.Windows.Forms.RadioButton rBOrigin5;
        private System.Windows.Forms.RadioButton rBOrigin4;
        private System.Windows.Forms.RadioButton rBOrigin3;
        private System.Windows.Forms.RadioButton rBOrigin2;
        private System.Windows.Forms.RadioButton rBOrigin1;
        private System.Windows.Forms.Button btnOffsetApply;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbOffsetY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOffsetX;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem rotaryDimaeterToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStrip_tb_rotary_diameter;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem ersetzteG23DurchLinienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heightMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetZoomingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.Label label_e;
        private System.Windows.Forms.Button btnZeroE;
        private System.Windows.Forms.Label label_we;
        private System.Windows.Forms.ToolStripMenuItem pasteFromClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.GroupBox btnOverrideFRGB;
        private System.Windows.Forms.Button btnOverrideFR1;
        private System.Windows.Forms.Button btnOverrideFR2;
        private System.Windows.Forms.Button btnOverrideFR0;
        private System.Windows.Forms.Button btnOverrideFR4;
        private System.Windows.Forms.Button btnOverrideFR3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOverrideFRValue;
        private System.Windows.Forms.ToolStripMenuItem cmsCommentOut;
        private System.Windows.Forms.Timer gamePadTimer;
        private System.Windows.Forms.ToolStripMenuItem moveToMarkedPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadFileToolStripMenuItem;
        private System.Windows.Forms.Button btnLimitExceed;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnZeroC;
        private System.Windows.Forms.Label label_wc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnZeroB;
        private System.Windows.Forms.Label label_wb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnZeroA;
        private System.Windows.Forms.Label label_wa;
        private System.Windows.Forms.Button btnZeroABC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gB_Jogging;
        private System.Windows.Forms.Label label12;
        private virtualJoystick.virtualJoystick virtualJoystickC;
        private virtualJoystick.virtualJoystick virtualJoystickB;
        private virtualJoystick.virtualJoystick virtualJoystickA;
        private System.Windows.Forms.CheckBox cBSendJogStop;
        private System.Windows.Forms.Button btnResume;
        private virtualJoystick.virtualJoystick virtualJoystickE;
        private System.Windows.Forms.Button btnJogStop;
        private System.Windows.Forms.Label lblTool;
        private System.Windows.Forms.CheckBox cBTool;
        private virtualJoystick.virtualJoystick virtualJoystickZ;
        private virtualJoystick.virtualJoystick virtualJoystickXY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBSpeed;
        private System.Windows.Forms.CheckBox cBGreifer;
        private System.Windows.Forms.Button btnKillAlarm;
        private System.Windows.Forms.Button btnFeedHold;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPause2000;
        private System.Windows.Forms.Button btnPause1000;
        private System.Windows.Forms.Button btnTeachen;
        private System.Windows.Forms.Button btnPause300;
    }
}

