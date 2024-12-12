using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*GROUP MEMBERS: Athule Malgas ,Akhona Mwelase, Zandile Nofemela , Pheliswa Nontsanga, Group 65*/
namespace PhumlaKamnandiSystem.Business
{
  
        public class Manager : Role
        {
            #region Data Members
            private string managerID;
            private string managerPassword;
            #endregion

            #region Properties
            public string ManagerID
            {
                get { return managerID; }
                set { managerID = value; }
            }

            public string ManagerPassword
            {
                get { return managerPassword; }
                set { managerPassword = value; }
            }
            #endregion

            #region Constructor
            public Manager() : base()
            {
                managerID = "";
                managerPassword = "";
            }

            public Manager(string sIDnumber, string sName, string sPhone, string sSurname, string sEmail, string sEmployeeID, string sEmployeePassword, string sManagerID, string sManagerPassword)
                : base()
            {
                managerID = sManagerID;
                managerPassword = sManagerPassword;
            }
            #endregion

            #region ToString Method
            public override string ToString()
            {
                return base.ToString() + " ManagerID: " + managerID;
            }
            #endregion
        }
    
}