(Move pen back to pen storage)
(Assumption: active pen storage position is empty)
( G53 indicates machine coordinates - no transform required)
( move Z in relative coordinates to compensate different tool length)
G1 G0 Z20					( lift gripper in save position)
G53 G1 G0 X#TOLX Y#TOLY	( move gripper in front of last pen in absolute machine coordinates)
G53 G1 G0 Z#TOLZ			( move gripper to correct height)
G1 G0 Z25					( lift pen)

G1 X-15					( move pen into holder)
Z-25						( move pen down)
M8							( open gripper)
Y3							( remove gripper from pen)
X15	
($TOOL-OUT)
G1
