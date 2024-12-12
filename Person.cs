using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PhumlaKamnandiSystem
{
    /*GROUP MEMBERS: Athule Malgas ,Akhona Mwelase, Zandile Nofemela , Pheliswa Nontsanga, Group 65*/
    public class Person
    {
        #region data members
        private string Idnumber, name,surname, phonenumber , email;
        #endregion

        #region Properties
        public string ID
        {
            get { return Idnumber; }
            set { Idnumber = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }

        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Telephone
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }
        #endregion

        #region Construtor
        public Person()
        {
            
            
        }

        public Person(string sIDnumber, string sName, string sPhone , string sSurname , string sEmail)
        {
            Idnumber = sIDnumber;
            name = sName;
            surname = sSurname;
            phonenumber   = sPhone;
            Email = sEmail;
            

        }
        #endregion

        #region ToStringMethod
        public override string ToString()
        {
            return name + ' ' + surname + ' ' + phonenumber + ' ' + email + ' ' ;
        }

        #endregion
    }
}

