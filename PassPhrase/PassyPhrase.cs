using System;

namespace PassPhrase.Tests
{
    public class PassyPhrase
    {
        public PassyPhrase()
        {
        }

        public string playPass(string s, int n)
        {
            if (string.IsNullOrWhiteSpace(s)) return string.Empty;

            char c;

            if (UpperCase(s))
                c = (char)((char.Parse(s) + n) % 90);
            else
                c = (char)((char.Parse(s) + n) % )

            return (newChar).ToString();
        }

        private bool UpperCase(string s)
        {
            var c = (int)char.Parse(s);

            return (('A' <= c) && (c <= 'Z'));
        }
    }
}