using VacationDestinationManager.Domain;
using VacationDestinationManager.RepositoryLayer;

namespace VacationDestinationManager.ServiceLayer
{
    internal class EntityService<TEntity, TKey> where TEntity : IEntity<TKey> where TKey : notnull
    {
        protected readonly IRepository<TEntity, TKey> _repository;

        public EntityService(IRepository<TEntity, TKey> repository)
        {
            _repository = repository;
        }

        public int Count => _repository.Count;

        public void Add(TEntity entity)
            => _repository.Add(entity);

        public TEntity? FindByKey(TKey key)
            => _repository.FindByKey(key);

        public void Update(TKey key,  TEntity newEntity)
            => _repository.Update(key, newEntity);

        public void Remove(TKey key)
            => _repository.Remove(key);

        public IEnumerable<TEntity> GetAll()
            => _repository.GetAll();
    }
}
