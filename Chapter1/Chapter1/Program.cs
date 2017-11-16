using System;
using System.Threading;

namespace Chapter1
{
    public static class Program
    {

        public static void Main()
        {
            /*
             * Reutilizando uma thread disponível do Threadpool para executar um código
             * evitando o custo da criação de uma nova thread.
             */

            ThreadPool.QueueUserWorkItem((s) =>
            {   
                Console.WriteLine("Trabalhando em uma thread do threadpool");
            });

 
            Console.ReadKey();
        }
    }
}
