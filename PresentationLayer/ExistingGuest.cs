using PhumlaKamnandiSystem.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PhumlaKamnandiSystem.PresentationLayer
{
    /*GROUP MEMBERS: Athule Malgas ,Akhona Mwelase, Zandile Nofemela , Pheliswa Nontsanga, Group 65*/
    public partial class ExistingGuest : Form
    {
        string guestId;
        string name;
        string surname;
        string phone;
        string idNumber;
        string email;
        string address;
        private String hotelID;
        private DateTime CheckIn;
        private DateTime CheckOut;
        private int numberOfGuests;
        private int numberOfRooms;
        private decimal amount;
        public ExistingGuest(string guestId, string name, string surname,string phone,string idNumber,string email,string address, string hotelId, DateTime checkIn, DateTime checkOut, int numGuests, int numRooms, decimal fullamount)
        {
            InitializeComponent();
            this.guestId = guestId;
            this.name = name;
            this.surname = surname;
            this.phone = phone;
            this.idNumber = idNumber;
            this.email = email;
            this.address = address;
            this.hotelID = hotelId;
            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
            this.numberOfGuests = numGuests;
            this.numberOfRooms = numRooms;
            this.amount = fullamount;
            txtGuestID.Text = guestId;
            txtName.Text = name;
            txtSurname.Text = surname;
            txtPhone.Text = phone;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MakeBooking makeBooking = new MakeBooking(guestId, name, surname, phone, idNumber, email, address, hotelID, CheckIn, CheckOut, numberOfGuests, numberOfRooms,amount);
            this.Hide();
            makeBooking.Show();
        }
    }
}
