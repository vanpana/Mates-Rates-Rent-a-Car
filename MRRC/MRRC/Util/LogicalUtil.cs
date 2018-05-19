using MRRC.Domain;
using MRRC.Domain.Entities.Attributes;
using MRRC.Domain.Entities.Logicals;
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
        // Static fields
        private static readonly String[] colors = new String[] { "red", "green", "blue", "grey", "black", "white", "pink" };
        private static readonly String[] fuel = String.Join(",", Enum.GetValues(typeof(Fuel)).Cast<Fuel>().ToList()).Split(',');
        private static readonly String[] vehicleClass = String.Join(",", Enum.GetValues(typeof(VehicleClass)).Cast<VehicleClass>().ToList()).Split(',');

        // Static methods
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

        public static Logical GetLogical(String query)
        {
            return GetLogicalFromParts(Split(query));
        }
        
        private static Logical GetLogicalFromParts(String[] parts)
        {
            Logical leftSide = null, rightSide = null;

            if (parts[0].Split(' ').Length == 1) leftSide = GetLogicalAttribute(parts[0]);
            else if (parts[0].Split(' ').Length != 1) leftSide = GetLogicalFromParts(Split(parts[0]));

            if (parts[2].Split(' ').Length == 1) rightSide = GetLogicalAttribute(parts[2]);
            else if (parts[2].Split(' ').Length != 1) rightSide = GetLogicalFromParts(Split(parts[2]));

            if (parts[1].Equals("and")) return new AndCompositeLogical(leftSide, rightSide);
            else if (parts[1].Equals("or")) return new OrCompositeLogical(leftSide, rightSide);

            return null;
        }

        private static Logical GetLogicalAttribute(String value)
        {
            MRRC.Domain.Entities.Attribute attribute = null;

            if (fuel.Contains(value)) attribute = new EngineAttribute(value);
            if (colors.Contains(value)) attribute = new ColorAttribute(value);
            if (vehicleClass.Contains(value)) attribute = new ClassAttribute(value);

            if (value.Equals("gps")) attribute = new GPSAttribute();
            if (value.Equals("sunroof")) attribute = new SunroofAttribute();

            return attribute != null ? new LogicalAttribute(attribute) : null;
        }
    }
}
