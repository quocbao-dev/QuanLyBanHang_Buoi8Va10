using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using System.Globalization;

namespace QuanLyBanHang
{
    public static class ExtensionMethods
    {
        public static string GenerateSlug(this string phrase)
        {
            if (string.IsNullOrEmpty(phrase))
            {
                return "";
            }
            string str = RemoveAccent(phrase).ToLower();
            str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
            str = Regex.Replace(str, @"[^\s+", "").Trim();
            str = Regex.Replace(str, @"\s", "-");
            return str;
        }
        private static string RemoveAccent(string phrase)
        {
            var normalizedString = phrase.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }

            }
            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
