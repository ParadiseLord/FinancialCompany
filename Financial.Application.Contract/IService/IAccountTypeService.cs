using Financial.Application.Contract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial.Application.Contract.IService
{
    public interface IAccountTypeService
    {
        void RegisterAccountType(CreateAccountTypeDto createAccountTypeDto);
    }
}
