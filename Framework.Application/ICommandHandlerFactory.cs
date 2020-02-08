﻿namespace Framework.Application
{
    public interface ICommandHandlerFactory
    {
        ICommandHandler<T> CreateHandler<T>() where T : ICommand;
    }
}
