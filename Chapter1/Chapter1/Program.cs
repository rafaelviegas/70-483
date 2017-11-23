using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    public static class Program
    {
        public static void Main()
        {
            //Essa tarefa só termina quando todas as 3 tarefas filhas terminarem 
            Task<Int32[]> parent = Task.Run(() =>
            {
                var results = new Int32[3];

                new Task(() => results[0] = 0, TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[1] = 1, TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[2] = 2, TaskCreationOptions.AttachedToParent).Start();

                return results;
            });

            //Essa tarefa só será executada quando a 'parent' terminar
            var finalTask = parent.ContinueWith(parentTask =>
            {
                foreach (var item in parentTask.Result)
                {
                    Console.WriteLine(item);
                }
            });

            finalTask.Wait();

            Console.ReadKey();
        }
    }
}
