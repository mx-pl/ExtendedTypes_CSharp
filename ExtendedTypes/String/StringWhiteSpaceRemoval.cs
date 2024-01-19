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
        #region SquashWhiteSpace()

        /// <summary>
        /// Replaces all sequences of whitespace characters in this <see cref="string"/> with a single space.
        /// </summary>
        /// <remarks>Optionally, an alternative <paramref name="replacement"/> can be specified.
        /// If <paramref name="replacement"/> is set to <see langword="null"/>, whitespace is removed entirely (replaced by "").</remarks>
        /// <param name="str">The string instance this method is invoked on.</param>
        /// <param name="replacement">The char whitespace sequences are replaced by.</param>
        /// <returns>This string with all sequences of whitespace characters replaced by the specified <see cref="char"/> (or removed entirely).</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static string SquashWhiteSpace(this string str, char? replacement = '\u0020')
        {
            /* --- Input Validation --- */

            if (str is null) throw new ArgumentNullException(nameof(str));

            if (str.Length == 0) return str; // Nothing to do.


            /* --- Replacing all sequences of whitespace --- */

            var replacementString = new StringBuilder();
            replacementString.Append(replacement); // If 'replacement' is null, StringBuilder remains unchanged (i.e. empty).

            return Regex.Replace(str, @"\s+", replacementString.ToString());
        }

        #endregion


        #region Shrink()

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

            /* --- Squash Whitespace --- */

            return inputSpan.ToString().SquashWhiteSpace(separator);
        }

        #endregion
    }
}