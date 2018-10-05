using System;

namespace Assign3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1;

            Console.WriteLine("odd numbers are");
            while(i<50)
            {
                
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(+i);
                    }
                i++;  
            }
        }
    }
}
