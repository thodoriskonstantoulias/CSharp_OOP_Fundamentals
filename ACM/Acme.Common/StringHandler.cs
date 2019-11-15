using System;

namespace Acme.Common
{
    public static class StringHandler
    {
        //Inserts spaces before each capital letter in a string except the first character
        public static string InsertSpaces(this string source)
        {
            string result = string.Empty;
            if (!string.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
            }
            result = result.Trim();
            return result;
        }
    }
}
