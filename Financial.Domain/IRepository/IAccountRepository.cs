using Financial.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial.Domain.Repository
{
    public interface IAccountRepository
    {
        Account Get(Guid id);
        void Save(Account customer);
    }
}
