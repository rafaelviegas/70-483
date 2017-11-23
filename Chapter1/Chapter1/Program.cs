using System;
using System.Threading.Tasks;

namespace Chapter1
{
    public static class Program
    {
        public static void Main()
        {
            //Criando nova Task e iniciando-a imediatamente
            Task t = Task.Run(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write('*');
                }
            });

            //Igual ao Join da Thread. Espera a Task executar por completa para seguir o fluxo
            t.Wait();
            Console.ReadKey();
        }
    }
}
