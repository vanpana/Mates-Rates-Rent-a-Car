using MRRC.Controller;
using MRRC.Domain;
using MRRC.Domain.Entities.Attributes;
using MRRC.Domain.Entities.Logicals;
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
    public partial class SearchVehicle : Form
    {
        ControllerImpl controller;

        public SearchVehicle(ControllerImpl controller)
        {
            InitializeComponent();

            this.controller = controller;
            errorBox.Text = "";
        }

        /*
         * Filter the vehicles
         * */
        private void actionButton_Click(object sender, EventArgs e)
        {
            // Set the error message to nothing
            errorBox.Text = "";

            try
            {
                Logical logical;

                // If there is no input, load all vehicles
                if (rateBox.Text.Equals("") && queryText.Text.Equals(""))
                {
                    logical = null;
                }
                // If there is only rate input, Load vehicles with the price range specified.
                else if (!rateBox.Text.Equals("") && queryText.Text.Equals(""))
                {
                    // Get logical expression
                    logical = controller.GetLogicalFromRate(rateBox.Text);
                }
                // If there is only query text, load vehicles matching the query.
                else if (rateBox.Text.Equals("") && !queryText.Text.Equals(""))
                {
                    // Get logical expression
                    logical = controller.GetLogicalFromQuery(queryText.Text);
                }
                // If both rate and query have values, load vehicles matching the rate and query
                else
                {
                    logical = new AndCompositeLogical(controller.GetLogicalFromRate(rateBox.Text), controller.GetLogicalFromQuery(queryText.Text));
                }

                if (logical != null) // Load vehicles based on the expression
                    LoadListItems(logical.Filter(controller.AvailableVehicles));
                // Load all available vehicles
                else LoadListItems(controller.AvailableVehicles);

                // If no vehicle was loaded, show a message
                if (vehicleList.Items.Count == 0) vehicleList.Items.Add("Sorry, no vehicle found!");
            } catch (Exception exception)
            {
                // Show the error in the message box.
                errorBox.Text = exception.Message;
            }
        }

        /*
        * Populates Rental list with the items queried
        * */
        private void LoadListItems(List<Vehicle> vehicles)
        {
            // Delete items if existent
            vehicleList.Items.Clear();

            // Load items
            foreach (Vehicle vehicle in vehicles)
            {
                vehicleList.Items.Add(vehicle.CSV);
            }
        }
    }
}
