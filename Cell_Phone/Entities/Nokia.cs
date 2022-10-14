using Cell_Phone.Messages;
using Cell_Phone.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cell_Phone.Entities
{
    public class Nokia : SmartPhone
    {
        public List<Account> Accounts { get; private set; }

        public Nokia(string numberPhone, string model, string iMEI, int memory, string email, string password) 
            : base(numberPhone, model, iMEI, memory)
        {
            AddNewAccoun(email, password);
        }

        public void AddNewAccoun(string email, string password)
        {
            if (Accounts == null)
            {
                Accounts = new List<Account>();
            }
            Account account = Accounts.FirstOrDefault(a => a.Email == email);

            if (account == null)
            {
                Accounts.Add(new Account(email, password));
            }
            else
            {
                Console.WriteLine(StringErrorMessages.EmailExist);
            }

        }

        public void RemoveAccount(string email, string password)
        {
            Account account = Accounts.FirstOrDefault(x => x.Email == email && x.Password == password);
            if (account != null)
            {
                Accounts.Remove(account);
            }
            else
            {
                Console.WriteLine(StringErrorMessages.AccountNotFound);
            }
        }


        public override void InstallAppl(string name)
        {
            MessagesCustom.MessageAndClearKeyEnd($"{StringLogMessages.InstalApp} {name}");
        }
    }
}
