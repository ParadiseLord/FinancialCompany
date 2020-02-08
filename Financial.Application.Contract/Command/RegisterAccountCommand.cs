using Financial.Domain.Model;
using Framework.Application;
using System;

namespace Financial.Application.Contract
{
    public class RegisterAccountCommand:ICommand
    {
        public string AccountNumber { get; set; }
        public Int32 Balance { get; set; }
        public int  AccountTypeId { get; set; }
        public int AccountOwnerId { get; set; }
    }
}
