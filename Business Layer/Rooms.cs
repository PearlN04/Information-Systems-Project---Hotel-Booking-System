using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*GROUP MEMBERS: Athule Malgas ,Akhona Mwelase, Zandile Nofemela , Pheliswa Nontsanga, Group 65*/
namespace PhumlaKamnandiSystem.Business
{
    public class Rooms
    {
        #region Data Members
        public string ID { get; set; }
        private string hotelID;
        private DateTime date;
        private int numRoomsAvailable;
        #endregion

        #region Constructors
        public Rooms()
        {

        }

        public Rooms( string hotelID, DateTime date, int numRoomsAvailable)
        {
                this.hotelID = hotelID;
                this.date = date;
                this.numRoomsAvailable = numRoomsAvailable;

        }

        #endregion

        #region Property Methods
        public string HotelID
        {
                get { return hotelID; }
                set { hotelID = value; }
        }

        public DateTime Date
        {
                get { return date; }
                set { date = value; }
        }

        public int NumRoomsAvailable
        {
                get { return numRoomsAvailable; }
                set { numRoomsAvailable = value; }
        }
        #endregion

    }
}

