using VacationDestinationManager.Domain;
using VacationDestinationManager.RepositoryLayer;
using VacationDestinationManager.ServiceLayer;

namespace VacationDestinationManager
{
    internal class ApplicationManager
    {
        static DestinationCsvRepository? _destinationRepository;
        static DestinationService? _destinationService;

        public static void InitializeAll()
        {
            if (_destinationService is not null)
                return;

            _destinationRepository = new DestinationCsvRepository(Path.Combine(Application.LocalUserAppDataPath, "destinations.csv"));
            _destinationRepository.LoadFromFile();
            _destinationService = new DestinationService(_destinationRepository);
        }

        public static DestinationService GetDestinationService()
        {
            if (_destinationService is null)
                throw new InvalidOperationException("Not initialized.");
            return _destinationService;
        }

        public static void SaveAndCloseAll()
        {
            if (_destinationRepository is null)
                throw new InvalidOperationException("Not initialized.");
            _destinationRepository.SaveToFile();
        }
    }
}
