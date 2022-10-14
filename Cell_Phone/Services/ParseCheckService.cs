using Cell_Phone.Messages;
using Cell_Phone.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cell_Phone.Services
{
    public static class ParseCheckService
    {
        public static int TryParseIntCheck(string message)
        {
            bool result = false;
            int numberParse = 0;
            do
            {
                Console.Write(message);
                result = int.TryParse(Console.ReadLine(), out numberParse);

                if (!result)
                {
                    MessagesCustom.MessageAndClear(StringErrorMessages.DigitNumberOnly, 2);
                }
                
            } while (!true);
            return numberParse;
        }
    }
}
