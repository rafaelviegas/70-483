using System;
using System.Threading;

namespace Chapter1
{
    public static class Program
    {
        public static void Main()
        {
            bool stopped = false;

            var t = new Thread(() =>
            {
                while (!stopped)
                {
                    Console.WriteLine("Rodando...");
                    Thread.Sleep(1000);
                }
            });

            t.Start();
            Console.WriteLine("Aperte uma tecla para sair...");
            Console.ReadKey();
            stopped = true;

            t.Join();
        }
    }
}
