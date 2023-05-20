using VacationDestinationManager.Domain;
using VacationDestinationManager.RepositoryLayer;

namespace VacationDestinationManager.ServiceLayer
{
    internal class EntityService<TEntity> where TEntity : IEntity
    {
        protected readonly IRepository<TEntity> _repository;

        public EntityService(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public int Count => _repository.Count;

        public void Add(TEntity entity)
            => _repository.Add(entity);

        public TEntity? FindById(int id)
            => _repository.FindById(id);

        public void Update(int id,  TEntity newEntity)
            => _repository.Update(id, newEntity);

        public void Remove(int id)
            => _repository.Remove(id);

        public IEnumerable<TEntity> GetAll()
            => _repository.GetAll();

        public int GetFreeId()
        {
            int id = 1;
            while (_repository.FindById(id) is not null)
                id++;
            return id;
        }
    }
}
