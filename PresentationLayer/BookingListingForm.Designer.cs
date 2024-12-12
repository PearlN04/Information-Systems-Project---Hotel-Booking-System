namespace PhumlaKamnandiSystem.PresentationLayer
{
    partial class BookingListingForm
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.numOfRoomsTextBox = new System.Windows.Forms.TextBox();
            this.numOfRoomsLabel = new System.Windows.Forms.Label();
            this.numOfGuestsTextBox = new System.Windows.Forms.TextBox();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.checkOutTextBox = new System.Windows.Forms.TextBox();
            this.CheckOutDateLabel = new System.Windows.Forms.Label();
            this.guestIDTextBox = new System.Windows.Forms.TextBox();
            this.guestIDLabel = new System.Windows.Forms.Label();
            this.checkInTextBox = new System.Windows.Forms.TextBox();
            this.CheckInDateLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.bookingListView = new System.Windows.Forms.ListView();
            this.listLabel = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.payStatusLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteButton.Location = new System.Drawing.Point(945, 380);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(131, 58);
            this.deleteButton.TabIndex = 35;
            this.deleteButton.Text = "Cancel a guest booking";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click_1);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editButton.Location = new System.Drawing.Point(804, 380);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(135, 58);
            this.editButton.TabIndex = 34;
            this.editButton.Text = "Change a Guest Booking";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.SteelBlue;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submitButton.Location = new System.Drawing.Point(878, 623);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(133, 41);
            this.submitButton.TabIndex = 33;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click_1);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.DarkGray;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelButton.Location = new System.Drawing.Point(691, 623);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(143, 41);
            this.cancelButton.TabIndex = 32;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // numOfRoomsTextBox
            // 
            this.numOfRoomsTextBox.Location = new System.Drawing.Point(303, 559);
            this.numOfRoomsTextBox.Name = "numOfRoomsTextBox";
            this.numOfRoomsTextBox.Size = new System.Drawing.Size(241, 22);
            this.numOfRoomsTextBox.TabIndex = 31;
            // 
            // numOfRoomsLabel
            // 
            this.numOfRoomsLabel.AutoSize = true;
            this.numOfRoomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfRoomsLabel.Location = new System.Drawing.Point(105, 559);
            this.numOfRoomsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numOfRoomsLabel.Name = "numOfRoomsLabel";
            this.numOfRoomsLabel.Size = new System.Drawing.Size(160, 20);
            this.numOfRoomsLabel.TabIndex = 30;
            this.numOfRoomsLabel.Text = "Number of Rooms";
            // 
            // numOfGuestsTextBox
            // 
            this.numOfGuestsTextBox.Location = new System.Drawing.Point(299, 518);
            this.numOfGuestsTextBox.Name = "numOfGuestsTextBox";
            this.numOfGuestsTextBox.Size = new System.Drawing.Size(241, 22);
            this.numOfGuestsTextBox.TabIndex = 29;
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentLabel.Location = new System.Drawing.Point(102, 518);
            this.paymentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(162, 20);
            this.paymentLabel.TabIndex = 28;
            this.paymentLabel.Text = "Number of Guests";
            // 
            // checkOutTextBox
            // 
            this.checkOutTextBox.Location = new System.Drawing.Point(299, 478);
            this.checkOutTextBox.Name = "checkOutTextBox";
            this.checkOutTextBox.Size = new System.Drawing.Size(241, 22);
            this.checkOutTextBox.TabIndex = 27;
            // 
            // CheckOutDateLabel
            // 
            this.CheckOutDateLabel.AutoSize = true;
            this.CheckOutDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutDateLabel.Location = new System.Drawing.Point(104, 478);
            this.CheckOutDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CheckOutDateLabel.Name = "CheckOutDateLabel";
            this.CheckOutDateLabel.Size = new System.Drawing.Size(143, 20);
            this.CheckOutDateLabel.TabIndex = 26;
            this.CheckOutDateLabel.Text = "Check Out Date";
            // 
            // guestIDTextBox
            // 
            this.guestIDTextBox.Location = new System.Drawing.Point(659, 380);
            this.guestIDTextBox.Name = "guestIDTextBox";
            this.guestIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.guestIDTextBox.TabIndex = 25;
            // 
            // guestIDLabel
            // 
            this.guestIDLabel.AutoSize = true;
            this.guestIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestIDLabel.Location = new System.Drawing.Point(541, 382);
            this.guestIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guestIDLabel.Name = "guestIDLabel";
            this.guestIDLabel.Size = new System.Drawing.Size(84, 20);
            this.guestIDLabel.TabIndex = 24;
            this.guestIDLabel.Text = "Guest ID";
            // 
            // checkInTextBox
            // 
            this.checkInTextBox.Location = new System.Drawing.Point(299, 433);
            this.checkInTextBox.Name = "checkInTextBox";
            this.checkInTextBox.Size = new System.Drawing.Size(241, 22);
            this.checkInTextBox.TabIndex = 23;
            // 
            // CheckInDateLabel
            // 
            this.CheckInDateLabel.AutoSize = true;
            this.CheckInDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInDateLabel.Location = new System.Drawing.Point(103, 433);
            this.CheckInDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CheckInDateLabel.Name = "CheckInDateLabel";
            this.CheckInDateLabel.Size = new System.Drawing.Size(116, 20);
            this.CheckInDateLabel.TabIndex = 22;
            this.CheckInDateLabel.Text = "CheckInDate";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(299, 382);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTextBox.TabIndex = 21;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(103, 382);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(101, 20);
            this.idLabel.TabIndex = 20;
            this.idLabel.Text = "Booking ID";
            // 
            // bookingListView
            // 
            this.bookingListView.FullRowSelect = true;
            this.bookingListView.GridLines = true;
            this.bookingListView.HideSelection = false;
            this.bookingListView.Location = new System.Drawing.Point(95, 49);
            this.bookingListView.Margin = new System.Windows.Forms.Padding(4);
            this.bookingListView.MultiSelect = false;
            this.bookingListView.Name = "bookingListView";
            this.bookingListView.Size = new System.Drawing.Size(925, 312);
            this.bookingListView.TabIndex = 19;
            this.bookingListView.UseCompatibleStateImageBehavior = false;
            this.bookingListView.View = System.Windows.Forms.View.Details;
            this.bookingListView.SelectedIndexChanged += new System.EventHandler(this.bookingListView_SelectedIndexChanged);
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLabel.Location = new System.Drawing.Point(95, 24);
            this.listLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(59, 20);
            this.listLabel.TabIndex = 18;
            this.listLabel.Text = "label1";
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(304, 598);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(100, 22);
            this.txtPayment.TabIndex = 37;
            // 
            // payStatusLabel
            // 
            this.payStatusLabel.AutoSize = true;
            this.payStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payStatusLabel.Location = new System.Drawing.Point(107, 600);
            this.payStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.payStatusLabel.Name = "payStatusLabel";
            this.payStatusLabel.Size = new System.Drawing.Size(141, 20);
            this.payStatusLabel.TabIndex = 38;
            this.payStatusLabel.Text = "Payment Status";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(106, 633);
            this.amountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(120, 20);
            this.amountLabel.TabIndex = 39;
            this.amountLabel.Text = "Total Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(305, 633);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 40;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.ForeColor = System.Drawing.Color.IndianRed;
            this.lblSelect.Location = new System.Drawing.Point(453, 25);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(371, 20);
            this.lblSelect.TabIndex = 41;
            this.lblSelect.Text = "Select a row to view ,edit or delete booking";
            // 
            // BookingListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 676);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.payStatusLabel);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.numOfRoomsTextBox);
            this.Controls.Add(this.numOfRoomsLabel);
            this.Controls.Add(this.numOfGuestsTextBox);
            this.Controls.Add(this.paymentLabel);
            this.Controls.Add(this.checkOutTextBox);
            this.Controls.Add(this.CheckOutDateLabel);
            this.Controls.Add(this.guestIDTextBox);
            this.Controls.Add(this.guestIDLabel);
            this.Controls.Add(this.checkInTextBox);
            this.Controls.Add(this.CheckInDateLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.bookingListView);
            this.Controls.Add(this.listLabel);
            this.Name = "BookingListingForm";
            this.Text = "BookingListingForm";
            this.Activated += new System.EventHandler(this.BookingListingForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BookingListingForm_FormClosed);
            this.Load += new System.EventHandler(this.BookingListingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox numOfRoomsTextBox;
        private System.Windows.Forms.Label numOfRoomsLabel;
        private System.Windows.Forms.TextBox numOfGuestsTextBox;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.TextBox checkOutTextBox;
        private System.Windows.Forms.Label CheckOutDateLabel;
        private System.Windows.Forms.TextBox guestIDTextBox;
        private System.Windows.Forms.Label guestIDLabel;
        private System.Windows.Forms.TextBox checkInTextBox;
        private System.Windows.Forms.Label CheckInDateLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.ListView bookingListView;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label payStatusLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblSelect;
    }
}