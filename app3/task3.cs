using System;
using System.Collections.Generic;
using static System.Console;
using static System.Convert;
namespace app3
{
    class task3
    {
        static void Main(string[] args)
        {
            int n = ToInt32(ReadLine());
            int[] arr=new int[1000];
            for(int i = 0; i < n; i++)
            {
                int t = ToInt32(ReadLine());
                if (1 <= t && t <= 60)
                    arr[i] = t;
                else
                    WriteLine("Out of range");
            }
            for(int i = 0; i < n; i++)
            {
                if (arr[i] == 0)
                {
                    WriteLine(0);
                    continue;
                }
                WriteLine(arr[i] - 1);
            }
        }
    }
}
