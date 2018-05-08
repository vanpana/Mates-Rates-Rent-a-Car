using MRRC.Controller;
using MRRC.Domain.Entities;
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
            foreach (Rental rental in controller.Rentals)
            {
                rentalList.Items.Add(rental.CSV);
            }
        }
    }
}
