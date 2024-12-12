using PhumlaKamnandiSystem.PresentationLayer;
using System;

/*GROUP MEMBERS: Athule Malgas ,Akhona Mwelase, Zandile Nofemela , Pheliswa Nontsanga, Group 65*/
namespace PhumlaKamnandiSystem.Business

{
    public class Receptionist : Role
    {
        #region data members
        public string hotelID;
        #endregion

        #region Constructor
        public Receptionist() : base() { }

        public Receptionist(string name, string surname, string email, string phonenumber, string idNo, string employeeID, string password,string hotelID)
            : base()
        {
            this.hotelID = hotelID;
        }
        #endregion

        #region Property methods

        public string HotelID
        {
            get { return hotelID; }
            set { hotelID = value; }
        }
        #endregion

        #region ToString Override
        public override string ToString()
        {
            return base.ToString() + " Role: Receptionist" +"Hotel: " +this.hotelID;
        }
        #endregion
    }
}
