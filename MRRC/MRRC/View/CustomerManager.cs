using MRRC.Controller;
using MRRC.Domain;
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
        ControllerImpl controller;

        public CustomerManager(ControllerImpl controller)
        {
            InitializeComponent();

            this.controller = controller;

            LoadListItems();
        }

        /*
         * Populates customer list with the items in the repository
         * */
        private void LoadListItems()
        {
            foreach (Customer customer in controller.Customers)
            {
                customerList.Items.Add(customer.CSV);
            }
        }
        
        /*
         * Save all data to file when the form is closed
         * */
        private void CustomerManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Build the text and write it to file
            FileUtil.SaveDataToFile(FileUtil.getCustomersFile(), controller.CustomersCSV);
        }
    }
}
