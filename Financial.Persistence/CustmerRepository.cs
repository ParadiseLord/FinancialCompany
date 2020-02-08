using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financial.Domain.Model;
using Financial.Domain;


namespace Financial.Persistence
{
    public class CustomerRepository : ICustomerRepository
    {
        private ISession session;

        public CustomerRepository(ISession session)
        {
            this.session = session;
        }

        public void Save(Customer customerAggregate)
        {
            session.Save(customerAggregate);
        }

        public Customer Get(Guid id)
        {
            return session.Query<Customer>().Single(p => p.Id == id);
        }

        public void Remove(Guid id)
        {
            var aggrigate = session.Query<Customer>().Single(p => p.Id == id);
            session.Delete(aggrigate);
        }
    }
}
