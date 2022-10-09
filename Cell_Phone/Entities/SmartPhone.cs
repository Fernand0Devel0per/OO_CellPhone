using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cell_Phone.Entities
{
    public abstract class SmartPhone
    {

        public string NumberPhone { get; set; }
        public string Model { get; private set; }
        public string IMEI { get; private set; }
        public int Memory { get; private set; }

        protected SmartPhone(string numberPhone, string model, string iMEI, int memory)
        {
            NumberPhone = numberPhone;
            Model = model;
            IMEI = iMEI;
            Memory = memory;
        }

        public void MakeCall() { }
        public void ReciveCall() { }
        public abstract void InstallAppl(string name);
    }
}
