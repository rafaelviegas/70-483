using System;
using System.Threading;

namespace Chapter1
{
    public static class Program
    {

        /*
         * Usando o atributo ThreadStatic a variável é inicializada apenas uma vez
         * Com ThreadLocal<T> a variável é inicializada dentro do escopo de cada Thread.
        */

        public static ThreadLocal<int> _field = new ThreadLocal<int>(() =>
         {
             return Thread.CurrentThread.ManagedThreadId;
         });

        public static void Main()
        {

            new Thread(() =>
            {
                for (int i = 0; i < _field.Value; i++)
                {
                  
                    Console.WriteLine("Thread A: {0}",i);
                }
            }).Start();

            new Thread(() =>
            {
                for (int i = 0; i < _field.Value; i++)
                {
               
                    Console.WriteLine("Thread B: {0}", i);
                }
            }).Start();

            Console.ReadKey();
        }
    }
}
