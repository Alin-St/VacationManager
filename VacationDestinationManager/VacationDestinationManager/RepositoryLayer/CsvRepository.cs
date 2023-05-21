using CsvHelper;
using System.Globalization;
using VacationDestinationManager.Domain;

namespace VacationDestinationManager.RepositoryLayer
{
    internal class CsvRepository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        private readonly MemoryRepository<TEntity> _memoryRepository = new();
        private readonly string _filename;

        public CsvRepository(string filename)
        {
            _filename = filename;
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
            // Clear previous entities if any.
            var ids = _memoryRepository.GetAll().Select(e => e.Id).ToList();
            ids.ForEach(id => _memoryRepository.Remove(id));

            // Add new data from file.
            if (!File.Exists(_filename))
                return;

            using var reader = new StreamReader(_filename);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var entities = csv.GetRecords<TEntity>().ToList();
            entities.ForEach(e => _memoryRepository.Add(e));
        }

        public void SaveToFile()
        {
            using var writer = new StreamWriter(_filename);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteRecords(_memoryRepository.GetAll());
        }
    }
}
