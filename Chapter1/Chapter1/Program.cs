﻿using System;
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
                Thread.Sleep(1000);
            }
        }
        public static void Main()
        {
            //Instanciando uma nova thread em background com o método que criei no inicio do programa
            var t = new Thread(ThreadMethod) {IsBackground = true};

            //startando a thread.
            t.Start();
  

            Console.ReadKey();

        }
    }
}
