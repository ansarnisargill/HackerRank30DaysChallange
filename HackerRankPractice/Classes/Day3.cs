using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankPractice.Classes
{
    public class Day3
    {
        public Day3()
        {
            Console.WriteLine("Enter Integer!");
            int N = Convert.ToInt32(Console.ReadLine());
            if (IsEven(N))
            {
                if(N>1 && N < 6)
                {
                    Console.WriteLine("Not Weird");
                }
                else if(N>5 && N < 21)
                {
                    Console.WriteLine("Weird");
                }
                else
                {
                    Console.WriteLine("Not Weird");
                }
            }
            else
            {
                Console.WriteLine("Weird");
            }
            Console.ReadLine();
        }
        public bool IsEven(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
