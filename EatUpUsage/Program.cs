using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace EatUpUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1] > 吃滿CPU");
            Console.WriteLine("[2] > 吃滿Memory");
            Console.WriteLine("==========================");
            while (true)
            {
                Console.Write("input>");
                string rl = Console.ReadLine();
                switch (rl)
                {
                    case "1":
                        {
                            ConsumeCPU();
                            break;
                        }
                    case "2":
                        {
                            EatMemory();
                            break;
                        }
                }
            }
        }
        public static void ConsumeCPU()
        {
            Console.WriteLine("<模擬吃滿CPU負載...>");
            
            List<byte[]> wastedMemory = new List<byte[]>();

            ThreadPool.SetMaxThreads(10000, 10000);
            ThreadPool.QueueUserWorkItem(obj =>
            {
                while (true)
                {
                    ThreadPool.QueueUserWorkItem(obj2 =>
                    {
                        while (true)
                            ;
                    });
                }
            });

            Console.Read();
        }
        public static void EatMemory()
        {
            Console.WriteLine("<模擬吃滿Memory負載...>");
            List<byte[]> wastedMemory = new List<byte[]>();

            while (true)
            {
                byte[] buffer = new byte[4096]; // Allocate 4kb
                wastedMemory.Add(buffer);
            }
        }
    }
}
