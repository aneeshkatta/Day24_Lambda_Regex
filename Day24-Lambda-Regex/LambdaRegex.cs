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
        public static string regex = "^[0-9a-z]{1,}([.+-_]*)(([0-9a-z]{1,})*)(@)(gmail|bl)(.)(com|co)([.]*)([in]*)$";
        //comparing both values using regex ismatch
        public static bool Validate(string mail) => Regex.IsMatch(mail, regex);
    }
}

