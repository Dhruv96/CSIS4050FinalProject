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
    public partial class ManageBookingsForm : Form
    {
        AirlineEntities context;

        public ManageBookingsForm()
        {
            InitializeComponent();

            this.Load += ManageBookingsForm_Load;
            listBoxBookingsManage.SelectedIndexChanged += (s, e) => GetBooking();
            buttonUpdateBookingManage.Click += ButtonUpdateBookingManage_Click;


        }

        private void ButtonUpdateBookingManage_Click(object sender, EventArgs e)
        {
            if (!(listBoxBookingsManage.SelectedItem is Booking booking)) 
            {
                MessageBox.Show("Booking to be updated must be selected");
                return;
            }

            booking.BookingId = int.Parse(textBoxBookingIdManage.Text);
            booking.PassengerId = int.Parse(textBoxPassengerIdManage.Text);
            booking.BaggageFee = int.Parse(textBoxBaggageFeeManage.Text);
            booking.ServiceFee = int.Parse(textBoxServiceFeeBookingManage.Text);
            booking.TotalFee = int.Parse(textBoxTotalFeeBookingManage.Text);
            booking.isRoundTrip = bool.Parse(textBoxIsRoundTripBookingManage.Text);

            if (booking.BookingId != null && booking.PassengerId != null && booking.BaggageFee != null &&
                booking.ServiceFee != null && booking.TotalFee != null && booking.isRoundTrip != null &&
                booking.BookingId.ToString().Trim().Length != 0 && booking.PassengerId.ToString().Trim().Length != 0 &&
                booking.BaggageFee.ToString().Trim().Length != 0 && booking.ServiceFee.ToString().Trim().Length != 0 &&
                booking.TotalFee.ToString().Trim().Length != 0 && booking.isRoundTrip.ToString().Trim().Length != 0)
            {
                if (Controller<AirlineEntities, Booking>.UpdateEntity(booking) == false)
                {
                    MessageBox.Show("Cannot update booking to database");
                    return;
                }
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else 
            {
                MessageBox.Show("Booking information is missing");
                return;
            }
            

        }

        private void GetBooking() 
        {
            if (!(listBoxBookingsManage.SelectedItem is Booking booking))
                return;
            textBoxBookingIdManage.Text = booking.BookingId.ToString();
            textBoxPassengerIdManage.Text = booking.PassengerId.ToString();
            textBoxBaggageFeeManage.Text = booking.BaggageFee.ToString();
            textBoxServiceFeeBookingManage.Text = booking.ServiceFee.ToString();
            textBoxTotalFeeBookingManage.Text = booking.TotalFee.ToString();
            textBoxIsRoundTripBookingManage.Text = booking.isRoundTrip.ToString();
        }

        private void ManageBookingsForm_Load(object sender, EventArgs e)
        {
            context = new AirlineEntities();
            listBoxBookingsManage.DataSource = Controller<AirlineEntities, Booking>.SetBindingList();
            textBoxBookingIdManage.ResetText();
            textBoxPassengerIdManage.ResetText();
            textBoxBaggageFeeManage.ResetText();
            textBoxServiceFeeBookingManage.ResetText();
            textBoxTotalFeeBookingManage.ResetText();
            textBoxIsRoundTripBookingManage.ResetText();
            listBoxBookingsManage.SelectedIndex = -1;
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
    public partial class ManageBookingsForm : Form
    {
        AirlineEntities context;

        public ManageBookingsForm()
        {
            InitializeComponent();

            this.Load += ManageBookingsForm_Load;
            listBoxBookingManage.SelectedIndexChanged += (s, e) => GetBooking();
            buttonUpdateBookingManage.Click += ButtonUpdateBookingManage_Click;


        }

        private void ButtonUpdateBookingManage_Click(object sender, EventArgs e)
        {
            if (!(listBoxBookingManage.SelectedItem is Booking booking)) 
            {
                MessageBox.Show("Booking to be updated must be selected");
                return;
            }

            booking.BookingId = int.Parse(textBoxBookingIdManage.Text);
            booking.PassengerId = int.Parse(textBoxPassengerIdManage.Text);
            booking.BaggageFee = int.Parse(textBoxBaggageFeeManage.Text);
            booking.ServiceFee = int.Parse(textBoxServiceFeeBookingManage.Text);
            booking.TotalFee = int.Parse(textBoxTotalFeeBookingManage.Text);
            booking.isRoundTrip = bool.Parse(textBoxIsRoundTripBookingManage.Text);

            if (booking.BookingId != null && booking.PassengerId != null && booking.BaggageFee != null &&
                booking.ServiceFee != null && booking.TotalFee != null && booking.isRoundTrip != null &&
                booking.BookingId.ToString().Trim().Length != 0 && booking.PassengerId.ToString().Trim().Length != 0 &&
                booking.BaggageFee.ToString().Trim().Length != 0 && booking.ServiceFee.ToString().Trim().Length != 0 &&
                booking.TotalFee.ToString().Trim().Length != 0 && booking.isRoundTrip.ToString().Trim().Length != 0)
            {
                if (Controller<AirlineEntities, Booking>.UpdateEntity(booking) == false)
                {
                    MessageBox.Show("Cannot update booking to database");
                    return;
                }
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else 
            {
                MessageBox.Show("Booking information is missing");
                return;
            }
            

        }

        private void GetBooking() 
        {
            if (!(listBoxBookingManage.SelectedItem is Booking booking))
                return;
            textBoxBookingIdManage.Text = booking.BookingId.ToString();
            textBoxPassengerIdManage.Text = booking.PassengerId.ToString();
            textBoxBaggageFeeManage.Text = booking.BaggageFee.ToString();
            textBoxServiceFeeBookingManage.Text = booking.ServiceFee.ToString();
            textBoxTotalFeeBookingManage.Text = booking.TotalFee.ToString();
            textBoxIsRoundTripBookingManage.Text = booking.isRoundTrip.ToString();
        }

        private void ManageBookingsForm_Load(object sender, EventArgs e)
        {
            context = new AirlineEntities();
            listBoxBookingManage.DataSource = Controller<AirlineEntities, Booking>.SetBindingList();
            textBoxBookingIdManage.ResetText();
            textBoxPassengerIdManage.ResetText();
            textBoxBaggageFeeManage.ResetText();
            textBoxServiceFeeBookingManage.ResetText();
            textBoxTotalFeeBookingManage.ResetText();
            textBoxIsRoundTripBookingManage.ResetText();
            listBoxBookingManage.SelectedIndex = -1;
        }
    }
}
>>>>>>> 6c7b88d4a40cde90ff3e408f65b29754592c7a3f
