using System;
using System.Collections.Generic;
using System.Text;

namespace GitHubLernBotApp.Extensions
{
    // This is copied from DontMergeMeYet project by Thomas Levesque (MIT License)
    // Source: https://github.com/thomaslevesque/DontMergeMeYet/blob/8dc060429c62101626d072f53288667d4bd11c43/src/DontMergeMeYet/Extensions/ByteArrayExtensions.cs#L5
    // License: https://github.com/thomaslevesque/DontMergeMeYet/blob/master/LICENSE
    static class ByteArrayExtensions
    {
        static readonly char[] HexDigits = "0123456789abcdef".ToCharArray();

        public static string ToHexString(this byte[] bytes)
        {
            if (bytes == null)
                throw new ArgumentNullException(nameof(bytes));

            char[] digits = new char[bytes.Length * 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                var d1 = Math.DivRem(bytes[i], 16, out var d2);
                digits[2 * i] = HexDigits[d1];
                digits[2 * i + 1] = HexDigits[d2];
            }
            return new string(digits);
        }
    }
}
