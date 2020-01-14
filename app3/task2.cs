using System;
using System.Collections.Generic;
using System.Text;

namespace app3
{
    class task2
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < 10; i++)
            {
                if(arr[i]<=0)
                {
                    arr[i] = 1;
                }
            }
            Console.WriteLine("-------");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
