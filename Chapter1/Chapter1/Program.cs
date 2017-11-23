using System;
using System.Threading.Tasks;

namespace Chapter1
{
    public static class Program
    {
        public static void Main()
        {
     
            var t = Task.Run(() => 42)
                .ContinueWith((task) =>
                {
                    return task.Result * 2;
                });

            Console.WriteLine(t.Result);
            Console.ReadKey();
        }
    }
}
