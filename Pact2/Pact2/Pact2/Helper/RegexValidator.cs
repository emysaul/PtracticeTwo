using System;
using System.Text.RegularExpressions;

namespace Pact2.Helper
{
    public class RegexValidator
    {
        public static bool ValidEmail(string email)
        {
            return !string.IsNullOrEmpty(email) &&
                Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                RegexOptions.IgnoreCase);

        }
    }
}