/*
 ---------------------------------------------------------------------------
  Copyright (c) 2024 mx-pl

  Licensed under the MIT License.

  You can view its full text at:
  https://github.com/mx-pl/ExtendedTypes_CSharp/blob/main/LICENSE.
 ---------------------------------------------------------------------------
*/

using System.Text;
using TestSuite.TestData;

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

                // Pretending 'nullString' is not null here to trigger Exception.
                nullString!.Shrink();
            });
        }

        #region Trimming

        [Theory]
        [MemberData(nameof(StringTestData.TestStrings), MemberType = typeof(StringTestData))]
        public void Shrink_RemovesLeadingAndTrailingWhiteSpace_ByDefault(string testString)
        {
            var shrunkString = testString.Shrink();

            // No whitespace at start.
            Assert.DoesNotMatch(@"^[\s]+", shrunkString);
            // No whitespace at end.
            Assert.DoesNotMatch(@"[\s]+$", shrunkString);
        }

        [Theory]
        [MemberData(nameof(StringTestData.TestStrings), MemberType = typeof(StringTestData))]
        public void Shrink_RemovesLeadingAndTrailingWhiteSpace_WithReplacementSpecified(string testString)
        {
            var shrunkString = testString.Shrink('£');

            // No whitespace at start.
            Assert.DoesNotMatch(@"^[\s]+", shrunkString);
            // No whitespace at end.
            Assert.DoesNotMatch(@"[\s]+$", shrunkString);
        }

        [Theory]
        [MemberData(nameof(StringTestData.TestStrings), MemberType = typeof(StringTestData))]
        public void Shrink_DoesNotRemoveLeadingAndTrailingWhiteSpace_WhenTrimSetToFalse(string testString)
        {
            var shrunkString = testString.Shrink(' ', false);

            // Nevertheless, Shrink() does still replace all sequences of whitespace chars with a single space.
            // Therefore, the testString has to be adapted, too.
            var testString_WhiteSpaceSquashed = testString.SquashWhiteSpace();

            Assert.Equal(testString_WhiteSpaceSquashed, shrunkString);
        }

        #endregion

        #region Whitespace Removal / Replacing

        [Theory]
        [MemberData(nameof(StringTestData.TestStrings), MemberType = typeof(StringTestData))]
        public void Shrink_ReplacesAllWhiteSpaceWithASingleSpace_ByDefault(string testString)
        {
            var squashedString = testString.Shrink();

            // Only non-whitespace characters and SPACE left.
            Assert.Matches(@"^[\S ]*$", squashedString);
            // Not more than a single space at once.
            Assert.DoesNotMatch(@"\s{2,}", squashedString);
        }

        [Theory]
        [MemberData(nameof(StringTestData.TestStrings), MemberType = typeof(StringTestData))]
        public void Shrink_ReplacesAllWhiteSpace_WithSingleSpecifiedChar(string testString)
        {
            var squashedString = testString.Shrink('£', false);

            // No whitespace left.
            Assert.DoesNotMatch(@"\s", squashedString);
            // Not more than a single '£' at once.
            Assert.DoesNotMatch(@"[£]{2,}", squashedString);
        }

        #endregion

        #region Integrity of Non-Whitespace Charaters

        [Theory]
        [MemberData(nameof(StringTestData.TestStrings), MemberType = typeof(StringTestData))]
        public void Shrink_DoesNotChangeNonWhiteSpaceCharacters(string testString)
        {
            var testString_WithoutAnyWhiteSpace =
                string.Concat(testString.Where(c => !char.IsWhiteSpace(c)));

            // --- Default ---
            var shrunkString_Default = testString.Shrink();
            var shrunkString_Default_WithoutSpace =
                string.Concat(shrunkString_Default.Where(c => c != '\u0020'));

            Assert.Equal(testString_WithoutAnyWhiteSpace, shrunkString_Default_WithoutSpace);

            // --- Replacement char specified ---
            var shrunkString_CharSpecified = testString.Shrink('£');
            var shrunkString_SpecifiedCharRemoved =
                string.Concat(shrunkString_CharSpecified.Where(c => c != '£'));

            Assert.Equal(testString_WithoutAnyWhiteSpace, shrunkString_SpecifiedCharRemoved);
        }

        #endregion
    }
}
