using Financial.Domain.Model;
using System;

namespace Financial.Persistence.Command
{
    public class CreateCustomerCommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string NationCode { get; set; }
        public Address  HomeAddress { get; set; }
        public Phone  PhoneNumber { get; set; }
        public string Mobile { get; set; }
    }
}
