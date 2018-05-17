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
        private Actions action;

        public RentalManager(ControllerImpl controller)
        {
            InitializeComponent();
            this.controller = controller;

            LoadListItems();
            HideInputs();
        }

        /*
        * Populates Rental list with the items in the repository
        * */
        private void LoadListItems()
        {
            // Delete items if existent
            rentalList.Items.Clear();

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

        /*
         * Hide the inputs for a clean window
         * */
        private void HideInputs()
        {
            customerIDLabel.Visible = false;
            customerIDText.Visible = false;

            vehicleRegistrationLabel.Visible = false;
            vehicleRegistrationText.Visible = false;

            actionButton.Visible = false;

            messageLabel.Visible = false;
        }

        private void ShowAddDeleteInputs()
        {
            customerIDLabel.Visible = true;
            customerIDText.Visible = true;

            vehicleRegistrationLabel.Visible = true;
            vehicleRegistrationText.Visible = true;

            actionButton.Visible = true;
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            // Try to do the action, preventing any other exception
            try
            {
                // The add logic
                if (action == Actions.add)
                {

                    // Check if the IDs have content
                    if (vehicleRegistrationText.Text == "") throw new Exception("Registration cannot be empty!");
                    if (customerIDText.Text == "") throw new Exception("ID cannot be empty!");


                    // Add the rental
                    controller.AddRental(vehicleRegistrationText.Text, int.Parse(customerIDText.Text));

                    // Hide the inputs if successful
                    HideInputs();
                }

                // The delete logic
                else if (action == Actions.delete)
                {
                    // Check if the IDs have content
                    if (vehicleRegistrationText.Text == "") throw new Exception("Registration cannot be empty!");
                    if (customerIDText.Text == "") throw new Exception("ID cannot be empty!");

                    // Delete the rental
                    controller.DeleteRental(new Tuple<string, int>(vehicleRegistrationText.Text, int.Parse(customerIDText.Text)));
                    
                    // Hide the inputs if successful
                    HideInputs();
                }
            }
            catch (Exception ce)
            {
                // If any exception occurs, prompt the user
                messageLabel.Visible = true;
                messageLabel.Text = ce.Message;
            }
            finally
            {
                // Reload the list
                LoadListItems();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            action = Actions.add;
            ShowAddDeleteInputs();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Check if anything is selected in the list
            if (rentalList.SelectedItems.Count > 0)
            {
                // Fetch selected value
                String value = rentalList.SelectedItem.ToString();

                // Get rental on selected ID
                Rental rental = controller.GetRental(int.Parse(value.Split(',')[1]));

                // Delete the rental if it exists
                controller.DeleteRental((new Tuple<string, int>(rental.RegistrationNumber, rental.ClientID)));

                // Clear selection
                rentalList.ClearSelected();

                // Reload the list
                LoadListItems();
            }
            else
            {
                action = Actions.delete;
                ShowAddDeleteInputs();
            }
        }
    }
}
