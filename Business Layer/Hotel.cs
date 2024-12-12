using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using PhumlaKamnandiSystem.Data;
using PhumlaKamnandiSystem.PresentationLayer;

/*GROUP MEMBERS: Athule Malgas ,Akhona Mwelase, Zandile Nofemela , Pheliswa Nontsanga, Group 65*/
namespace PhumlaKamnandiSystem.Business
{
    public  class Hotel
    {

        #region Data Members
        public string hotelID;
        public string hotelName;
        public string location;
        public string phone;
        public string email;
        public decimal rate;
        public string hotelType;
        public int capacity;
        #endregion

        #region Constructor
        public Hotel()
        {
        }

        public Hotel(string hotelId, string hotelName, string location, string email, decimal rate, string hotelType,int capacity)
          
        { 
            this.hotelID = hotelId;
            this.hotelName = hotelName;
            this.location = location;
            this.email = email;
            this.rate = rate;
            this.hotelType = hotelType;
            this.capacity = capacity;
           
        }
        #endregion

        #region Property Methods
        public string HotelID
        {
            get { return hotelID; }
            set { hotelID = value; }
        }

        public string HotelName
        {
            get { return hotelName; }
            set { hotelName = value; }

        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public string Email
        {
            get;set;
        }

        public decimal Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public string HotelType
        {
            get;set;
        }
        #endregion

        #region Methods
        public Employee Manager { get; set; }
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();

        #endregion




        #region ToString Method
        public override string ToString()
        {
            return  "Hotel: " + this.hotelName + " Location: " +this.location +" Phone: " +this.phone +"Email: " +this.email +"Rate:" +this.rate;
        }
        #endregion
    }
}
