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
        /// Indicates whether the value of this string instance is null or an empty string ("").
        /// </summary>
        /// <returns>true if the string is null or an empty string (""); otherwise, false.</returns>
        public static bool IsNullOrEmpty(this string? str)
        {
            return string.IsNullOrEmpty(str);
        }

        /// <summary>
        /// Indicates whether the value of this string instance is null, empty, or consists only of 
        /// white-space characters.
        /// </summary>
        /// <returns>
        /// true, if the string is null or string.Empty, or if it consists exclusively of white-space characters.
        /// </returns>
        public static bool IsNullOrWhiteSpace(this string? str)
        {
            return string.IsNullOrWhiteSpace(str);
        }

        /// <summary>
        /// Indicates whether the value of this string instance is not null or an empty string ("").
        /// </summary>
        /// <returns>true, if the string is neither null nor empty; otherwise, false.</returns>
        public static bool IsNotNullOrEmpty(this string? str)
        {
            return !string.IsNullOrEmpty(str);
        }

        /// <summary>
        /// Indicates whether the value of this string instance is not null, empty, or only consisting of
        /// white-space characters.
        /// </summary>
        /// <returns>
        /// true, if the string is neither null, empty, nor exclusively consisting of white-space characters; otherwise, false.
        /// </returns>
        public static bool IsNotNullOrWhiteSpace(this string? str)
        {
            return !string.IsNullOrWhiteSpace(str);
        }
    }
}
