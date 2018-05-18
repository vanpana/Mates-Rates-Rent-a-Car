using MRRC.Controller;
using MRRC.Domain;
using MRRC.Util;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MRRC.View
{
    public partial class FleetManager : Form
    {
        private ControllerImpl controller;
        private Actions action;

        public FleetManager()
        {
            InitializeComponent();
        }

        public FleetManager(ControllerImpl controller)
        {
            InitializeComponent();
            this.controller = controller;

            LoadListItems();
            HideInputs();
            LoadComboBoxes();
        }

        /*
         * Populates Fleet list with the items in the repository
         * */
        private void LoadListItems()
        {
            // Delete items if existent
            fleetList.Items.Clear();

            // Load new ones from the repository
            foreach (Vehicle vehicle in controller.Vehicles)
            {
                fleetList.Items.Add(vehicle.CSV);
            }
        }

        /*
         * Hide the inputs for a clean window
         * */
        private void HideInputs()
        {
            registrationLabel.Visible = false;
            registrationText.Visible = false;

            makeLabel.Visible = false;
            makeText.Visible = false;

            modelLabel.Visible = false;
            modelText.Visible = false;

            yearLabel.Visible = false;
            yearText.Visible = false;

            classLabel.Visible = false;
            classCombo.Visible = false;

            seatLabel.Visible = false;
            seatText.Visible = false;

            transmissionLabel.Visible = false;
            transmissionCombo.Visible = false;

            fuelLabel.Visible = false;
            fuelCombo.Visible = false;

            gpsBox.Visible = false;
            sunBox.Visible = false;

            colorLabel.Visible = false;
            colorText.Visible = false;

            rateLabel.Visible = false;
            rateText.Visible = false;

            messageLabel.Visible = false;
        }

        private void LoadComboBoxes()
        {
            // Add vehicle class items to the combo box
            classCombo.Items.AddRange(Enum.GetValues(typeof(VehicleClass)).Cast<object>().ToArray());

            // Add transmission items to the combo box
            transmissionCombo.Items.AddRange(Enum.GetValues(typeof(Transmission)).Cast<object>().ToArray());

            // Add fuel items to the combo box
            fuelCombo.Items.AddRange(Enum.GetValues(typeof(Fuel)).Cast<object>().ToArray());
        }
        /*
        * Save all data to file when the form is closed
        * */
        private void FleetManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Build the text and write it to file
            FileUtil.SaveDataToFile(FileUtil.getFleetsFile(), controller.VehicleCSV);
        }

        /*
          * Shows input for add and update actions.
          * */
        private void ShowAddUpdateInputs()
        {
            registrationLabel.Visible = true;
            registrationText.Visible = true;

            makeLabel.Visible = true;
            makeText.Visible = true;

            modelLabel.Visible = true;
            modelText.Visible = true;

            yearLabel.Visible = true;
            yearText.Visible = true;

            classLabel.Visible = true;
            classCombo.Visible = true;

            seatLabel.Visible = true;
            seatText.Visible = true;

            transmissionLabel.Visible = true;
            transmissionCombo.Visible = true;

            fuelLabel.Visible = true;
            fuelCombo.Visible = true;

            gpsBox.Visible = true;
            sunBox.Visible = true;

            colorLabel.Visible = true;
            colorText.Visible = true;

            rateLabel.Visible = true;
            rateText.Visible = true;
        }

        /*
         * Shows input for delete action.
         * */
        private void ShowDeleteInputs()
        {
            HideInputs();

            registrationLabel.Visible = true;
            registrationText.Visible = true;
        }

        private void FleetManager_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            action = Actions.add;
            ShowAddUpdateInputs();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            action = Actions.update;
            ShowAddUpdateInputs();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Check if anything is selected in the list
            if (fleetList.SelectedItems.Count > 0)
            {
                // Fetch selected value
                String value = fleetList.SelectedItem.ToString();

                // Get vehicle on selected ID
                Vehicle vehicle = controller.GetVehicle(value.Split(',')[0]);

                // Delete the vehicle if it exists
                controller.DeleteVehicle(vehicle.Registration);

                // Clear selection
                fleetList.ClearSelected();

                // Reload the list
                LoadListItems();
            }

            action = Actions.delete;
            ShowDeleteInputs();
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            // Try to do the action, preventing any other exception
            try
            {
                // The add logic
                if (action == Actions.add)
                {
                    // Check if the registration has content
                    if (registrationText.Text == "") throw new Exception("Registration cannot be empty!");

                    // Add the vehicle
                    controller.AddVehicle(
                        registrationText.Text, makeText.Text, modelText.Text, yearText.Text,
                        classCombo.GetItemText(classCombo.SelectedItem), int.Parse(seatText.Text),
                        transmissionCombo.GetItemText(transmissionCombo.SelectedItem),
                        fuelCombo.GetItemText(fuelCombo.SelectedItem),
                        gpsBox.Checked, sunBox.Checked, colorText.Text, int.Parse(rateText.Text));

                    // Hide the inputs if successful
                    HideInputs();
                }

                // The update logic 
                else if (action == Actions.update)
                {
                    // Check if the registration has content
                    if (registrationText.Text == "") throw new Exception("Registration cannot be empty!");

                    // Update the vehicle
                    controller.UpdateVehicle(registrationText.Text, makeText.Text, modelText.Text, yearText.Text,
                        classCombo.GetItemText(classCombo.SelectedItem), int.Parse(seatText.Text),
                        transmissionCombo.GetItemText(transmissionCombo.SelectedItem),
                        fuelCombo.GetItemText(fuelCombo.SelectedItem),
                        gpsBox.Checked, sunBox.Checked, colorText.Text, int.Parse(rateText.Text));

                    // Hide the inputs if successful
                    HideInputs();
                }

                // The delete logic
                else if (action == Actions.delete)
                {
                    // Check if the registration has content
                    if (registrationText.Text == "") throw new Exception("Registration cannot be empty!");

                    // Delete the customer
                    controller.DeleteVehicle(registrationText.Text);

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
    }
}
