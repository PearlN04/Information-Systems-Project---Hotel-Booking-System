using PhumlaKamnandiSystem.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhumlaKamnandiSystem.Data;
using PhumlaKamnandiSystem.PresentationLayer;

namespace PhumlaKamnandiSystem.PresentationLayer
{
    /*GROUP MEMBERS: Athule Malgas ,Akhona Mwelase, Zandile Nofemela , Pheliswa Nontsanga, Group 65*/
    public partial class GuestSearch : Form
    {
        private String hotelID;
        private DateTime CheckIn;
        private DateTime CheckOut;
        private int numberOfGuests;
        private int numberOfRooms;
        private decimal amount;

        public GuestSearch(string hotelId,DateTime checkIn,DateTime checkOut,int numGuests,int numRooms,decimal fullamount)
        {
            InitializeComponent();
            this.hotelID = hotelId;
            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
            this.numberOfGuests = numGuests;
            this.numberOfRooms = numRooms;
            this.amount = fullamount;
        }

        private void button2_Click(object sender, EventArgs e)
        {   

            this.Hide();
            AddNewGuest newGuest = new AddNewGuest(hotelID, CheckIn, CheckOut, numberOfGuests, numberOfRooms, amount);
            newGuest.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string guestID = txtGuestID.Text;
            if (string.IsNullOrEmpty(guestID))
            {
                MessageBox.Show("Please enter guestID");
            }
            else
            {
                BookingSystem bookingSystem = new BookingSystem();
                DataTable guestTable = bookingSystem.GetGuestID(guestID);

                if (guestTable.Rows.Count > 0)
                {
                    DataRow row = guestTable.Rows[0];

                    string guestId = Convert.ToString(row["GuestID"]);
                    string name = Convert.ToString(row["Name"]);
                    string surname = Convert.ToString(row["Surname"]);
                    string phone = Convert.ToString(row["Phone"]);
                    string idNumber = Convert.ToString(row["IDNumber"]);
                    string email = Convert.ToString(row["Email"]);
                    string address = Convert.ToString(row["Address"]);

                    MessageBox.Show(name);

                    ExistingGuest existingGuest = new ExistingGuest(guestID,name,surname,phone,idNumber,email,address,hotelID, CheckIn, CheckOut, numberOfGuests,  numberOfRooms, amount);
                    this.Hide();
                    existingGuest.Show();
                }
                else
                {
                    Console.WriteLine("Guest not found.");
                }
            }
        }
    }
}
