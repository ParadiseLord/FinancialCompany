using Framwork;
using Financial.Domain.Model;
using Financial.Domain.Repository;
using Financial.Application.Contract.DTO;
using Financial.Application.Contract.IService;

namespace Financial.Application
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;
        private IUnitOfWork uow;
        public CustomerService(ICustomerRepository customerRepository, IUnitOfWork uow)
        {
            this.customerRepository = customerRepository;
            this.uow = uow;
        }
        public void RegisterCustomer(CreateCustomerDto dto)
        {
            uow.Begin();
            var address = new Address(dto.HomeAddress_Province, dto.HomeAddress_City, dto.HomeAddress_PostalCode);
            var phone = new Phone(dto.Phone_CityCode, dto.Phone_Number);
            var customer = new Customer(dto.FirstName, dto.LastName,dto.Gender,dto.Age, address,dto.NationCode,dto.BirthDate,phone,dto.Mobile);
            try
            {
                customerRepository.Save(customer);
                uow.Commit();
            }
            catch (System.Exception ex)
            {

                uow.Rollback();
            }
        }
    }

}
