using MRRC.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRC.Util
{
    class LogicalUtil
    {
        public static String[] Split(String query)
        {
            // Lowercase the query
            query = query.ToLower();

            // Check if parantheses are correctly closed
            if (!Various.CheckParentheses(query)) throw new ParseException("Parentheses are not balanced!");

            // Check if there is anything to split
            if (query.Length <= 0) throw new ParseException("Query can't be empty!");

            String logicWord = null;
            int[] indexes = null;
            bool foundAnd = false;
            bool foundOr = false;

            // Try to remove useless () if there are at the beginning or at the end
            if (query[0] == '(' && query[query.Length - 1] == ')')
            {
                String noParentheses = query.Substring(1, query.Length - 2);

                if (Various.CheckParentheses(noParentheses)) query = noParentheses;
            }

            // Check if there exists AND
            if (query.Contains("and"))
            {
                logicWord = "and";

                try
                {
                    indexes = Various.GetKeywordStartEndPosition(query, logicWord);
                    foundAnd = true;
                }
                catch (ParseException)
                {
                    foundAnd = false;
                }
            }

            // Check if there exists OR
            if (query.Contains("or") && !foundAnd)
            {
                logicWord = "or";

                try
                {
                    indexes = Various.GetKeywordStartEndPosition(query, logicWord);
                    foundOr = true;
                }
                catch (ParseException)
                {
                    foundOr = false;
                }
            }

            // If AND or OR doesn't exist, throw exception
            if (!foundAnd && !foundOr) throw new ParseException("Query doesn't contain \"and\" or \"or\"!");

            // Split by found indexes
            return new string[] { query.Substring(0, indexes[0]), logicWord, query.Substring(indexes[1], query.Length - indexes[1]) };
        }
    }
}
