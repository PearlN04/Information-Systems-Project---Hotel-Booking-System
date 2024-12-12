using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PhumlaKamnandiSystem.Business;


namespace PhumlaKamnandiSystem.PresentationLayer
{
    /*GROUP MEMBERS: Athule Malgas ,Akhona Mwelase, Zandile Nofemela , Pheliswa Nontsanga, Group 65*/
    public partial class OccupancyReport : Form
    {
        private string hotelID;

        OccupancyReportLevel report = new OccupancyReportLevel();

        public OccupancyReport(string hotelID)
        {
            InitializeComponent();
            this.hotelID = hotelID;  
            ViewOccupancyData();
            LoadOccupancyPieChart(hotelID);
            LoadOccupancyLineGraph(hotelID);
        }

        private void ViewOccupancyData()
        {
            DataTable occupancyData = report.GetRoomsOccupiedData(hotelID);        
            dataGridOcuppancy.DataSource = occupancyData;      
        }

        private void btnToggleView_Click(object sender, EventArgs e)
        {
            if (radioDay.Checked)
            {
                dataGridOcuppancy.DataSource = report.GetRoomsOccupiedData(hotelID);
            }
            else if (radioMonth.Checked)
            {
                dataGridOcuppancy.DataSource = report.GetMonthlyOccupancyData(hotelID);
            }
        }

        public void LoadOccupancyPieChart(string hotelID)
        {
            OccupancyReportLevel level = new OccupancyReportLevel();
            double averageOccupancyRate = level.GetAverageOccupancyRate(hotelID);
            double unoccupiedRate = 100 - averageOccupancyRate;

            chart1.Series.Clear();  
            Series pieSeries = new Series
            {
                Name = "Occupancy",
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true  
            };

            
            pieSeries.Points.AddXY("Occupied", averageOccupancyRate);
            pieSeries.Points.AddXY("Unoccupied", unoccupiedRate);

            
            pieSeries.Points[0].LegendText = "Occupied";  
            pieSeries.Points[1].LegendText = "Unoccupied";  
            pieSeries.Label = "#PERCENT";  

            chart1.Series.Add(pieSeries);
            chart1.Titles.Clear();
            chart1.Titles.Add("Average Yearly Occupancy Rate");

       
            chart1.Legends.Clear(); 
            Legend legend = new Legend
            {
                Name = "Legend1",
                Docking = Docking.Right, 
                IsTextAutoFit = true 
            };
            chart1.Legends.Add(legend);  
            chart1.Palette = ChartColorPalette.BrightPastel;  
        }

        private void LoadOccupancyLineGraph(string hotelID)
        {
            chart2.Series.Clear();  
            Series lineSeries = new Series
            {
                Name = "Weekly Occupancy",
                ChartType = SeriesChartType.Line,
                BorderWidth = 3,  
                Color = System.Drawing.Color.Blue  
            };

            OccupancyReportLevel level = new OccupancyReportLevel();
            DataTable weeklyOccupancyData = level.GetWeeklyData(hotelID);

            foreach (DataRow row in weeklyOccupancyData.Rows)
            {
                string weekRangeS = $"{row["WeekStartDate"]} - {row["WeekEndDate"]}";  
                double occupancyRate = Convert.ToDouble(row["AverageOccupancyRate"]);
                lineSeries.Points.AddXY(weekRangeS, occupancyRate);  
            }

          
            chart2.Series.Add(lineSeries);
            chart2.ChartAreas[0].AxisX.Title = "Week";
            chart2.ChartAreas[0].AxisY.Title = "Average Occupancy Rate (%)";
            chart2.Titles.Clear();
            chart2.Titles.Add("Weekly Average Occupancy Rate For The Year 2024 ");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioMonth_Click(object sender, EventArgs e)
        {
            dataGridOcuppancy.DataSource = report.GetMonthlyOccupancyData(hotelID);
        }

        private void radioDay_CheckedChanged(object sender, EventArgs e)
        {
            dataGridOcuppancy.DataSource = report.GetByDay(hotelID, DateTime.Parse(dtpDate.Text));
        }

        private void radioDay_Click(object sender, EventArgs e)
        {
            dataGridOcuppancy.DataSource = report.GetByDay(hotelID, DateTime.Parse(dtpDate.Text));
        }

        private void btnToggleView_Click_1(object sender, EventArgs e)
        {
            if (radioDay.Checked)
            {
                radioDay.Checked = !radioDay.Checked;
            }
            else if (radioDay.Checked)
            {
                radioMonth.Checked = !radioMonth.Checked;
            }
            ViewOccupancyData();
        }

        private void btnGeneratePDF_Click(object sender, EventArgs e)
        {          

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
