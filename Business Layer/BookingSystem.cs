using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhumlaKamnandiSystem.Data;
using PhumlaKamnandiSystem.PresentationLayer;
using PhumlaKamnandiSystem.Properties;

/*GROUP MEMBERS: Athule Malgas ,Akhona Mwelase, Zandile Nofemela , Pheliswa Nontsanga, Group 65*/
namespace PhumlaKamnandiSystem.Business
{
    public class BookingSystem
    {

        #region Data Members

        Collection<Employee> employees;
        Employee employee;
        EmployeeController employeeController;
        bool successfulLogin;
        Collection<Rooms> rooms;
        Rooms room;
        RoomsController roomController;
        Hotel hotelID;
        private string connectionString = Settings.Default.BookingDatabaseConnectionString;
        #endregion


        #region constructor
        public BookingSystem()
        {
            employeeController = new EmployeeController();
            employees = employeeController.AllEmployees;

            roomController = new RoomsController(); // Initialize the RoomsController
            rooms = roomController.AllRooms;

        }
        #endregion


        #region Utility Methods
        public string insertGuest(string guestID, string name, string surname, string phone, string idnumber, string email, string address)
        {
            SqlConnection connection = new SqlConnection(connectionString); 
            string result = "";
            try
            {
                connection.Open(); 

                string query = "INSERT INTO Guest (GuestID, Name, Surname, Phone, IDNumber, Email, Address) " +
                               "VALUES (@guestID, @name, @surname, @phone, @idnumber, @email, @address)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@guestID", guestID);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@surname", surname);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@idNumber", idnumber);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@address", address);

