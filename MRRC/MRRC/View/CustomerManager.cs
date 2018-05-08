using MRRC.Controller;
using MRRC.Domain;
using MRRC.Domain.Exceptions;
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
    public partial class CustomerManager : Form
    {
        private ControllerImpl controller;
        private Actions action;

        public CustomerManager(ControllerImpl controller)
        {
            InitializeComponent();

            this.controller = controller;

            LoadListItems();
            HideInputs();
            LoadComboBoxes();
        }

        /*
         * Populates customer list with the items in the repository
         * */
        private void LoadListItems()
        {
            // Delete items if existent
            customerList.Items.Clear();

            // Load new ones from the repository
            foreach (Customer customer in controller.Customers)
            {
                customerList.Items.Add(customer.CSV);
            }
        }

        /*
         * Hide the inputs for a clean window
         * */
        private void HideInputs()
        {
            idLabel.Visible = false;
            idText.Visible = false;

            titleLabel.Visible = false;
            titleCombo.Visible = false;

            firstNameLabel.Visible = false;
            firstNameText.Visible = false;

            lastNameLabel.Visible = false;
            lastNameText.Visible = false;

            genderLabel.Visible = false;
            genderCombo.Visible = false;

            dateOfBirthLabel.Visible = false;
            dateOfBirthText.Visible = false;

            actionButton.Visible = false;
            messageLabel.Visible = false;
        }

        private void LoadComboBoxes()
        {
            // Add title items to the combo box
            titleCombo.Items.AddRange(Enum.GetValues(typeof(CustomerTitle)).Cast<object>().ToArray());

            // Add gender items to the combo box
            genderCombo.Items.AddRange(Enum.GetValues(typeof(Gender)).Cast<object>().ToArray());
        }

        /*
         * Shows input for add and update actions.
         * */
        private void ShowAddUpdateInputs()
        {
            idLabel.Visible = true;
            idText.Visible = true;

            titleLabel.Visible = true;
            titleCombo.Visible = true;

            firstNameLabel.Visible = true;
            firstNameText.Visible = true;

            lastNameLabel.Visible = true;
            lastNameText.Visible = true;

            genderLabel.Visible = true;
            genderCombo.Visible = true;

            dateOfBirthLabel.Visible = true;
            dateOfBirthText.Visible = true;

            actionButton.Visible = true;
            messageLabel.Visible = false;
        }

        /*
         * Shows input for delete action.
         * */
        private void ShowDeleteInputs()
        {
            idLabel.Visible = true;
            idText.Visible = true;

            titleLabel.Visible = false;
            titleCombo.Visible = false;

            firstNameLabel.Visible = false;
            firstNameText.Visible = false;

            lastNameLabel.Visible = false;
            lastNameText.Visible = false;

            genderLabel.Visible = false;
            genderCombo.Visible = false;

            dateOfBirthLabel.Visible = false;
            dateOfBirthText.Visible = false;

            actionButton.Visible = true;
            messageLabel.Visible = false;
        }
        
        /*
         * Save all data to file when the form is closed
         * */
        private void CustomerManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Build the text and write it to file
            FileUtil.SaveDataToFile(FileUtil.getCustomersFile(), controller.CustomersCSV);
        }

        /*
         * Set button action click for the add. Also shows the inputs for the add action.
         * */
        private void addButton_Click(object sender, EventArgs e)
        {
            action = Actions.add;
            ShowAddUpdateInputs();
        }

        /*
         * Set button action click for the update. Also shows the inputs for the update action.
         * */
        private void updateButton_Click(object sender, EventArgs e)
        {
            action = Actions.update;
            ShowAddUpdateInputs();
        }

        /*
         * Set button action click for the delete. Also shows the inputs for the add delete.
         * */
        private void deleteButton_Click(object sender, EventArgs e)
        {
            action = Actions.delete;
            ShowDeleteInputs();
        }

        /*
         * The action button for the CRUD actions.
         * */
        private void actionButton_Click(object sender, EventArgs e)
        {
            // Try to do the action, preventing any other exception
            try
            {
                // The add logic
                if (action == Actions.add)
                {
                    controller.AddCustomer(
                        int.Parse(idText.Text),
                        titleCombo.GetItemText(titleCombo.SelectedItem),
                        firstNameText.Text,
                        lastNameText.Text,
                        genderCombo.GetItemText(genderCombo.SelectedItem),
                        dateOfBirthText.Text);
                }

                // The update logic 
                else if (action == Actions.update)
                {

                }

                // The delete logic
                else if (action == Actions.delete)
                {

                }
            } catch (Exception ce)
            {
                // If any exception occurs, prompt the user
                messageLabel.Visible = true;
                messageLabel.Text = ce.Message;
            } finally
            {
                // Reload the list
                LoadListItems();
            }
        }
    }
}
