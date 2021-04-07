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
    public partial class ManageBookingsForm : Form
    {

        public ManageBookingsForm()
        {
            InitializeComponent();

            this.Load += ManageBookingsForm_Load;
            listBoxBookingsManage.SelectedIndexChanged += (s, e) => GetBooking();
            buttonUpdateBookingManage.Click += ButtonUpdateBookingManage_Click;
            this.FormClosed += ManageBookingsForm_FormClosed;
        }

        private void ManageBookingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            AdminPageForm adminPageForm = new AdminPageForm();
            adminPageForm.ShowDialog();
            this.Close();
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
            booking.BaggageFee = Math.Round(decimal.Parse(textBoxBaggageFeeManage.Text), 2);
            booking.ServiceFee = Math.Round(decimal.Parse(textBoxServiceFeeBookingManage.Text), 2);
            booking.TotalFee = Math.Round(decimal.Parse(textBoxTotalFeeBookingManage.Text), 2);
            //  booking.isRoundTrip = bool.Parse(textBoxIsRoundTripBookingManage.Text);

            if (booking.BookingId != null && booking.PassengerId != null && booking.BaggageFee != null &&
                booking.ServiceFee != null && booking.TotalFee != null &&
                booking.BookingId.ToString().Trim().Length != 0 && booking.PassengerId.ToString().Trim().Length != 0 &&
                booking.BaggageFee.ToString().Trim().Length != 0 && booking.ServiceFee.ToString().Trim().Length != 0 &&
                booking.TotalFee.ToString().Trim().Length != 0)
            {

                if (Controller<AirlineEntities, Booking>.UpdateEntity(booking))
                    MessageBox.Show("Booking Updated Successfully");
                else
                    MessageBox.Show("Cannot Update Booking");
            }
            else
            {
                MessageBox.Show("Cannot Update Booking");
            }
       
            this.DialogResult = DialogResult.OK;
            Close();
        }
       
       //     else 
        //    {
             //   MessageBox.Show("Booking information is missing");
//return;
       //     }
           

        private void GetBooking() 
        {
            if (!(listBoxBookingsManage.SelectedItem is Booking booking))
                return;
            textBoxBookingIdManage.Text = booking.BookingId.ToString();
            textBoxPassengerIdManage.Text = booking.PassengerId.ToString();
            textBoxBaggageFeeManage.Text = booking.BaggageFee.ToString();
            textBoxServiceFeeBookingManage.Text = booking.ServiceFee.ToString();
            textBoxTotalFeeBookingManage.Text = booking.TotalFee.ToString();
            //textBoxIsRoundTripBookingManage.Text = booking.isRoundTrip.ToString();
        }

        private void ManageBookingsForm_Load(object sender, EventArgs e)
        { 
            listBoxBookingsManage.DataSource = Controller<AirlineEntities, Booking>.SetBindingList();
            textBoxBookingIdManage.ResetText();
            textBoxPassengerIdManage.ResetText();
            textBoxBaggageFeeManage.ResetText();
            textBoxServiceFeeBookingManage.ResetText();
            textBoxTotalFeeBookingManage.ResetText();
           // textBoxIsRoundTripBookingManage.ResetText();
            listBoxBookingsManage.SelectedIndex = -1;
            textBoxBookingIdManage.Enabled = false;
            textBoxPassengerIdManage.Enabled = false;
        }
    }
}
