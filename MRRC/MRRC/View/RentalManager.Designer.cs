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
            // RentalManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}