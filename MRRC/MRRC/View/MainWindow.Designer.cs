namespace MRRC
{
    partial class MainWindow
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
            this.Title = new System.Windows.Forms.Label();
            this.fleetButton = new System.Windows.Forms.Button();
            this.customersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(239, 40);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(287, 29);
            this.Title.TabIndex = 0;
            this.Title.Text = "Mates Rates Rent a Car";
            // 
            // fleetButton
            // 
            this.fleetButton.Location = new System.Drawing.Point(244, 126);
            this.fleetButton.Name = "fleetButton";
            this.fleetButton.Size = new System.Drawing.Size(282, 38);
            this.fleetButton.TabIndex = 1;
            this.fleetButton.Text = "Manage Fleet";
            this.fleetButton.UseVisualStyleBackColor = true;
            this.fleetButton.Click += new System.EventHandler(this.fleetButton_Click);
            // 
            // customersButton
            // 
            this.customersButton.Location = new System.Drawing.Point(244, 206);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(282, 38);
            this.customersButton.TabIndex = 2;
            this.customersButton.Text = "Manage Customers";
            this.customersButton.UseVisualStyleBackColor = true;
            this.customersButton.Click += new System.EventHandler(this.customersButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customersButton);
            this.Controls.Add(this.fleetButton);
            this.Controls.Add(this.Title);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button fleetButton;
        private System.Windows.Forms.Button customersButton;
    }
}

