using System.Collections.Generic;
using Framework.Core;

namespace Account.Domain.Model
{
    public class DocumentRow : ValueObject<DocumentRow>
    {
        public virtual string AccountNumber { get; protected set; }
        public virtual string Description { get; protected set; }
        public virtual string Amount { get; protected set; }

        public DocumentRow(string accountNumber, string description, string amount)
        {
            AccountNumber = accountNumber;
            Description = description;
            Amount = amount;
        }

        protected DocumentRow()
        {
            // Orm
        }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            return new object[] { AccountNumber, Description, Amount };
        }
    }
}