using System;

namespace GarbageCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            long mem1 = GC.GetTotalMemory(false);

            {
                int[] values = new int[50000];
                values = null;
            }
            long mem2 = GC.GetTotalMemory(false);
            {
                //Collect Garbage
                GC.Collect();
            }

            long mem3 = GC.GetTotalMemory(false);
            Console.WriteLine("hello");
            {
                Console.WriteLine(mem1);
                Console.WriteLine(mem2);
                Console.WriteLine(mem3);
            }
            Console.WriteLine("#######################");
            long bytes1 = GC.GetTotalMemory(false);// Get memory in bytes
            byte[] memory = new byte[1000 * 1000 * 10]; //Ten million bytes
            memory[0] = 1;
            long bytes2 = GC.GetTotalMemory(false);
            long bytes3 = GC.GetTotalMemory(true);
            Console.WriteLine(bytes1);
            Console.WriteLine(bytes2);
            Console.WriteLine(bytes2 - bytes1);
            Console.WriteLine(bytes3);
            Console.WriteLine(bytes3 - bytes2);
            Console.ReadKey();
        }
    }

}
