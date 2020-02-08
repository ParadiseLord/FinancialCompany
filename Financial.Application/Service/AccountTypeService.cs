using Framwork;
using Financial.Domain.Model;
using Financial.Domain.Repository;
using Financial.Application.Contract.DTO;
using Financial.Application.Contract.IService;

namespace Financial.Application
{
    public class AccountTypeService : IAccountTypeService
    {
        private readonly IAccountTypeRepository accountTypeRepository;
        private IUnitOfWork uow;
        public AccountTypeService(IAccountTypeRepository accountTypeRepository, IUnitOfWork uow)
        {
            this.accountTypeRepository = accountTypeRepository;
            this.uow = uow;
        }
        public void RegisterAccountType(CreateAccountTypeDto dto)
        {
            uow.Begin();
            var accountType = new AccountType(dto.AccountTypeNumber, dto.Title);
            try
            {
                accountTypeRepository.Save(accountType);
                uow.Commit();
            }
            catch (System.Exception ex)
            {

                uow.Rollback();
            }
        }
    }

}
