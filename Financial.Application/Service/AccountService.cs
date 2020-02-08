using Framwork;
using Financial.Domain.Model;
using Financial.Domain.Repository;
using Financial.Application.Contract.DTO;
using Financial.Application.Contract.IService;

namespace Financial.Application
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository accountRepository;
        private readonly IAccountTypeRepository accountTypeRepository;
        private readonly ICustomerRepository customerRepository;

        private IUnitOfWork uow;
        public AccountService(IAccountRepository accountRepository, IAccountTypeRepository accountTypeRepository,ICustomerRepository customerRepository, IUnitOfWork uow)
        {
            this.accountRepository = accountRepository;
            this.accountTypeRepository = accountTypeRepository;
            this.customerRepository = customerRepository;
            this.uow = uow;
        }

        public void RegisterAccount(CreateAccountDto dto)
        {
            uow.Begin();
            var accountOwner = customerRepository.Get(dto.CustomerId);
            var accountType = accountTypeRepository.Get(dto.AccountTypeId);
            var account = new Account(dto.Balance, accountOwner, accountType);
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
