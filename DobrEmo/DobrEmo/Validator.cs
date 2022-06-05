using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DobrEmo
{
    class Validator
    {
        static Regex ValidEmailRegex = CreateValidEmailRegex();

        private static Regex CreateValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }

        internal static bool EmailIsValid(string emailAddress)
        {
            bool isValid = ValidEmailRegex.IsMatch(emailAddress);

            return isValid;
        }

        internal static string ValidatePassword(string password)
        {
            var input = password;
            string ErrorMessage = "";

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Password should not be empty");
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{6,32}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input))
            {
                ErrorMessage = "Грешка! Паролата трябва да съдържа поне една малка буква!";
                return ErrorMessage;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                ErrorMessage = "Грешка! Паролата трябва да съдържа поне една главна буква!";
                return ErrorMessage;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                ErrorMessage = "Грешка! Паролата трябва да бъде между 6 и 32 символа!";
                return ErrorMessage;
            }
            else if (!hasNumber.IsMatch(input))
            {
                ErrorMessage = "Грешка! Паролата трябва да съдържа поне една цифра!";
                return ErrorMessage;
            }

            else if (!hasSymbols.IsMatch(input))
            {
                ErrorMessage = "Грешка! Паролата трябва да съдържа поне един специален знак!";
                return ErrorMessage;
            }
            else
            {
                return ErrorMessage;
            }
        }
    }
}
