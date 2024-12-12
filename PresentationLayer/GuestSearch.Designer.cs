namespace PhumlaKamnandiSystem.PresentationLayer
{
    partial class GuestSearch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddNewGuest = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-55, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 81);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(250, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(739, 71);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phumla Kamnandi Booking System";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::PhumlaKamnandiSystem.Properties.Resources.WhatsApp_Image_2024_09_25_at_16_521;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(67, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(99, 54);
            this.panel2.TabIndex = 0;
            // 
            // txtGuestID
            // 
            this.txtGuestID.Location = new System.Drawing.Point(58, 125);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.Size = new System.Drawing.Size(180, 22);
            this.txtGuestID.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(262, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search Guest";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddNewGuest
            // 
            this.btnAddNewGuest.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddNewGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewGuest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNewGuest.Location = new System.Drawing.Point(575, 115);
            this.btnAddNewGuest.Name = "btnAddNewGuest";
            this.btnAddNewGuest.Size = new System.Drawing.Size(159, 51);
            this.btnAddNewGuest.TabIndex = 7;
            this.btnAddNewGuest.Text = "Add New Guest";
            this.btnAddNewGuest.UseVisualStyleBackColor = false;
            this.btnAddNewGuest.Click += new System.EventHandler(this.button2_Click);
            // 
            // GuestSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 702);
            this.Controls.Add(this.btnAddNewGuest);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGuestID);
            this.Controls.Add(this.panel1);
            this.Name = "GuestSearch";
            this.Text = "6";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtGuestID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddNewGuest;
    }
}