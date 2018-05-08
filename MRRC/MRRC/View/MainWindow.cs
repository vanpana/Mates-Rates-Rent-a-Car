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
using MRRC.Domain.Exceptions;
using MRRC.Domain.Validators;
using MRRC.Repository;
using MRRC.View;

namespace MRRC
{
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

        private void fleetButton_Click(object sender, EventArgs e)
        {
            new FleetManager(controller).Show();
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            new CustomerManager(controller).Show();
        }

        private void rentalsButton_Click(object sender, EventArgs e)
        {
            new RentalManager(controller).Show();
        }
    }
}
