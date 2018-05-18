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
    }
}
