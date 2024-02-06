/*
 ---------------------------------------------------------------------------
  Copyright (c) 2024 mx-pl

  Licensed under the MIT License.

  You can view its full text at:
  https://github.com/mx-pl/ExtendedTypes_CSharp/blob/main/LICENSE.
 ---------------------------------------------------------------------------
*/

/*
 * Implementing string's pre-existing IsNullOrEmpty() and IsNullOrWhiteSpace() methods
 * as extension methods for better readability and conciseness in code.
 * Additionally, adding their negated versions, ie IsNotNullOrEmpty() and IsNotNullOrWhiteSpace().
 * 
 * Note: To avoid confusion, the method descriptions intentionally mirror the original ones and each other.
 */

namespace ExtendedTypes.String
{
    /// <summary>
    /// A class encapsulating extension methods for concise and easily readable string-null-or-empty-checks.
    /// </summary>
    public static class StringEmptyChecks
    {
        /// <summary>
        /// Indicates whether the value of this <see cref="string"/> instance is <see langword="null"/> or an empty string ("").
        /// </summary>
        /// <returns><see langword="true"/> if the string is <see langword="null"/> or an empty string (""); otherwise, <see langword="false"/>.</returns>
        public static bool IsNullOrEmpty(this string? str)
        {
            return string.IsNullOrEmpty(str);
        }

        /// <summary>
        /// Indicates whether the value of this <see cref="string"/> instance is <see langword="null"/>, empty, or consists only of 
        /// whitespace characters.
        /// </summary>
        /// <returns>
        /// <see langword="true"/>, if the string is <see langword="null"/> or string.Empty, or if it consists exclusively of whitespace characters.
        /// </returns>
        public static bool IsNullOrWhiteSpace(this string? str)
        {
            return string.IsNullOrWhiteSpace(str);
        }

        /// <summary>
        /// Indicates whether the value of this <see cref="string"/> instance is not <see langword="null"/> or an empty string ("").
        /// </summary>
        /// <returns><see langword="true"/>, if the string is neither <see langword="null"/> nor empty; otherwise, <see langword="false"/>.</returns>
        public static bool IsNotNullOrEmpty(this string? str)
        {
            return !string.IsNullOrEmpty(str);
        }

        /// <summary>
        /// Indicates whether the value of this <see cref="string"/> instance is not <see langword="null"/>, empty, or only consisting of
        /// whitespace characters.
        /// </summary>
        /// <returns>
        /// <see langword="true"/>, if the string is neither <see langword="null"/>, empty, nor exclusively consisting of whitespace characters; otherwise, <see langword="false"/>.
        /// </returns>
        public static bool IsNotNullOrWhiteSpace(this string? str)
        {
            return !string.IsNullOrWhiteSpace(str);
        }
    }
}
