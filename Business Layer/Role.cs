using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*GROUP MEMBERS: Athule Malgas ,Akhona Mwelase, Zandile Nofemela , Pheliswa Nontsanga, Group 65*/
namespace PhumlaKamnandiSystem.Business
{
    public class Role
    {
        #region Data Members
        public enum RoleType
        {
            NoRole = 0,
            Receptionist = 1,
            Manager = 2
        }
        protected RoleType roleVal;
        protected string description;

        #endregion

        #region Property Methods
       
        public RoleType getRoleValue
        {
            get { return roleVal; }
            set { roleVal = value; }
        }
        public string getDescription
        {
            get { return description; }
            set { description = value; }
        }
        #endregion

        #region Constructor
        public Role()
        {
            roleVal = Role.RoleType.NoRole;
            description = "No role";
        }
        #endregion

    }
}
