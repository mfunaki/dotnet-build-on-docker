using System;
using MyLibrary;

class Program
{
    static void Main(string[] args)
    {
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

        int num;
        bool isDebug = false;
        if (args[0].CompareTo("-d") == 0)
        {
            num = int.Parse(args[1]);
            isDebug = true;
        } 
        else
        {
            num = int.Parse(args[0]);
        }

        Fibo fibo = new Fibo();
        sw.Start();
        long result = fibo.Compute(num);
        sw.Stop();

        Console.WriteLine(result);
        
        if (isDebug)
        {
            Console.WriteLine("Elapsed: {0}ms", sw.ElapsedMilliseconds);
            fibo.PrintDebugInfo();
        }
    }
}
