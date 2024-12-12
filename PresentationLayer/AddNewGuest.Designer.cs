namespace PhumlaKamnandiSystem.PresentationLayer
{
    partial class AddNewGuest
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlGuestInfo = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.btnGenerateGuestID = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtIDNumber = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.lblGuestIID = new System.Windows.Forms.Label();
            this.lblSubheading = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnMakeBooking = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlGuestInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Controls.Add(this.pnlLogo);
            this.panel1.Location = new System.Drawing.Point(-12, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 79);
            this.panel1.TabIndex = 2;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHeading.Location = new System.Drawing.Point(251, 11);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(739, 71);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "Phumla Kamnandi Booking System";
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::PhumlaKamnandiSystem.Properties.Resources.WhatsApp_Image_2024_09_25_at_16_521;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Location = new System.Drawing.Point(47, 11);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(109, 54);
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlGuestInfo
            // 
            this.pnlGuestInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGuestInfo.Controls.Add(this.lblInfo);
            this.pnlGuestInfo.Controls.Add(this.btnAddGuest);
            this.pnlGuestInfo.Controls.Add(this.btnGenerateGuestID);
            this.pnlGuestInfo.Controls.Add(this.txtName);
            this.pnlGuestInfo.Controls.Add(this.txtSurname);
            this.pnlGuestInfo.Controls.Add(this.txtEmail);
            this.pnlGuestInfo.Controls.Add(this.txtIDNumber);
            this.pnlGuestInfo.Controls.Add(this.txtPhone);
            this.pnlGuestInfo.Controls.Add(this.txtAddress);
            this.pnlGuestInfo.Controls.Add(this.txtGuestID);
            this.pnlGuestInfo.Controls.Add(this.lblIDNumber);
            this.pnlGuestInfo.Controls.Add(this.lblEmail);
            this.pnlGuestInfo.Controls.Add(this.lblSurname);
            this.pnlGuestInfo.Controls.Add(this.lblAddress);
            this.pnlGuestInfo.Controls.Add(this.lblPhone);
            this.pnlGuestInfo.Controls.Add(this.lblGuestName);
            this.pnlGuestInfo.Controls.Add(this.lblGuestIID);
            this.pnlGuestInfo.Location = new System.Drawing.Point(251, 167);
            this.pnlGuestInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGuestInfo.Name = "pnlGuestInfo";
            this.pnlGuestInfo.Size = new System.Drawing.Size(648, 394);
            this.pnlGuestInfo.TabIndex = 3;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.IndianRed;
            this.lblInfo.Location = new System.Drawing.Point(41, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(405, 18);
            this.lblInfo.TabIndex = 27;
            this.lblInfo.Text = "To generate guest ID , please enter name and ID first";
            // 
            // btnAddGuest
            // 
            this.btnAddGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGuest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddGuest.Location = new System.Drawing.Point(131, 338);
            this.btnAddGuest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(185, 42);
            this.btnAddGuest.TabIndex = 26;
            this.btnAddGuest.Text = "Add Guest";
            this.btnAddGuest.UseVisualStyleBackColor = false;
            this.btnAddGuest.Click += new System.EventHandler(this.btnAddGuest_Click);
            // 
            // btnGenerateGuestID
            // 
            this.btnGenerateGuestID.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGenerateGuestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateGuestID.Location = new System.Drawing.Point(141, 31);
            this.btnGenerateGuestID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerateGuestID.Name = "btnGenerateGuestID";
            this.btnGenerateGuestID.Size = new System.Drawing.Size(99, 50);
            this.btnGenerateGuestID.TabIndex = 22;
            this.btnGenerateGuestID.Text = "Generate Guest ID";
            this.btnGenerateGuestID.UseVisualStyleBackColor = false;
            this.btnGenerateGuestID.Click += new System.EventHandler(this.btnGenerateGuestID_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(141, 98);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 22);
            this.txtName.TabIndex = 21;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(141, 145);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(216, 22);
            this.txtSurname.TabIndex = 20;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(141, 190);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(216, 22);
            this.txtEmail.TabIndex = 19;
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Location = new System.Drawing.Point(192, 236);
            this.txtIDNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(216, 22);
            this.txtIDNumber.TabIndex = 18;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(192, 271);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(216, 22);
            this.txtPhone.TabIndex = 17;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(192, 310);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(216, 22);
            this.txtAddress.TabIndex = 16;
            // 
            // txtGuestID
            // 
            this.txtGuestID.Location = new System.Drawing.Point(256, 43);
            this.txtGuestID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.Size = new System.Drawing.Size(152, 22);
            this.txtGuestID.TabIndex = 11;
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNumber.Location = new System.Drawing.Point(41, 236);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(99, 20);
            this.lblIDNumber.TabIndex = 10;
            this.lblIDNumber.Text = "ID Number";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(41, 190);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 20);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(40, 146);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(83, 20);
            this.lblSurname.TabIndex = 8;
            this.lblSurname.Text = "Surname";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(45, 310);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(78, 20);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(45, 271);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(61, 20);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestName.Location = new System.Drawing.Point(40, 101);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(57, 20);
            this.lblGuestName.TabIndex = 1;
            this.lblGuestName.Text = "Name";
            // 
            // lblGuestIID
            // 
            this.lblGuestIID.AutoSize = true;
            this.lblGuestIID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestIID.Location = new System.Drawing.Point(40, 46);
            this.lblGuestIID.Name = "lblGuestIID";
            this.lblGuestIID.Size = new System.Drawing.Size(84, 20);
            this.lblGuestIID.TabIndex = 0;
            this.lblGuestIID.Text = "Guest ID";
            // 
            // lblSubheading
            // 
            this.lblSubheading.AutoSize = true;
            this.lblSubheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubheading.Location = new System.Drawing.Point(400, 113);
            this.lblSubheading.Name = "lblSubheading";
            this.lblSubheading.Size = new System.Drawing.Size(224, 32);
            this.lblSubheading.TabIndex = 7;
            this.lblSubheading.Text = "Add New Guest";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(645, 569);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 49);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnMakeBooking
            // 
            this.btnMakeBooking.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMakeBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeBooking.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMakeBooking.Location = new System.Drawing.Point(787, 569);
            this.btnMakeBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMakeBooking.Name = "btnMakeBooking";
            this.btnMakeBooking.Size = new System.Drawing.Size(173, 49);
            this.btnMakeBooking.TabIndex = 25;
            this.btnMakeBooking.Text = "Continue";
            this.btnMakeBooking.UseVisualStyleBackColor = false;
            this.btnMakeBooking.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkGray;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(35, 101);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(126, 44);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "< GO BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AddNewGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 628);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnMakeBooking);
            this.Controls.Add(this.pnlGuestInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSubheading);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddNewGuest";
            this.Text = "AddNewGuest";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlGuestInfo.ResumeLayout(false);
            this.pnlGuestInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlGuestInfo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtIDNumber;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtGuestID;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label lblGuestIID;
        private System.Windows.Forms.Label lblSubheading;
        private System.Windows.Forms.Button btnGenerateGuestID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnMakeBooking;
        private System.Windows.Forms.Button btnAddGuest;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnBack;
    }
}