using Framework.Application;
using Framwork;
using Account.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Account.Application.Contract;
using Account.Domain.Model;
using Account.Domain.Repository;

namespace Account.Application
{
   public class RegisterDocumentCommandHandler : ICommandHandler<RegisterDocumentCommand>
    {
        private readonly IDocumentRepository documentRepository;
        private IUnitOfWork uow;
        public RegisterDocumentCommandHandler(IDocumentRepository documentRepository, IUnitOfWork uow)
        {
            this.documentRepository = documentRepository;
            this.uow = uow;
        }

        public void Handle(RegisterDocumentCommand command)
        {
            uow.Begin();
            var documentRow = new DocumentRow(command.DocumentRow_AccountNumber, command.DocumentRow_Description, command.DocumentRow_Amount);
            var document = new Document(command.InsertDateTime, command.documentNumber, documentRow);
            try
            {
                documentRepository.Save(document);
                uow.Commit();
            }
            catch (System.Exception ex)
            {

                uow.Rollback();
            }
        }
    }
}
