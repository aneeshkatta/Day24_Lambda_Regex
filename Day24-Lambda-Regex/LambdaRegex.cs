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
        public static string regex = "(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*]).{8,}";
        //comparing both values using regex ismatch
        public static bool Validate(string password) => Regex.IsMatch(password, regex);
    }
}

