using System.Diagnostics;

namespace GetSystem
{
    class Program
    {
    
        
        static void Main(string[] args)
        {
            string binaryPath = args[0];
            string ProcessToSpoof = args[1];
            int parentProcessId;
            Process[] explorerproc = Process.GetProcessesByName(ProcessToSpoof);
            parentProcessId = explorerproc[0].Id;
            IamYourDaddy.Run(parentProcessId, binaryPath);
           
        }



    }
}
