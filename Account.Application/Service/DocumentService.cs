using Account.Application.Contract.DTO;
using Account.Application.Contract.IService;
using Account.Domain.Model;
using Account.Domain.Repository;
using Framwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Application.Service
{
    public class DocumentService : IDocumentService
    {
        private readonly IDocumentRepository documentRepository;
        private IUnitOfWork uow;

        public DocumentService(IDocumentRepository documentRepository, IUnitOfWork uow)
        {
            this.documentRepository = documentRepository;
            this.uow = uow;
        }

        public void RegisterCustomer(CreateDocumentDTO dto)
        {
            uow.Begin();
            var documentRow = new DocumentRow(dto.DocumentRow_AccountNumber, dto.DocumentRow_Description, dto.DocumentRow_Amount);
            var document = new Document(dto.InsertDateTime, dto.documentNumber, documentRow);
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
