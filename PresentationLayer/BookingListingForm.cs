using PhumlaKamnandiSystem.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml;
using PhumlaKamnandiSystem.Data;

namespace PhumlaKamnandiSystem.PresentationLayer
{
    /*GROUP MEMBERS: Athule Malgas ,Akhona Mwelase, Zandile Nofemela , Pheliswa Nontsanga, Group 65*/
    public partial class BookingListingForm : Form
    {
        #region Variables
        public bool listFormClosed;
        private Collection<Booking> bookings;
        private BookingController bookingController = new BookingController();
        private FormStates state;

        public enum FormStates
        {
            View = 0,
            Add = 1,
            Edit = 2,
            Delete = 3
        }
        private Booking booking;
        #endregion
        public BookingListingForm()
        {
            InitializeComponent();
            this.Load += BookingListingForm_Load;
            this.Activated += BookingListingForm_Activated;
            this.FormClosed += BookingListingForm_FormClosed;
            state = FormStates.View;
            this.bookingListView.SelectedIndexChanged += new EventHandler(this.bookingListView_SelectedIndexChanged);
        }

          


        #region constructor
        public BookingListingForm(BookingController bookController)
            {

                InitializeComponent();
                bookingController = bookController;
                this.Load += BookingListingForm_Load;
                this.Activated += BookingListingForm_Activated;
                this.FormClosed += BookingListingForm_FormClosed;
                state = FormStates.View;
            }
        #endregion

        #region Events
        private void BookingListingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            listFormClosed = true;
        }

        private void BookingListingForm_Load(object sender, EventArgs e)
        {
            bookingListView.View = View.Details;
        }

        private void BookingListingForm_Activated(object sender, EventArgs e)
        {
            bookingListView.View = View.Details;
            setUpEmployeeListView();
            ShowAll(false);
        }
        #endregion

