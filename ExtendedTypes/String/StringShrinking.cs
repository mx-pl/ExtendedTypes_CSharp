/*
 ---------------------------------------------------------------------------
  Copyright (c) 2024 mx-pl

  Licensed under the MIT License.

  You can view its full text at:
  https://github.com/mx-pl/ExtendedTypes_CSharp/blob/main/LICENSE.
 ---------------------------------------------------------------------------
*/

using System.Text.RegularExpressions;

namespace ExtendedTypes.String
{
    /// <summary>
    /// A class encapsulating extension methods for easy removal of white-space characters from strings.
    /// </summary>
    public static class StringShrinking
    {
       /// <summary>
       /// 
       /// </summary>
       /// <param name="str"></param>
       /// <param name="separator"></param>
       /// <param name="doTrim"></param>
       /// <returns></returns>
       /// <exception cref="ArgumentNullException"></exception>
        public static string Shrink(
            this string str,
            char? separator = ' ',
            bool doTrim = true)
        {
            if (str is null) throw new ArgumentNullException(nameof(str));

            var trimmedString = doTrim ? str.Trim() : str;

            if (separator is not null)
            {
                // Replace all white-space characters with the specified separator.
                return Regex.Replace(trimmedString, @"\s+", separator.Value.ToString());
            }
            else
            {
                // No separator has been specified:
                // Keep the different kinds of white-space characters,
                // but condence consecutive ones (of the same kind) to only one.

                // TODO: Implement for different kinds of white-space characters!

                return trimmedString; // Preliminary !!
            }
        }
    }
}
