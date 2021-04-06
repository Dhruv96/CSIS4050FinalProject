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
    public partial class LoginForm : Form
    {
        AirlineEntities context;
        public LoginForm()
        {
            InitializeComponent();
            context = new AirlineEntities();
            context.SeedDatabase();
            buttonLoginAsPassenger.Click += ButtonLoginAsPassenger_Click;
            buttonLoginAsAdmin.Click += ButtonLoginAsAdmin_Click;
        }

        private void ButtonLoginAsAdmin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            this.Hide();
            AdminPageForm adminPageForm = new AdminPageForm();
            adminPageForm.ShowDialog();
            this.Close();
        }

        private void ButtonLoginAsPassenger_Click(object sender, EventArgs e)
        {
            this.Hide();
            PassengerForm passengerForm = new PassengerForm();
            passengerForm.ShowDialog();
            this.Close();
        }
    }
}
