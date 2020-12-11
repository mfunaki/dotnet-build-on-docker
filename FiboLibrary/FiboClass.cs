using System;

namespace MyLibrary
{
    public class Fibo
    {
        public long Compute(int n)
        {
            if (n < 2)
            {
                return n;
            }
            return Compute(n - 1) + Compute(n - 2);
        }

        public void PrintDebugInfo()
        {
            Console.WriteLine("CLR Version: {0}",
                System.Runtime.InteropServices.RuntimeEnvironment.GetSystemVersion());
            Console.WriteLine("CLR Runtime Version: {0}", 
                Environment.Version.ToString());
            var os = Environment.OSVersion;
            Console.WriteLine("Platform: {0}", os.Platform);
            Console.WriteLine("Version : {0}", os.VersionString);
            Console.WriteLine(" Major  : {0}", os.Version.Major);
            Console.WriteLine(" Minor  : {0}", os.Version.Minor);
            Console.WriteLine("Service Pack: {0}", os.ServicePack);
        }
    }
}