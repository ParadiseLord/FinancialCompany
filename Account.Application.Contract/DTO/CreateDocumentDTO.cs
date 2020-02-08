using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Application.Contract.DTO
{
    public class CreateDocumentDTO
    {
        public string documentNumber { get; set; }
        public DateTime InsertDateTime { get; set; }
        public string DocumentRow_AccountNumber { get; set; }
        public string DocumentRow_Description { get; set; }
        public string DocumentRow_Amount { get; set; }
    }
}
