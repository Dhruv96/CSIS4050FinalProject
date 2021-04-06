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
            this.FormClosed += ManageFlightForm_FormClosed;

        }

        private void ManageFlightForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            AdminPageForm adminPageForm = new AdminPageForm();
            adminPageForm.ShowDialog();
            this.Close();
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
