using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*GROUP MEMBERS: Athule Malgas ,Akhona Mwelase, Zandile Nofemela , Pheliswa Nontsanga, Group 65*/
namespace PhumlaKamnandiSystem.Business
{
    public class Employee:Person
    {
        #region Data Members
        private string employeeID;
        private string password;
        public Role role;
        private string hotelID;
        #endregion

        #region constructor
        public Employee(Role.RoleType roleValue)
        {
            switch (roleValue)
            {
                case Role.RoleType.NoRole:
                    role = new Role();
                    break;
                case Role.RoleType.Receptionist:
                    role = new Receptionist();
                    break;
                case Role.RoleType.Manager:
                    role = new Manager();
                    break;
            }
        }
        #endregion

        #region Property methods

        public string HotelID {
            get; set; 
        }
        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        #endregion

    }
}
