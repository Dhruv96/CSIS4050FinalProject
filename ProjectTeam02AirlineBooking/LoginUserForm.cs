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
            context.SeedDatabase();
            buttonLoginAsPassenger.Click += ButtonLoginAsPassenger_Click;
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
