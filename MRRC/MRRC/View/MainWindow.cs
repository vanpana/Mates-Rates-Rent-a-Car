using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MRRC.Controller;
using MRRC.Domain;
using MRRC.Domain.Exceptions;
using MRRC.Domain.Validators;
using MRRC.Repository;
using MRRC.Util;
using MRRC.View;

namespace MRRC
{
    public enum Actions { add, update, delete }

    public partial class MainWindow : Form
    {
        private ControllerImpl controller;

        public MainWindow()
        {
            InitializeComponent();

            // Initialize the Controller with the Repositories
            controller = new ControllerImpl(new FleetRepository(new VehicleValidator()),
                new CustomerRepository(new CustomerValidator()), new RentalRepository(new RentalValidator()));
        }

        /*
         * Show the fleet manager window.
         * */
        private void fleetButton_Click(object sender, EventArgs e)
        {
            new FleetManager(controller).Show();
        }

        /*
         * Show the customers manager window.
         * */
        private void customersButton_Click(object sender, EventArgs e)
        {
            new CustomerManager(controller).Show();
        }

        /*
         * Show the rentals manager window.
         * */
        private void rentalsButton_Click(object sender, EventArgs e)
        {
            new RentalManager(controller).Show();
        }

        /*
         * Save all files on closing the app
         * */
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Build the fleets text and write it to file
            FileUtil.SaveDataToFile(FileUtil.getFleetsFile(), controller.VehicleCSV);

            // Build the customers text and write it to file
            FileUtil.SaveDataToFile(FileUtil.getCustomersFile(), controller.CustomersCSV);

            // Build the rentals text and write it to file
            FileUtil.SaveDataToFile(FileUtil.getRentalsFile(), controller.RentalCSV);
        }
    }
}
