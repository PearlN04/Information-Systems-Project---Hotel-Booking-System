using iTextSharp.text;
using PhumlaKamnandiSystem.Business;
using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

/*GROUP MEMBERS: Athule Malgas ,Akhona Mwelase, Zandile Nofemela , Pheliswa Nontsanga, Group 65*/
namespace PhumlaKamnandiSystem.Data
{
    public class BookingDB : DB
    {
        private string table = "Booking";
        private string sqlLocal = "SELECT * FROM Booking";
        private Collection<Booking> bookings;

        public Collection<Booking> AllBookings => bookings;

        public BookingDB() : base()
        {
            bookings = new Collection<Booking>();
            FillDataSet(sqlLocal, table);
            DataColumn[] primaryKeyColumns = new DataColumn[1];
            primaryKeyColumns[0] = dsMain.Tables[table].Columns["BookingID"];
            dsMain.Tables[table].PrimaryKey = primaryKeyColumns;
            Add2Collection(table);
        }

        private void Add2Collection(string table)
        {
            DataRow myRow = null;
            Booking aBooking;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    int bookingID = Convert.ToInt32(myRow["BookingID"]);
                    string guestID = Convert.ToString(myRow["GuestID"]).TrimEnd();
                    string hotelID = Convert.ToString(myRow["HotelID"]).TrimEnd();
                    DateTime checkIn = Convert.ToDateTime(myRow["CheckInDate"]);
                    DateTime checkOut = Convert.ToDateTime(myRow["CheckOutDate"]);
                    int numberOfRooms = Convert.ToInt32(myRow["NumberOfRooms"]);
                    int numberOfGuests = Convert.ToInt32(myRow["NumberOfGuests"]);
                    string paymentStatus = Convert.ToString(myRow["PaymentStatus"]).TrimEnd();
                    decimal amount = Convert.ToDecimal(myRow["Total_Amount"]);

                    aBooking = new Booking(bookingID, guestID, hotelID, checkIn, checkOut, numberOfRooms, numberOfGuests, paymentStatus, amount);
                    bookings.Add(aBooking);
                }
            }
        }
        
        public void DataSetChange(Booking aBooking, DB.DBOperation operation)
        {
            
                DataRow aRow = null;

                switch (operation)
                {
                    case DBOperation.Add:
                        aRow = dsMain.Tables[table].NewRow();
                        FillRow(aRow, aBooking, DBOperation.Add);
                        dsMain.Tables[table].Rows.Add(aRow);
                        break;

                    case DBOperation.Edit:
                    aRow = dsMain.Tables[table].Rows.Find(aBooking.BookingID); 
                    if (aRow != null)
                    {
                        FillRow(aRow, aBooking, DBOperation.Edit);  
                        MessageBox.Show($"Row for BookingID {aBooking.BookingID} found and updated.");
                    }
                    else
                    {
                        MessageBox.Show($"Row for BookingID {aBooking.BookingID} not found.");
                    }
                    break;

                case DBOperation.Delete:
                    aRow = dsMain.Tables[table].Rows.Find(aBooking.BookingID); 
                    if (aRow != null)
                    {
                        aRow.Delete();  
                    }
                    break;
                    
                }
        }
        

        private void FillRow(DataRow aRow, Booking aBooking, DB.DBOperation operation)
        {
            aRow["BookingID"] = aBooking.BookingID;
            aRow["GuestID"] = aBooking.GuestID;
            aRow["HotelID"] = aBooking.HotelID;
            aRow["CheckInDate"] = aBooking.CheckInDate;
            aRow["CheckOutDate"] = aBooking.CheckOutDate;
            aRow["NumberOfRooms"] = aBooking.NumberOfRooms;
            aRow["NumberOfGuests"] = aBooking.NumOfGuests;
            aRow["PaymentStatus"] = aBooking.PaymentStatus;
            aRow["Total_Amount"] = aBooking.Amount;
        }

        public bool UpdateDataSource(DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                Create_DELETE_Command();  
            }
            if (operation == DB.DBOperation.Delete)
            {
                Create_DELETE_Command();  
            }
            if (operation == DB.DBOperation.Edit)
            {
                Create_UPDATE_Command();  
                MessageBox.Show("Update command created and will be executed.");
            }
            return UpdateDataSource(sqlLocal, table);          

        }

        private void Create_UPDATE_Command()
        {
            daMain.UpdateCommand = new SqlCommand(
                "UPDATE Booking SET GuestID = @GuestID, HotelID = @HotelID, CheckInDate = @CheckInDate, " +
                "CheckOutDate = @CheckOutDate, NumberOfRooms = @NumberOfRooms, NumberOfGuests = @NumberOfGuests, " +
                "PaymentStatus = @PaymentStatus, Total_Amount = @Total_Amount WHERE BookingID = @BookingID", cnMain);

            Build_UPDATE_Parameters();
        }

        private void Build_UPDATE_Parameters()
        {
            daMain.UpdateCommand.Parameters.Add(new SqlParameter("@BookingID", SqlDbType.Int)).SourceColumn = "BookingID";
            daMain.UpdateCommand.Parameters.Add(new SqlParameter("@GuestID", SqlDbType.NVarChar, 20)).SourceColumn = "GuestID";
            daMain.UpdateCommand.Parameters.Add(new SqlParameter("@HotelID", SqlDbType.NChar, 10)).SourceColumn = "HotelID";
            daMain.UpdateCommand.Parameters.Add(new SqlParameter("@CheckInDate", SqlDbType.DateTime)).SourceColumn = "CheckInDate";
            daMain.UpdateCommand.Parameters.Add(new SqlParameter("@CheckOutDate", SqlDbType.DateTime)).SourceColumn = "CheckOutDate";
            daMain.UpdateCommand.Parameters.Add(new SqlParameter("@NumberOfRooms", SqlDbType.Int)).SourceColumn = "NumberOfRooms";
            daMain.UpdateCommand.Parameters.Add(new SqlParameter("@NumberOfGuests", SqlDbType.Int)).SourceColumn = "NumberOfGuests";
            daMain.UpdateCommand.Parameters.Add(new SqlParameter("@PaymentStatus", SqlDbType.NVarChar, 20)).SourceColumn = "PaymentStatus";
            daMain.UpdateCommand.Parameters.Add(new SqlParameter("@Total_Amount", SqlDbType.Decimal)).SourceColumn = "Total_Amount";
        }

        private void Create_DELETE_Command()
        {
            
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Booking WHERE BookingID = @BookingID", cnMain);
            daMain.DeleteCommand.Parameters.Add(new SqlParameter("@BookingID", SqlDbType.Int, 10, "BookingID"));
        }
        private void Create_INSERT_Command()
        {
            daMain.InsertCommand = new SqlCommand("INSERT INTO Booking (BookingID, GuestID, HotelID, CheckInDate, CheckOutDate, NumberOfRooms, NumberOfGuests, PaymentStatus, Total_Amount) VALUES (@BookingID, @GuestID, @HotelID, @CheckInDate, @CheckOutDate, @NumberOfRooms, @NumberOfGuests, @PaymentStatus, @Total_Amount)", cnMain);
            Build_INSERT_Parameters();
        }

        private void Build_INSERT_Parameters()
        {
            daMain.InsertCommand.Parameters.Add(new SqlParameter("@BookingID", SqlDbType.Int)).SourceColumn = "BookingID";
            daMain.InsertCommand.Parameters.Add(new SqlParameter("@GuestID", SqlDbType.NVarChar, 20)).SourceColumn = "GuestID";
            daMain.InsertCommand.Parameters.Add(new SqlParameter("@HotelID", SqlDbType.NChar, 10)).SourceColumn = "HotelID";
            daMain.InsertCommand.Parameters.Add(new SqlParameter("@CheckInDate", SqlDbType.DateTime)).SourceColumn = "CheckInDate";
            daMain.InsertCommand.Parameters.Add(new SqlParameter("@CheckOutDate", SqlDbType.DateTime)).SourceColumn = "CheckOutDate";
            daMain.InsertCommand.Parameters.Add(new SqlParameter("@NumberOfRooms", SqlDbType.Int)).SourceColumn = "NumberOfRooms";
            daMain.InsertCommand.Parameters.Add(new SqlParameter("@NumberOfGuests", SqlDbType.Int)).SourceColumn = "NumberOfGuests";
            daMain.InsertCommand.Parameters.Add(new SqlParameter("@PaymentStatus", SqlDbType.NVarChar, 20)).SourceColumn = "PaymentStatus";
            daMain.InsertCommand.Parameters.Add(new SqlParameter("@Total_Amount", SqlDbType.Decimal)).SourceColumn = "Total_Amount";
        }
    }
}
