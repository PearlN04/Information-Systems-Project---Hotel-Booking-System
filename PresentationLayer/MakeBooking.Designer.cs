namespace PhumlaKamnandiSystem.PresentationLayer
{
    partial class MakeBooking
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioFullAmount = new System.Windows.Forms.RadioButton();
            this.radioPayDeposit = new System.Windows.Forms.RadioButton();
            this.radioPayLater = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.txtExpirationDate = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMakeBooking = new System.Windows.Forms.Button();
            this.rtxtBookingDetails = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMakeFinalBooking = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 80);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(218, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(739, 71);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phumla Kamnandi Booking System";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::PhumlaKamnandiSystem.Properties.Resources.WhatsApp_Image_2024_09_25_at_16_521;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(47, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 54);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.btnMakeBooking);
            this.panel3.Controls.Add(this.rtxtBookingDetails);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btnMakeFinalBooking);
            this.panel3.Location = new System.Drawing.Point(35, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1096, 462);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.radioFullAmount);
            this.panel4.Controls.Add(this.radioPayDeposit);
            this.panel4.Controls.Add(this.radioPayLater);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtCardName);
            this.panel4.Controls.Add(this.txtExpirationDate);
            this.panel4.Controls.Add(this.txtCardNumber);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(691, 33);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(375, 258);
            this.panel4.TabIndex = 24;
            // 
            // radioFullAmount
            // 
            this.radioFullAmount.AutoSize = true;
            this.radioFullAmount.Location = new System.Drawing.Point(222, 207);
            this.radioFullAmount.Name = "radioFullAmount";
            this.radioFullAmount.Size = new System.Drawing.Size(124, 20);
            this.radioFullAmount.TabIndex = 40;
            this.radioFullAmount.TabStop = true;
            this.radioFullAmount.Text = "Pay Full Amount";
            this.radioFullAmount.UseVisualStyleBackColor = true;
            // 
            // radioPayDeposit
            // 
            this.radioPayDeposit.AutoSize = true;
            this.radioPayDeposit.Location = new System.Drawing.Point(113, 207);
            this.radioPayDeposit.Name = "radioPayDeposit";
            this.radioPayDeposit.Size = new System.Drawing.Size(102, 20);
            this.radioPayDeposit.TabIndex = 39;
            this.radioPayDeposit.TabStop = true;
            this.radioPayDeposit.Text = "Pay Deposit";
            this.radioPayDeposit.UseVisualStyleBackColor = true;
            // 
            // radioPayLater
            // 
            this.radioPayLater.AutoSize = true;
            this.radioPayLater.Location = new System.Drawing.Point(12, 207);
            this.radioPayLater.Name = "radioPayLater";
            this.radioPayLater.Size = new System.Drawing.Size(81, 20);
            this.radioPayLater.TabIndex = 38;
            this.radioPayLater.TabStop = true;
            this.radioPayLater.Text = "Pay later";
            this.radioPayLater.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 105);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 20);
            this.label17.TabIndex = 37;
            this.label17.Text = "Name on Card";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 146);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(194, 20);
            this.label16.TabIndex = 36;
            this.label16.Text = "Expiration Month/Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Card Number";
            // 
            // txtCardName
            // 
            this.txtCardName.Location = new System.Drawing.Point(160, 103);
            this.txtCardName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(129, 22);
            this.txtCardName.TabIndex = 30;
            // 
            // txtExpirationDate
            // 
            this.txtExpirationDate.Location = new System.Drawing.Point(208, 144);
            this.txtExpirationDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExpirationDate.Name = "txtExpirationDate";
            this.txtExpirationDate.Size = new System.Drawing.Size(145, 22);
            this.txtExpirationDate.TabIndex = 26;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(143, 62);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(147, 22);
            this.txtCardNumber.TabIndex = 25;
            this.txtCardNumber.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Credit Card Details";
            // 
            // btnMakeBooking
            // 
            this.btnMakeBooking.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMakeBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeBooking.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMakeBooking.Location = new System.Drawing.Point(78, 372);
            this.btnMakeBooking.Name = "btnMakeBooking";
            this.btnMakeBooking.Size = new System.Drawing.Size(166, 49);
            this.btnMakeBooking.TabIndex = 23;
            this.btnMakeBooking.Text = "Confirm Booking Details";
            this.btnMakeBooking.UseVisualStyleBackColor = false;
            this.btnMakeBooking.Click += new System.EventHandler(this.btnMakeBooking_Click);
            // 
            // rtxtBookingDetails
            // 
            this.rtxtBookingDetails.Location = new System.Drawing.Point(39, 18);
            this.rtxtBookingDetails.Name = "rtxtBookingDetails";
            this.rtxtBookingDetails.Size = new System.Drawing.Size(554, 332);
            this.rtxtBookingDetails.TabIndex = 22;
            this.rtxtBookingDetails.Text = "";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(889, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 49);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMakeFinalBooking
            // 
            this.btnMakeFinalBooking.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMakeFinalBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeFinalBooking.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMakeFinalBooking.Location = new System.Drawing.Point(751, 314);
            this.btnMakeFinalBooking.Name = "btnMakeFinalBooking";
            this.btnMakeFinalBooking.Size = new System.Drawing.Size(120, 49);
            this.btnMakeFinalBooking.TabIndex = 12;
            this.btnMakeFinalBooking.Text = "Make Booking";
            this.btnMakeFinalBooking.UseVisualStyleBackColor = false;
            this.btnMakeFinalBooking.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(379, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Make Booking";
            // 
            // MakeBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 651);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Name = "MakeBooking";
            this.Text = "MakeBooking";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox rtxtBookingDetails;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMakeFinalBooking;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMakeBooking;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radioFullAmount;
        private System.Windows.Forms.RadioButton radioPayDeposit;
        private System.Windows.Forms.RadioButton radioPayLater;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.TextBox txtExpirationDate;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label label1;
    }
}