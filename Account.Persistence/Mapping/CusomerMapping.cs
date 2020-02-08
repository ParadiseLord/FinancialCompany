using NHibernate.Mapping.ByCode.Conformist;
using Financial.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial.Persistence.Mapping
{
    public class CustomerMapping : ClassMapping<Customer>
    {
        public CustomerMapping()
        {
            Table("Customers");
            Id(p => p.Id);
            Property(p => p.FirstName, p => p.Access(NHibernate.Mapping.ByCode.Accessor.Field));
            Property(p => p.Lastname, p => p.Access(NHibernate.Mapping.ByCode.Accessor.Field));
            Property(p => p.Age, p => p.Access(NHibernate.Mapping.ByCode.Accessor.Field));
            Property(p => p.Gender, p => p.Access(NHibernate.Mapping.ByCode.Accessor.Field));
            Property(p => p.BirthDate, p => p.Access(NHibernate.Mapping.ByCode.Accessor.Field));
            Property(p => p.Mobile, p => p.Access(NHibernate.Mapping.ByCode.Accessor.Field));

            Component(p => p.HomeAddress, p => {
                p.Property(z => z.City, z => z.Column("HomeAddress_City"));
                p.Property(z => z.Province, z => z.Column("HomeAddress_Province"));
                p.Property(z => z.PostalCode, z => z.Column("HomeAddress_PostalCode"));
            });
            Component(p => p.PhoneNumber, p => {
                p.Property(z => z.CityCode, z => z.Column("Phone_CityCode"));
                p.Property(z => z.Number, z => z.Column("Phone_Number"));
            });


        }
    }
}
