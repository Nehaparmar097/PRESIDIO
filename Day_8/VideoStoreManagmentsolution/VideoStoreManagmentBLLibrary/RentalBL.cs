using static VideoStoreManagmentBLLibrary.RentalBL;
using VideoStoreManagmentModelLibrary;

namespace VideoStoreManagmentBLLibrary
{
      // File: RentalManager.cs in the RentalBL library
        public class RentalBL : IRentalService
        {
            private readonly List<Video> videos;
            private readonly List<Customer> customers;
            private readonly List<RentalRecord> rentalRecords;

        public RentalBL()
        {
        }

        public RentalBL(List<Video> videos, List<Customer> customers, List<RentalRecord> rentalRecords)
            {
                this.videos = videos;
                this.customers = customers;
                this.rentalRecords = rentalRecords;
            }

            public void RentVideo(int customerId, int videoId)
            {
                var video = videos.FirstOrDefault(v => v.VideoId == videoId && v.AvailabilityStatus);
                if (video == null)
                {
                    Console.WriteLine("Video is not noww available.");
                    return;
                }

                video.AvailabilityStatus = false;  
                var rentalRecord = new RentalRecord
                {
                    CustomerId = customerId,
                    VideoId = videoId,
                    RentalDate = DateTime.Now,
                    DueDate = DateTime.Now.AddDays(7)  // Assuming  7-day rental period for videos
                };
                rentalRecords.Add(rentalRecord);
                Console.WriteLine("Rental processed successfully.");
            }

            public void ReturnVideo(int customerId, int videoId)
            {
                var rentalRecord = rentalRecords.FirstOrDefault(r => r.VideoId == videoId && r.CustomerId == customerId && !r.ReturnDate.HasValue);
                if (rentalRecord == null)
                {
                    Console.WriteLine("No matching rental record found.");
                    return;
                }

                rentalRecord.ReturnDate = DateTime.Now;
                var video = videos.FirstOrDefault(v => v.VideoId == videoId);
                if (video != null)
                {
                    video.AvailabilityStatus = true;
                }

               
                if (DateTime.Now > rentalRecord.DueDate)
                {
                    var daysLate = (DateTime.Now - rentalRecord.DueDate).Days;
                    rentalRecord.LateFee = daysLate * 2.00m; 
                    Console.WriteLine($"Video returned with a late fee of ${rentalRecord.LateFee}.");
                }
                else
                {
                    Console.WriteLine("Video returned on time. No late fee.");
                }
            }
        }

    }

