using System;
using System.Linq;
using DataAccessLayer.Entities;
using DataAccessLayer.UnitOfWork;

namespace DataAccessLayer.Reposiotries.EF
{
    internal class EFUserRepository : EFBaseRepository, IUserRepository
    {
        public EFUserRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public User SearchByID(Guid id)
        {
            return context.Users.SingleOrDefault(user => user.ID == id);
        }
    }
}