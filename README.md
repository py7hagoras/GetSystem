# GetSystem
This is a C# implementation of making a process/executable run as NT AUTHORITY/SYSTEM. This is achieved through parent ID spoofing of almost any SYSTEM process.

# Usage: 

GetSystem.exe <absolute path of executable to run> <SYSTEM process to spoof as parent>
  
GetSystem.exe C:\Windows\System32\cmd.exe lsass

![Showing run of GetSystem to spawn cmd.exe as SYSTEM with lsass as parent](https://github.com/py7hagoras/GetSystem/raw/master/GetSystem.PNG)




