using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cell_Phone.Entities
{
    public class Nokia : SmartPhone
    {

        public Nokia(string numberPhone, string model, string iMEI, int memory) 
            : base(numberPhone, model, iMEI, memory)
        {

        }

        public override void InstallAppl(string name)
        {
            Console.WriteLine();
        }
    }
}
