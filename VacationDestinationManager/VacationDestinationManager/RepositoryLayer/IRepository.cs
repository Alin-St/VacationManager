using VacationDestinationManager.Domain;

namespace VacationDestinationManager.RepositoryLayer
{
    internal interface IRepository<TEntity, TKey> where TEntity : IEntity<TKey> where TKey : notnull
    {
        int Count { get; }
        void Add(TEntity entity);
        TEntity? FindByKey(TKey key);
        void Update(TKey key, TEntity entity);
        void Remove(TKey key);
        IReadOnlyCollection<TEntity> GetAll();
    }
}
