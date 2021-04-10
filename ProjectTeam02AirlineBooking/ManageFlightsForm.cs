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
            // setting click listeners
            buttonFlightsInfo.Click += ButtonFlightsInfo_Click;
            buttonAirlinesInfo.Click += ButtonAirlinesInfo_Click;
            buttonAirportsInfo.Click += ButtonAirportsInfo_Click;

            // setting form closed handler
            this.FormClosed += ManageFlightForm_FormClosed;

        }


        /// <summary>
        /// This function is called when form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManageFlightForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            // opening admin form again
            AdminPageForm adminPageForm = new AdminPageForm();
            adminPageForm.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// This function is called when Airports info button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAirportsInfo_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            AirportsAddOrEditForm airportsAddOrEditForm = new AirportsAddOrEditForm();

            airportsAddOrEditForm.ShowDialog();

            this.Close();
        }

        /// <summary>
        /// This function is called when Airlines info button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAirlinesInfo_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            // opening airlines add or edit form
            AirlinesAddOrEditForm airlinesAddOrEditForm = new AirlinesAddOrEditForm();

            airlinesAddOrEditForm.ShowDialog();

            this.Close();
        }

        /// <summary>
        /// This function is called when flights info button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFlightsInfo_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            // opening add or edit flight form
            FlightInfoAddOrEditForm flightInfoAddOrEditForm = new FlightInfoAddOrEditForm();

            flightInfoAddOrEditForm.ShowDialog();

            this.Close();
        }
    }
}
