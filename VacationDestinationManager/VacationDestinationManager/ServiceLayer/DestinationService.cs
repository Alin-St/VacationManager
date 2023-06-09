using VacationDestinationManager.Domain;
using VacationDestinationManager.RepositoryLayer;

namespace VacationDestinationManager.ServiceLayer
{
    internal class DestinationService : EntityService<Destination, int>
    {
        public DestinationService(IRepository<Destination, int> repository) : base(repository)
        { }

        public void AddDestination(string username, string geolocation, string title, byte[] imageBytes, string description, DateTime stayDate)
        {
            int id = this.GetFreeId();
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
            var oldItem = FindByKey(id) ?? throw new InvalidOperationException("Id not found.");
            var newItem = new Destination(id, oldItem.Username, newGeolocation, newTitle, newImageBytes, newDescription, newStayDate);
            Update(id, newItem);
        }
    }
}
