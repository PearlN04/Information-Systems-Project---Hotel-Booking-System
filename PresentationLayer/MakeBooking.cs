using PhumlaKamnandiSystem.Business;
using PhumlaKamnandiSystem.Data;
using PhumlaKamnandiSystem.Properties;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PhumlaKamnandiSystem.PresentationLayer
{
    /*GROUP MEMBERS: Athule Malgas ,Akhona Mwelase, Zandile Nofemela , Pheliswa Nontsanga, Group 65*/
    public partial class MakeBooking : Form
    {
        string guestId;
        string name;
        string surname;
        string phone;
        string idNumber;
        string email;
        string address;
        private string hotelID;
        private DateTime checkIn;
        private DateTime checkOut;
        private int numberOfGuests;
        private int numberOfRooms;
        private decimal amount;
        private string paymentStatus = "";  
        BookingController bookingController = new BookingController();
        Booking newBooking;
        public string connectionString = Settings.Default.BookingDatabaseConnectionString;

        public MakeBooking(string guestId, string name, string surname, string phone, string idNumber, string email, string address, string hotelId, DateTime checkIn, DateTime checkOut, int numGuests, int numRooms, decimal fullAmount)
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
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.numberOfGuests = numGuests;
            this.numberOfRooms = numRooms;
            this.amount = fullAmount;
            DisplayBookingDetails();
            btnMakeFinalBooking.Enabled = false;
            panel4.Enabled = false;
        }

        private void DisplayBookingDetails()
        {
            rtxtBookingDetails.Text = "Booking  Details:";
            rtxtBookingDetails.AppendText("\n====================================================");
            rtxtBookingDetails.AppendText($"\nGuest ID: {guestId}");
            rtxtBookingDetails.AppendText($"\nGuest Name: {name}");
            rtxtBookingDetails.AppendText($"\nGuest Surname: {surname}");
            rtxtBookingDetails.AppendText($"\nCheck-In date: {checkIn:yyyy/MM/dd}");
            rtxtBookingDetails.AppendText($"\nCheck-Out date: {checkOut:yyyy/MM/dd}");
            rtxtBookingDetails.AppendText($"\nNumber of guests: {numberOfGuests}");
            rtxtBookingDetails.AppendText($"\nNumber of rooms to be booked: {numberOfRooms}");
            rtxtBookingDetails.AppendText($"\nAmount: R {amount:F2}");
            rtxtBookingDetails.AppendText($"\nDeposit: R{(amount / 10):F2}");
        }

        private void btnMakeBooking_Click(object sender, EventArgs e)
        {
            panel4.Enabled = true;
            btnMakeFinalBooking.Enabled = true;
            BookingSystem bookingSystem = new BookingSystem();
            String reservationNumber = "res-" + hotelID + "-" + bookingSystem.getLastID();
            MessageBox.Show("Reservation Reference Number: " + reservationNumber);
                
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paymentStatus = "";
            bool valid = true;
            String cardName = txtCardName.Text;
            String cardNumber = txtCardNumber.Text;
            String expirationDate = txtExpirationDate.Text;


            if (string.IsNullOrEmpty(cardName))
            {
                MessageBox.Show("Please Enter CardHolder name");
                valid = false;
            }

            if (string.IsNullOrEmpty(cardNumber))
            {
                MessageBox.Show("Please enter card number");
                valid = false;

            }

            if (string.IsNullOrEmpty(expirationDate))
            {
                MessageBox.Show("Please enter expiration date");
            }

            if ((radioPayLater.Checked == false) && (radioPayDeposit.Checked == false) && (radioFullAmount.Checked == false))
            {
                MessageBox.Show("Please pick one payment option");
                valid = false;
            }

            if (valid)
            {
                if (radioFullAmount.Checked)
                {
                    paymentStatus = "Fully Paid";
                }
                else if (radioPayDeposit.Checked) { paymentStatus = "Deposit Paid"; }
                else if (radioPayLater.Checked) { paymentStatus = "No payment"; }
                BookingSystem bookingSystem = new BookingSystem();
                int bookingID = (bookingSystem.getLastID()) + 1;
                BookingController bookingController = new BookingController();

                using (SqlConnection connection = new SqlConnection(Settings.Default.BookingDatabaseConnectionString))
                {
                    connection.Open();

                    SqlTransaction transaction = connection.BeginTransaction(); 
                    try
                    {
                        string query = "INSERT INTO Booking (BookingID, GuestID, HotelID, CheckInDate, CheckOutDate, NumberOfRooms, NumberOfGuests, PaymentStatus, Total_Amount) " +
                                       "VALUES (@BookingID, @GuestID, @HotelID, @CheckInDate, @CheckOutDate, @NumberOfRooms, @NumberOfGuests, @PaymentStatus, @Total_Amount)";

                        using (SqlCommand command = new SqlCommand(query, connection, transaction))
                        {
                            
                            command.Parameters.AddWithValue("@BookingID", bookingID);  
                            command.Parameters.AddWithValue("@GuestID", guestId);
                            command.Parameters.AddWithValue("@HotelID", hotelID);
                            command.Parameters.AddWithValue("@CheckInDate", checkIn);
                            command.Parameters.AddWithValue("@CheckOutDate", checkOut);
                            command.Parameters.AddWithValue("@NumberOfRooms", numberOfRooms);
                            command.Parameters.AddWithValue("@NumberOfGuests", numberOfGuests);
                            command.Parameters.AddWithValue("@PaymentStatus", paymentStatus);
                            command.Parameters.AddWithValue("@Total_Amount", amount);

    
                            int rowsAffected = command.ExecuteNonQuery();
                            transaction.Commit();

                            MessageBox.Show($"{rowsAffected} row(s) inserted successfully.");
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                MessageBox.Show(bookingSystem.roomsUpdated(hotelID,numberOfRooms, checkIn, checkOut));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtxtBookingDetails.Clear();
            panel4.Enabled = false;
        }
    }
}
