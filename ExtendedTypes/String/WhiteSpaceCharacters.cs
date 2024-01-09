/*
 ---------------------------------------------------------------------------
  Copyright (c) 2024 mx-pl

  Licensed under the MIT License.

  You can view its full text at:
  https://github.com/mx-pl/ExtendedTypes_CSharp/blob/main/LICENSE.
 ---------------------------------------------------------------------------
*/

namespace ExtendedTypes.String
{
    /// <summary>
    /// Collection of all chars considered white-space characters.
    /// </summary>
    /// <remarks>Taken from: https://learn.microsoft.com/en-us/dotnet/api/system.char.iswhitespace?view=net-6.0 (as of 2024-01-09).</remarks>
    public static class WhiteSpaceCharacters
    {
        // Members of the UnicodeCategory.SpaceSeparator category.
        private static readonly char[] spaceSeparators = {
            '\u0020', // SPACE
            '\u00A0', // NO-BREAK SPACE
            '\u1680', // OGHAM SPACE MARK
            '\u2000', // EN QUAD
            '\u2001', // EM QUAD
            '\u2002', // EN SPACE
            '\u2003', // EM SPACE
            '\u2004', // THREE-PER-EM SPACE
            '\u2005', // FOUR-PER-EM SPACE
            '\u2006', // SIX-PER-EM SPACE
            '\u2007', // FIGURE SPACE
            '\u2008', // PUNCTUATION SPACE
            '\u2009', // THIN SPACE
            '\u200A', // HAIR SPACE
            '\u202F', // NARROW NO-BREAK SPACE
            '\u205F', // MEDIUM MATHEMATICAL SPACE
            '\u3000' // IDEOGRAPHIC SPACE
        };

        // Members of the UnicodeCategory.LineSeparator category.
        private static readonly char[] lineSeparators = {
            '\u2028' // LINE SEPARATOR
        };

        // Members of the UnicodeCategory.ParagraphSeparator category.
        private static readonly char[] paragraphSeparators = {
            '\u2029' // PARAGRAPH SEPARATOR
        };

        // Uncategorized.
        private static readonly char[] uncategorizedChars = {
            '\u0009', // CHARACTER TABULATION
            '\u000A', // LINE FEED
            '\u000B', // LINE TABULATION
            '\u000C', // FORM FEED
            '\u000D', // CARRIAGE RETURN
            '\u0085' // NEXT LINE
        };

        public static char[] SpaceSeparators => spaceSeparators;
        public static char[] LineSeparators => lineSeparators;
        public static char[] ParagraphSeparators => paragraphSeparators;
        public static char[] UncategorizedChars => uncategorizedChars;
        public static char[] All {
            get {
                return spaceSeparators
                    .Concat(lineSeparators)
                    .Concat(paragraphSeparators)
                    .Concat(uncategorizedChars)
                    .ToArray();
            }
        }
    }
}
