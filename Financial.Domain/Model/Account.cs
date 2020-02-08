using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financial.Domain.Model;
using Framework.Core;

namespace Financial.Domain.Model
{
    public class Account:EntityBase,IAggregateRoot
    {
        #region fields

        private string accountNumber;
        private Int32 balance;

        #endregion
        #region properties
        public virtual string AccountNumber => accountNumber;
        public virtual Int32 Balance => balance;
        public virtual AccountType AccountType { get; }
        public virtual Customer AccountOwner { get; set; }

        #endregion
        public Account()//ORM
        {

        }
        public Account(Int32 balance,Customer accountOwner,AccountType accountType)
        {
            SetBalance(balance);
            AccountOwner = accountOwner;
            AccountType = accountType;
            accountNumber = GenerateAccountNumber(AccountOwner, AccountType);
        }

        private string GenerateAccountNumber(Customer accountOwner, AccountType accountType)
        {
            if (accountOwner != null && accountType != null)
                throw new ArgumentNullException();
            else
                return accountOwner.NationCode + accountType.AccountTypeNumber.Substring(0, 2);
        }

        private void SetBalance(int balance)
        {
            if (balance < 0)
                throw new InvalidCastException();
            else
               this.balance = balance;
        }
    }
}
