/*
 ---------------------------------------------------------------------------
  Copyright (c) 2024 mx-pl

  Licensed under the MIT License.

  You can view its full text at:
  https://github.com/mx-pl/ExtendedTypes_CSharp/blob/main/LICENSE.
 ---------------------------------------------------------------------------
*/

using System.Text;

namespace ExtendedTypes.String
{
    /// <summary>
    /// Options specifing which kinds of <see cref="char"/> are considered when condensing.
    /// </summary>
    public enum StringCondenseOptions
    {
        /// <summary>
        /// All kinds of characters are condensed.
        /// </summary>
        Default,

        /// <summary>
        /// Only whitespace characters are condensed.
        /// </summary>
        OnlyWhiteSpace,

        /// <summary>
        /// The upper- and lowercase form of a <see cref="char"/> are treated as identical.
        /// Nevertheless, the leading character of each sequence retains its case in the result.
        /// </summary>
        IgnoreCase
    }

    /// <summary>
    /// A class encapsulating extension methods for easy removal of duplicate characters from strings.
    /// </summary>
    public static class StringCondensing
    {
        /// <summary>
        /// Replaces all sequences of identical <see cref="char"/>s within this <see cref="string"/> with a single instance of that character.
        /// </summary>
        /// <remarks>Note: Different types of whitespace (space, tab, etc.) are represented by different chars and,
        /// therefore, treated as distinct.</remarks>
        /// <param name="str">The string instance this method is invoked on.</param>
        /// <param name="options">Options specifing which chars shall be considered for condensing.</param>
        /// <returns>This <see cref="string"/> with all sequences of identical chars replaced with just one each.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static string Condense(this string str, StringCondenseOptions options = StringCondenseOptions.Default)
        {
            /* --- Input Validation --- */
            if (str is null) throw new ArgumentNullException(nameof(str));

            if (str.Length == 0) return str; // Nothing to do.


            /* --- Condense Sequences of Identical Chars --- */

            // We condense sequences of the same character to just one of its kind.

            // In other words, when we build our result string, we will only include those chars
            // that differ from their preceding one.

            // In any case:
            // ¬ The first char in the string will be included;
            // ¬ condensedString.Length <= str.Length
            //      (because we are (potentially) going to remove characters).
            var condensedString = new StringBuilder(str.Length);
            condensedString.Append(str[0]);

            char previous =
                options == StringCondenseOptions.IgnoreCase
                ? char.ToLower(str[0])
                : str[0];

            for (int i = 1; i < str.Length; i++)
            {
                // If OnlyWhiteSpace option is set, non-whitespace characters are not condensed.
                if (options == StringCondenseOptions.OnlyWhiteSpace && !char.IsWhiteSpace(str[i]))
                {
                    condensedString.Append(str[i]);
                    previous = str[i];
                    continue;
                }

                // If IgnoreCase option is set, all chars are converted to lower-case before comparison.
                if (options == StringCondenseOptions.IgnoreCase)
                {
                    if (char.ToLower(str[i]) != previous)
                    {
                        condensedString.Append(str[i]); // Retain case of first char in sequence.
                        previous = char.ToLower(str[i]);
                    }

                    continue;
                }

                // Default
                if (str[i] != previous)
                {
                    condensedString.Append(str[i]);
                    previous = str[i];
                }
            }

            return condensedString.ToString();
        }
    }
}
