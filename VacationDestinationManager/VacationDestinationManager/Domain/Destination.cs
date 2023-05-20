namespace VacationDestinationManager.Domain
{
    internal record Destination(int Id,
                                string Username,
                                string Geolocation,
                                string Title,
                                byte[] Image,
                                string Description,
                                DateTime StayDate) : IEntity
    { }
}
