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

                // Pretending 'nullString' is not null here to trigger Exception.
                nullString!.Condense();
            });
        }

        #endregion


        #region Option: Default

        [Fact]
        public void Condense_ReturnsStringThatDoesNotContainSequencesOfSameChar_ByDefault()
        {
            string testString = "fOooBaAr   455.\t\t";

            var condensedString = testString.Condense();

            Assert.DoesNotMatch(@"([\s\S])\1", condensedString);
        }

        #endregion


        #region Option: OnlyWhiteSpace

        [Fact]
        public void Condense_ReturnsStringThatDoesNotContainSequencesOfSameWhiteSpace_IfOptionOnlyWhiteSpaceSet()
        {
            string testString = "fOooBaAr   455.\t\t";

            var condensedString = testString.Condense(StringCondenseOptions.OnlyWhiteSpace);

            Assert.DoesNotMatch(@"(\s)\1", condensedString);
        }

        [Fact]
        public void Condense_DoesNotChangeNonWhiteSpaceCharacters_IfOptionOnlyWhiteSpaceSet()
        {
            string testString = "fOooBaAr   455.\t\t";
            var testString_WithoutWhiteSpace =
                string.Concat(testString.Where(c => !char.IsWhiteSpace(c)));

            var condensedString = testString.Condense(StringCondenseOptions.OnlyWhiteSpace);
            var condensedString_WithoutWhiteSpace =
                string.Concat(condensedString.Where(c => !char.IsWhiteSpace(c)));

            Assert.Equal(testString_WithoutWhiteSpace, condensedString_WithoutWhiteSpace);
        }

        #endregion


        #region Option: IgnoreCase

        [Fact]
        public void Condense_ReturnsStringThatDoesNotContainSequencesOfSameCharUpperOrLowerForm_IfOptionIgnoreCaseSet()
        {
            string testString = "fOooBaAr   455.\t\t";

            var condensedString = testString.Condense(StringCondenseOptions.IgnoreCase);
            var condensedString_ToLower = condensedString.ToLower();

            Assert.DoesNotMatch(@"([\s\S])\1", condensedString_ToLower);
        }

        #endregion
    }
}
