namespace MRRC.View
{
    partial class RentalManager
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
            this.rentalList = new System.Windows.Forms.ListBox();
            this.Header = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.customerIDText = new System.Windows.Forms.TextBox();
            this.vehicleRegistrationLabel = new System.Windows.Forms.Label();
            this.vehicleRegistrationText = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.actionButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rentalList
            // 
            this.rentalList.FormattingEnabled = true;
            this.rentalList.ItemHeight = 24;
            this.rentalList.Location = new System.Drawing.Point(12, 37);
            this.rentalList.Name = "rentalList";
            this.rentalList.Size = new System.Drawing.Size(776, 340);
            this.rentalList.TabIndex = 1;
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Location = new System.Drawing.Point(12, 9);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(91, 25);
            this.Header.TabIndex = 2;
            this.Header.Text = "Header...";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 398);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(238, 34);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Rent vehicle";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Location = new System.Drawing.Point(545, 497);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(116, 25);
            this.customerIDLabel.TabIndex = 9;
            this.customerIDLabel.Text = "CustomerID";
            // 
            // customerIDText
            // 
            this.customerIDText.Location = new System.Drawing.Point(550, 525);
            this.customerIDText.Name = "customerIDText";
            this.customerIDText.Size = new System.Drawing.Size(100, 29);
            this.customerIDText.TabIndex = 8;
            // 
            // vehicleRegistrationLabel
            // 
            this.vehicleRegistrationLabel.AutoSize = true;
            this.vehicleRegistrationLabel.Location = new System.Drawing.Point(108, 497);
            this.vehicleRegistrationLabel.Name = "vehicleRegistrationLabel";
            this.vehicleRegistrationLabel.Size = new System.Drawing.Size(184, 25);
            this.vehicleRegistrationLabel.TabIndex = 11;
            this.vehicleRegistrationLabel.Text = "Vehicle Registration";
            // 
            // vehicleRegistrationText
            // 
            this.vehicleRegistrationText.Location = new System.Drawing.Point(113, 525);
            this.vehicleRegistrationText.Name = "vehicleRegistrationText";
            this.vehicleRegistrationText.Size = new System.Drawing.Size(100, 29);
            this.vehicleRegistrationText.TabIndex = 10;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(550, 398);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(238, 34);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Return vehicle";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // actionButton
            // 
            this.actionButton.Location = new System.Drawing.Point(327, 569);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(117, 41);
            this.actionButton.TabIndex = 12;
            this.actionButton.Text = "Do it!";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(353, 641);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(64, 25);
            this.messageLabel.TabIndex = 13;
            this.messageLabel.Text = "label1";
            // 
            // RentalManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 713);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.vehicleRegistrationLabel);
            this.Controls.Add(this.vehicleRegistrationText);
            this.Controls.Add(this.customerIDLabel);
            this.Controls.Add(this.customerIDText);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.rentalList);
            this.Name = "RentalManager";
            this.Text = "RentalManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RentalManager_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox rentalList;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.TextBox customerIDText;
        private System.Windows.Forms.Label vehicleRegistrationLabel;
        private System.Windows.Forms.TextBox vehicleRegistrationText;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.Label messageLabel;
    }
}