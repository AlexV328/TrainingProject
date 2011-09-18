using System;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Reposiotries
{
    public interface IUserRepository
    {
        User SearchByID(Guid id);
    }
}