using VacationDestinationManager.Domain;
using VacationDestinationManager.Properties;
using VacationDestinationManager.RepositoryLayer;
using VacationDestinationManager.ServiceLayer;
using VacationDestinationManager.Utilities;

namespace VacationDestinationManager
{
    internal class ApplicationManager
    {
        static CsvRepository<Destination, int>? _destinationRepository;
        static CsvRepository<User, string>? _userRepository;

        static DestinationService? _destinationService;
        static UserService? _userService;

        public static void InitializeAll()
        {
            if (_destinationService is not null && _userService is not null)
                return;

            // Initialize destinations from file.
            var destinationCsvPath = Path.Combine(Application.LocalUserAppDataPath, "destinations.csv");
            _destinationRepository = new(destinationCsvPath);
            _destinationRepository.LoadFromFile();
            _destinationService = new(_destinationRepository);

            // Initialize users from file.
            var userCsvPath = Path.Combine(Application.LocalUserAppDataPath, "users.csv");
            _userRepository = new(userCsvPath);
            _userRepository.LoadFromFile();
            _userService = new(_userRepository);

            // Comment this out if you don't want to add sample destinations / users when the file is missing.
            if (!File.Exists(destinationCsvPath))
                AddSampleDestinations();

            if (!File.Exists(userCsvPath))
                AddSampleUsers();
        }

        public static DestinationService GetDestinationService()
        {
            if (_destinationService is null)
                throw new InvalidOperationException("Not initialized.");
            return _destinationService;
        }

        public static UserService GetUserService()
        {
            if (_userService is null)
                throw new InvalidOperationException("Not initialized.");
            return _userService;
        }

        public static void SaveAndCloseAll()
        {
            if (_destinationRepository is null || _userRepository is null)
                throw new InvalidOperationException("Not initialized.");

            _destinationRepository.SaveToFile();
            _userRepository.SaveToFile();
        }

