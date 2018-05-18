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

            // TODO: Only display the non rented vehicles
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (rateBox.Text.Equals("") && queryText.Text.Equals(""))
                {
                    LoadListItems(controller.Vehicles);
                }
                else if (!rateBox.Text.Equals("") && queryText.Text.Equals(""))
                {
                    // Check if format is min-max
                    String rate = rateBox.Text.Replace(" ", "");

                    // Split the rate string
                    String[] parts = rate.Split('-');

                    // Check if the format is correct
                    if (parts.Length != 2) throw new Exception("Invalid price format!");

                    // Get the min and max rates
                    int min = int.Parse(parts[0]);
                    int max = int.Parse(parts[1]);

                    Logical logical = new LogicalAttribute(new PriceAttribute(min, max));

                    LoadListItems(logical.Filter(controller.Vehicles));
                }
            } catch (Exception exception)
            {
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
