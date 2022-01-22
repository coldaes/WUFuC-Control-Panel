title WUFuC script command
echo WUFuC Copyright (C) 2022 coldsoft
echo WUFuC Copyright (C) 2017 zeffy
echo This program comes with ABSOLUTELY NO WARRANTY; for details type `show w'.
echo This is free software, and you are welcome to redistribute it
echo under certain conditions; type `show c' for details.
echo.

set "wufuc_task=wufuc.{72EEE38B-9997-42BD-85D3-2DD96DA17307}"
net start Schedule
schtasks /Change /TN "%wufuc_task%" /ENABLE
schtasks /Run /TN "%wufuc_task%"
exit
