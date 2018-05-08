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
using static System.Windows.Forms.ListViewItem;

namespace MRRC.View
{
    public partial class FleetManager : Form
    {
        private ControllerImpl controller;

        public FleetManager()
        {
            InitializeComponent();
        }

        public FleetManager(ControllerImpl controller)
        {
            InitializeComponent();
            this.controller = controller;

            LoadListItems();
        }

        /*
         * Populates Fleet list with the items in the repository
         * */
        private void LoadListItems()
        {
            foreach(Vehicle vehicle in controller.Vehicles)
            {
                fleetList.Items.Add(vehicle.CSV);
            }
        }

        /*
        * Save all data to file when the form is closed
        * */
        private void FleetManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Build the text and write it to file
            FileUtil.SaveDataToFile(FileUtil.getFleetsFile(), controller.VehicleCSV);
        }
    }
}
