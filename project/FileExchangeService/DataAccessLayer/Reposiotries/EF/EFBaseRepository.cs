using System;
using DataAccessLayer.UnitOfWork;
using DataAccessLayer.UnitOfWork.EF;

namespace DataAccessLayer.Reposiotries.EF
{
    internal class EFBaseRepository
    {
        protected FileExchangeContext context;

        protected EFBaseRepository(IUnitOfWork unitOfWork)
        {
            var fileExchangeContext = unitOfWork as FileExchangeContext;

            if (fileExchangeContext == null)
                throw new ArgumentException("Invalid unit of work");

            context = fileExchangeContext;
        }
    }
}