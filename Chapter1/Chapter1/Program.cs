using System;
using System.Threading;

namespace Chapter1
{
    public static class Program
    {
        //Criando método para simulação de uma thread.
        public static void ThreadMethod()
        {
            //A thread então imprime números de 0 a 9.
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                //Usando o método Sleep para simular a suspenção desta thread por 0 milissegundos.
                Thread.Sleep(0);
            }
        }
        public static void Main()
        {
            //Instanciando uma nova thread com o método que criei no inicio do programa.
            var t = new Thread(ThreadMethod);
            //startando a thread.
            t.Start();
            //Criando um processo qualquer no meu método main
            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                //Usando o método Sleep para simular a suspenção desta thread por 0 milissegundos.
                Thread.Sleep(0);
            }
            //Usando o método Join para que o programa aguarde o termino desta thread para prosseguir.
            t.Join();

            Console.ReadKey();

        }
    }
}
