using System;
using System.Threading.Tasks;

namespace Chapter1
{
    public static class Program
    {
        public static void Main()
        {
     
            Task<int> t = Task.Run(() => 42);

            Console.WriteLine(t.Result);
            Console.ReadKey();
        }
    }
}
