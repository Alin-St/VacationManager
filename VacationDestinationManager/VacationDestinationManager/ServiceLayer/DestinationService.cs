using VacationDestinationManager.Domain;
using VacationDestinationManager.RepositoryLayer;

namespace VacationDestinationManager.ServiceLayer
{
    internal class DestinationService : EntityService<Destination>
    {
        public DestinationService(IRepository<Destination> repository) : base(repository)
        { }

        public void AddDestination(string username, string geolocation, string title, byte[] imageBytes, string description, DateTime stayDate)
        {
            int id = GetFreeId();
            var newItem = new Destination(id, username, geolocation, title, imageBytes, description, stayDate);
            _repository.Add(newItem);
        }

        public void UpdateDestination(int id,
                                      string newGeolocation,
                                      string newTitle,
                                      byte[] newImageBytes,
                                      string newDescription,
                                      DateTime newStayDate)
        {
            var oldItem = FindById(id) ?? throw new InvalidOperationException("Id not found.");
            var newItem = new Destination(id, oldItem.Username, newGeolocation, newTitle, newImageBytes, newDescription, newStayDate);
            Update(id, newItem);
        }
    }
}