                int rowsAffected = command.ExecuteNonQuery();
                result = $"{rowsAffected} row(s) inserted successfully.";
            }
            catch (SqlException sqlEx)
            {
                result = "SQL Error: " + sqlEx.Message;
            }
            catch (Exception ex)
            {
                result = "Error: " + ex.Message;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();  // Explicitly close the connection
                }
            }

            return result;
        }

        public string roomsUpdated(string hotelid, int numberOfBookedRooms,DateTime checkin, DateTime checkout)
        {
            string response = "";
            string query = "UPDATE Rooms SET NumberOfRoomsAvailable = NumberOfRoomsAvailable - @BookedRooms " +
                           "WHERE Date >= @CheckinDate AND Date < @CheckoutDate AND HotelID = @HotelID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BookedRooms", numberOfBookedRooms);
                    command.Parameters.AddWithValue("@CheckinDate", checkin);
                    command.Parameters.AddWithValue("@CheckoutDate", checkout); 
                    command.Parameters.AddWithValue("@HotelID", hotelid);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        response = "Number of rooms updated successfully!";
                    }
                    else
                    {
                        response = "Couldn't update rooms, an error occurred, please try again.";
                    }
                }
            }

            return response;
        }

        public string roomsAddedUpdated(string hotelid, int numberOfBookedRooms, DateTime checkin, DateTime checkout)
        {
            string response = "";

            string query = "UPDATE Rooms SET NumberOfRoomsAvailable = NumberOfRoomsAvailable + @BookedRooms " +
                           "WHERE Date >= @CheckinDate AND Date < @CheckoutDate AND HotelID = @HotelID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BookedRooms", numberOfBookedRooms);
                    command.Parameters.AddWithValue("@CheckinDate", checkin);
                    command.Parameters.AddWithValue("@CheckoutDate", checkout);
                    command.Parameters.AddWithValue("@HotelID", hotelid);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        response = "Number of rooms updated successfully!";
                    }
                    else
                    {
                        response = "Couldn't update rooms, an error occurred, please try again.";
                    }
                }
            }

            return response;
        }

        public string updatedBooking(string hotelid, int numberofGuests,int numberOfBookedRooms, DateTime checkin, DateTime checkout)
        {
            string response = "";

            string query = "UPDATE Booking SET CheckInDate=@CheckinDate, CheckOutDate=@CheckoutDate,NumberOfRooms=@BookedRooms, NumberOfGuests=@NumberOfGuests  WHERE HotelID = @HotelID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BookedRooms", numberOfBookedRooms);
                    command.Parameters.AddWithValue("@CheckinDate", checkin);
                    command.Parameters.AddWithValue("@CheckoutDate", checkout); // Update till day before checkout
                    command.Parameters.AddWithValue("@HotelID", hotelid);
                    command.Parameters.AddWithValue("@NumberOfGuests",numberofGuests);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        response = "Number of rooms updated successfully!";
                    }
                    else
                    {
                        response = "Couldn't edit bookings, an error occurred, please try again.";
                    }
                }
            }

            return response;
        }


        public decimal getTotalAmount(DateTime checkin, string hotelID, int numGuests, int numRooms, int numKids5, int numkids16, int numAdults) {
            decimal hotelRate = TotalFee(checkin, hotelID);
            decimal hotelamount;
            if (numGuests == 1) {
                hotelamount = hotelRate;
            }
            else
            {
                hotelamount = hotelRate * numAdults;
                hotelamount = hotelamount + ((hotelRate / 2) * numkids16);
            }
            return hotelamount;
        }

        public int getLastID() {
            int lastID = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(BookingID) FROM Booking"; 
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        lastID = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return lastID;
        }

        public int getLastBookingID()
        {
            int lastID = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(BookingID) FROM Booking"; 
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar(); 
                    if (result != DBNull.Value)
                    {
                        lastID = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return lastID;
        }

        public string EmployeeHotelID {
            get; private set; 
        }


        public decimal TotalFee(DateTime checkin, string hotelID)
        {
            decimal price = 0;
            DateTime lowSeason = new DateTime(2024, 12, 01);
            DateTime midSeason = new DateTime(2024, 12, 08);
            DateTime HighSeason = new DateTime(2024, 12, 16);

            if (checkin.Date >= lowSeason.Date)
            {
                if (checkin.Date < midSeason.Date)
                {
                    price = 550;

                }
                else if ((checkin.Date >= midSeason.Date) && (checkin.Date < HighSeason.Date))
                {
                    price = 750;

                }
                else if (checkin.Date >= HighSeason.Date)
                {
                    price = 995;

                }
            }
            else
            {
                price = GetHotelAmount(hotelID); 
            }
            return price;
        }

        public DataTable GetGuestID(string guestID)
        {
            DataTable guestTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT GuestID, Name, Surname, Phone, IDNumber, Email, Address FROM Guest WHERE GuestID = @guestID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@guestID", guestID);
                adapter.Fill(guestTable);
            }

            return guestTable;
        }

        public decimal GetHotelAmount(string hotelID)
        {
            decimal hotelAmount = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Rate FROM Hotel WHERE hotelID = @hotelID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@hotelID", hotelID);

                DataTable hotelTable = new DataTable();
                adapter.Fill(hotelTable);

                if (hotelTable.Rows.Count > 0)
                {
                    hotelAmount = Convert.ToDecimal(hotelTable.Rows[0]["Rate"]);
                }
            }

            return hotelAmount;
        }
    
    public string RoomAvailability(string hotelid, int numRooms, DateTime checkIn, DateTime checkOut)
        {
            string errorMessage = "";

            for (DateTime date = checkIn; date <= checkOut; date = date.AddDays(1))
            {
                bool roomAvailable = false;

                foreach (Rooms room in rooms)
                {
                    if (room.HotelID.Equals(hotelid) && room.Date.Date == date.Date)
                    {
                        roomAvailable = true;

                        if (room.NumRoomsAvailable == 0)
                        {
                            errorMessage = $"Room not available on {date.ToString("yyyy/MM/dd")} please pick another date";
                        }
                        if ((room.NumRoomsAvailable>0) && (room.NumRoomsAvailable < numRooms))
                        {
                            errorMessage = $"Number of rooms requested exceed number of available rooms on {date.ToString("yyyy/MM/dd")}, please pick another date or reduce the number of rooms.";
                            return errorMessage; 
                        }
                    }
                }

                if (!roomAvailable)
                {
                    errorMessage = $"No room data found for the date {date.ToString("yyyy/MM/dd")}. Please pick another date.";
                    return errorMessage;
                }
            }
            return errorMessage;
        }

        public bool Login(string emplid, string password)
        {
            successfulLogin = false;
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Checking EmployeeID: {employee.EmployeeID}, Password: {employee.Password}");
                if (employee.EmployeeID.Equals(emplid)){
                        if (employee.Password.Equals(password)){
                        Hotel hotel = new Hotel();
                        EmployeeHotelID = employee.HotelID;
                        successfulLogin = true;
                    }
                    
                }
            }
            return successfulLogin;
            #endregion

        }

    }
}