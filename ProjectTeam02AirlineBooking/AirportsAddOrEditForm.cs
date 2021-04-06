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

            this.Load += AirportsAddOrEditForm_Load;
            listBoxAirportsList.SelectedIndexChanged += (s, e) => GetAirport();
            buttonAirportManageAdd.Click += ButtonAirportManageAdd_Click;
            buttonAirportManageUpdate.Click += ButtonAirportManageUpdate_Click;
        }

        private void ButtonAirportManageUpdate_Click(object sender, EventArgs e)
        {
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

        private void ButtonAirportManageAdd_Click(object sender, EventArgs e)
        {
            Airport airport = new Airport();
            airport.AirportId = int.Parse(textBoxAirportIdManage.Text);
            airport.AirportName = textBoxAirportNameManage.Text;

            if (airport.AirportId != null && airport.AirportName != null &&
                airport.AirportId.ToString().Trim().Length != 0 &&
                airport.AirportName.ToString().Trim().Length != 0)
            {
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

        private void GetAirport() 
        {
            if (!(listBoxAirportsList.SelectedItem is Airport airport))
                return;

            textBoxAirportIdManage.Text = airport.AirportId.ToString();
            textBoxAirportNameManage.Text = airport.AirportName;
        }

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
