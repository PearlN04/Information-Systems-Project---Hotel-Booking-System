using PhumlaKamnandiSystem.PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhumlaKamnandiSystem.Business;
using PhumlaKamnandiSystem.Data;
using System.Diagnostics;

/*GROUP MEMBERS: Athule Malgas ,Akhona Mwelase, Zandile Nofemela , Pheliswa Nontsanga, Group 65*/
namespace PhumlaKamnandiSystem
{
    public partial class Form1 : Form
    {
        BookingSystem bookingSystem = new BookingSystem();
        public Form1()
        {
            InitializeComponent();
            lblAbout.Click += new EventHandler(lblAbout_Click);
            rtbAbout.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmployeeID.Text == "")
            {
                lblNullEmployeeID.Visible = true;
            }
            else { lblNullEmployeeID.Visible = false; }

            if (txtPassword.Text == "")
            {
                lblNullPassword.Visible = true;
            }
            else { lblNullPassword.Visible = false; }

            if ((!string.IsNullOrEmpty(txtPassword.Text)) && (!string.IsNullOrEmpty(txtEmployeeID.Text))) {
                String employeeID = txtEmployeeID.Text;
                String password = txtPassword.Text;
                if (bookingSystem.Login(employeeID, password))
                {
                    string hotelname = bookingSystem.EmployeeHotelID;
                    lblInvalidLogin.Visible = false;
                    this.Hide();
                    txtEmployeeID.Text = employeeID;
                    HomePage homePage = new HomePage(hotelname);
                    homePage.Show();
                }
                else
                {
                    lblInvalidLogin.Visible = true;
                }
            }
        }

       



        public void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {
            lblNullEmployeeID.Visible=false;
            lblInvalidLogin.Visible=false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblNullPassword.Visible=false;
            lblInvalidLogin.Visible=false;
        }

        private void pnlInsta_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https:/www.instagram.com/hotelskysa",
                UseShellExecute = true
            });
        }

        private void pnlTwitter_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https:/www.twitter.com",
                UseShellExecute = true
            });
        }

        private void lblAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void lblAbout_Click(object sender, EventArgs e)
        {
            if (!rtbAbout.Visible)
            { 
                rtbAbout.Visible = true;
                rtbAbout.Text = "Phumla Kamnandi Hotel Management System\n" +
                 "The Phumla Kamnandi Hotel group is a new empowerment group that was formed last year to \n" +
                 "manage a portfolio of small hotels around South Africa. There are about 30 Phumla Kamnandi \r\nHotels in the group, each of which runs independently, but which benefits from being part of a \r\ngroup and from the marketing done at group level. \n" +

                 "This system allows clerks amd managers to manage bookings, guests, and hotel information efficiently.\n\n" +
                 "Features:\n" +
                 "- Add Guests and Manage guest information\n" +
                 "- Edit , Add and Manage Bookings\n" +
                 "- Generate Occupancy Level and RevenueReports\n" +
                 "- Hotel Room Availability Tracking\n" +
                 "- Payment Processing";
                rtbAbout.Visible = true;
                rtbAbout.Size = new Size(400, 200);
                rtbAbout.Location = new Point(195, 197);
            }
        }
    } 
}
