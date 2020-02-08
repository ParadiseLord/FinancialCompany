using Framwork;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Persitence
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly ISession session;

        public UnitOfWork(ISession session)
        {
            this.session = session;
        }
        public void Begin()
        {
            session.BeginTransaction();
        }

        public void Commit()
        {
            session.Transaction.Commit();

        }

        public void Rollback()
        {
            session.Transaction.Rollback(); 
        }
    }
}
