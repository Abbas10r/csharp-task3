using System;
using System.Collections.Generic;
using System.Text;

namespace app3
{
    class task3
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr=new int[3];
            for(int i = 0; i < n; i++)
            {
                int t = Convert.ToInt32(Console.ReadLine());
                if (1 <= t && t <= 60)
                    arr[i] = t;
                else
                    Console.WriteLine("Out of range");
            }
            for(int i = 0; i < n; i++)
            {
                if (arr[i] == 0)
                {
                    Console.WriteLine(0);
                    continue;
                }
                Console.WriteLine(arr[i] - 1);
            }
        }
    }
}
