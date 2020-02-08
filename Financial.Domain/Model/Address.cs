using System.Collections.Generic;
using Framework.Core;

namespace Financial.Domain.Model
{
    public class Address : ValueObject<Address>
    {
        public virtual string Province { get; protected set; }
        public virtual string City { get; protected set; }
        public virtual string PostalCode { get; protected set; }

        public Address(string province, string city, string postalcode)
        {
            Province = province;
            City = city;
            PostalCode = postalcode;
        }

        protected Address()
        {
            // Orm
        }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            return new object[] { Province, City, PostalCode };
        }
    }
}
