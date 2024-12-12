using PhumlaKamnandiSystem.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhumlaKamnandiSystem.PresentationLayer
{
    /*GROUP MEMBERS: Athule Malgas ,Akhona Mwelase, Zandile Nofemela , Pheliswa Nontsanga, Group 65*/
    public partial class Reservation : Form
    {
        private Form1 form1;
        public string hotelID;

        #region Form Initialization
        public Reservation(string htlid)
        {
            InitializeComponent();
            btnMakeReservation.Enabled = false;
            hotelID = htlid;
            lblHotelName.Text = "Hotel ID:" + htlid;

        }
        #endregion





        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnMakeReservation.Enabled = false;
            rtxtRoomDetails.Clear();
            numericNumGuests.Value = 0;
            numericNumRooms.Value = 0;
            dtpCheckIn.Value = DateTime.Now;
            dtpCheckOut.Value = DateTime.Now;
            numericUD5years.Value = 0;
            numericUpDownAdult.Value = 0;
            numericUpDownSixTo16.Value = 0;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool validData = true;
            if (numericNumGuests.Value == 0)
            {
                MessageBox.Show("Please enter number of guests");
                validData = false;
            }

            if (numericNumRooms.Value == 0)
            {
                MessageBox.Show("Please enter number of rooms");
                validData = false;
            }

            int numYoungerthanFive = (int)numericUD5years.Value;
            int numYoungerthan16 = (int)numericUpDownSixTo16.Value;
            int numAdults = (int)numericUpDownAdult.Value;
            int numGuests = (int)numericNumGuests.Value;
            int numRooms = (int)numericNumRooms.Value;
            DateTime Checkin = DateTime.Parse(dtpCheckIn.Text);
            DateTime Checkout = DateTime.Parse(dtpCheckOut.Text);

            int totalExtraGuests = numYoungerthan16 + numYoungerthanFive + numAdults;

            if ((numGuests > 1) && (totalExtraGuests != numGuests))
            {
                MessageBox.Show("Number of guests added do not match initial number of guests added,click add guests button to add details");
                validData = false;
            }

            if ((numRooms == 1) && (numGuests > 4))
            {
                MessageBox.Show("Number of guests in 1 room can't exceed 4");
                validData = false;
            }
            else if (Checkout < Checkin)
            {
                MessageBox.Show("Check-out date must not be earlier than the check-in date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop further execution
                validData = false;
            }
            
            if (validData) {
                rtxtRoomDetails.Enabled = true;
                BookingSystem bookingSystem = new BookingSystem();
                string response = bookingSystem.RoomAvailability(hotelID, numRooms, Checkin, Checkout);
                decimal rate = bookingSystem.GetHotelAmount(hotelID);
                decimal totalFee = bookingSystem.TotalFee(Checkin, hotelID);
                decimal bookingAmount = bookingSystem.getTotalAmount(Checkin, hotelID,numGuests,numRooms,numYoungerthanFive,numYoungerthan16,numAdults);

                if (response == "")
                {
                    rtxtRoomDetails.Text = "Reservation Details:";
                    rtxtRoomDetails.AppendText("\n====================================================");
                    rtxtRoomDetails.AppendText("\nCheck-In date:" + Checkin.ToString("yyyy/MM/dd"));
                    rtxtRoomDetails.AppendText("\nCheck-Out date:" + Checkout.ToString("yyyy/MM/dd"));
                    rtxtRoomDetails.AppendText("\nNumber of guests:" + numGuests);
                    rtxtRoomDetails.AppendText("\nNumber of rooms to be booked: " + numRooms);
                    if (numericUD5years.Value > 0)
                    {
                        rtxtRoomDetails.AppendText("\nNumber of kids under the age of 5:" + numYoungerthanFive);
                    }
                    if (numericUpDownSixTo16.Value > 0)
                    {
                        rtxtRoomDetails.AppendText("\nNumber of children between 6 and 16:" + numYoungerthan16);
                    }
                    if (numericUpDownSixTo16.Value > 0)
                    {
                        rtxtRoomDetails.AppendText("\nNumber of adult guests:" + numAdults);
                    }
                    btnMakeReservation.Enabled = true;
                }
                else
                {
                    MessageBox.Show(response);
                }
            }



        }

        private void btnAdditionalGuestDetails_Click(object sender, EventArgs e)
        {
            if (numericNumGuests.Value < 2)
            {
                MessageBox.Show("Can't add extra guests details, number of guests has to be 2 or more");
            }
            else
            {
                pnlExtralGuests.Visible = true;
                numericUD5years.Visible = true;
                numericUpDownSixTo16.Visible = true;
                numericUpDownAdult.Visible = true;
                btnDone.Visible = true;
                lblGuestExtra.Visible = true;
                btnCancelGuests.Visible = true;
                lblfive.Visible = true;
                lblSix.Visible = true;
                lblAdult.Visible = true;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            int numYoungerthanFive = (int)numericUD5years.Value;
            int numYoungerthan16 = (int)numericUpDownSixTo16.Value;
            int numAdults = (int)numericUpDownAdult.Value;
            int numGuests = (int)numericNumGuests.Value;

            int totalExtraGuests = numYoungerthan16 + numYoungerthanFive + numAdults;

            if (totalExtraGuests != numGuests)
            {
                MessageBox.Show("Number of guests added do not match initial number of guests added");
            }
            else
            {
                MessageBox.Show("Guest Details added");
                pnlExtralGuests.Visible = false;
                numericUD5years.Visible = false;
                numericUpDownSixTo16.Visible = false;
                numericUpDownAdult.Visible = false;
                btnDone.Visible = false;
                lblGuestExtra.Visible = false;
                btnCancelGuests.Visible = false;
                lblfive.Visible = false;
                lblSix.Visible = false;
                lblAdult.Visible = false;
            }
        }

        private void btnCancelGuests_Click(object sender, EventArgs e)
        {
            pnlExtralGuests.Visible = false;
            numericUD5years.Visible = false;
            numericUpDownSixTo16.Visible = false;
            numericUpDownAdult.Visible = false;
            btnDone.Visible = false;
            lblGuestExtra.Visible = false;
            lblfive.Visible = false;
            lblSix.Visible = false;
            lblAdult.Visible = false;
        }

        private void lblHotelName_Click(object sender, EventArgs e)
        {

          
        }

        private void btnMakeReservation_Click(object sender, EventArgs e)
        {
            BookingSystem bookingSystem= new BookingSystem();
            decimal amount = 0;
            int numYoungerthanFive = (int)numericUD5years.Value;
            int numYoungerthan16 = (int)numericUpDownSixTo16.Value;
            int numAdults = (int)numericUpDownAdult.Value;
            int numGuests = (int)numericNumGuests.Value;
            int numRooms = (int)numericNumRooms.Value;
            DateTime Checkin = DateTime.Parse(dtpCheckIn.Text);
            DateTime Checkout = DateTime.Parse(dtpCheckOut.Text);
            decimal rate = bookingSystem.GetHotelAmount(hotelID);
            decimal totalFee = bookingSystem.TotalFee(Checkin, hotelID);
            decimal bookingAmount = bookingSystem.getTotalAmount(Checkin, hotelID, numGuests, numRooms, numYoungerthanFive, numYoungerthan16, numAdults);
            this.Hide();
            GuestSearch guestsearch = new GuestSearch(hotelID, Checkin, Checkout, numGuests, numRooms, bookingAmount);
            guestsearch.Show();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage(hotelID);
            homepage.Show();
            this.Hide();
        }
    }
}
