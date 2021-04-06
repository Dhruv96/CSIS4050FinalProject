using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTeam02AirlineBooking
{
    public partial class AdminPageForm : Form
    {
        public AdminPageForm()
        {
            InitializeComponent();

            //Button click event handler
            buttonManageFlights.Click += ButtonManageFlights_Click;
            buttonManageBookings.Click += ButtonManageBookings_Click;

        }
        
        private void ButtonManageBookings_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            ManageBookingsForm manageBookingsForm = new ManageBookingsForm();

            manageBookingsForm.ShowDialog();

            this.Close();
        }

        private void ButtonManageFlights_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            ManageFlightForm manageFlightsForm = new ManageFlightForm();

            manageFlightsForm.ShowDialog();

            this.Close();
        }
    }
}
