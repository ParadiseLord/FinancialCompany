using Framework.Application;
using Framwork;
using Financial.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financial.Application.Contract;
using Financial.Domain.Model;
using Financial.Domain.Repository;

namespace Financial.Application
{
   public class RegisterAccountTypeCommandHandler : ICommandHandler<RegisterAccountTypeCommand>
    {
        private readonly IAccountTypeRepository accountTypeRepository;
        private IUnitOfWork uow;
        public RegisterAccountTypeCommandHandler(IAccountTypeRepository accounttypeRepository, IUnitOfWork uow)
        {
            this.accountTypeRepository = accounttypeRepository;
            this.uow = uow;
        }

        public void Handle(RegisterAccountTypeCommand command)
        {
            uow.Begin();

            var accounttype = new AccountType(command.AccountTypeNumber, command.Title);
            try
            {
                accountTypeRepository.Save(accounttype);
                uow.Commit();
            }
            catch (System.Exception ex)
            {

                uow.Rollback();
            }
        }
    }
}
