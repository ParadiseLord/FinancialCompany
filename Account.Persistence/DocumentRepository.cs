using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Account.Domain.Model;
using Account.Domain;
using Account.Domain.Repository;

namespace Financial.Persistence
{
    public class DocumentRepository : IDocumentRepository
    {
        private ISession session;

        public DocumentRepository(ISession session)
        {
            this.session = session;
        }

        public void Save(Document documentAggregate)
        {
            session.Save(documentAggregate);
        }

        public Document Get(Guid id)
        {
            return session.Query<Document>().Single(p => p.Id == id);
        }

        public void Remove(Guid id)
        {
            var aggrigate = session.Query<Document>().Single(p => p.Id == id);
            session.Delete(aggrigate);
        }
    }
}
