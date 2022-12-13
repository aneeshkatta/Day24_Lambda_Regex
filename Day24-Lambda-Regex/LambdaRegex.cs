using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day24_Lambda_Regex
{
    public class LambdaRegex
    {
        //regex pattern for string
        public static string regex = "^[A-Z][A-za-z]{2,}";
        //comparing both values using regex ismatch
        public static bool Validate(string firstname) => Regex.IsMatch(firstname, regex);
    }
}

