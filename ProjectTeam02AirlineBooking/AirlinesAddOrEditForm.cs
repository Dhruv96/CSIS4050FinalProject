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
    public partial class AirlinesAddOrEditForm : Form
    {
        AirlineEntities context;
        public AirlinesAddOrEditForm()
        {
            InitializeComponent();
            // Setting load listener
            this.Load += AirlinesAddOrEditForm_Load;

            // setting selection index changed listener
            listBoxAirlineManageList.SelectedIndexChanged += (s, e) => GetAirlines();

            //Setting click listeners
            buttonAirlineManageAdd.Click += ButtonAirlineManageAdd_Click;
            buttonAirlineManageUpdate.Click += ButtonAirlineManageUpdate_Click;
            this.FormClosed += AirlinesAddOrEditForm_FormClosed;
        }

        /// <summary>
        /// This function is called when form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AirlinesAddOrEditForm_FormClosed(object sender, FormClosedEventArgs e)
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
        private void ButtonAirlineManageUpdate_Click(object sender, EventArgs e)
        {
            if (!(listBoxAirlineManageList.SelectedItem is Airline airline)) 
            {
                MessageBox.Show("Airline to be updated must be selected");
                return;
            }

            airline.AirlineId = int.Parse(textBoxAirlineIdManage.Text);
            airline.AirlineName = textBoxAirlineNameManage.Text;

            if (airline.AirlineId != null && airline.AirlineName != null
                && airline.AirlineId.ToString().Trim().Length != 0 &&
                airline.AirlineName.Trim().Length != 0)
            {
                // updating the entity
                if (Controller<AirlineEntities, Airline>.UpdateEntity(airline) == false)
                {
                    MessageBox.Show("Cannot update airline to database");
                    return;
                }
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else 
            {
                MessageBox.Show("Airline information is missing");
                return;
            }

        }

        /// <summary>
        /// This function is called when add button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAirlineManageAdd_Click(object sender, EventArgs e)
        {
            // updating entity properties
            Airline airline = new Airline();
            airline.AirlineId = int.Parse(textBoxAirlineIdManage.Text);
            airline.AirlineName = textBoxAirlineNameManage.Text;

            if (airline.AirlineId != null && airline.AirlineName != null &&
                airline.AirlineId.ToString().Trim().Length != 0 && airline.AirlineName.Trim().Length != 0)
            {
                if (Controller<AirlineEntities, Airline>.AddEntity(airline) == null)
                {
                    MessageBox.Show("Cannot add airline to database");
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
        /// This function is called when form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AirlinesAddOrEditForm_Load(object sender, EventArgs e)
        {
            // setting datasources and initial UI
            context = new AirlineEntities();
            listBoxAirlineManageList.DataSource = Controller<AirlineEntities, Airline>.SetBindingList();
            textBoxAirlineIdManage.ResetText();
            textBoxAirlineNameManage.ResetText();
            listBoxAirlineManageList.SelectedIndex = -1;
        }

       /// <summary>
       /// This function is called when selected item in listbox is changed
       /// </summary>
        private void GetAirlines() 
        {
            // setting textfields when airline is selected in listbox
            if (!(listBoxAirlineManageList.SelectedItem is Airline airline))
                return;

            textBoxAirlineIdManage.Text = airline.AirlineId.ToString();
            textBoxAirlineNameManage.Text = airline.AirlineName;

          
        }

    }
}
