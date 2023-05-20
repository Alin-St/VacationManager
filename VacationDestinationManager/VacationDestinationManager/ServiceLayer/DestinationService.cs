using VacationDestinationManager.Domain;
using VacationDestinationManager.RepositoryLayer;

namespace VacationDestinationManager.ServiceLayer
{
    internal class DestinationService : EntityService<Destination>
    {
        public DestinationService(IRepository<Destination> repository) : base(repository)
        { }

        void AddDestination(string username, string geolocation, string title, byte[] imageBytes, string description, DateTime stayDate)
        {
            int id = GetFreeId();
            var newItem = new Destination(id, username, geolocation, title, imageBytes, description, stayDate);
            _repository.Add(newItem);
        }
    }
}
