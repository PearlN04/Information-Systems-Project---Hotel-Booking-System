using PhumlaKamnandiSystem.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*GROUP MEMBERS: Athule Malgas ,Akhona Mwelase, Zandile Nofemela , Pheliswa Nontsanga, Group 65*/
namespace PhumlaKamnandiSystem.Business
{
    public class GenerateRevenueReport
    {
        public GenerateRevenueReport() { }
        private string connectionString = Settings.Default.BookingDatabaseConnectionString;

        public DataTable GetMonthlyRevenue(string hotelId)
        {
            DataTable datatable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                string query = @"
        SELECT 
            DATENAME(MONTH, CheckInDate) AS Month, 
            SUM(Total_Amount) AS TotalRevenue
        FROM 
            Booking
        WHERE 
            HotelID = @HotelID
            AND CheckInDate BETWEEN @StartDate AND @EndDate
        GROUP BY 
            DATENAME(MONTH, CheckInDate), MONTH(CheckInDate)
        ORDER BY 
            MONTH(CheckInDate);";

                using (SqlCommand commandA = new SqlCommand(query, conn))
                {
                    commandA.Parameters.AddWithValue("@HotelID", hotelId);
                    commandA.Parameters.AddWithValue("@StartDate", new DateTime(2024, 10, 1));
                    commandA.Parameters.AddWithValue("@EndDate", new DateTime(2024, 12, 31));

                    SqlDataAdapter adapter = new SqlDataAdapter(commandA);
                    adapter.Fill(datatable);
                }
            }

            return datatable;

        }
    }
}
