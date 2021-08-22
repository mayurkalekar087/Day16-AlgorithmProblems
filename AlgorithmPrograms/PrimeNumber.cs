using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class PrimeNumber
    {
        public void Prime()
        {
            int num, i, flag, start, End;

            Console.Write("\n\n");
            Console.Write("Find the prime numbers within a range of numbers:\n");
            Console.Write("---------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input starting number of range: ");
            start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input ending number of range : ");
            End = Convert.ToInt32(Console.ReadLine());
            Console.Write("The prime numbers between {0} and {1} are : \n", start, End);

            for (num = start; num <= End; num++)
            {
                flag = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        flag = 1;
                        break;
                    }
                }

                if (flag == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
            Console.Write("\n");
        }
    }
}
