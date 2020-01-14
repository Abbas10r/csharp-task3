
using System;

namespace app3
{
    class task1
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
