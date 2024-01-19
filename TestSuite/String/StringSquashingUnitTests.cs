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
    public class StringSquashingUnitTests
    {
        // -- Note --
        // While SquashWhiteSpace() is not supposed to change
        // the string instance itself, this is always true
        // as strings are immutable in C# and the ref keyword is
        // not allowed for string extension methods (as of 2024-01).

        [Fact]
        public void SquashWhiteSpace_ThrowsArgumentNullException_IfStringInstanceIsNull_()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                string? nullString = null;

                // Pretending 'nullString' is not null here.
                nullString!.SquashWhiteSpace();
            });
        }

        [Theory]
        [MemberData(nameof(StringTestData.TestStrings), MemberType = typeof(StringTestData))]
        public void SquashWhiteSpace_ReplacesAllWhiteSpaceWithSingleSpace_ByDefault(string testString)
        {
            var squashedString = testString.SquashWhiteSpace();

            // Only non-whitespace characters and SPACE left.
            Assert.Matches(@"^[\S ]*$", squashedString);
            // Not more than a single space at once.
            Assert.DoesNotMatch(@"\s{2,}", squashedString);
        }

        [Theory]
        [MemberData(nameof(StringTestData.TestStrings), MemberType = typeof(StringTestData))]
        public void SquashWhiteSpace_RemovesAllWhiteSpace_IfReplacementIsNull(string testString)
        {
            var squashedString = testString.SquashWhiteSpace(null);

            Assert.DoesNotMatch(@"\s", squashedString);
        }

        [Theory]
        [MemberData(nameof(StringTestData.TestStrings), MemberType = typeof(StringTestData))]
        public void SquashWhiteSpace_ReplacesAllWhiteSpace_WithSingleSpecifiedChar(string testString)
        {
            var squashedString = testString.SquashWhiteSpace('£');

            // No whitespace left.
            Assert.DoesNotMatch(@"\s", squashedString);
            // Not more than a single '£' at once.
            Assert.DoesNotMatch(@"[£]{2,}", squashedString);
        }

        [Theory]
        [MemberData(nameof(StringTestData.TestStrings), MemberType = typeof(StringTestData))]
        public void SquashWhiteSpace_DoesNotChangeNonWhiteSpaceCharacters(string testString)
        {
            var testStringWithoutWhiteSpace =
                string.Concat(testString.Where(c => !char.IsWhiteSpace(c)));

            // --- Default ---
            var squashedStringDefault = testString.SquashWhiteSpace();
            var squashedStringDefaultWithoutSpace =
                string.Concat(squashedStringDefault.Where(c => c != '\u0020'));

            Assert.Equal(testStringWithoutWhiteSpace, squashedStringDefaultWithoutSpace);


            // --- Replacement char null ---
            var squashedStringNull = testString.SquashWhiteSpace(null);

            Assert.Equal(testStringWithoutWhiteSpace, squashedStringNull);


            // --- Replacement char specified ---
            var squashedStringCharSpecified = testString.SquashWhiteSpace('£');
            var squashedStringSpecifiedCharRemoved =
                string.Concat(squashedStringCharSpecified.Where(c => c != '£'));

            Assert.Equal(testStringWithoutWhiteSpace, squashedStringSpecifiedCharRemoved);
        }
    }
}
