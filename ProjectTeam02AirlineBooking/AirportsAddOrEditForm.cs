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
    public partial class AirportsAddOrEditForm : Form
    {
        AirlineEntities context;
        public AirportsAddOrEditForm()
        {
            InitializeComponent();

            // setting load handler and selection index changed handler
            this.Load += AirportsAddOrEditForm_Load;
            listBoxAirportsList.SelectedIndexChanged += (s, e) => GetAirport();
            // setting click handlers
            buttonAirportManageAdd.Click += ButtonAirportManageAdd_Click;
            buttonAirportManageUpdate.Click += ButtonAirportManageUpdate_Click;
            // setting form closed handler
            this.FormClosed += AirportsAddOrEditForm_FormClosed;
        }

        /// <summary>
        /// This function is called when this form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AirportsAddOrEditForm_FormClosed(object sender, FormClosedEventArgs e)
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
        private void ButtonAirportManageUpdate_Click(object sender, EventArgs e)
        {
            // updating the entity properties
            if (!(listBoxAirportsList.SelectedItem is Airport airport)) 
            {
                MessageBox.Show("Airport to be updated must be selected");
                return;
            }
            airport.AirportId = int.Parse(textBoxAirportIdManage.Text);
            airport.AirportName = textBoxAirportNameManage.Text;

            if (airport.AirportId != null && airport.AirportName != null && 
                airport.AirportId.ToString().Trim().Length != 0 &&
                airport.AirportName.Trim().Length != 0) 
            {
                // updating the entitiy
                if (Controller<AirlineEntities, Airport>.UpdateEntity(airport) == false) 
                {
                    MessageBox.Show("Cannot update airport to database");
                    return;
                }
                this.DialogResult = DialogResult.OK;
                Close();
            
            }else
            {
                MessageBox.Show("Airport information is missing");
                return;
            }

        }

        /// <summary>
        /// This function is called when Add button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAirportManageAdd_Click(object sender, EventArgs e)
        {
            Airport airport = new Airport();
            airport.AirportId = int.Parse(textBoxAirportIdManage.Text);
            airport.AirportName = textBoxAirportNameManage.Text;

            if (airport.AirportId != null && airport.AirportName != null &&
                airport.AirportId.ToString().Trim().Length != 0 &&
                airport.AirportName.ToString().Trim().Length != 0)
            {
                // adding new entity
                if (Controller<AirlineEntities, Airport>.AddEntity(airport) == null)
                {
                    MessageBox.Show("Cannot add airport to database");
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
        /// This function is called when listbox selected item is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetAirport() 
        {
            if (!(listBoxAirportsList.SelectedItem is Airport airport))
                return;

            textBoxAirportIdManage.Text = airport.AirportId.ToString();
            textBoxAirportNameManage.Text = airport.AirportName;
        }

        /// <summary>
        /// This function is called when form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AirportsAddOrEditForm_Load(object sender, EventArgs e)
        {
            context = new AirlineEntities();
            listBoxAirportsList.DataSource = Controller<AirlineEntities, Airport>.SetBindingList();
            textBoxAirportIdManage.ResetText();
            textBoxAirportNameManage.ResetText();
            listBoxAirportsList.SelectedIndex = -1;
        }
    }
}
