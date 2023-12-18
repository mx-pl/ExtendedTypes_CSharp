/*
 ---------------------------------------------------------------------------
  Copyright (c) 2023 mx-pl

  Licensed under the MIT License.

  You can view its full text at:
  https://github.com/mx-pl/ExtendedTypes_CSharp/blob/main/LICENSE.
 ---------------------------------------------------------------------------
*/

namespace TestSuite.Boolean
{
    public class BoolTogglingUnitTests
    {
        #region Toggle()

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Toggle_ChangesInstanceValue_ToItsNegation(bool initial)
        {
            var b = initial;

            b.Toggle();

            // Value of 'b' should now be the negated value of 'initial'.
            Assert.Equal(b, !initial);
        }

        #endregion

        #region Toggled()

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Toggled_DoesNotChangeInstanceValue(bool initial)
        {
            var b = initial;

            _ = b.Toggled();

            // Value of 'b' should still be the same as that of 'initial'.
            Assert.Equal(b, initial);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Toggled_Returns_NegatedInstanceValue(bool initial)
        {
            var b = initial;

            var result = b.Toggled();

            // Value of 'result' should be the negated value of 'initial'.
            Assert.Equal(result, !initial);
        }

        #endregion
    }
}
