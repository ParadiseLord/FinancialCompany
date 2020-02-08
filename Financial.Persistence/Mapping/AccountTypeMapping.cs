using NHibernate.Mapping.ByCode.Conformist;
using Financial.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial.Persistence.Mapping
{
    public class AccountTypeMapping : ClassMapping<AccountType>
    {
        public AccountTypeMapping()
        {
            Table("AccountType");
            Id(p => p.Id);
            Property(p => p.AccountTypeNumber, p => p.Access(NHibernate.Mapping.ByCode.Accessor.Field));
            Property(p => p.Title, p => p.Access(NHibernate.Mapping.ByCode.Accessor.Field));
        }
    }
}
