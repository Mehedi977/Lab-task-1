using System;


namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            int i = 30;
            for (int i = 1; i <= 30; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("even : " + i);
            }
            //2.
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("X0X0X0");
                Console.WriteLine("0X0X0X");
            }
            //3.
            int rows = 5;
            int cols = 5;
            int j;
            int m;
            for (j = 1; j <= rows; j++)
            {
                for (m = j; m < j + cols; m++)
                {
                    Console.Write(m);
                }

                Console.WriteLine("\n");
            }

            /*4.
            1 to 100.*/
            int k1, odd_sum = 0, even_sum = 0, num = 100;

            for (k1 = 1; k1 <= num; k1++)
            {
                if (k1 % 2 == 0)
                    even_sum = even_sum + k1;
                else
                    odd_sum = odd_sum + k1;
            }
            Console.WriteLine("Sum of all odd number  = " + odd_sum + "\n");
            Console.WriteLine("Sum of all even number = " + even_sum + "\n");

            /*5.
              1
               2
                3
                 4
                  5
                */
            int i5, j5, rows5 = 5;
            for (i5 = 1; i5 <= rows5; ++i5)
            {
                for (j5 = 1; j5 <= i5; ++j5)
                {
                    if (j5 == i5)
                    {
                        for (int t = 1; t <= j5; t++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(j5);
                    }
                }
                Console.WriteLine("\n");
            }



           