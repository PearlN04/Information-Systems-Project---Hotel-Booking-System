using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhumlaKamnandiSystem.PresentationLayer
{
    /*GROUP MEMBERS: Athule Malgas ,Akhona Mwelase, Zandile Nofemela , Pheliswa Nontsanga, Group 65*/
    public partial class HomePage : Form
    {
        private string employeeID;
        public HomePage(string empl)
        {
            InitializeComponent();
            employeeID = empl;
        }
        Form1 form1 = new Form1();

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookingListingForm bookingListingForm = new BookingListingForm();
            bookingListingForm.Show();
        }

        private void btnMakeAReservation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reservation reservation = new Reservation(employeeID);
            reservation.Show();
        }

        private void btnOccupancyReport_Click(object sender, EventArgs e)
        {
            OccupancyReport occupancyReport = new OccupancyReport(employeeID);
            this.Hide();

            occupancyReport.Show();
        }

        private void btnMakeGuestReservationEnquiry_Click(object sender, EventArgs e)
        {
            BookingListingForm bookingListingForm = new BookingListingForm();
            bookingListingForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RevenueReport revenueReport = new RevenueReport(employeeID);
            revenueReport.Show();
            this.Hide();
        }
    }
}
