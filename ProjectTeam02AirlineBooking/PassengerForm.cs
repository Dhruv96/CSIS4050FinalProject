using EFControllerUtilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineBookingCodeFirstFromDB;
using System.Windows.Forms;

namespace ProjectTeam02AirlineBooking
{
    public partial class PassengerForm : Form
    {
        public PassengerForm()
        {
            InitializeComponent();
            this.Load += PassengerForm_Load;
        }

        private void PassengerForm_Load(object sender, EventArgs e)
        { 
            comboBoxAirlines.DataSource = Controller<AirlineEntities, Airline>.SetBindingList();
        }
    }
}
