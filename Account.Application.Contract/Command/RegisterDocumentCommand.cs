using Framework.Application;
using System;

namespace Account.Application.Contract
{
    public class RegisterDocumentCommand:ICommand
    {
        public string documentNumber { get; set; }
        public DateTime InsertDateTime { get; set; }
        public string DocumentRow_AccountNumber { get; set; }
        public string DocumentRow_Description { get; set; }
        public string DocumentRow_Amount { get; set; }
    }
}
