using System;

namespace Financial.Application.Contract.DTO
{
    public class CreateAccountDto
    {
        public int Balance { get; set; }
        public Guid  AccountTypeId{ get; set; }
        public Guid CustomerId { get; set; }
    }
}