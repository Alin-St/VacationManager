using VacationDestinationManager.Domain;
using VacationDestinationManager.RepositoryLayer;

namespace VacationDestinationManager.ServiceLayer
{
    internal class UserService : EntityService<User, string>
    {
        public UserService(IRepository<User, string> repository) : base(repository)
        { }

        public void AddUser(string username, byte[] passwordHash)
        {
            var newUser = new User(username, passwordHash);
            _repository.Add(newUser);
        }

        public void UpdateUser(string username, byte[] newPasswordHash)
        {
            var newUser = new User(username, newPasswordHash);
            Update(username, newUser);
        }
    }
}
