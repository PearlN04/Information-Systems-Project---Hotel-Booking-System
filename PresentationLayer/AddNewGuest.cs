using PhumlaKamnandiSystem.Business;
using PhumlaKamnandiSystem.Data;
using PhumlaKamnandiSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PhumlaKamnandiSystem.PresentationLayer
{
    /*GROUP MEMBERS: Athule Malgas ,Akhona Mwelase, Zandile Nofemela , Pheliswa Nontsanga, Group 65*/
    public partial class AddNewGuest : Form
    {

        private String hotelID;
        private DateTime CheckIn;
        private DateTime CheckOut;
        private int numberOfGuests;
        private int numberOfRooms;
        private decimal amount;
        String guestID;
        String paymentStatus;

        public AddNewGuest(string hotelId, DateTime checkIn, DateTime checkOut, int numGuests, int numRooms, decimal fullamount)
        {
            InitializeComponent();
            this.hotelID = hotelId;
            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
            this.numberOfGuests = numGuests;
            this.numberOfRooms = numRooms;
            this.amount = fullamount;
             txtGuestID.ReadOnly = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String guestName = txtName.Text;
            String guestSurname = txtSurname.Text;
            String idNO = txtIDNumber.Text;
            String email = txtEmail.Text;
            String phone = txtPhone.Text;
            String address = txtAddress.Text;
            String guestID = txtGuestID.Text;
            MakeBooking makeBooking = new MakeBooking(guestID, guestName, guestSurname, phone,idNO, email,address, hotelID, CheckIn, CheckOut, numberOfGuests, numberOfRooms, amount);
            makeBooking.Show();
            this.Hide();
        }

        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            
            bool validguest = true;
            String guestName = txtName.Text;
            String guestSurname = txtSurname.Text;
            String idNO = txtIDNumber.Text;
            String email = txtEmail.Text;
            String phone = txtPhone.Text;
            String address = txtAddress.Text;
            String guestID = txtGuestID.Text;

            if (string.IsNullOrEmpty(guestName))
            {
                MessageBox.Show("Please enter name");
                validguest = false;
            }
            if (string.IsNullOrEmpty(guestSurname))
            {
                MessageBox.Show("Surname required");
                validguest = false;
            }
            if (string.IsNullOrEmpty(idNO))
            {
                MessageBox.Show("ID Number required");
                validguest = false;
            }
            else if (idNO.Length != 13)
            {
                MessageBox.Show("ID Number must be exactly 13 digits.");
                validguest = false;

            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email is required");
                validguest = false;
            }
            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Phone number is required");
                validguest = false;
            }
            else if (phone.Length != 10)
            {
                MessageBox.Show("Phone number must be exactly 10 digits.");
                validguest = false;

            }

            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Address is required");
                validguest = false;

            }

            if (string.IsNullOrEmpty(guestID))
            {
                MessageBox.Show("Guest ID is required , click generate guestID to generate guestID");
                validguest = false;
            }

            if (validguest == true)
            {
                
                BookingSystem bookingSystem = new BookingSystem();
               
                string responseMessage = bookingSystem.insertGuest(guestID, guestName,guestSurname,phone,idNO, email, address);
                MessageBox.Show(responseMessage);
            }

        }
    

        private void btnGenerateGuestID_Click(object sender, EventArgs e)
        {
            bool validDetails = true;
            String guestName = txtName.Text;
            String guestSurname = txtSurname.Text;
            String idNO = txtIDNumber.Text;
            if (string.IsNullOrEmpty(guestName))
            {
                MessageBox.Show("Please enter name");
                validDetails = false;
            }
            if (string.IsNullOrEmpty(guestSurname))
            {
                MessageBox.Show("Surname required");
                validDetails = false;
            }
            if (string.IsNullOrEmpty(idNO))
            {
                MessageBox.Show("ID Number required");
                validDetails = false;
            }
            else if (idNO.Length != 13)
            {
                MessageBox.Show("ID Number must be exactly 13 digits.");
                validDetails = false;
            }

            if (validDetails == true) {
                guestID = guestName.Substring(0, 1)  +idNO + guestSurname.Substring(0, 1);
                txtGuestID.Text = guestID;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnMakeBooking.Enabled = false;
           
            txtEmail.Clear();
            txtGuestID.Clear();
            txtSurname.Clear();
            txtIDNumber.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
         
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GuestSearch guestSearch = new GuestSearch(hotelID, CheckIn, CheckOut, numberOfGuests, numberOfRooms, amount);
            guestSearch.Show();
            this.Hide();
        }
    }
}
