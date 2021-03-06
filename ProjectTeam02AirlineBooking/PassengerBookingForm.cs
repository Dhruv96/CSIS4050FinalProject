using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirlineBookingCodeFirstFromDB;
using EFControllerUtilities;

namespace ProjectTeam02AirlineBooking
{
    public partial class PassengerBookingForm : Form
    {
        AirlineEntities context;
        // declaring variables needed 
        int SeatNum = -1;
        float baggageFee, serviceFee = 30, totalFees;
        decimal flightPrice;
        int flightId, bookingId;

        public PassengerBookingForm(int flightId, decimal flightPrice)
        {
            InitializeComponent();
            this.flightId = flightId;
            this.flightPrice = flightPrice;
            Load += PassengerBookingForm_Load;

            // fetching available (not booked seats) from DB
            var seats = Controller<AirlineEntities, Seat>.
               SetBindingList().Where(seat => seat.FlightId == flightId && seat.isBooked == 0);

            comboBoxSeats.DataSource = seats.ToList();

            int[] baggageArray = {0,1,2,3,4,5};
            comboBoxBaggage.DataSource = baggageArray;
        }

        /// <summary>
        /// This function is called when form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PassengerBookingForm_Load(object sender, EventArgs e)
        {
            context = new AirlineEntities();
            context.Database.Log = (s => Debug.Write(s));
            buttonAddToBooking.Click += ButtonAddToBooking_Click;
            buttonAddMorePeople.Click += ButtonAddMorePeople_Click;
            buttonDone.Click += ButtonDone_Click;
            labelServiceFeeNum.Text = 30.ToString();
            labelTotalFeeNum.Text = (30+flightPrice).ToString();
            labelBaggageFeeNum.Text = 0.ToString();
            comboBoxBaggage.SelectedIndex = 0;
            comboBoxSeats.SelectedIndex = -1;
           // SeatNum = ((Seat)comboBoxSeats.SelectedItem).SeatNum;
            comboBoxBaggage.SelectedIndexChanged += ComboBoxBaggage_SelectedIndexChanged;
            comboBoxSeats.SelectedIndexChanged += ComboBoxSeats_SelectedIndexChanged;
            var Bookings = Controller<AirlineEntities, Booking>.SetBindingList();
            bookingId = Bookings.Count();

        }

        /// <summary>
        /// This function is called when seat num in combo box is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxSeats_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeatNum = ((Seat)comboBoxSeats.SelectedItem).SeatNum;
        }

        /// <summary>
        /// This function is called user updates the baggage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxBaggage_SelectedIndexChanged(object sender, EventArgs e)
        {
            int noOfBags = (int)comboBoxBaggage.SelectedItem;
            baggageFee = noOfBags * 20;
            labelBaggageFeeNum.Text = baggageFee.ToString();
            serviceFee = 30;
            labelServiceFeeNum.Text = serviceFee.ToString();
            totalFees = baggageFee + serviceFee + (float)flightPrice;
            labelTotalFeeNum.Text = totalFees.ToString();
        }

        private void ButtonDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// This function is called when user clicks add more people too booking button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddMorePeople_Click(object sender, EventArgs e)
        {
            // this function is used to add more people in the same booking
            textBoxFname.ResetText();
            textBoxLname.ResetText();
            textBoxEmail.ResetText();
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            comboBoxBaggage.SelectedIndex = 0;
            baggageFee = 0;
            labelBaggageFeeNum.Text = "0";
            var seats = Controller<AirlineEntities, Seat>.
                SetBindingList().Where(seat => seat.FlightId == flightId && seat.isBooked == 0);

            comboBoxSeats.DataSource = seats.ToList();
           // comboBoxSeats.SelectedIndex = 0;
           // SeatNum = ((Seat)comboBoxSeats.SelectedItem).SeatNum;
            comboBoxSeats.ResetText();
        }

        /// <summary>
        /// This function is called when Add to booking button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddToBooking_Click(object sender, EventArgs e)
        {
            String Fname = textBoxFname.Text;
            String Lname = textBoxLname.Text;
            String email = textBoxEmail.Text;
            if (Fname.Trim() != "" && Lname.Trim() != "" && email.Trim() != "" && SeatNum != -1)
            {
                if (radioButtonMale.Checked || radioButtonFemale.Checked)
                {
                    Passenger passenger = new Passenger
                    {
                        Email = email,
                        FirstName = Fname,
                        LastName = Lname,
                        Gender = radioButtonMale.Checked ? "Male" : "Female"
                    };

                    // First adding the passenger in DB
                    Passenger p = Controller<AirlineEntities, Passenger>.AddEntity(passenger);
                    if (p == null)
                    {
                        MessageBox.Show("Cannot create passenger");
                        return;
                    }

                    context.SaveChanges();

                    // Create a booking for the passenger created above
                    Booking booking = new Booking
                    {
                        BookingId = bookingId,
                        PassengerId = p.PassengerId,
                        BaggageFee = (decimal)baggageFee,
                        ServiceFee = (decimal)serviceFee,
                        TotalFee = (decimal)baggageFee + (decimal)serviceFee + (decimal)flightPrice 
                    };
                    var book = Controller<AirlineEntities, Booking>.AddEntity(booking);
                    if (book == null)
                    {
                        MessageBox.Show("Cannot create Booking");
                        return;
                    }
                    context.SaveChanges();

                    var seat = new Seat
                    {
                        FlightId = flightId,
                        isBooked = 1,
                        SeatNum = SeatNum
                    };

                    // setting seat not available (booked) in seats table
                    if(Controller<AirlineEntities, Seat>.UpdateEntity(seat) == false)
                    {
                        MessageBox.Show("Unable to update seat status");
                    }
                    
                    FlightBooking flightBooking = new FlightBooking
                    {
                        BookingId = booking.BookingId,
                        PassengerId = p.PassengerId,
                        FlightId = flightId,
                        SeatNum = ((Seat)comboBoxSeats.SelectedItem).SeatNum
                    };


                    //Adding flight booking entity in table
                    var fB = Controller<AirlineEntities, FlightBooking>.AddEntity(flightBooking);
                    if(fB == null)
                    {
                        MessageBox.Show("Cannot create Flight Booking");
                        return;
                    }
                    MessageBox.Show("Successfully booked");
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Please Select Gender");
                }

            }
            else
            {
                MessageBox.Show("Please fill all the entries");
            }
        }
    }
}
