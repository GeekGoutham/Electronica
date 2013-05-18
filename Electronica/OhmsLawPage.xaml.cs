using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Electronica
{
    public partial class OhmsLawPage : PhoneApplicationPage
    {
        
        double res, volt, cur;
        public OhmsLawPage()
        {
            InitializeComponent();
        }
        private void VoltageCal()
        {
            try
            {
                res = Convert.ToDouble(ResistText.Text);

                cur = Convert.ToDouble(CurrentText.Text);
                double voltResult = cur * res;
                VoltText.Text = Convert.ToString(voltResult);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for Current and Resistance!", "Format Error", MessageBoxButton.OK);
            }
        }
        private void CurrentCal()
        {
            try
            {
                res = Convert.ToDouble(ResistText.Text);
                volt = Convert.ToDouble(VoltText.Text);

                double curResult = volt / res;
                CurrentText.Text = Convert.ToString(curResult);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for Voltage and Resistance!", "Format Error", MessageBoxButton.OK);
            }
        }
        private void ResistorCal()
        {

            try
            {
                volt = Convert.ToDouble(VoltText.Text);
                cur = Convert.ToDouble(CurrentText.Text);
                double resResult = volt / cur;
                ResistText.Text = Convert.ToString(resResult);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for Voltage and Current!", "Format Error", MessageBoxButton.OK);
            }
        }
       
        private void getVolt(object sender, System.EventArgs e)
        {
        	// TODO: Add event handler implementation here.
            VoltageCal();
        }

        private void getCurrent(object sender, System.EventArgs e)
        {
        	// TODO: Add event handler implementation here.
            CurrentCal();
        }

        private void getResistance(object sender, System.EventArgs e)
        {
        	// TODO: Add event handler implementation here.
            ResistorCal();
        }
    }
}