namespace MRRC.View
{
    partial class FleetManager
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
            this.fleetList = new System.Windows.Forms.ListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.registrationText = new System.Windows.Forms.TextBox();
            this.makeLabel = new System.Windows.Forms.Label();
            this.makeText = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.modelText = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearText = new System.Windows.Forms.TextBox();
            this.classLabel = new System.Windows.Forms.Label();
            this.classCombo = new System.Windows.Forms.ComboBox();
            this.seatLabel = new System.Windows.Forms.Label();
            this.seatText = new System.Windows.Forms.TextBox();
            this.transmissionLabel = new System.Windows.Forms.Label();
            this.transmissionCombo = new System.Windows.Forms.ComboBox();
            this.fuelLabel = new System.Windows.Forms.Label();
            this.fuelCombo = new System.Windows.Forms.ComboBox();
            this.gpsBox = new System.Windows.Forms.CheckBox();
            this.sunBox = new System.Windows.Forms.CheckBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorText = new System.Windows.Forms.TextBox();
            this.rateLabel = new System.Windows.Forms.Label();
            this.rateText = new System.Windows.Forms.TextBox();
            this.actionButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fleetList
            // 
            this.fleetList.FormattingEnabled = true;
            this.fleetList.ItemHeight = 24;
            this.fleetList.Location = new System.Drawing.Point(12, 12);
            this.fleetList.Name = "fleetList";
            this.fleetList.Size = new System.Drawing.Size(776, 340);
            this.fleetList.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(550, 374);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(238, 34);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(278, 374);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(238, 34);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 374);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(238, 34);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Location = new System.Drawing.Point(30, 454);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(114, 25);
            this.registrationLabel.TabIndex = 9;
            this.registrationLabel.Text = "Registration";
            // 
            // registrationText
            // 
            this.registrationText.Location = new System.Drawing.Point(35, 482);
            this.registrationText.Name = "registrationText";
            this.registrationText.Size = new System.Drawing.Size(100, 29);
            this.registrationText.TabIndex = 8;
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(168, 454);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(61, 25);
            this.makeLabel.TabIndex = 11;
            this.makeLabel.Text = "Make";
            // 
            // makeText
            // 
            this.makeText.Location = new System.Drawing.Point(173, 482);
            this.makeText.Name = "makeText";
            this.makeText.Size = new System.Drawing.Size(100, 29);
            this.makeText.TabIndex = 10;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(305, 454);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(66, 25);
            this.modelLabel.TabIndex = 13;
            this.modelLabel.Text = "Model";
            // 
            // modelText
            // 
            this.modelText.Location = new System.Drawing.Point(310, 482);
            this.modelText.Name = "modelText";
            this.modelText.Size = new System.Drawing.Size(100, 29);
            this.modelText.TabIndex = 12;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(448, 454);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(53, 25);
            this.yearLabel.TabIndex = 15;
            this.yearLabel.Text = "Year";
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(453, 482);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(100, 29);
            this.yearText.TabIndex = 14;
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(590, 451);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(62, 25);
            this.classLabel.TabIndex = 17;
            this.classLabel.Text = "Class";
            // 
            // classCombo
            // 
            this.classCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classCombo.FormattingEnabled = true;
            this.classCombo.Location = new System.Drawing.Point(592, 479);
            this.classCombo.Name = "classCombo";
            this.classCombo.Size = new System.Drawing.Size(121, 32);
            this.classCombo.TabIndex = 16;
            this.classCombo.SelectedValueChanged += new System.EventHandler(this.classCombo_SelectedValueChanged);
            // 
            // seatLabel
            // 
            this.seatLabel.AutoSize = true;
            this.seatLabel.Location = new System.Drawing.Point(30, 539);
            this.seatLabel.Name = "seatLabel";
            this.seatLabel.Size = new System.Drawing.Size(80, 25);
            this.seatLabel.TabIndex = 19;
            this.seatLabel.Text = "Seat no";
            // 
            // seatText
            // 
            this.seatText.Location = new System.Drawing.Point(35, 567);
            this.seatText.Name = "seatText";
            this.seatText.Size = new System.Drawing.Size(100, 29);
            this.seatText.TabIndex = 18;
            // 
            // transmissionLabel
            // 
            this.transmissionLabel.AutoSize = true;
            this.transmissionLabel.Location = new System.Drawing.Point(171, 536);
            this.transmissionLabel.Name = "transmissionLabel";
            this.transmissionLabel.Size = new System.Drawing.Size(129, 25);
            this.transmissionLabel.TabIndex = 21;
            this.transmissionLabel.Text = "Transmission";
            // 
            // transmissionCombo
            // 
            this.transmissionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transmissionCombo.FormattingEnabled = true;
            this.transmissionCombo.Location = new System.Drawing.Point(173, 564);
            this.transmissionCombo.Name = "transmissionCombo";
            this.transmissionCombo.Size = new System.Drawing.Size(121, 32);
            this.transmissionCombo.TabIndex = 20;
            // 
            // fuelLabel
            // 
            this.fuelLabel.AutoSize = true;
            this.fuelLabel.Location = new System.Drawing.Point(336, 536);
            this.fuelLabel.Name = "fuelLabel";
            this.fuelLabel.Size = new System.Drawing.Size(50, 25);
            this.fuelLabel.TabIndex = 23;
            this.fuelLabel.Text = "Fuel";
            // 
            // fuelCombo
            // 
            this.fuelCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fuelCombo.FormattingEnabled = true;
            this.fuelCombo.Location = new System.Drawing.Point(338, 564);
            this.fuelCombo.Name = "fuelCombo";
            this.fuelCombo.Size = new System.Drawing.Size(121, 32);
            this.fuelCombo.TabIndex = 22;
            // 
            // gpsBox
            // 
            this.gpsBox.AutoSize = true;
            this.gpsBox.Location = new System.Drawing.Point(497, 535);
            this.gpsBox.Name = "gpsBox";
            this.gpsBox.Size = new System.Drawing.Size(80, 29);
            this.gpsBox.TabIndex = 24;
            this.gpsBox.Text = "GPS";
            this.gpsBox.UseVisualStyleBackColor = true;
            // 
            // sunBox
            // 
            this.sunBox.AutoSize = true;
            this.sunBox.Location = new System.Drawing.Point(497, 570);
            this.sunBox.Name = "sunBox";
            this.sunBox.Size = new System.Drawing.Size(107, 29);
            this.sunBox.TabIndex = 25;
            this.sunBox.Text = "Sunroof";
            this.sunBox.UseVisualStyleBackColor = true;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(30, 625);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(59, 25);
            this.colorLabel.TabIndex = 27;
            this.colorLabel.Text = "Color";
            // 
            // colorText
            // 
            this.colorText.Location = new System.Drawing.Point(35, 653);
            this.colorText.Name = "colorText";
            this.colorText.Size = new System.Drawing.Size(100, 29);
            this.colorText.TabIndex = 26;
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Location = new System.Drawing.Point(168, 625);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(100, 25);
            this.rateLabel.TabIndex = 29;
            this.rateLabel.Text = "Daily Rate";
            // 
            // rateText
            // 
            this.rateText.Location = new System.Drawing.Point(173, 653);
            this.rateText.Name = "rateText";
            this.rateText.Size = new System.Drawing.Size(100, 29);
            this.rateText.TabIndex = 28;
            // 
            // actionButton
            // 
            this.actionButton.Location = new System.Drawing.Point(321, 704);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(138, 67);
            this.actionButton.TabIndex = 30;
            this.actionButton.Text = "Do it!";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(345, 834);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(92, 25);
            this.messageLabel.TabIndex = 31;
            this.messageLabel.Text = "message";
            // 
            // FleetManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 896);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.rateText);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.colorText);
            this.Controls.Add(this.sunBox);
            this.Controls.Add(this.gpsBox);
            this.Controls.Add(this.fuelLabel);
            this.Controls.Add(this.fuelCombo);
            this.Controls.Add(this.transmissionLabel);
            this.Controls.Add(this.transmissionCombo);
            this.Controls.Add(this.seatLabel);
            this.Controls.Add(this.seatText);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.classCombo);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.modelText);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.makeText);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.registrationText);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.fleetList);
            this.Name = "FleetManager";
            this.Text = "FleetManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FleetManager_FormClosed);
            this.Load += new System.EventHandler(this.FleetManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox fleetList;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.TextBox registrationText;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.TextBox makeText;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.TextBox modelText;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.ComboBox classCombo;
        private System.Windows.Forms.Label seatLabel;
        private System.Windows.Forms.TextBox seatText;
        private System.Windows.Forms.Label transmissionLabel;
        private System.Windows.Forms.ComboBox transmissionCombo;
        private System.Windows.Forms.Label fuelLabel;
        private System.Windows.Forms.ComboBox fuelCombo;
        private System.Windows.Forms.CheckBox gpsBox;
        private System.Windows.Forms.CheckBox sunBox;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.TextBox colorText;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.TextBox rateText;
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.Label messageLabel;
    }
}