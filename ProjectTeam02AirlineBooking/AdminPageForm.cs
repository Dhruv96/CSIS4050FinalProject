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
using System.Diagnostics;
using System.Data.SqlClient;
using DataTableAccessLayer;

namespace ProjectTeam02AirlineBooking
{
    public partial class AdminPageForm : Form
    {
        // field to keep the access layer field

        private SqlDataTableAccessLayer AirlinesDB;

        // dataset will hold all tables being used

        private DataSet AirlinesDbDataset;


        public AdminPageForm()
        {
            InitializeComponent();

            AirlinesDB = new SqlDataTableAccessLayer();
            AirlinesDbDataset = new DataSet()
            {
                // must be named for backup purposes

                DataSetName = "AirlinesDBDataset",
            };

            string connectionString = AirlinesDB.GetConnectionString("AirlinesDBConnection");
            AirlinesDB.OpenConnection(connectionString); // connecting to database

            InitializeDatasets();

            //Button click event handlers
            buttonManageFlights.Click += ButtonManageFlights_Click;
            buttonManageBookings.Click += ButtonManageBookings_Click;
            buttonBackupDB.Click += ButtonBackupDB_Click;
            buttonGetReports.Click += ButtonGetReports_Click;
        }

        /// <summary>
        /// This function initializes the dataset used to perform backup and restore
        /// </summary>
        private void InitializeDatasets() {
            DataTable airlines =  AirlinesDB.GetDataTable("Airline");
            DataTable airports = AirlinesDB.GetDataTable("Airport");
            DataTable bookings = AirlinesDB.GetDataTable("Booking");
            DataTable flights = AirlinesDB.GetDataTable("Flight");
            DataTable flightBookings = AirlinesDB.GetDataTable("FlightBooking");
            DataTable passengers = AirlinesDB.GetDataTable("Passenger");
            DataTable seats = AirlinesDB.GetDataTable("Seat");

          
            AirlinesDbDataset.Tables.Add(airlines);
            AirlinesDbDataset.Tables.Add(airports);
            AirlinesDbDataset.Tables.Add(bookings);
            AirlinesDbDataset.Tables.Add(flights);
            AirlinesDbDataset.Tables.Add(flightBookings);
            AirlinesDbDataset.Tables.Add(passengers);
            AirlinesDbDataset.Tables.Add(seats);     

        }


        /// <summary>
        /// This function is called when get reports button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGetReports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.ShowDialog();
        }

        /// <summary>
        /// This function is called when backup db button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonBackupDB_Click(object sender, EventArgs e)
        {
            //Backing up DB
           // InitializeDatasets();
            AirlinesDB.BackupDataSetToXML(AirlinesDbDataset);
            MessageBox.Show("Successfully backed up Database");
        }

        /// <summary>
        /// This function is called when manage bookings button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageBookings_Click(object sender, EventArgs e)
        {
             this.Visible = false;

            //Opening Manage Bookings form
            ManageBookingsForm manageBookingsForm = new ManageBookingsForm();

            manageBookingsForm.ShowDialog();

            
        }

        /// <summary>
        /// This function is called when manage flights button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageFlights_Click(object sender, EventArgs e)
        {
           
            // Opening manage flights form
            ManageFlightForm manageFlightsForm = new ManageFlightForm();

            manageFlightsForm.ShowDialog();

           
        }
    }
}
