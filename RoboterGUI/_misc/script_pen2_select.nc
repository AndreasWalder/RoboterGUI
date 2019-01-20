( Select and grip pen nr.)
( G53 indicates machine coordinates - no transform required)
( move Z in relative coordinates to compensate different tool length)
M8							( open gripper)
G1 G0 Z20					( lift gripper in save position)
G53 G1 G0 X#TOAX Y#TOAY	( move gripper in front of actual pen in absolute machine coordinates)
G53 G1 G0 Z#TOAZ			( move gripper to correct height)

G1 Y3						( move gripper in position)
X-15
M9							( close gripper)
Y-3
Z20							( lift pen)
X15							( take pen)
($TOOL-IN)
G1
