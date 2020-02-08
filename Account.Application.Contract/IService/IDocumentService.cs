using Account.Application.Contract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Application.Contract.IService
{
    public interface IDocumentService
    {
            void RegisterCustomer(CreateDocumentDTO createDocumentDto);
    }
}
