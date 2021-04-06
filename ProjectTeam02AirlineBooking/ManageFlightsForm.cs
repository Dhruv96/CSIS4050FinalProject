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
    public partial class ManageFlightForm : Form
    {
        public ManageFlightForm()
        {
            InitializeComponent();

            buttonFlightsInfo.Click += ButtonFlightsInfo_Click;
            buttonAirlinesInfo.Click += ButtonAirlinesInfo_Click;
            buttonAirportsInfo.Click += ButtonAirportsInfo_Click;

        }

        private void ButtonAirportsInfo_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            AirportsAddOrEditForm airportsAddOrEditForm = new AirportsAddOrEditForm();

            airportsAddOrEditForm.ShowDialog();

            this.Close();
        }

        private void ButtonAirlinesInfo_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            AirlinesAddOrEditForm airlinesAddOrEditForm = new AirlinesAddOrEditForm();

            airlinesAddOrEditForm.ShowDialog();

            this.Close();
        }

        private void ButtonFlightsInfo_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            FlightInfoAddOrEditForm flightInfoAddOrEditForm = new FlightInfoAddOrEditForm();

            flightInfoAddOrEditForm.ShowDialog();

            this.Close();
        }
    }
}
