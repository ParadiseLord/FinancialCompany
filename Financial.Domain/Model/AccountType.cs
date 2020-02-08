using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial.Domain.Model
{
    public class AccountType:EntityBase,IAggregateRoot
    {
        #region fields
        string accountTypeNumber;
        string title;
        #endregion

        #region properties
        public virtual string AccountTypeNumber => accountTypeNumber;
        public virtual string Title => title;

        #endregion
        public AccountType()//ORM
        {

        }
        public AccountType(string accountTypeNumber,string title)
        {
            SetAccountTypeNumber(accountTypeNumber);
            this.title = title;
        }

        private void SetAccountTypeNumber(string accountTypeNumber)
        {
            if (accountTypeNumber.Length < 2)
                throw new Exception("The AccountTypeNumber Lenght is too small");
            else
                this.accountTypeNumber = accountTypeNumber;
        }
    }
}
