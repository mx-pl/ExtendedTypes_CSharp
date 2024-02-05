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
    public class StringNullOrEmptyUnitTests
    {
        #region IsNullOrEmpty()

        [Fact]
        public void IsNullOrEmpty_ResultMimicsPreExistingMemberMethod_WhenNull()
        {
            string? nullString = null;

            var resultPreExisting = string.IsNullOrEmpty(nullString);
            var resultExtension = nullString.IsNullOrEmpty();

            // The newly created extension methods are supposed to faithfully mirror
            // string's pre-existing methods of the same name.

            Assert.Equal(resultPreExisting, resultExtension);
        }

        [Theory]
        [MemberData(nameof(StringTestData.TestStrings), MemberType = typeof(StringTestData))]
        public void IsNullOrEmpty_ResultMimicsPreExistingMemberMethod(string initial)
        {
            var resultPreExisting = string.IsNullOrEmpty(initial);
            var resultExtension = initial.IsNullOrEmpty();

            // The newly created extension methods are supposed to faithfully mirror
            // string's pre-existing methods of the same name.

            Assert.Equal(resultPreExisting, resultExtension);
        }

        #endregion


        #region IsNotNullOrEmpty()

        [Fact]
        public void IsNotNullOrEmpty_ResultMimicsPreExistingMemberMethod_WhenNull()
        {
            string? nullString = null;

            var resultPreExisting = string.IsNullOrEmpty(nullString);

            // Important: The method tested here is answering the opposite question (*not* null or empty).
            var resultExtension = nullString.IsNotNullOrEmpty();

            // Therefore, if the newly created extension methods is faithfully matching the behaviour of
            // string's pre-existing method, the results should always be the opposite of each other.
            Assert.NotEqual(resultPreExisting, resultExtension);
        }

        [Theory]
        [MemberData(nameof(StringTestData.TestStrings), MemberType = typeof(StringTestData))]
        public void IsNotNullOrEmpty_ResultMimicsPreExistingMemberMethod_ButNegated(string initial)
        {
            var resultPreExisting = string.IsNullOrEmpty(initial);

            // Important: The method tested here is answering the opposite question (*not* null or empty).
            var resultExtension = initial.IsNotNullOrEmpty();

            // Therefore, if the newly created extension methods is faithfully matching the behaviour of
            // string's pre-existing method, the results should always be the opposite of each other.
            Assert.NotEqual(resultPreExisting, resultExtension);
        }

        #endregion
    }
}
