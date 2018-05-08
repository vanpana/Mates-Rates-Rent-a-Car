using MRRC.Controller;
using MRRC.Domain.Entities;
using MRRC.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRRC.View
{
    public partial class RentalManager : Form
    {
        private ControllerImpl controller;

        public RentalManager(ControllerImpl controller)
        {
            InitializeComponent();
            this.controller = controller;

            LoadListItems();
        }

        /*
        * Populates Rental list with the items in the repository
        * */
        private void LoadListItems()
        {
            // Load header
            Header.Text = String.Join(", ", controller.RentalHeader);

            // Load items
            foreach (Rental rental in controller.Rentals)
            {
                rentalList.Items.Add(rental.CSV);
            }
        }

        /*
         * Save all data to file when the form is closed
         * */
        private void RentalManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Build the text and write it to file
            FileUtil.SaveDataToFile(FileUtil.getRentalsFile(), controller.RentalCSV);
        }
    }
}
