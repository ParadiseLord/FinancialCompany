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
    public class AccountTypeRepository : IAccountTypeRepository
    {
        private ISession session;

        public AccountTypeRepository(ISession session)
        {
            this.session = session;
        }

        public void Save(Account customerAggregate)
        {
            session.Save(customerAggregate);
        }

        public Account Get(Guid id)
        {
            return session.Query<Account>().Single(p => p.Id == id);
        }

        public void Remove(Guid id)
        {
            var aggrigate = session.Query<Account>().Single(p => p.Id == id);
            session.Delete(aggrigate);
        }
    }
}
