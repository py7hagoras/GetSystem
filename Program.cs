using System.Diagnostics;
using System.ServiceProcess;

namespace GetTrustedInstaller
{
    class Program
    {
    
        
        static void Main(string[] args)
        {

            // I use TrustedInstaller process that is in the background only when the TrustedInstaller service is running to pass its ID to py7hagoras code
            ServiceController sc = new ServiceController
            {
                ServiceName = "TrustedInstaller",
            };
            if (sc.Status != ServiceControllerStatus.Running)
            sc.Start();
            Process[] proc = Process.GetProcessesByName("TrustedInstaller");
            IamYourDaddy.Run(proc[0].Id, args[0]);
           
        }



    }
}
