using Financial.Domain.Model;

namespace Financial.Persistence.Command
{
    public class CreateAccountCommand
    {
        public int Balance { get; set; }
        public int AccountTypeId { get; set; }
        public int AccountOwnerId { get; set; }
    }
}
