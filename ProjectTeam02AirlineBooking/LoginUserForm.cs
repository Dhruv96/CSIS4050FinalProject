using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirlineBookingCodeFirstFromDB;

namespace ProjectTeam02AirlineBooking
{
    public partial class LoginUserForm : Form
    {
        AirlineEntities context;
        public LoginUserForm()
        {
            InitializeComponent();
            context = new AirlineEntities();
            // Seeding database
            context.SeedDatabase();
            // setting click handlers
            buttonLoginAsPassenger.Click += ButtonLoginAsPassenger_Click;
            buttonLoginAsAdmin.Click += ButtonLoginAsAdmin_Click;
        }

        /// <summary>
        /// This function is called when Login as Admin button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLoginAsAdmin_Click(object sender, EventArgs e)
        {
            // opening admin form
            AdminPageForm adminPageForm = new AdminPageForm();
            adminPageForm.ShowDialog();
            
        }

        /// <summary>
        /// This function is called login as passenger button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLoginAsPassenger_Click(object sender, EventArgs e)
        {
            // opening passenger form
            PassengerForm passengerForm = new PassengerForm();
            passengerForm.ShowDialog();
        }
    }
}
