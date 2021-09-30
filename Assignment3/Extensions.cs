using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Assignment3
{
    public static class Extensions
    {
        public static bool isSecure(this Uri u)
        {
            return u.Scheme == ("https");
        }

        public static int wordCount(this String s)
        {
            int counter = 0;
            var pattern = @"(?<return>[a-z]+)(\W*\d*)";
            Regex reg = new Regex(pattern);
            
            foreach(Match m in reg.Matches(s)){
                counter++;
            }
            
            return counter;
        }
    }
}
