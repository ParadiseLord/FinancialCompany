using Framwork;
using System;

namespace Framework.Application
{
    public interface ICommandBus
    {
        void Dispatch<T>(T command) where T : ICommand;
    }

    public class CommandBus : ICommandBus
    {
        private ICommandHandlerFactory _factory;
         private IUnitOfWork uow;
        public CommandBus(ICommandHandlerFactory factory, IUnitOfWork uow)
        {
            this._factory = factory;
            // this.uow = uow;
        }

        public void Dispatch<T>(T command) where T : ICommand
        {
            var handler = _factory.CreateHandler<T>();
            //
                handler.Handle(command);
        }
    }
}