        public static void AddSampleDestinations()
        {
            if (_destinationService is null)
                throw new InvalidOperationException("Not initialized.");

            // Remove existing destinations.
            var ids = _destinationService.GetAll().Select(e => e.Id).ToList();
            ids.ForEach(id => _destinationService.Remove(id));

            // Add sample destinations.
            var destinations = new List<Destination>();

            // Destination 1
            var destination1 = new Destination(
                Id: 1,
                Username: "admin",
                Geolocation: "New York, USA",
                Title: "Exploring the Big Apple",
                Image: Utility.ImageToBytes(Resources._1_new_york),
                Description: "A trip to New York City, exploring the iconic landmarks and enjoying the bustling atmosphere.",
                StayDate: new DateTime(2023, 6, 15)
            );
            destinations.Add(destination1);

            // Destination 2
            var destination2 = new Destination(
                Id: 2,
                Username: "admin",
                Geolocation: "Paris, France",
                Title: "Romantic Getaway in Paris",
                Image: Utility.ImageToBytes(Resources._2_paris),
                Description: "A romantic vacation in the City of Love, visiting the Eiffel Tower, strolling along the Seine, and savoring delicious French cuisine.",
                StayDate: new DateTime(2023, 7, 5)
            );
            destinations.Add(destination2);

            // Destination 3
            var destination3 = new Destination(
                Id: 3,
                Username: "admin",
                Geolocation: "Cape Town, South Africa",
                Title: "Thrilling Safari Experience",
                Image: Utility.ImageToBytes(Resources._3_cape_town),
                Description: "Embarking on an unforgettable safari adventure in Cape Town, exploring the diverse wildlife and breathtaking landscapes.",
                StayDate: new DateTime(2023, 8, 10)
            );
            destinations.Add(destination3);

            // Destination 4
            var destination4 = new Destination(
                Id: 4,
                Username: "admin",
                Geolocation: "Bali, Indonesia",
                Title: "Island Paradise in Bali",
                Image: Utility.ImageToBytes(Resources._4_bali),
                Description: "A tropical escape to Bali, enjoying pristine beaches, lush rice terraces, and immersing in the rich cultural heritage.",
                StayDate: new DateTime(2023, 9, 20)
            );
            destinations.Add(destination4);

            // Destination 5
            var destination5 = new Destination(
                Id: 5,
                Username: "admin",
                Geolocation: "Zermatt, Switzerland",
                Title: "Conquering the Swiss Alps",
                Image: Utility.ImageToBytes(Resources._5_zermatt),
                Description: "An exhilarating mountain adventure in Zermatt, Switzerland, climbing majestic peaks and enjoying breathtaking alpine scenery.",
                StayDate: new DateTime(2023, 10, 8)
            );
            destinations.Add(destination5);

            // Destination 6
            var destination6 = new Destination(
                Id: 6,
                Username: "gigel",
                Geolocation: "Rome, Italy",
                Title: "Journey through Ancient Rome",
                Image: Utility.ImageToBytes(Resources._6_rome),
                Description: "Immersing in the history of Rome, exploring ancient ruins, visiting the Colosseum, and indulging in authentic Italian cuisine.",
                StayDate: new DateTime(2023, 11, 15)
            );
            destinations.Add(destination6);

            // Destination 7
            var destination7 = new Destination(
                Id: 7,
                Username: "gigel",
                Geolocation: "Phuket, Thailand",
                Title: "Relaxing Beach Retreat",
                Image: Utility.ImageToBytes(Resources._7_phuket),
                Description: "Unwinding on the pristine beaches of Phuket, Thailand, enjoying turquoise waters, water sports, and vibrant nightlife.",
                StayDate: new DateTime(2023, 12, 5)
            );
            destinations.Add(destination7);

            // Destination 8
            var destination8 = new Destination(
                Id: 8,
                Username: "gigel",
                Geolocation: "Banff National Park, Canada",
                Title: "Exploring the Canadian Rockies",
                Image: Utility.ImageToBytes(Resources._8_banff_national_park),
                Description: "Discovering the natural beauty of Banff National Park, hiking scenic trails, spotting wildlife, and marveling at stunning mountain landscapes.",
                StayDate: new DateTime(2024, 1, 10)
            );
            destinations.Add(destination8);

            // Destination 9
            var destination9 = new Destination(
                Id: 9,
                Username: "dorel",
                Geolocation: "Kyoto, Japan",
                Title: "Japanese Cultural Immersion",
                Image: Utility.ImageToBytes(Resources._9_kyoto),
                Description: "Immersing in the rich cultural heritage of Kyoto, exploring ancient temples, experiencing traditional tea ceremonies, and enjoying cherry blossoms.",
                StayDate: new DateTime(2024, 2, 20)
            );
            destinations.Add(destination9);

            // Destination 10
            var destination10 = new Destination(
                Id: 10,
                Username: "dorel",
                Geolocation: "Barcelona, Spain",
                Title: "Gastronomic Delights in Barcelona",
                Image: Utility.ImageToBytes(Resources._10_barcelona),
                Description: "Indulging in the culinary delights of Barcelona, savoring tapas, paella, and visiting vibrant food markets like La Boqueria.",
                StayDate: new DateTime(2024, 3, 15)
            );
            destinations.Add(destination10);

            destinations.ForEach(_destinationService.Add);
        }

        public static void AddSampleUsers()
        {
            if (_userService is null)
                throw new InvalidOperationException("Not initialized.");

            // Remove existing users.
            var usernames = _userService.GetAll().Select(u => u.Username).ToList();
            usernames.ForEach(un => _userService.Remove(un));

            // Add sample users.
            var users = new List<User>();

            // User 1
            var user1 = new User(
                Username: "admin",
                PasswordHash: Utility.HashStringSha256("1234")
            );
            users.Add(user1);

            // User 2
            var user2 = new User(
                Username: "gigel",
                PasswordHash: Utility.HashStringSha256("gigi2002")
            );
            users.Add(user2);

            // User 3
            var user3 = new User(
                Username: "dorel",
                PasswordHash: Utility.HashStringSha256("lerod")
            );
            users.Add(user3);

            users.ForEach(_userService.Add);
        }
    }
}
