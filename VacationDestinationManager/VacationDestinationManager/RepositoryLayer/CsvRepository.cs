using VacationDestinationManager.Domain;

namespace VacationDestinationManager.RepositoryLayer
{
    internal class CsvRepository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        private readonly MemoryRepository<TEntity> _memoryRepository = new();
        private readonly string _filename;
        private readonly Func<List<string>, TEntity> _csvToEntity;
        private readonly Func<TEntity, List<string>> _entityToCsv;

        public CsvRepository(string filename, Func<List<string>, TEntity> propertyListToEntity, Func<TEntity, List<string>> entityToPropertyList)
        {
            _filename = filename;
            _csvToEntity = propertyListToEntity;
            _entityToCsv = entityToPropertyList;
        }

        public int Count => _memoryRepository.Count;

        public void Add(TEntity entity)
            => _memoryRepository.Add(entity);

        public TEntity? FindById(int id)
            => _memoryRepository.FindById(id);

        public void Update(int id, TEntity entity)
            => _memoryRepository.Update(id, entity);

        public void Remove(int id)
            => _memoryRepository.Remove(id);

        public IEnumerable<TEntity> GetAll()
            => _memoryRepository.GetAll();

        public void LoadFromFile()
        {
            var fileContent = File.Exists(_filename) ? File.ReadAllText(_filename) : "";
            var lines = fileContent.Split(new[] { "\n", "\r\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines)
            {
                var properties = line.Split(',').ToList();
                var entity = _csvToEntity(properties);
                _memoryRepository.Add(entity);
            }
        }

        public void SaveToFile()
        {
            string fileContent = "";
            foreach (var entity in _memoryRepository.GetAll())
            {
                var properties = _entityToCsv(entity);
                var line = string.Join(',', properties);
                fileContent += line;
            }

            File.WriteAllText(_filename, fileContent);
        }
    }
}
