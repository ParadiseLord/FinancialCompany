using Financial.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial.Domain.Repository
{
    public interface ICustomerRepository
    {
        Customer Get(Guid id);
        void Save(Customer customer);
    }
}
