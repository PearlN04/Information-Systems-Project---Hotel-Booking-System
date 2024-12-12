using System;

/*GROUP MEMBERS: Athule Malgas ,Akhona Mwelase, Zandile Nofemela , Pheliswa Nontsanga, Group 65*/
namespace PhumlaKamnandiSystem.Business
{
    public class Guest:Person
    {
        #region Data Members
        private string guestID;
        private string guestAddress;
        private int age;
        private String idNum;
        private int id;
       
        #endregion

        #region Property Methods
        public string GuestID
        {
            get { return guestID; }
            set { guestID = value; }
        }

        public String GuestAddress
        {
            get { return guestAddress; }
            set { guestAddress = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public String IdNum
        {
            get { return idNum; }
            set { idNum = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        #endregion



        #region Constructor
        public Guest() 
        {
         
        }

        public Guest(string sIDnumber, string sName, string sPhone, string sSurname, string sEmail, string guestID, string guestAddress, int age)
            : base(sIDnumber, sName, sPhone, sSurname, sEmail)
       
        {
      
            this.guestID = guestID;
            this.guestAddress = guestAddress;
            this.age = age;
        }
        #endregion

        #region ToString Method
        public override string ToString()
        {
            return base.ToString() + "GuestID: " + guestID + " Address: " + guestAddress;
        }
        #endregion
    }
}
