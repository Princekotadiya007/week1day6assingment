using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_Fibonaci_series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, number;

            Console.WriteLine("enter the number");
            number = Convert.ToInt32(Console.ReadLine());

            Console.Write(n1 + "",+ n2 + "");

            for(int i=2; i < number; i++)
            {
                n3 = n1 + n2; //0+1=1
                Console.Write(n3 + "");//1
                n1 = n2; //1 1 2 3
                n2 = n3;//1 2 3 5
            }
        }
    }
}
