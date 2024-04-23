using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
namespace VideoStoreManagmentModelLibrary
{
    public class RentalRecord
    {
       
            public int CustomerId { get; set; }
            public int VideoId { get; set; }
            public DateTime RentalDate { get; set; }
            public DateTime DueDate { get; set; }
            public DateTime? ReturnDate { get; set; }
            public decimal LateFee { get; set; }

        public RentalRecord()
        {
        }
       //paramitarized constructor
        public RentalRecord(int customerId, int videoId, DateTime rentalDate, DateTime dueDate, DateTime? returnDate, decimal lateFee)
        {
            CustomerId = customerId;
            VideoId = videoId;
            RentalDate = rentalDate;
            DueDate = dueDate;
            ReturnDate = returnDate;
            LateFee = lateFee;
        }
    }
}
