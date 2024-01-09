/*
 ---------------------------------------------------------------------------
  Copyright (c) 2024 mx-pl

  Licensed under the MIT License.

  You can view its full text at:
  https://github.com/mx-pl/ExtendedTypes_CSharp/blob/main/LICENSE.
 ---------------------------------------------------------------------------
*/

using System.Text;
using System.Text.RegularExpressions;

namespace ExtendedTypes.String
{
    /// <summary>
    /// A class encapsulating extension methods for easy removal of whitespace characters from strings.
    /// </summary>
    public static class StringWhiteSpaceRemoval
    {
        #region Public Extension Methods

        public static string CondenseWhiteSpace(this string str, string? replacement = " ")
        {
            /* --- Input Validation --- */
            if (str is null) throw new ArgumentNullException(nameof(str));

            if (str.Length == 0) return str;

            /* --- Replacing all sequences of whitespace --- */
            if (replacement is not null)
            {
                return Regex.Replace(
                    str,
                    @"\s+",
                    replacement.Length > 1
                    ? replacement[0].ToString()
                    : replacement);
            }
            else
            {
                // We do not replace the whitespace characters but condense sequences of the same kind
                // of whitespace character to just one of its kind.

                // I.e. when building our result string we will only include non-whitespace characters
                // and whitespace characters which are different from their preceding one.

                // Note that in any case:
                //
                //  condensedString.Length <= str.Length
                //      (because we are going to remove characters)

                var condensedString = new StringBuilder(str[0], str.Length);

                char previous = str[0];

                for (int i = 1; i < str.Length; i++)
                {
                    if (!char.IsWhiteSpace(str[i]) || str[i] != previous)
                    {
                        condensedString.Append(str[i]);
                        previous = str[i];
                    }
                }

                return condensedString.ToString();
            }
        }


        public static string Shrink(this string str) => Shrink(str, ' ', true);


        public static string Shrink(this string str, char separator) => Shrink(str, separator, true);


        public static string Shrink(this string str, char separator, bool trim)
        {
            /* --- Input Validation --- */

            if (str is null) throw new ArgumentNullException(nameof(str));
            if (str.Length == 0) return str;

            /* --- Trimming --- */

            var inputSpan = str.AsSpan();

            if (trim)
            {
                var trimmedSpan = inputSpan.Trim();

                // Since Trim() has removed all *leading* and *trailing* whitespace characters,
                // at least three chars have to remain in the string for further whitespace
                // characters to be present (i.e. non-whitespace | whitespace | non-whitespace ).
                if (trimmedSpan.Length <= 2)
                    return trimmedSpan.ToString();

                inputSpan = trimmedSpan;
            }

            /* --- Condense Whitespace --- */

            return inputSpan.ToString().CondenseWhiteSpace(separator.ToString());
        }

        #endregion
    }
}