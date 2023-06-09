using VacationDestinationManager.Domain;

namespace VacationDestinationManager.RepositoryLayer
{
    internal class MemoryRepository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : IEntity<TKey> where TKey : notnull
    {
        readonly Dictionary<TKey, TEntity> _entities = new();

        public int Count => _entities.Count;

        public void Add(TEntity entity)
        {
            if (_entities.ContainsKey(entity.GetKey()))
                throw new InvalidOperationException("An entity with the same key already exists.");

            _entities.Add(entity.GetKey(), entity);
        }

        public TEntity? FindByKey(TKey key)
        {
            _ = _entities.TryGetValue(key, out var entity);
            return entity;
        }

        public void Update(TKey key, TEntity newEntity)
        {
            if (!_entities.ContainsKey(key))
                throw new InvalidOperationException("Key not found.");

            if (!key.Equals(newEntity.GetKey()))
                throw new InvalidOperationException("Cannot update an entity's key.");

            _entities[key] = newEntity;
        }

        public void Remove(TKey key)
        {
            if (!_entities.Remove(key))
                throw new InvalidOperationException("Key not found.");
        }

        public IReadOnlyCollection<TEntity> GetAll()
        {
            return _entities.Values;
        }
    }
}
