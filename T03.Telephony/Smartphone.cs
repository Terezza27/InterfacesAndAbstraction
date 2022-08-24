using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T03.Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string Call(string num)
        {
            if (!num.All(c => Char.IsDigit(c)))
            {
                throw new ArgumentException("Invalid number!");
            }
            return num.Length > 7 ? $"Calling... {num}" : $"Dialing... {num}";
        }

        public string Browsing(string webSide)
        {
            if (webSide.Any(c => Char.IsDigit(c)))
            {
                throw new ArgumentException("Invalid URL!");
            }
            else
            {
                return $"Browsing: {webSide}!";
            }

        }


    }
}
