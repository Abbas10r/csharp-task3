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
            int[] arr=new int[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
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
