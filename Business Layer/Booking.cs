using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*GROUP MEMBERS: Athule Malgas ,Akhona Mwelase, Zandile Nofemela , Pheliswa Nontsanga, Group 65*/
namespace PhumlaKamnandiSystem.Business
{
    public class Booking
    {
        #region Data Members
        private int bookingID;
        private string hotelID;
        private string guestID;
        private int numOfGuests;
        private DateTime checkInDate;
        private DateTime checkOutDate;
        private int numberOfRooms;
        private string paymentStatus;
        private decimal amount;
        #endregion

        #region Constructor
        public Booking() { }

        public Booking(int bookingID, string guestID, string hotelID, DateTime checkInDate, DateTime checkOutDate, int numberOfRooms, int numOfGuests, string paymentStatus, decimal amount)
        {
            this.bookingID = bookingID;
            this.guestID = guestID;
            this.hotelID = hotelID;
            this.numOfGuests = numOfGuests;
            this.checkInDate = checkInDate;
            this.checkOutDate = checkOutDate;
            this.numberOfRooms = numberOfRooms;
            this.paymentStatus = paymentStatus;
            this.amount = amount;
        }
        #endregion

        #region Property Methods
        public int BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }

        public string HotelID
        {
            get { return hotelID; }
            set { hotelID = value; }
        }

        public string GuestID
        {
            get { return guestID; }
            set { guestID = value; }
        }

        public int NumOfGuests
        {
            get { return numOfGuests; }
            set { numOfGuests = value; }
        }

        public DateTime CheckInDate
        {
            get { return checkInDate; }
            set { checkInDate = value; }
        }

        public DateTime CheckOutDate
        {
            get { return checkOutDate; }
            set { checkOutDate = value; }
        }

        public int NumberOfRooms
        {
            get { return numberOfRooms; }
            set { numberOfRooms = value; }
        }
        public string PaymentStatus
        {
            get { return paymentStatus; }
            set { paymentStatus = value; }
        }
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        #endregion
    }
}




