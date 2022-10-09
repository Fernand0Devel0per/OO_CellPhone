using Cell_Phone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cell_Phone.Interface
{
    public interface IAddAccount
    {
        public void AddNewAccoun(string email, string password);
        public void RemoveAccount(string email, string password);
    }
}
