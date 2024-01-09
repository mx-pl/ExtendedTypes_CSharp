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
    public class StringEmptyChecksUnitTests
    {
        #region IsNullOrEmpty()

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("\n")]
        [InlineData("\t")]
        [InlineData("\t  ")]
        [InlineData("fooBar")]
        [InlineData("foo bar")]
        [InlineData("\tfoo bar")]
        public void IsNullOrEmpty_Result_MimicsPreExistingStringMethod(string initial)
        {
            var resPreExisting = string.IsNullOrEmpty(initial);
            var resExtension = initial.IsNullOrEmpty();

            // The newly created extension methods are supposed to faithfully mirror
            // string's pre-existing methods of the same name.

            Assert.Equal(resPreExisting, resExtension);
        }

        #endregion

        #region IsNullOrWhiteSpace()

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("\n")]
        [InlineData("\t")]
        [InlineData("\t  ")]
        [InlineData("fooBar")]
        [InlineData("foo bar")]
        [InlineData("\tfoo bar")]
        public void IsNullOrWhiteSpace_Result_MimicsPreExistingStringMethod(string initial)
        {
            var resPreExisting = string.IsNullOrWhiteSpace(initial);
            var resExtension = initial.IsNullOrWhiteSpace();

            // The newly created extension methods are supposed to faithfully mirror
            // string's pre-existing methods of the same name.

            Assert.Equal(resPreExisting, resExtension);
        }

        #endregion

        #region IsNotNullOrEmpty()

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("\n")]
        [InlineData("\t")]
        [InlineData("\t  ")]
        [InlineData("fooBar")]
        [InlineData("foo bar")]
        [InlineData("\tfoo bar")]
        public void IsNotNullOrEmpty_Result_MimicsPreExistingStringMethod(string initial)
        {
            var resPreExisting = string.IsNullOrEmpty(initial);

            // Important: The method tested here is answering the opposite question (*not* null or empty).
            var resExtension = initial.IsNotNullOrEmpty();

            // Therefore, if the newly created extension methods is faithfully matching the behaviour of
            // string's pre-existing method, the results should always be the opposite of each other.
            Assert.NotEqual(resPreExisting, resExtension);
        }

        #endregion

        #region IsNotNullOrWhiteSpace()

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("\n")]
        [InlineData("\t")]
        [InlineData("\t  ")]
        [InlineData("fooBar")]
        [InlineData("foo bar")]
        [InlineData("\tfoo bar")]
        public void IsNotNullOrWhiteSpace_Result_MimicsPreExistingStringMethod(string initial)
        {
            var resPreExisting = string.IsNullOrWhiteSpace(initial);

            // Important: The method tested here is answering the opposite question (*not* null or empty).
            var resExtension = initial.IsNotNullOrWhiteSpace();

            // Therefore, if the newly created extension methods is faithfully matching the behaviour of
            // string's pre-existing method, the results should always be the opposite of each other.
            Assert.NotEqual(resPreExisting, resExtension);
        }

        #endregion
    }
}
