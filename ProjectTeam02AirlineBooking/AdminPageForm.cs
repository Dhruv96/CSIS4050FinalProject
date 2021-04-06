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
            buttonManageBookings.Click += ButtonManageBookings_Click;
            buttonManageBookings.Click += ButtonManageBookings_Click1;
            buttonBackToLoginForm.Click += ButtonBackToLoginForm_Click;

        }

        private void ButtonBackToLoginForm_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            LoginUserForm loginUserForm = new LoginUserForm();

            loginUserForm.ShowDialog();

            this.Close();
        }

        private void ButtonManageBookings_Click1(object sender, EventArgs e)
        {
            this.Visible = false;

            ManageBookingsForm manageBookingsForm = new ManageBookingsForm();

            manageBookingsForm.ShowDialog();

            this.Close();
        }

        private void ButtonManageBookings_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            ManageFlightForm manageFlightsForm = new ManageFlightForm();

            manageFlightsForm.ShowDialog();

            this.Close();
        }
    }
}
