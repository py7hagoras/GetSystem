# GetTrustedInstaller - Fork of py7hagoras/GetSystem
This is a fork of py7hagoras/GetSystem repo that was modified to be able to make a process/executable run under NT SERVICE\TRUSTEDINSTALLER permissions. 

# Usage: 

GetTrustedInstaller.exe <absolute path of executable to run + arguments>
  
GetTrustedInstaller.exe 'C:\Windows\System32\cmd.exe /k whoami'

![Showing run of GetTrustedInstaller to spawn cmd.exe with TrustedInstaller.exe as a Parent](https://github.com/rara64/GetTrustedInstaller/blob/master/GetTrustedInstaller.png)




