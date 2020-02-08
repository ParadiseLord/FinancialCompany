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
   public class RegisterCustomerCommandHandler : ICommandHandler<RegisterCustomerCommand>
    {
        private readonly ICustomerRepository customerRepository;
        private IUnitOfWork uow;
        public RegisterCustomerCommandHandler(ICustomerRepository customerRepository, IUnitOfWork uow)
        {
            this.customerRepository = customerRepository;
            this.uow = uow;
        }

        public void Handle(RegisterCustomerCommand command)
        {
            uow.Begin();
            var address = new Address(command.HomeAddress_Province, command.HomeAddress_City, command.HomeAddress_PostalCode);
            var phone = new Phone(command.Phone_CityCode, command.Phone_Number);
            var customer = new Customer(command.FirstName, command.LastName,command.Gender,command.Age, address,command.NationCode, command.BirthDate, phone,command.Mobile);
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
