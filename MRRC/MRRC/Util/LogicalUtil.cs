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
        private static readonly String[] transmission = String.Join(",", Enum.GetValues(typeof(Transmission)).Cast<Transmission>().ToList()).Split(',');

        // Static methods
        /*
         * Splits a string (the query) by AND and OR keywords. If they aren't found, it throws an exception.
         * */
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
                    // If the method throws exception, AND was not found
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
                    // If the method throws exception, OR was not found
                    foundOr = false;
                }
            }

            // If AND or OR doesn't exist, throw exception
            if (!foundAnd && !foundOr) throw new ParseException("Query doesn't contain \"and\" or \"or\"!");

            // Split by found indexes
            return new string[] { query.Substring(0, indexes[0]), logicWord, query.Substring(indexes[1], query.Length - indexes[1]) };
        }

        /*
         * Builds a logical expression for a provided query.
         * */
        public static Logical GetLogical(String query)
        {
            return GetLogicalFromParts(Split(query));
        }
        
        /*
         * Gets a composite logical (AndComposite or OrComposite based on the keyword on parts[1]).
         * */
        private static Logical GetLogicalFromParts(String[] parts)
        {
            // Get the left side and right side
            Logical leftSide = GetSideLogical(parts[0]), rightSide = GetSideLogical(parts[2]);

            // If the keyword is AND, build an AndCompositeLogical
            if (parts[1].Equals("and")) return new AndCompositeLogical(leftSide, rightSide);
            // If the keyword is OR, build an AndCompositeLogical
            else if (parts[1].Equals("or")) return new OrCompositeLogical(leftSide, rightSide);

            // If no keyword is found, throw an exception
            throw new ParseException("Invalid query format!");
        }

        /*
         * If a side is composite, break in pieces and try again.
         * */
        private static Logical GetSideLogical(String part)
        {
            // If side is a single attribute, get the attribute
            if (part.Split(' ').Length == 1) return GetLogicalAttribute(part);
            // If side is a composite attribute, break it into pieces and try to get the attributes
            else if (part.Split(' ').Length != 1) return GetLogicalFromParts(Split(part));

            // If nothing matches, throw an exception
            throw new ParseException("Invalid query format!");
        }

        /*
         * Build an attribute based on a value. Search in the static fields for the value.
         * */
        public static Logical GetLogicalAttribute(String value)
        {
            Domain.Entities.Attribute attribute = null;

            if (fuel.Contains(value)) attribute = new EngineAttribute(value);
            if (colors.Contains(value)) attribute = new ColorAttribute(value);
            if (vehicleClass.Contains(value)) attribute = new ClassAttribute(value);
            if (transmission.Contains(value)) attribute = new TransmissionAttribute(value);

            if (value.Contains("seater")) attribute = new SeatsAttribute(value);
            if (value.Equals("gps")) attribute = new GPSAttribute();
            if (value.Equals("sunroof")) attribute = new SunroofAttribute();

            if (attribute == null) throw new ParseException($"Attribute {value} not found!");

            return new LogicalAttribute(attribute);
        }
    }
}
