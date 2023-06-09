using CsvHelper;
using System.Globalization;
using VacationDestinationManager.Domain;

namespace VacationDestinationManager.RepositoryLayer
{
    internal class CsvRepository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : IEntity<TKey> where TKey : notnull
    {
        private MemoryRepository<TEntity, TKey> _memoryRepository = new();
        private readonly string _filename;

        public CsvRepository(string filename)
        {
            _filename = filename;
        }

        public int Count => _memoryRepository.Count;

        public void Add(TEntity entity)
            => _memoryRepository.Add(entity);

        public TEntity? FindByKey(TKey key)
            => _memoryRepository.FindByKey(key);

        public void Update(TKey key, TEntity entity)
            => _memoryRepository.Update(key, entity);

        public void Remove(TKey key)
            => _memoryRepository.Remove(key);

        public IReadOnlyCollection<TEntity> GetAll()
            => _memoryRepository.GetAll();

        public void LoadFromFile()
        {
            // Add new data from file in a new repo.
            var newMemoryRepository = new MemoryRepository<TEntity, TKey>();

            if (!File.Exists(_filename))
                return;

            using var reader = new StreamReader(_filename);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var entities = csv.GetRecords<TEntity>().ToList();
            entities.ForEach(newMemoryRepository.Add);

            // Update the repository if everything was successful.
            _memoryRepository = newMemoryRepository;
        }

        public void SaveToFile()
        {
            // Get the repository content in csv format.
            string repositoryContent;
            using (var stringWriter = new StringWriter())
            {
                using (var csvWriter = new CsvWriter(stringWriter, CultureInfo.InvariantCulture))
                    csvWriter.WriteRecords(_memoryRepository.GetAll());
                repositoryContent = stringWriter.ToString();
            }

            // Save the repository to the file if everything was successful.
            File.WriteAllText(_filename, repositoryContent);
        }
    }
}
