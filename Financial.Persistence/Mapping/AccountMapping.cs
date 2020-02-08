using NHibernate.Mapping.ByCode.Conformist;
using Financial.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial.Persistence.Mapping
{
    public class AccountMapping : ClassMapping<Account>
    {
        public AccountMapping()
        {
            Table("Customers");
            Id(p => p.Id);
            Property(p => p.AccountNumber, p => p.Access(NHibernate.Mapping.ByCode.Accessor.Field));
            Property(p => p.Balance, p => p.Access(NHibernate.Mapping.ByCode.Accessor.Field));
            

            Component(p => p.AccountType, p => {
                p.Property(z => z.AccountTypeNumber, z => z.Column("AccountType_AccountTypeNumber"));
                p.Property(z => z.Title, z => z.Column("AccountType_Title"));
            });
           


        }
    }
}
