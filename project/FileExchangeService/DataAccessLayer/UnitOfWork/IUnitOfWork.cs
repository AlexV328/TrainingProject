namespace DataAccessLayer.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Commit();

        T Create<T>(T entity) where T : class;
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
    }
}