using System;
using System.Linq;

namespace CSharpExtensionMethods
{
    public static class StringExtension
    {
        public static string Shorten(this string str,int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("number of words should be greater than or equal to 0");
            if (numberOfWords == 0)
                return "";

            var words = str.Split(' ');//IENUMERABLE OF STRINGS..

            if (words.Length <= numberOfWords)
                return str;
            return string.Join(" ",words.Take(numberOfWords)) +"....";

           

        }
    }
}
