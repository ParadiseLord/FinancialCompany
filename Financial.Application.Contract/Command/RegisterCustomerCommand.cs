using Framework.Application;
using System;

namespace Financial.Application.Contract
{
    public class RegisterCustomerCommand:ICommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeAddress_Province { get; set; }
        public string HomeAddress_City { get; set; }
        public string HomeAddress_PostalCode { get; set; }
        public string Phone_Number { get; set; }
        public string Phone_CityCode { get; set; }
        public string Mobile { get; set; }
        public string NationCode { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
    }
}
