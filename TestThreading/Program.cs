using System;

namespace TestThreading
{
    class Program
    { 
        static void Main()
        {
            Tester tester = new Tester();
            ActionsForTest methods = new ActionsForTest();

            tester.StopWatching(methods.Loopfor);
            tester.StopWatching(methods.LoopFor);
            Console.ReadLine();
        }      
    }
}
