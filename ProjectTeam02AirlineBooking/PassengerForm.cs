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

        private void ComboBoxDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFlights();
        }

        private void ComboBoxDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFlights();
        }

        private void ComboBoxAirlines_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFlights();
        }

        private void PassengerForm_Load(object sender, EventArgs e)
        { 
            comboBoxAirlines.DataSource = Controller<AirlineEntities, Airline>.SetBindingList();
            comboBoxDepart.DataSource = Controller<AirlineEntities, Airport>.SetBindingList();
            comboBoxDestination.DataSource = Controller<AirlineEntities, Airport>.SetBindingList();
            comboBoxDepart.SelectedIndex = 0;
            comboBoxDestination.SelectedIndex = 1;

            radioButtonOneWay.Select();
            comboBoxAirlines.SelectedIndexChanged += ComboBoxAirlines_SelectedIndexChanged;
            comboBoxDepart.SelectedIndexChanged += ComboBoxDepart_SelectedIndexChanged;
            comboBoxDestination.SelectedIndexChanged += ComboBoxDestination_SelectedIndexChanged;
            dateTimePickerFrom.TextChanged += DateTimePickerFrom_TextChanged;
            dateTimePickerTo.TextChanged += DateTimePickerFrom_TextChanged;
            returnDateTimePicker.TextChanged += DateTimePickerFrom_TextChanged;
            radioButtonOneWay.CheckedChanged += RadioButtonOneWay_CheckedChanged;
            radioButtonRoundTrip.CheckedChanged += RadioButtonRoundTrip_CheckedChanged;
            returnDateTimePicker.Enabled = false;
            InitializeDataGridView();
            LoadFlights();
        }

        private void RadioButtonRoundTrip_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRoundTrip.Checked)
                returnDateTimePicker.Enabled = true;
            else
                returnDateTimePicker.Enabled = false;

            LoadFlights();
        }

        private void RadioButtonOneWay_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOneWay.Checked)
                returnDateTimePicker.Enabled = false;
            else
                returnDateTimePicker.Enabled = true;

            LoadFlights();
        }

        private void DateTimePickerFrom_TextChanged(object sender, EventArgs e)
        {
            LoadFlights();
        }

        private void LoadFlights()
        {
            var selectedAirline = (Airline)comboBoxAirlines.SelectedItem;
            var departureAirport = (Airport)comboBoxDepart.SelectedItem;
            var destinationAirport = (Airport)comboBoxDestination.SelectedItem;
            var fromDate = dateTimePickerFrom.Value;
            var toDate = dateTimePickerTo.Value;
            var flights = Controller<AirlineEntities, Flight>.
                GetEntitiesWithIncluded("FlightBookings", "Seats");
            if (radioButtonRoundTrip.Checked)
            {
                DateTime returnDate = returnDateTimePicker.Value;
                flights = flights.Where(flight => (flight.AirlineId == selectedAirline.AirlineId) &&
                    (flight.DepartureAirport == departureAirport.AirportId) &&
                         (flight.DestinationAirport == destinationAirport.AirportId) && (flight.FlightDate.CompareTo(toDate) <= 0) &&
                            (flight.FlightDate.CompareTo(fromDate) >= 0) || 
                            (flight.FlightDate.Date == returnDate.Date && flight.AirlineId == selectedAirline.AirlineId));
            }
            else
            {
                flights = flights.Where(flight => (flight.AirlineId == selectedAirline.AirlineId) &&
                    (flight.DepartureAirport == departureAirport.AirportId) &&
                         (flight.DestinationAirport == destinationAirport.AirportId) && (flight.FlightDate.CompareTo(toDate) <= 0) &&
                            (flight.FlightDate.CompareTo(fromDate) >= 0));
            }
          
            dataGridViewAvailableFlights.Rows.Clear();

            foreach(var flight in flights)
            {
                dataGridViewAvailableFlights.Rows.Add(flight.FlightId, flight.GetAirline(),
                   flight.GetDepartureAirport(), flight.GetDestinationAirport(), flight.FlightDate,
                    flight.Price, flight.Seats.Count);
            }
        }


        private void InitializeDataGridView()
        {
            dataGridViewAvailableFlights.Columns.Clear();  // any columns created by the designer, get rid of them
            dataGridViewAvailableFlights.ReadOnly = true;  // no cell editing allowed
            dataGridViewAvailableFlights.AllowUserToAddRows = false;     // no rows can be added or deleted
            dataGridViewAvailableFlights.AllowUserToDeleteRows = false;
            dataGridViewAvailableFlights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAvailableFlights.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewAvailableFlights.AutoSize = false;        // don't autosize the cells
            dataGridViewAvailableFlights.RowHeadersVisible = false;
            dataGridViewAvailableFlights.Width = 900;

            // right justify everything

            dataGridViewAvailableFlights.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewAvailableFlights.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // set up columns here
            DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[]{
                new DataGridViewTextBoxColumn() {Name = "FlightId"},
                new DataGridViewTextBoxColumn() {Name = "Airlines"},
                new DataGridViewTextBoxColumn() {Name = "Departure Airport"},
                new DataGridViewTextBoxColumn() {Name = "Destination Airport"},
                new DataGridViewTextBoxColumn() {Name = "Flight Date"},
                new DataGridViewTextBoxColumn() {Name = "Price"},
                new DataGridViewTextBoxColumn() {Name = "Available Seats"}
            };

            // adding columns in dataGridView 
            dataGridViewAvailableFlights.Columns.AddRange(columns);


        }

    }

}
