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

        /// <summary>
        /// This function is called when destination combobox selected item is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFlights();
        }

        /// <summary>
        /// This function is called when departure combobox selected item is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFlights();
        }

        /// <summary>
        /// This function is called when selected airlines in combobox is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxAirlines_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFlights();
        }

        /// <summary>
        /// This function is called when form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            buttonCancel.Click += ButtonCancel_Click;
            buttonNext.Click += ButtonNext_Click;
            returnDateTimePicker.Enabled = false;
            InitializeDataGridView();
            LoadFlights();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// This function is called when next button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNext_Click(object sender, EventArgs e)
        {
           if(dataGridViewAvailableFlights.SelectedRows.Count > 0)
            {
                int flightId = (int)dataGridViewAvailableFlights.SelectedRows[0].Cells[0].Value;
                decimal price = (decimal)dataGridViewAvailableFlights.SelectedRows[0].Cells[5].Value;
                this.Hide();
                PassengerBookingForm passengerBookingForm = new PassengerBookingForm(flightId, price);
                passengerBookingForm.ShowDialog();
                this.Close();
            }
            
           else
            {
                MessageBox.Show("Please Select a Flight");
            }
        }

        /// <summary>
        /// This function is called when round trip radio button is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButtonRoundTrip_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRoundTrip.Checked)
                returnDateTimePicker.Enabled = true;
            else
                returnDateTimePicker.Enabled = false;

            LoadFlights();
        }

        /// <summary>
        /// This function is called when one way radio button is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This function loads the flights and displays 
        /// them in the gridview based on the user selected filters
        /// </summary>
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
          
            // Adding flights in datagridview
            dataGridViewAvailableFlights.Rows.Clear();

            foreach(var flight in flights)
            {
                dataGridViewAvailableFlights.Rows.Add(flight.FlightId, flight.GetAirline(),
                   flight.GetDepartureAirport(), flight.GetDestinationAirport(), flight.FlightDate,
                    flight.Price, flight.Seats.Count(seat => seat.isBooked == 0));
            }
        }

        /// <summary>
        /// This function initializes datagridview by setting its properties
        /// </summary>
        private void InitializeDataGridView()
        {
            dataGridViewAvailableFlights.Columns.Clear();  // any columns created by the designer, get rid of them
            dataGridViewAvailableFlights.ReadOnly = true;  // no cell editing allowed
            dataGridViewAvailableFlights.AllowUserToAddRows = false;     // no rows can be added or deleted
            dataGridViewAvailableFlights.AllowUserToDeleteRows = false;
            dataGridViewAvailableFlights.MultiSelect = false;
            dataGridViewAvailableFlights.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            dataGridViewAvailableFlights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAvailableFlights.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewAvailableFlights.AutoSize = false;        // don't autosize the cells
            dataGridViewAvailableFlights.RowHeadersVisible = true;


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
