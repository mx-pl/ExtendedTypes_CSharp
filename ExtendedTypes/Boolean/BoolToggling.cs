/*
 ---------------------------------------------------------------------------
  Copyright (c) 2023 mx-pl

  Licensed under the MIT License.

  You can view its full text at:
  https://github.com/mx-pl/ExtendedTypes_CSharp/blob/main/LICENSE.
 ---------------------------------------------------------------------------
*/

namespace ExtendedTypes.Boolean
{
    /// <summary>
    /// A class encapsulating extension methods for straightforward and easily readable boolean negation.
    /// </summary>
    public static class BoolToggling
    {
        /// <summary>
        /// Sets this instance to its negated value.
        /// </summary>
        public static void Toggle(this ref bool b)
        {
            b = !b;
        }

        /// <summary>
        /// Returns the negated value of this instance without changing the instance itself.
        /// </summary>
        /// <returns>The negated value of this instance.</returns>
        public static bool Toggled(this bool b)
        {
            return !b;
        }

        /// <summary>
        /// Returns the negated value of this instance without changing the instance itself.
        /// </summary>
        /// <remarks>An alias for Toggled—functionality is the same.</remarks>
        /// <returns>The negated value of this instance.</returns>
        public static bool Not(this bool b) => Toggled(b);
    }
}