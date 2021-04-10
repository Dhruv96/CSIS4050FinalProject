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

            // setiing load handler
            this.Load += FlightInfoAddOrEditForm_Load;
            // setting selected index change listener
            listBoxFlightsManage.SelectedIndexChanged += (s,e) => GetFlights();
            // setting click listeners
            buttonFlightAdd.Click += ButtonFlightAdd_Click;
            buttonFlightUpdate.Click += ButtonFlightUpdate_Click;
            // setting form closed listeners
            this.FormClosed += FlightInfoAddOrEditForm_FormClosed;
            
        }

        /// <summary>
        /// This function is called when form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlightInfoAddOrEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            ManageFlightForm manageFlightForm = new ManageFlightForm();
            manageFlightForm.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// This function is called when update button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFlightUpdate_Click(object sender, EventArgs e)
        {
            if (!(listBoxFlightsManage.SelectedItem is Flight flight)) 
            {
                MessageBox.Show("Flight to be updated must be selected");
                return;
            }
            // updating entity properties
            flight.FlightId = int.Parse(textBoxFlightId.Text);
            flight.AirlineId = int.Parse(textBoxAirlineId.Text);
            flight.DepartureAirport = int.Parse(textBoxDepartureAirport.Text);
            flight.DestinationAirport = int.Parse(textBoxDestinationAirport.Text);
            flight.FlightDate = dateTimePickerFlightDate.Value;
            flight.Price = Math.Round(decimal.Parse(textBoxPrice.Text),2);

            if (flight.FlightId != null && flight.AirlineId != null && flight.DepartureAirport != null &&
                 flight.DestinationAirport != null && flight.FlightDate != null && flight.Price != null &&
                 flight.FlightId.ToString().Trim().Length != 0 && flight.AirlineId.ToString().Trim().Length != 0 &&
                 flight.DepartureAirport.ToString().Trim().Length != 0 && flight.DestinationAirport.ToString().Trim().Length != 0
                 && flight.FlightDate.ToString().Trim().Length != 0 && flight.Price.ToString().Trim().Length != 0)
            {
                // updating entity
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

        /// <summary>
        /// This function is called when Add button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFlightAdd_Click(object sender, EventArgs e)
        {
            // Setting properties of entity
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
                // Adding the entity
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

        /// <summary>
        /// This function is called when selected index of listbox is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This function is called when form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
