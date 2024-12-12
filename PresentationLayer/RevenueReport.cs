using PhumlaKamnandiSystem.Business;
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
    public partial class RevenueReport : Form
    {
        private string hotelID;
        GenerateRevenueReport report = new GenerateRevenueReport();

        public RevenueReport(string hotelID)
        {
            InitializeComponent();
            this.hotelID = hotelID;
            ViewRevenueData();

        }

        private void ViewRevenueData()
        {
            DataTable revenueData = report.GetMonthlyRevenue(hotelID);
            dataGridRevenue.DataSource = revenueData;
        }
    }
}