        #region ListView set up
        public void setUpEmployeeListView()
        {
            ListViewItem bookingDetails;
            Booking bookingW;
            bookings = null;
            bookingListView.Clear();

            bookingListView.Columns.Insert(0, "BookingID", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(1, "GuestID", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(2, "HotelID", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(3, "CheckIn_Date", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(4, "CheckOut_Date", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(5, "NumberOfRooms", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(6, "NumberOfGuests", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(7, "PaymentStatus", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(8, "Total_Amount", 120, HorizontalAlignment.Left);

            bookings = bookingController.AllBookings;
            listLabel.Text = "Listing of all bookings";
           
            foreach (Booking booking in bookings)
            {
                bookingDetails = new ListViewItem();
                bookingDetails.Text = booking.BookingID.ToString();
                bookingDetails.SubItems.Add(booking.GuestID.ToString());
                bookingDetails.SubItems.Add(booking.HotelID.ToString());
                bookingDetails.SubItems.Add(booking.CheckInDate.ToString());
                bookingDetails.SubItems.Add(booking.CheckOutDate.ToString());
                bookingDetails.SubItems.Add(booking.NumberOfRooms.ToString());
                bookingDetails.SubItems.Add(booking.NumOfGuests.ToString());
                bookingDetails.SubItems.Add(booking.PaymentStatus.ToString());
                bookingDetails.SubItems.Add(booking.Amount.ToString());
                bookingListView.Items.Add(bookingDetails);

            }

            bookingListView.Refresh();
            bookingListView.GridLines = true;
            }
        #endregion

        private void editButton_Click(object sender, EventArgs e)
        {
            state = FormStates.Edit;
            EnableEntries(true);
        }
        

        #region Utility Methods

        private void ShowAll(bool value)
        {
            idLabel.Visible = value;
            guestIDLabel.Visible = value;
            CheckInDateLabel.Visible = value;
            paymentLabel.Visible = value;
            CheckOutDateLabel.Visible = value;
            payStatusLabel.Visible = value;
            amountLabel.Visible = value;
               

            idTextBox.Visible = value;
            guestIDTextBox.Visible = value;
            checkInTextBox.Visible = value;
            numOfGuestsTextBox.Visible = value;
            checkOutTextBox.Visible = value;
            numOfRoomsLabel.Visible = value;
            numOfRoomsTextBox.Visible = value;
            txtAmount.Visible = value;
            txtPayment.Visible = value;

            if (state == FormStates.Delete)
            {
                    cancelButton.Visible = !value;
                    submitButton.Visible = !value;
            }
            else
            {
                    submitButton.Visible = value;
                    cancelButton.Visible = value;
            }
            deleteButton.Visible = value;
            editButton.Visible = value;

        }

        private void ClearAll()
        {
            idTextBox.Clear();
            checkInTextBox.Clear();
            guestIDTextBox.Clear();
            checkOutTextBox.Clear();
            numOfGuestsTextBox.Clear();
            numOfRoomsTextBox.Clear();
            txtPayment.Clear();
            txtAmount.Clear();
        }

        private void EnableEntries(bool value)
        {
            if ((state == FormStates.Edit) && value)
            {
                    idTextBox.Enabled = !value;
                    guestIDTextBox.Enabled = !value;
            }
            else
            {
                    idTextBox.Enabled = value;
                    guestIDTextBox.Enabled = value;
            }
            checkInTextBox.Enabled = value;
            checkOutTextBox.Enabled = value;
            numOfGuestsTextBox.Enabled = value;
            numOfRoomsTextBox.Enabled = value;

            if (state == FormStates.Delete)
            {
                    cancelButton.Visible = !value;
                    submitButton.Visible = !value;
            }
            else
            {
                    cancelButton.Visible = value;
                    submitButton.Visible = value;
             }
        }
        #endregion

        private void PopulateTextBoxes(Booking booking)
        {

            idTextBox.Text =Convert.ToString( booking.BookingID);
            checkInTextBox.Text = Convert.ToString(booking.CheckInDate);
            guestIDTextBox.Text = booking.GuestID;
            checkOutTextBox.Text = Convert.ToString(booking.CheckOutDate);
            numOfGuestsTextBox.Text = Convert.ToString(booking.NumOfGuests);
            numOfRoomsTextBox.Text = Convert.ToString(booking.NumberOfRooms);
            txtPayment.Text = booking.PaymentStatus;
            txtAmount.Text = Convert.ToString(booking.Amount);     
        }

            


        private void PopulateObject()
        {
              
            Booking booking = new Booking();
            booking.BookingID = int.Parse(idTextBox.Text);
            booking.GuestID = guestIDTextBox.Text;
            booking.CheckInDate = DateTime.Parse(checkInTextBox.Text);
            booking.CheckOutDate = DateTime.Parse(checkOutTextBox.Text);
            booking.NumOfGuests= int.Parse(numOfGuestsTextBox.Text);      
            booking.NumberOfRooms = int.Parse(numOfRoomsTextBox.Text);         
            booking.PaymentStatus = txtPayment.Text;
            booking.Amount = decimal.Parse(txtAmount.Text);
                
        }


        private void submitButton_Click_1(object sender, EventArgs e)
        {
           
            PopulateObject();
            if (state == FormStates.Edit)
            {
                bookingController.DataMaintenance(booking, Data.DB.DBOperation.Edit);
            }
            else
            {
                bookingController.DataMaintenance(booking, Data.DB.DBOperation.Delete);
                BookingSystem bookingSystem = new BookingSystem();
                MessageBox.Show(bookingSystem.roomsAddedUpdated(booking.HotelID,booking.NumberOfRooms,booking.CheckInDate,booking.CheckOutDate));
            }

            bookingController.FinalizeChanges(booking, state == FormStates.Delete ? DB.DBOperation.Delete : DB.DBOperation.Edit);
            ClearAll();
            state = FormStates.View;
            ShowAll(false);
            setUpEmployeeListView();

        }

        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("The selected employee record is about to be deleted !!!");
            state = FormStates.Delete; 
            cancelButton.Visible = true;
            submitButton.Visible = true;

        }

        private void bookingListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bookingListView.SelectedItems.Count > 0)
            {
                ShowAll(true);
                state = FormStates.View;
                EnableEntries(false);

                string selectedBookingId = bookingListView.SelectedItems[0].Text;
                booking = bookingController.Find(selectedBookingId);

                if (booking != null)
                {
                    PopulateTextBoxes(booking);
                }
                else
                {
                    MessageBox.Show("Booking not found for the selected ID.");
                }
            }

        }
    }
}
    

