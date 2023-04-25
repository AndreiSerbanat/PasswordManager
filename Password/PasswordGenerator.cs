using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    public class PasswordGenerator
    {
        private static readonly List<char> Characters = new List<char>()
    {
        'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
        '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
        '~', '`', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '-', '+', '=', '{', '[', '}', ']', ',', '|', ':', ';', '<', '>', '.', '?', '/'
    };

        private static readonly Random Random = new Random();

        public string GeneratePassword(int length, bool allowNumbers, bool allowSymbols)
        {
            var password = "";

            for (int i = 0; i < length; i++)
            {
                int index = Random.Next(0, Characters.Count);

                if (!allowNumbers && char.IsDigit(Characters[index]))
                {
                    // Skip if numbers are not allowed and the current character is a digit
                    i--;
                    continue;
                }

                if (!allowSymbols && !char.IsLetterOrDigit(Characters[index]))
                {
                    // Skip if symbols are not allowed and the current character is not a letter or digit
                    i--;
                    continue;
                }

                password += Characters[index];
            }

            return password;
        }
    }
}
