using System.Data.Entity;
using DataAccessLayer.Entities;

namespace DataAccessLayer.UnitOfWork.EF
{
    internal class FileExchangeContext : DbContext, IUnitOfWork
    {
        public DbSet<User> Users { get; set; }

        public FileExchangeContext()
            : base("FileExchange")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public void Commit()
        {
            SaveChanges();
        }

        public T Create<T>(T entity) where T : class
        {
            return Set(typeof (T)).Create() as T;
        }

        public void Add<T>(T entity) where T : class
        {
            Set(typeof (T)).Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            Set(typeof(T)).Remove(entity);
        }
    }
}