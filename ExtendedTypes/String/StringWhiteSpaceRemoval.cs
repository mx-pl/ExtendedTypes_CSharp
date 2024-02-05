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
        /// <returns>This string with all sequences of whitespace characters replaced by a space, the specified <see cref="char"/> or removed entirely.</returns>
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

        /// <summary>
        /// Removes all whitespace from the start and end of the current <see cref="string"/>. Additionally,
        /// all remaining occurrances of whitespace are replaced with a single space.
        /// </summary>
        /// <param name="str">The string instance this method is invoked on.</param>
        /// <returns>
        /// A <see cref="string"/> with no leading or trailing whitespace, whose sequences of non-whitespace characters
        /// are kept apart by single space chars.
        /// </returns>
        public static string Shrink(this string str) => Shrink(str, ' ', true);

        /// <summary>
        /// Removes all whitespace from the start and end of the current <see cref="string"/>. Additionally,
        /// all remaining occurrances of whitespace are replaced with the <paramref name="separator"/> <see cref="char"/>.
        /// </summary>
        /// <param name="str">The string instance this method is invoked on.</param>
        /// <param name="separator">The <see cref="char"/> used to replace the whitespace.</param>
        /// <returns>
        /// A <see cref="string"/> with no leading or trailing whitespace, whose sequences of non-whitespace characters
        /// are kept apart by the specified <paramref name="separator"/>.
        /// </returns>
        public static string Shrink(this string str, char separator) => Shrink(str, separator, true);

        /// <summary>
        /// Replaces all sequences of whitespace in the current <see cref="string"/> with the <paramref name="separator"/> <see cref="char"/>.
        /// Optionally, the string is trimmed beforehand.
        /// </summary>
        /// <param name="str">The string instance this method is invoked on.</param>
        /// <param name="separator">The <see cref="char"/> used to replace the whitespace.</param>
        /// <param name="trim">
        /// Indicating whether leading and trailing whitespace should be removed from the string.
        /// <see langword="true"/> if so; <see langword="false"/> if not.
        /// </param>
        /// <returns>
        /// A <see cref="string"/> where all sequences of non-whitespace characters
        /// are kept apart by the specified <paramref name="separator"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static string Shrink(this string str, char separator, bool trim)
        {
            if (str is null) throw new ArgumentNullException(nameof(str));
            if (str.Length == 0) return str; // Nothing to do.

            if (trim)
            {
                var trimmedStr = str.Trim();

                // Since Trim() has removed all *leading* and *trailing* whitespace characters,
                // at least three chars have to remain in the string for further whitespace
                // characters to be present (i.e. non-whitespace | whitespace | non-whitespace ).
                if (trimmedStr.Length <= 2) return trimmedStr;

                return trimmedStr.SquashWhiteSpace(separator);
            }
            else
            {
                return str.SquashWhiteSpace(separator);
            }
        }

        #endregion
    }
}