using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFControllerUtilities;
using AirlineBookingCodeFirstFromDB;

namespace ProjectTeam02AirlineBooking
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            // settting data source of airlines comboobx
            comboBoxAirlines.DataSource = Controller<AirlineEntities, Airline>.SetBindingList();
            comboBoxAirlines.SelectedIndex = -1;
            buttonGetRevenue.Click += ButtonGetRevenue_Click;
        }

        /// <summary>
        /// This function is called when user clicks get revenue button
        /// and loads the revenue earned from a specific airlines between the
        /// time period specified using datetimepicker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGetRevenue_Click(object sender, EventArgs e)
        {
            // getting required dates and airlines to calculate revenue
            DateTime fromDate = dateTimePickerFrom.Value.Date;
            DateTime toDate = dateTimePickerTo.Value.Date;
            if(comboBoxAirlines.SelectedIndex != -1)
            {
                Airline selectedAirline = (Airline)comboBoxAirlines.SelectedItem;
                decimal totalRevenue = 0;
               
                var flightBookings = Controller<AirlineEntities, FlightBooking>.GetEntitiesWithIncluded("flight", "booking");
                var flights = Controller<AirlineEntities, Flight>.GetEntities();
                    foreach (FlightBooking flightBooking in flightBookings)
                    {
                        foreach(Flight flight in flights)
                        {
                            if (selectedAirline.AirlineId == flightBooking.Flight.AirlineId &&
                                selectedAirline.AirlineId == flight.AirlineId
                            && flight.FlightDate.CompareTo(fromDate) >= 0 &&
                            flight.FlightDate.CompareTo(toDate) < 0 && flight.FlightId == flightBooking.FlightId)
                            {
                                totalRevenue += flightBooking.Booking.TotalFee;
                            }
                        }
              
                }

                labelRevenueEarned.Text = totalRevenue.ToString();
            }
            else
            {
                MessageBox.Show("Please Select an Airline");
            }

        }
    }
}
