using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cprohw9
{
    static class Task1
    {
        public static void Work()
        {
            Task ts1 = new Task(() => Console.WriteLine("Task1"));
            Task ts2 = new Task(() =>
            {
                Console.WriteLine("Task2 start");
                Thread.Sleep(1000);
                Console.WriteLine("Task2 end");
            });
            Task ts3 = new Task(() =>
            {
                Thread.Sleep(1000);
                int i = 0;
                Console.WriteLine("Task3 start {0}",i);
                Thread.Sleep(1000);
                i += 10;
                Console.WriteLine("Task3 end {0}", i);
            });

            Task[] tasks = {ts1, ts2, ts3};

            ts1.Start();
            ts2.Start();
            ts3.Start();

            Task.WaitAll(tasks);

            Console.WriteLine("Tasks End");
        }
    }
}
