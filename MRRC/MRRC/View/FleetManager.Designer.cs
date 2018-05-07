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
            // FleetManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fleetList);
            this.Name = "FleetManager";
            this.Text = "FleetManager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox fleetList;
    }
}