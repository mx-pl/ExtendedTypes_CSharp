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
    public class StringCondensingUnitTests
    {
        #region In Any Case

        // -- Note --
        // While Condense() is not supposed to change
        // the string instance itself, this is always true
        // as strings are immutable in C# and the ref keyword is
        // not allowed for string extension methods (as of 2024-01).

        [Fact]
        public void Condense_ThrowsArgumentNullException_IfStringInstanceIsNull_()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                string? nullString = null;

                // Pretending 'nullString' is not null here.
                nullString!.Condense();
            });
        }

        #endregion


        #region Option: Default

        [Fact]
        public void Condense_ReturnsStringThatDoesNotContainConsecutiveOccurrancesOfSameChar_ByDefault()
        {
            string testString = "fooBar   455.\t\t";

            var condensedString = testString.Condense();

            Assert.DoesNotMatch(@"(\s\S)\1", condensedString);
        }

        #endregion


        #region Option: OnlyWhiteSpace

        [Fact]
        public void Condense_ReturnsStringThatDoesNotContainConsecutiveOccurrancesOfSameWhiteSpace_IfOptionOnlyWhiteSpace()
        {
            string testString = "fooBar   455.\t\t";

            var condensedString = testString.Condense(StringCondenseOptions.OnlyWhiteSpace);

            Assert.DoesNotMatch(@"(\sS)\1", condensedString);
        }

        [Fact]
        public void Condense_DoesNotChangeNonWhiteSpaceCharacters_IfOptionOnlyWhiteSpace()
        {
            string testString = "fooBar   455.\t\t";
            var testStringWithoutWhiteSpace =
                string.Concat(testString.Where(c => !char.IsWhiteSpace(c)));

            var condensedString = testString.Condense(StringCondenseOptions.OnlyWhiteSpace);
            var condensedStringWithoutWhiteSpace =
                string.Concat(condensedString.Where(c => !char.IsWhiteSpace(c)));

            Assert.Equal(testStringWithoutWhiteSpace, condensedStringWithoutWhiteSpace);
        }


        #endregion
    }
}
