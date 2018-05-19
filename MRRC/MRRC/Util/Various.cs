using MRRC.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRC.Util
{
    class Various
    {
        /*
         * Parses a string to the given T enum type.
         * */
        public static T ParseEnum<T>(string value)
        {
            return (T) Enum.Parse(typeof(T), value, true);
        }

        /*
         * Parses a string and determines its bool value. If the value is not "true", it's automatically "false"
         * */
        public static bool BoolFromString(String value)
        {
            return value.ToLower().Equals("true") ? true : false;
        }

        /*
         * Checks if the parentheses are opened and closed correctly.
         * */
        public static bool CheckParentheses(String query)
        {
            Stack<Char> parentheses = new Stack<char>();
            int counter = 0;
            foreach (char c in query)
            {
                if (c == '(') { parentheses.Push(c); counter++; }
                else if (c == ')')
                {
                    try
                    {
                        if (parentheses.Pop() != '(') return false;
                        counter--;
                    }
                    catch (Exception e)
                    {
                        return false;
                    }
                }
            }

            return counter == 0;
        }

        /*
         * Returns an array of [start, end] positions of a keyword after first pair of balanced parentheses.
         * */
        public static int[] GetKeywordStartEndPosition(String query, String keyword)
        {
            try
            {
                int open = 0;

                for (int index = 0; index < query.Length; index++)
                {
                    if (query[index] == '(') open++;
                    else if (query[index] == ')') open--;

                    if (open == 0 && query.Substring(index, keyword.Length).Equals(keyword))
                        return new int[] { index - 1, index + keyword.Length + 1 };
                }

                throw new ParseException("Didn't find anything!");
            }
            catch (Exception)
            {
                throw new ParseException("Couldn't find keyword in the query");
            }
        }
    }
}
