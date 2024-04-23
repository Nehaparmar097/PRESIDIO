
using System;
using VideoStoreManagmentModelLibrary;
using VideoStoreManagmentBLLibrary;
//using VideoStoreManagmentDALLibrary;
using CustomerStoreManagmentDALLibrary;
//using CustomerStoreManagmentDALLibrary;

namespace VideoStoreManagment
{
    internal class Program
    {
        
        static void DisplayMainMenu()
        {
            Console.WriteLine("1. Add Video");
            Console.WriteLine("2. Add Customer");
            Console.WriteLine("3. Show All Videos");
            Console.WriteLine("4. Rent Video (Customer)");
            Console.WriteLine("5. Exit");
        }

        static int GetMenuChoice()
        {
            Console.Write("\nEnter your choice: ");
            return int.Parse(Console.ReadLine());
        }

        static void AddVideo(IVideoService videoService)
        {
            Console.WriteLine("Enter Video details:");
            Console.WriteLine("Video ID: ");
            int videoId = int.Parse(Console.ReadLine());
            Console.WriteLine("Title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Genre: ");
            string genre = Console.ReadLine();
            Console.WriteLine("Description: ");
            string description = Console.ReadLine();
            Console.WriteLine("Availability Status (true/false): ");
            bool availabilityStatus = bool.Parse(Console.ReadLine());
            Console.WriteLine("Rental Price: ");
            int rentalPrice = int.Parse(Console.ReadLine());

            var video = new Video(videoId, title, genre, description, availabilityStatus, rentalPrice);
            videoService.AddVideo(video);
            Console.WriteLine("Video added successfully.");
        }

        static void AddCustomer(ICustomerService customerService)
        {
            Console.WriteLine("Enter Customer details:");
            Console.WriteLine("Customer ID: ");
            int customerId = int.Parse(Console.ReadLine());
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();

            var customer = new Customer(customerId, name, age, email);
            customerService.AddCustomer(customer);
            Console.WriteLine("Customer added successfully.");
        }

        static void ShowAllVideos(IVideoService videoService)
        {
            var allVideos = videoService.GetAllVideos();
            Console.WriteLine("\nAll Videos:");
            foreach (var v in allVideos)
            {
                Console.WriteLine($"ID: {v.VideoId}, Title: {v.VideoTitle}, Genre: {v.VideoGenre}");
            }
        }

        static void RentVideo(IVideoService videoService, ICustomerService customerService)
        {
            Console.Write("Enter Customer ID: ");
            int customerId = int.Parse(Console.ReadLine());
            Console.Write("Enter Video ID to rent: ");
            int videoId = int.Parse(Console.ReadLine());

            var customer = customerService.GetCustomerById(customerId);
            if (customer != null)
            {
                var video = videoService.GetAllVideos().FirstOrDefault(v => v.VideoId == videoId);
                if (video != null)
                {
                    Console.WriteLine($"Renting video '{video.VideoTitle}' for customer '{customer.Name}'.");
                     Console.WriteLine(DateTime.Now);
                }
                else
                {
                    Console.WriteLine($"Video with ID '{videoId}' not found.");
                }
            }
            else
            {
                Console.WriteLine($"Customer with ID '{customerId}' not found.");
            }
        }
            static void Main(string[] args)
            {
                var videoRepo = new VideoStoreRepo();
                var customerRepo = new UserRepo();

                var videoService = new VideoService(videoRepo.GetAll());
                var customerService = new CustomerService(customerRepo.GetAll());

                bool exit = false;
                while (!exit)
                {
                    DisplayMainMenu();
                    int choice = GetMenuChoice();

                    switch (choice)
                    {
                        case 1:
                            AddVideo(videoService);
                            break;
                        case 2:
                            AddCustomer(customerService);
                            break;
                        case 3:
                            ShowAllVideos(videoService);
                            break;
                        case 4:
                            RentVideo(videoService, customerService);
                            break;
                        case 5:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }

        }

    }



