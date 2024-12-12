using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhumlaKamnandiSystem.Properties;
using System.Net.Mail;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using MailBee.SmtpMail;
using System.Net.Mail;
using System.Net;


/*GROUP MEMBERS: Athule Malgas ,Akhona Mwelase, Zandile Nofemela , Pheliswa Nontsanga, Group 65*/
namespace PhumlaKamnandiSystem.Business
{
    public class OccupancyReportLevel
    {
        public OccupancyReportLevel() { }
        private string connectionString = Settings.Default.BookingDatabaseConnectionString;

        public DataTable GetRoomsOccupiedData(string hotelId)
        {
            DataTable datatable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
               
                string query = @"
                SELECT 
                    Date,
                    (10 - NumberOfRoomsAvailable) AS NumberOfRoomsOccupied, NumberOfRoomsAvailable as NumberOfRoomsAvailable,
                    ROUND(((10 - NumberOfRoomsAvailable) * 100.0 / 10), 1) AS OccupancyRate
                FROM Rooms
                WHERE HotelID = @HotelID";

                using (SqlCommand commandA = new SqlCommand(query, conn))
                {
                    commandA.Parameters.AddWithValue("@HotelID", hotelId); 

                    SqlDataAdapter adapter = new SqlDataAdapter(commandA);
                    adapter.Fill(datatable);  
                }
            }

            return datatable;  
        }

        public DataTable GetMonthlyOccupancyData(string hotelId)
        {
            DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                FORMAT(Date, 'yyyy-MM') AS Month,
                SUM(10 - NumberOfRoomsAvailable) AS RoomsOccupied,
                (SUM(10 - NumberOfRoomsAvailable) * 100.0 / 310) AS OccupancyRate
            FROM Rooms
            WHERE HotelID = @HotelID
            GROUP BY FORMAT(Date, 'yyyy-MM')";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@HotelID", hotelId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                }
            }

            return table;
        }


        public DataTable GetByDay(string hotelId,DateTime date)
        {
            DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT 
                    Date,
                    (10 - NumberOfRoomsAvailable) AS NumberOfRoomsOccupied, NumberOfRoomsAvailable as NumberOfRoomsAvailable,
                    ROUND(((10 - NumberOfRoomsAvailable) * 100.0 / 10), 1) AS OccupancyRate
                FROM Rooms
                WHERE HotelID = @HotelID AND Date=@Date";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@HotelID", hotelId);
                    cmd.Parameters.AddWithValue("@Date", date);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                }
            }

            return table;
        }

         public double GetAverageOccupancyRate(string hotelID)
        {
            double averageOccupancyRate = 0;

            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                AVG((10 - NumberOfRoomsAvailable) * 100.0 / 10) AS AverageOccupancyRate
            FROM Rooms
            WHERE HotelID = @HotelID AND Date BETWEEN '2024-01-01' AND '2024-12-31';";  

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@HotelID",hotelID);  

                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        averageOccupancyRate = Convert.ToDouble(result);
                    }
                }
            }

            return averageOccupancyRate;
        }

        public DataTable GetWeeklyData(string hotelID)
        {
            DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT 
                    MIN(CONVERT(VARCHAR(10), Date, 105)) AS WeekStartDate,   -- Start date of the week
                    MAX(CONVERT(VARCHAR(10), Date, 105)) AS WeekEndDate,     -- End date of the week
                    AVG((10 - NumberOfRoomsAvailable) * 100.0 / 10) AS AverageOccupancyRate
                FROM Rooms
                WHERE HotelID = @HotelID 
                AND Date BETWEEN '2024-10-01' AND '2024-12-31'
                GROUP BY DATEPART(week, Date)
                ORDER BY MIN(Date)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@HotelID", hotelID); 

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table); 
                }
            }

            return table;
        }
    }
}

