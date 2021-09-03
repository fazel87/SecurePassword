using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurePassword
{
    static class PasswordGenerate
    {
        public static char[] character = { '!', '@', '#', '$', '%', '^', '^', '&', '*', '(', ')', '-', '_', '=', '+', '\\', '|', '/', '.', ',', '?', '`', '~' };
        private static readonly Random rnd = new Random();
        public static string GenerateAsPassword(this string AcountName, int secure)
        {
            string result = AcountName;

            for (int i = 0; i < secure; i++)
            {
                result = result.Add(Random(0, result.Length), character[Random(0, character.Length)]);
            }
            return result;
        }
        public static string Add(this string str, int location, char character)
        {

            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i == location)
                    result += character;
                result += str[i];

            }
            return result;
        }
        public static int Random(int min, int max)
        {
            return rnd.Next(min < max ? min : 0, max);
        }
        public static string RandomString(int size, bool lower = false)
        {
            var builder = new StringBuilder(size);
            char offset = lower ? 'a' : 'A';

            for (var i = 0; i < size; i++)
            {
                builder.Append((char)rnd.Next(offset, offset + 26));
            }

            return lower ? builder.ToString().ToLower() : builder.ToString();
        }
    }
}
