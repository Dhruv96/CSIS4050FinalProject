<<<<<<< HEAD
﻿using AirlineBookingCodeFirstFromDB;
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

            this.Load += AirlinesAddOrEditForm_Load;

            listBoxAirlineManageList.SelectedIndexChanged += (s, e) => GetAirlines();
            buttonAirlineManageAdd.Click += ButtonAirlineManageAdd_Click;
            buttonAirlineManageUpdate.Click += ButtonAirlineManageUpdate_Click;

        }

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

        private void ButtonAirlineManageAdd_Click(object sender, EventArgs e)
        {
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

        private void AirlinesAddOrEditForm_Load(object sender, EventArgs e)
        {
            context = new AirlineEntities();
            listBoxAirlineManageList.DataSource = Controller<AirlineEntities, Airline>.SetBindingList();
            textBoxAirlineIdManage.ResetText();
            textBoxAirlineNameManage.ResetText();
            listBoxAirlineManageList.SelectedIndex = -1;
        }

        private void GetAirlines() 
        {
            if (!(listBoxAirlineManageList.SelectedItem is Airline airline))
                return;

            textBoxAirlineIdManage.Text = airline.AirlineId.ToString();
            textBoxAirlineNameManage.Text = airline.AirlineName;

          
        }

    }
}
=======
﻿using AirlineBookingCodeFirstFromDB;
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

            this.Load += AirlinesAddOrEditForm_Load;

            listBoxAirlinesManageList.SelectedIndexChanged += (s, e) => GetAirlines();
            buttonAirlineManageAdd.Click += ButtonAirlineManageAdd_Click;
            buttonAirlineManageUpdate.Click += ButtonAirlineManageUpdate_Click;

        }

        private void ButtonAirlineManageUpdate_Click(object sender, EventArgs e)
        {
            if (!(listBoxAirlinesManageList.SelectedItem is Airline airline)) 
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

        private void ButtonAirlineManageAdd_Click(object sender, EventArgs e)
        {
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

        private void AirlinesAddOrEditForm_Load(object sender, EventArgs e)
        {
            context = new AirlineEntities();
            listBoxAirlinesManageList.DataSource = Controller<AirlineEntities, Airline>.SetBindingList();
            textBoxAirlineIdManage.ResetText();
            textBoxAirlineNameManage.ResetText();
            listBoxAirlinesManageList.SelectedIndex = -1;
        }

        private void GetAirlines() 
        {
            if (!(listBoxAirlinesManageList.SelectedItem is Airline airline))
                return;

            textBoxAirlineIdManage.Text = airline.AirlineId.ToString();
            textBoxAirlineNameManage.Text = airline.AirlineName;

          
        }

    }
}
>>>>>>> 6c7b88d4a40cde90ff3e408f65b29754592c7a3f
