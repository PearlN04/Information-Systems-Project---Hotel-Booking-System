namespace PhumlaKamnandiSystem.PresentationLayer
{
    partial class RevenueReport
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
            this.dataGridRevenue = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRevenue
            // 
            this.dataGridRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRevenue.Location = new System.Drawing.Point(91, 142);
            this.dataGridRevenue.Name = "dataGridRevenue";
            this.dataGridRevenue.RowHeadersWidth = 51;
            this.dataGridRevenue.RowTemplate.Height = 24;
            this.dataGridRevenue.Size = new System.Drawing.Size(745, 360);
            this.dataGridRevenue.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(410, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 32);
            this.label6.TabIndex = 24;
            this.label6.Text = "Revenue Report";
            // 
            // RevenueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 689);
            this.Controls.Add(this.dataGridRevenue);
            this.Controls.Add(this.label6);
            this.Name = "RevenueReport";
            this.Text = "RevenueReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridRevenue;
        private System.Windows.Forms.Label label6;
    }
}