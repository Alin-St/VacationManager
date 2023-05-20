using VacationDestinationManager.Domain;

namespace VacationDestinationManager.RepositoryLayer
{
    internal class DestinationCsvRepository : CsvRepository<Destination>
    {
        public DestinationCsvRepository(string filename) : base(filename, PropertyListToDestination, DestinationToPropertyList)
        { }

        public static Destination PropertyListToDestination(List<string> properties)
        {
            return new Destination(
                int.Parse(properties[0]),
                properties[1],
                properties[2],
                properties[3],
                Array.Empty<byte>(),
                properties[5],
                DateTime.Parse(properties[6]));
        }

        public static List<string> DestinationToPropertyList(Destination destination)
        {
            return new string[]
            {
                destination.Id.ToString(),
                destination.Username,
                destination.Geolocation,
                destination.Title,
                "",
                destination.Description,
                destination.StayDate.ToString(),
            }.ToList();
        }
    }
}
