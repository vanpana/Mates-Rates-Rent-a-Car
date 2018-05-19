namespace MRRC.View
{
    partial class SearchVehicle
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
            this.vehicleList = new System.Windows.Forms.ListBox();
            this.rateLabel = new System.Windows.Forms.Label();
            this.rateBox = new System.Windows.Forms.TextBox();
            this.queryText = new System.Windows.Forms.TextBox();
            this.queryLabel = new System.Windows.Forms.Label();
            this.actionButton = new System.Windows.Forms.Button();
            this.errorBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vehicleList
            // 
            this.vehicleList.FormattingEnabled = true;
            this.vehicleList.ItemHeight = 24;
            this.vehicleList.Location = new System.Drawing.Point(651, 12);
            this.vehicleList.Name = "vehicleList";
            this.vehicleList.Size = new System.Drawing.Size(412, 412);
            this.vehicleList.TabIndex = 0;
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Location = new System.Drawing.Point(12, 12);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(146, 25);
            this.rateLabel.TabIndex = 1;
            this.rateLabel.Text = "Rate (min-max)";
            // 
            // rateBox
            // 
            this.rateBox.Location = new System.Drawing.Point(17, 49);
            this.rateBox.Name = "rateBox";
            this.rateBox.Size = new System.Drawing.Size(200, 29);
            this.rateBox.TabIndex = 2;
            // 
            // queryText
            // 
            this.queryText.Location = new System.Drawing.Point(17, 146);
            this.queryText.Name = "queryText";
            this.queryText.Size = new System.Drawing.Size(600, 29);
            this.queryText.TabIndex = 4;
            // 
            // queryLabel
            // 
            this.queryLabel.AutoSize = true;
            this.queryLabel.Location = new System.Drawing.Point(12, 109);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(66, 25);
            this.queryLabel.TabIndex = 3;
            this.queryLabel.Text = "Query";
            // 
            // actionButton
            // 
            this.actionButton.Location = new System.Drawing.Point(17, 208);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(75, 33);
            this.actionButton.TabIndex = 5;
            this.actionButton.Text = "Filter";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // errorBox
            // 
            this.errorBox.AutoSize = true;
            this.errorBox.Location = new System.Drawing.Point(14, 328);
            this.errorBox.Name = "errorBox";
            this.errorBox.Size = new System.Drawing.Size(64, 25);
            this.errorBox.TabIndex = 6;
            this.errorBox.Text = "label1";
            // 
            // SearchVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 450);
            this.Controls.Add(this.errorBox);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.queryText);
            this.Controls.Add(this.queryLabel);
            this.Controls.Add(this.rateBox);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.vehicleList);
            this.Name = "SearchVehicle";
            this.Text = "SearchVehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox vehicleList;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.TextBox rateBox;
        private System.Windows.Forms.TextBox queryText;
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.Label errorBox;
    }
}