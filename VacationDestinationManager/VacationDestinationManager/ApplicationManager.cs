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

            var destinationCsvPath = Path.Combine(Application.LocalUserAppDataPath, "destinations.csv");
            _destinationRepository = new DestinationCsvRepository(destinationCsvPath);

            _destinationRepository.LoadFromFile();
            _destinationService = new DestinationService(_destinationRepository);

            // Comment this out if you don't want to add sample destinations when the file is missing.
            if (!File.Exists(destinationCsvPath))
                AddSampleDestinations();
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

        public static void AddSampleDestinations()
        {
            if (_destinationService is null)
                throw new InvalidOperationException("Not initialized.");

            var ids = _destinationService.GetAll().Select(e => e.Id).ToList();
            ids.ForEach(id => _destinationService.Remove(id));

            var destinations = new List<Destination>();

            // Destination 1
            var destination1 = new Destination(
                Id: 1,
                Username: "john_doe",
                Geolocation: "New York, USA",
                Title: "Exploring the Big Apple",
                Image: Array.Empty<byte>(),
                Description: "A trip to New York City, exploring the iconic landmarks and enjoying the bustling atmosphere.",
                StayDate: new DateTime(2023, 6, 15)
            );
            destinations.Add(destination1);

            // Destination 2
            var destination2 = new Destination(
                Id: 2,
                Username: "traveler123",
                Geolocation: "Paris, France",
                Title: "Romantic Getaway in Paris",
                Image: Array.Empty<byte>(),
                Description: "A romantic vacation in the City of Love, visiting the Eiffel Tower, strolling along the Seine, and savoring delicious French cuisine.",
                StayDate: new DateTime(2023, 7, 5)
            );
            destinations.Add(destination2);

            // Destination 3
            var destination3 = new Destination(
                Id: 3,
                Username: "adventure_junkie",
                Geolocation: "Cape Town, South Africa",
                Title: "Thrilling Safari Experience",
                Image: Array.Empty<byte>(),
                Description: "Embarking on an unforgettable safari adventure in Cape Town, exploring the diverse wildlife and breathtaking landscapes.",
                StayDate: new DateTime(2023, 8, 10)
            );
            destinations.Add(destination3);

            // Destination 4
            var destination4 = new Destination(
                Id: 4,
                Username: "wanderlust_adventurer",
                Geolocation: "Bali, Indonesia",
                Title: "Island Paradise in Bali",
                Image: Array.Empty<byte>(),
                Description: "A tropical escape to Bali, enjoying pristine beaches, lush rice terraces, and immersing in the rich cultural heritage.",
                StayDate: new DateTime(2023, 9, 20)
            );
            destinations.Add(destination4);

            // Destination 5
            var destination5 = new Destination(
                Id: 5,
                Username: "mountain_explorer",
                Geolocation: "Zermatt, Switzerland",
                Title: "Conquering the Swiss Alps",
                Image: Array.Empty<byte>(),
                Description: "An exhilarating mountain adventure in Zermatt, Switzerland, climbing majestic peaks and enjoying breathtaking alpine scenery.",
                StayDate: new DateTime(2023, 10, 8)
            );
            destinations.Add(destination5);

            // Destination 6
            var destination6 = new Destination(
                Id: 6,
                Username: "history_buff",
                Geolocation: "Rome, Italy",
                Title: "Journey through Ancient Rome",
                Image: Array.Empty<byte>(),
                Description: "Immersing in the history of Rome, exploring ancient ruins, visiting the Colosseum, and indulging in authentic Italian cuisine.",
                StayDate: new DateTime(2023, 11, 15)
            );
            destinations.Add(destination6);

            // Destination 7
            var destination7 = new Destination(
                Id: 7,
                Username: "beachlover",
                Geolocation: "Phuket, Thailand",
                Title: "Relaxing Beach Retreat",
                Image: Array.Empty<byte>(),
                Description: "Unwinding on the pristine beaches of Phuket, Thailand, enjoying turquoise waters, water sports, and vibrant nightlife.",
                StayDate: new DateTime(2023, 12, 5)
            );
            destinations.Add(destination7);

            // Destination 8
            var destination8 = new Destination(
                Id: 8,
                Username: "nature_enthusiast",
                Geolocation: "Banff National Park, Canada",
                Title: "Exploring the Canadian Rockies",
                Image: Array.Empty<byte>(),
                Description: "Discovering the natural beauty of Banff National Park, hiking scenic trails, spotting wildlife, and marveling at stunning mountain landscapes.",
                StayDate: new DateTime(2024, 1, 10)
            );
            destinations.Add(destination8);

            // Destination 9
            var destination9 = new Destination(
                Id: 9,
                Username: "cultural_explorer",
                Geolocation: "Kyoto, Japan",
                Title: "Japanese Cultural Immersion",
                Image: Array.Empty<byte>(),
                Description: "Immersing in the rich cultural heritage of Kyoto, exploring ancient temples, experiencing traditional tea ceremonies, and enjoying cherry blossoms.",
                StayDate: new DateTime(2024, 2, 20)
            );
            destinations.Add(destination9);

            // Destination 10
            var destination10 = new Destination(
                Id: 10,
                Username: "foodie_traveler",
                Geolocation: "Barcelona, Spain",
                Title: "Gastronomic Delights in Barcelona",
                Image: Array.Empty<byte>(),
                Description: "Indulging in the culinary delights of Barcelona, savoring tapas, paella, and visiting vibrant food markets like La Boqueria.",
                StayDate: new DateTime(2024, 3, 15)
            );

            destinations.ForEach(d => _destinationService.Add(d));
        }
    }
}
