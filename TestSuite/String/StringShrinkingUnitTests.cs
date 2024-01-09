/*
 ---------------------------------------------------------------------------
  Copyright (c) 2024 mx-pl

  Licensed under the MIT License.

  You can view its full text at:
  https://github.com/mx-pl/ExtendedTypes_CSharp/blob/main/LICENSE.
 ---------------------------------------------------------------------------
*/

using System.Text;

namespace TestSuite.String
{
    public class StringShrinkingUnitTests
    {
        // -- Note --
        // While Shrink() is not supposed to change
        // the string instance itself, this is always true
        // as strings are immutable in C# and the ref keyword is
        // not allowed for string extension methods (as of 2024-01).

        [Fact]
        public void Shrink_ThrowsArgumentNullException_IfStringInstanceIsNull()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                string? nullString = null;

                // Pretending 'nullString' is not null here.
                nullString!.Shrink();
            });
        }

        #region Trimming

        [Theory]
        [MemberData(nameof(StringTestData.AllWhiteSpaceChars), MemberType = typeof(StringTestData))]
        public void Shrink_RemovesLeadingAndTrailingWhiteSpace_ByDefault(char whiteSpace)
        {
            var stringBuilder = new StringBuilder();
            var baseString = "foo";

            stringBuilder.AppendFormat("{0}{1}{2}", whiteSpace, baseString, whiteSpace);
            var testString = stringBuilder.ToString();

            // Remove whitespace characters using Shrink().
            var trimmedString = testString.Shrink();

            // The trimmed string should now equal the original string.
            Assert.Equal(baseString, trimmedString);
        }

        #endregion
    }
}
