using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cell_Phone.Messages
{
    public static class MessagesCustom
    {

        public static void MessageAndClear(string message, int time = 1)
        {
            Console.WriteLine(message);
            Thread.Sleep(time * 1000);
            Console.Clear();
        }

        public static void MessageAndClearKeyEnd(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
            Console.Clear();
        }

    }
}
