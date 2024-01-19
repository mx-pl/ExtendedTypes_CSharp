/*
 ---------------------------------------------------------------------------
  Copyright (c) 2024 mx-pl

  Licensed under the MIT License.

  You can view its full text at:
  https://github.com/mx-pl/ExtendedTypes_CSharp/blob/main/LICENSE.
 ---------------------------------------------------------------------------
*/

namespace TestSuite.String
{
    internal static class StringTestData
    {
        public static IEnumerable<object?[]> TestStrings = new[]
        {
            new object?[] {null},
            new object[] {""},
            new object[] {" "},
            new object[] {"\n"},
            new object[] {"\t"},
            new object[] {"\t  "},
            new object[] {"fooBar"},
            new object[] {"foo bar"},
            new object[] {"\tfoo bar"}
        };
    }
}
