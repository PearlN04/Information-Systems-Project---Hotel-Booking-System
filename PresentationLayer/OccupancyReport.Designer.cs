namespace PhumlaKamnandiSystem.PresentationLayer
{
    partial class OccupancyReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnGeneratePDF = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.radioMonth = new System.Windows.Forms.RadioButton();
            this.radioDay = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridOcuppancy = new System.Windows.Forms.DataGridView();
            this.btnToggleView = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOcuppancy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeneratePDF
            // 
            this.btnGeneratePDF.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGeneratePDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePDF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGeneratePDF.Location = new System.Drawing.Point(883, 72);
            this.btnGeneratePDF.Name = "btnGeneratePDF";
            this.btnGeneratePDF.Size = new System.Drawing.Size(120, 49);
            this.btnGeneratePDF.TabIndex = 12;
            this.btnGeneratePDF.Text = "Generate Report";
            this.btnGeneratePDF.UseVisualStyleBackColor = false;
            this.btnGeneratePDF.Click += new System.EventHandler(this.btnGeneratePDF_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(400, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(346, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Occupancy Level Report";
            // 
            // radioMonth
            // 
            this.radioMonth.AutoSize = true;
            this.radioMonth.Location = new System.Drawing.Point(84, 84);
            this.radioMonth.Name = "radioMonth";
            this.radioMonth.Size = new System.Drawing.Size(83, 20);
            this.radioMonth.TabIndex = 14;
            this.radioMonth.TabStop = true;
            this.radioMonth.Text = "By month";
            this.radioMonth.UseVisualStyleBackColor = true;
            this.radioMonth.Click += new System.EventHandler(this.radioMonth_Click);
            // 
            // radioDay
            // 
            this.radioDay.AutoSize = true;
            this.radioDay.Location = new System.Drawing.Point(224, 84);
            this.radioDay.Name = "radioDay";
            this.radioDay.Size = new System.Drawing.Size(72, 20);
            this.radioDay.TabIndex = 15;
            this.radioDay.TabStop = true;
            this.radioDay.Text = "By Day";
            this.radioDay.UseVisualStyleBackColor = true;
            this.radioDay.CheckedChanged += new System.EventHandler(this.radioDay_CheckedChanged);
            this.radioDay.Click += new System.EventHandler(this.radioDay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Select time dimension";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(302, 84);
            this.dtpDate.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(2024, 9, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 17;
            this.dtpDate.Value = new System.DateTime(2024, 9, 29, 3, 19, 52, 0);
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(36, 413);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(1032, 243);
            this.chart2.TabIndex = 19;
            this.chart2.Text = "chart2";
            // 
            // dataGridOcuppancy
            // 
            this.dataGridOcuppancy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOcuppancy.Location = new System.Drawing.Point(80, 139);
            this.dataGridOcuppancy.Name = "dataGridOcuppancy";
            this.dataGridOcuppancy.RowHeadersWidth = 51;
            this.dataGridOcuppancy.RowTemplate.Height = 24;
            this.dataGridOcuppancy.Size = new System.Drawing.Size(652, 251);
            this.dataGridOcuppancy.TabIndex = 21;
            // 
            // btnToggleView
            // 
            this.btnToggleView.BackColor = System.Drawing.Color.SteelBlue;
            this.btnToggleView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleView.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnToggleView.Location = new System.Drawing.Point(530, 72);
            this.btnToggleView.Name = "btnToggleView";
            this.btnToggleView.Size = new System.Drawing.Size(120, 49);
            this.btnToggleView.TabIndex = 22;
            this.btnToggleView.Text = "Clear";
            this.btnToggleView.UseVisualStyleBackColor = false;
            this.btnToggleView.Click += new System.EventHandler(this.btnToggleView_Click_1);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(754, 147);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(325, 243);
            this.chart1.TabIndex = 23;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // OccupancyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 693);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnToggleView);
            this.Controls.Add(this.dataGridOcuppancy);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioDay);
            this.Controls.Add(this.radioMonth);
            this.Controls.Add(this.btnGeneratePDF);
            this.Controls.Add(this.label6);
            this.Name = "OccupancyReport";
            this.Text = "OccupancyReport";
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOcuppancy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGeneratePDF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioMonth;
        private System.Windows.Forms.RadioButton radioDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataGridView dataGridOcuppancy;
        private System.Windows.Forms.Button btnToggleView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}