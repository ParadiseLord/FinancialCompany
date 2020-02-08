using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Domain.Model
{
    public class Document:EntityBase,IAggregateRoot
    {
        #region fields

        DateTime insertDateTime;
        string documentNumber;
        #endregion

        #region properties
        public DateTime InsertDateTime => insertDateTime;
        public string DocumentNumber => documentNumber;
        public DocumentRow DocumentRow { get; }

        #endregion
        public Document()//ORM
        {

        }

        public Document(DateTime insertDateTime, string documentNumber, DocumentRow documentRow)
        {
            this.insertDateTime = insertDateTime;
            this.documentNumber = documentNumber;
            DocumentRow = documentRow;
        }
    }
}
