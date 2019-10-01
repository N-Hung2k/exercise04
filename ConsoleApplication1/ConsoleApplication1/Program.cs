using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool a = IsOdd(4);
            if (a == true)
            {
                Console.WriteLine("le");
            }else
            {
                Console.WriteLine("Chan");
            }
        }

        public static bool IsOdd(int n)
        {
            bool result = n % 2 == 1;
            return result;
        }

        public static bool IsEven(int n)
        {
            bool result = n % 2 == 0;
            return result;
        }
    }
}
