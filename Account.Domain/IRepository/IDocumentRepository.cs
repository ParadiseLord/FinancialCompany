using Account.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Domain.Repository
{
    public interface IDocumentRepository
    {
        Document Get(Guid id);
        void Save(Document document);
    }
}
