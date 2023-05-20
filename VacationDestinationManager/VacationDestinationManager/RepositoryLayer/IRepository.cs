using VacationDestinationManager.Domain;

namespace VacationDestinationManager.RepositoryLayer
{
    internal interface IRepository<TEntity> where TEntity : IEntity
    {
        int Count { get; }
        void Add(TEntity entity);
        TEntity? FindById(int id);
        void Update(int id, TEntity entity);
        void Remove(int id);
        IEnumerable<TEntity> GetAll();
    }
}
