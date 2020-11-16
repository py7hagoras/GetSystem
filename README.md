# GetTrustedInstaller - Fork of py7hagoras/GetSystem
This is a fork of py7hagoras/GetSystem repo that was modified to be able to make a process/executable run under NT SERVICE\TRUSTEDINSTALLER permissions. 

# Usage: 

GetTrustedInstaller.exe <absolute path of executable to run> <SYSTEM process to spoof as parent>
  
GetTrustedInstaller.exe C:\Windows\System32\cmd.exe

![Showing run of GetSystem to spawn cmd.exe as SYSTEM with lsass as parent](https://github.com/py7hagoras/GetSystem/raw/master/GetTrustedInstaller.PNG)




