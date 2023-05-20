using VacationDestinationManager.Domain;

namespace VacationDestinationManager.RepositoryLayer
{
    internal class MemoryRepository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        private readonly List<TEntity> _entities = new();

        public int Count => _entities.Count;

        public void Add(TEntity entity)
        {
            _entities.Add(entity);
        }

        public TEntity? FindById(int id)
        {
            return _entities.Find(x => x.Id == id);
        }

        public void Update(int id, TEntity newEntity)
        {
            int ind = _entities.FindIndex(x => x.Id == id);
            if (ind < 0)
                throw new InvalidOperationException("Id not found.");
            _entities[ind] = newEntity;
        }

        public void Remove(int id)
        {
            int ind = _entities.FindIndex(x => x.Id == id);
            if (ind < 0)
                throw new InvalidOperationException("Id not found.");
            _entities.RemoveAt(ind);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _entities;
        }
    }
}
