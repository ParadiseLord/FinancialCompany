using Financial.Domain.Model;
using Framework.Application;
using System;

namespace Financial.Application.Contract
{
    public class RegisterAccountTypeCommand:ICommand
    {
        public string AccountTypeNumber { get; set; }
        public string Title { get; set; }

    }
}
