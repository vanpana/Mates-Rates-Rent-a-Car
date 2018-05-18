namespace MRRC.View
{
    partial class CustomerManager
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
            this.customerList = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.idText = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.titleCombo = new System.Windows.Forms.ComboBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.genderCombo = new System.Windows.Forms.ComboBox();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.dateOfBirthText = new System.Windows.Forms.TextBox();
            this.actionButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerList
            // 
            this.customerList.FormattingEnabled = true;
            this.customerList.ItemHeight = 24;
            this.customerList.Location = new System.Drawing.Point(12, 12);
            this.customerList.Name = "customerList";
            this.customerList.Size = new System.Drawing.Size(776, 340);
            this.customerList.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 358);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(238, 34);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(278, 358);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(238, 34);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(550, 358);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(238, 34);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(37, 462);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(100, 29);
            this.idText.TabIndex = 5;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(32, 434);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(31, 25);
            this.idLabel.TabIndex = 6;
            this.idLabel.Text = "ID";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(311, 434);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(106, 25);
            this.firstNameLabel.TabIndex = 8;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(316, 462);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(200, 29);
            this.firstNameText.TabIndex = 7;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(545, 434);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(106, 25);
            this.lastNameLabel.TabIndex = 10;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(550, 462);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(200, 29);
            this.lastNameText.TabIndex = 9;
            // 
            // titleCombo
            // 
            this.titleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.titleCombo.FormattingEnabled = true;
            this.titleCombo.Location = new System.Drawing.Point(158, 459);
            this.titleCombo.Name = "titleCombo";
            this.titleCombo.Size = new System.Drawing.Size(121, 32);
            this.titleCombo.TabIndex = 11;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(156, 431);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(49, 25);
            this.titleLabel.TabIndex = 12;
            this.titleLabel.Text = "Title";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(82, 509);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(77, 25);
            this.genderLabel.TabIndex = 14;
            this.genderLabel.Text = "Gender";
            // 
            // genderCombo
            // 
            this.genderCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderCombo.FormattingEnabled = true;
            this.genderCombo.Location = new System.Drawing.Point(84, 537);
            this.genderCombo.Name = "genderCombo";
            this.genderCombo.Size = new System.Drawing.Size(121, 32);
            this.genderCombo.TabIndex = 13;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(446, 509);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(118, 25);
            this.dateOfBirthLabel.TabIndex = 16;
            this.dateOfBirthLabel.Text = "Date of Birth";
            // 
            // dateOfBirthText
            // 
            this.dateOfBirthText.Location = new System.Drawing.Point(451, 537);
            this.dateOfBirthText.Name = "dateOfBirthText";
            this.dateOfBirthText.Size = new System.Drawing.Size(200, 29);
            this.dateOfBirthText.TabIndex = 15;
            // 
            // actionButton
            // 
            this.actionButton.Location = new System.Drawing.Point(358, 590);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(75, 38);
            this.actionButton.TabIndex = 17;
            this.actionButton.Text = "Do it!";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(369, 650);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 25);
            this.messageLabel.TabIndex = 18;
            // 
            // CustomerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 684);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthText);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.genderCombo);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titleCombo);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.customerList);
            this.Name = "CustomerManager";
            this.Text = "CustomerManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerManager_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox customerList;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.ComboBox titleCombo;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.ComboBox genderCombo;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.TextBox dateOfBirthText;
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.Label messageLabel;
    }
}