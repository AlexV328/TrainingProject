using System;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Reposiotries
{
    public interface IUserReposioty
    {
        User SearchByID(Guid id);
    }
}