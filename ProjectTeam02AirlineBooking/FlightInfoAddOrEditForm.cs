using AirlineBookingCodeFirstFromDB;
using EFControllerUtilities;
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
    public partial class FlightInfoAddOrEditForm : Form
    {
        AirlineEntities context;
        public FlightInfoAddOrEditForm()
        {
            InitializeComponent();

            this.Load += FlightInfoAddOrEditForm_Load;
            listBoxFlightsManage.SelectedIndexChanged += (s,e) => GetFlights();
            buttonFlightAdd.Click += ButtonFlightAdd_Click;
            buttonFlightUpdate.Click += ButtonFlightUpdate_Click;
        }

        private void ButtonFlightUpdate_Click(object sender, EventArgs e)
        {
            if (!(listBoxFlightsManage.SelectedItem is Flight flight)) 
            {
                MessageBox.Show("Flight to be updated must be selected");
                return;
            }
            flight.FlightId = int.Parse(textBoxFlightId.Text);
            flight.AirlineId = int.Parse(textBoxAirlineId.Text);
            flight.DepartureAirport = int.Parse(textBoxDepartureAirport.Text);
            flight.DestinationAirport = int.Parse(textBoxDestinationAirport.Text);
            flight.FlightDate = dateTimePickerFlightDate.Value;
            flight.Price = int.Parse(textBoxPrice.Text);

            if (flight.FlightId != null && flight.AirlineId != null && flight.DepartureAirport != null &&
                 flight.DestinationAirport != null && flight.FlightDate != null && flight.Price != null &&
                 flight.FlightId.ToString().Trim().Length != 0 && flight.AirlineId.ToString().Trim().Length != 0 &&
                 flight.DepartureAirport.ToString().Trim().Length != 0 && flight.DestinationAirport.ToString().Trim().Length != 0
                 && flight.FlightDate.ToString().Trim().Length != 0 && flight.Price.ToString().Trim().Length != 0)
            {
                if (Controller<AirlineEntities, Flight>.UpdateEntity(flight) == false)
                {
                    MessageBox.Show("Cannot update flight to database");
                    return;
                }
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else 
            {
                MessageBox.Show("Flight information is missing");
                return;
            }
        }

        private void ButtonFlightAdd_Click(object sender, EventArgs e)
        {
            Flight flight = new Flight();
            flight.FlightId = int.Parse(textBoxFlightId.Text);
            flight.AirlineId = int.Parse(textBoxAirlineId.Text);
            flight.DepartureAirport = int.Parse(textBoxDepartureAirport.Text);
            flight.DestinationAirport = int.Parse(textBoxDestinationAirport.Text);
            flight.FlightDate = dateTimePickerFlightDate.Value;
            flight.Price = int.Parse(textBoxPrice.Text);

            if (flight.FlightId != null && flight.AirlineId != null && flight.DepartureAirport != null &&
                 flight.DestinationAirport != null && flight.FlightDate != null && flight.Price != null &&
                 flight.FlightId.ToString().Trim().Length != 0 && flight.AirlineId.ToString().Trim().Length != 0 &&
                 flight.DepartureAirport.ToString().Trim().Length != 0 && flight.DestinationAirport.ToString().Trim().Length != 0
                 && flight.FlightDate.ToString().Trim().Length != 0 && flight.Price.ToString().Trim().Length != 0) 
            {
                if (Controller<AirlineEntities, Flight>.AddEntity(flight) == null) 
                {
                    MessageBox.Show("Cannot add flight info to database");
                    return;
                }
                this.DialogResult = DialogResult.OK;

                Close();
            }
            else
            {
                MessageBox.Show("Please enter all the details");
            }
        }

        private void GetFlights() 
        {
            if (!(listBoxFlightsManage.SelectedItem is Flight flight))
                return;

            textBoxFlightId.Text = flight.FlightId.ToString();
            textBoxAirlineId.Text = flight.AirlineId.ToString();
            textBoxDepartureAirport.Text = flight.DepartureAirport.ToString();
            textBoxDestinationAirport.Text = flight.DestinationAirport.ToString();
            dateTimePickerFlightDate.Value = flight.FlightDate;
            textBoxPrice.Text = flight.Price.ToString();
        
        }

        private void FlightInfoAddOrEditForm_Load(object sender, EventArgs e)
        {
            context = new AirlineEntities();
            listBoxFlightsManage.DataSource = Controller<AirlineEntities, Flight>.SetBindingList();
            textBoxAirlineId.ResetText();
            textBoxFlightId.ResetText();
            textBoxDepartureAirport.ResetText();
            textBoxDestinationAirport.ResetText();
            textBoxPrice.ResetText();
            dateTimePickerFlightDate.ResetText();
            listBoxFlightsManage.SelectedIndex = -1;
        
        }
    }
}
