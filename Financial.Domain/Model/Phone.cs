using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core;

namespace Financial.Domain.Model
{
    public class Phone : ValueObject<Phone>
    {
        
        public virtual string CityCode { get; protected set; }
        public virtual string Number { get; protected set; }

        public Phone(string citycode, string number)
        {
            CityCode = citycode;
            Number = number;
        }

        protected Phone()
        {
            // Orm
        }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            return new object[] { CityCode, Number };
        }
    }
}
