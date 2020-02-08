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
   public class RegisterAccountCommandHandler : ICommandHandler<RegisterAccountCommand>
    {
        private readonly IAccountRepository accountRepository;
        private readonly ICustomerRepository customerRepository;
        private IUnitOfWork uow;
        public RegisterAccountCommandHandler(ICustomerRepository customerRepository, IAccountRepository accountRepository, IUnitOfWork uow)
        {
            this.customerRepository = customerRepository;
            this.accountRepository = accountRepository;
            this.uow = uow;
        }

        public void Handle(RegisterAccountCommand command)
        {
            uow.Begin();
            var accountOwner = customerRepository.Get(command.AccountOwner.Id);
            
            var account = new Account(command.Balance, accountOwner, command.AccountType);
            try
            {
                accountRepository.Save(account);
                uow.Commit();
            }
            catch (System.Exception ex)
            {

                uow.Rollback();
            }
        }
    }
}
