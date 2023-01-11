using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0; ;

            for(int i=1; i<number; i++)
            {
                if(number%i==0)
                {
                    count++;    
                }
                if(count==2)
                {
                    Console.WriteLine("it is prime number");
                }
                else
                {
                    Console.WriteLine("it is not a prime number");
                }
            }
        }
    }
}
