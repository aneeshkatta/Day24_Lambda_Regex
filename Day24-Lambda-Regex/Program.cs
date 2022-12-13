using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day24_Lambda_Regex
{
     class Program
    {
        static void Main(string[] args)
        {
            string mail = "abc.xyz@bl.co.in";
            bool result = LambdaRegex.Validate(mail);
            if (result)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Not Valid");
            }
            Console.ReadKey();
        }
    }
}
