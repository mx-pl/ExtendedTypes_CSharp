/*
 ---------------------------------------------------------------------------
  Copyright (c) 2024 mx-pl

  Licensed under the MIT License.

  You can view its full text at:
  https://github.com/mx-pl/ExtendedTypes_CSharp/blob/main/LICENSE.
 ---------------------------------------------------------------------------
*/

using TestSuite.TestData;

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

                // Pretending 'nullString' is not null here to trigger Exception.
                nullString!.SquashWhiteSpace();
            });
        }

        #region Whitespace Removal / Replaceing

        [Theory]
        [MemberData(nameof(StringTestData.TestStrings), MemberType = typeof(StringTestData))]
        public void SquashWhiteSpace_ReplacesAllWhiteSpaceWithASingleSpace_ByDefault(string testString)
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

            // No whitespace left.
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

        #endregion

        #region Integrity of Non-Whitespace Charaters

        [Theory]
        [MemberData(nameof(StringTestData.TestStrings), MemberType = typeof(StringTestData))]
        public void SquashWhiteSpace_DoesNotChangeNonWhiteSpaceCharacters(string testString)
        {
            var testString_WithoutAnyWhiteSpace =
                string.Concat(testString.Where(c => !char.IsWhiteSpace(c)));

            // --- Default ---
            var squashedString_Default = testString.SquashWhiteSpace();
            var squashedString_Default_WithoutSpace =
                string.Concat(squashedString_Default.Where(c => c != '\u0020'));

            Assert.Equal(testString_WithoutAnyWhiteSpace, squashedString_Default_WithoutSpace);


            // --- Replacement char null ---
            var squashedString_ReplacementNull = testString.SquashWhiteSpace(null);

            Assert.Equal(testString_WithoutAnyWhiteSpace, squashedString_ReplacementNull);


            // --- Replacement char specified ---
            var squashedString_CharSpecified = testString.SquashWhiteSpace('£');
            var squashedString_SpecifiedCharRemoved =
                string.Concat(squashedString_CharSpecified.Where(c => c != '£'));

            Assert.Equal(testString_WithoutAnyWhiteSpace, squashedString_SpecifiedCharRemoved);
        }

        #endregion
    }
}
