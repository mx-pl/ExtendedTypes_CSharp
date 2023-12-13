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
    }
}