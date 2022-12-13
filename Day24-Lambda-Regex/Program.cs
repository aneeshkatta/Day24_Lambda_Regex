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
            string inputFirstName = "Raj";
            bool result = LambdaRegex.Validate(inputFirstName);
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
