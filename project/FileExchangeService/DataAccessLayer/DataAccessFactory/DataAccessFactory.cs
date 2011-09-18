using DataAccessLayer.Reposiotries;
using DataAccessLayer.Reposiotries.EF;
using DataAccessLayer.UnitOfWork;
using DataAccessLayer.UnitOfWork.EF;

namespace DataAccessLayer.DataAccessFactory
{
    public class DataAccessFactory
    {
        public IUnitOfWork CreateUnitOfWork()
        {
            return new FileExchangeContext();
        }

        public IUserRepository CreateUserRepository(IUnitOfWork unitOfWork)
        {
            return new EFUserRepository(unitOfWork);
        }
    }
}