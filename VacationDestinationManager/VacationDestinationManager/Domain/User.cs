namespace VacationDestinationManager.Domain
{
    internal record User(string Username,
                         byte[] PasswordHash) : IEntity<string>
    {
        public string GetKey()
            => Username;
    }
}
