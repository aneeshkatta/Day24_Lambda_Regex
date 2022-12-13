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
        public static string regex = "^[0-9][0-9][ -][1-9][0-9]{9}";
        //comparing both values using regex ismatch
        public static bool Validate(string ph) => Regex.IsMatch(ph, regex);
    }
}

