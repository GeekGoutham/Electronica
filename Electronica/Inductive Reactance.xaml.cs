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
    public partial class Inductive_Reactance : PhoneApplicationPage
    {
        public Inductive_Reactance()
        {
            InitializeComponent();
        }

        private void calFreq(object sender, System.EventArgs e)
        {
        	
            try
            {// TODO: Add event handler implementation here.
                double reactanceCapacitive = Convert.ToDouble(reacText.Text);
                double Capatica = Convert.ToDouble(capText.Text);

                double result = reactanceCapacitive/(2*3.14*Capatica);
                freqText.Text = Convert.ToString(result);
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter valid numbers for Reactance and Inductance!", "Format Error", MessageBoxButton.OK);
            }
        }

        private void calInduc(object sender, System.EventArgs e)
        {
        	// TODO: Add event handler implementation here.
            try
            {// TODO: Add event handler implementation here.
                double reactanceCapacitive = Convert.ToDouble(reacText.Text);
                double Frequen = Convert.ToDouble(freqText.Text);

                double result = reactanceCapacitive/(2*3.14*Frequen);
                capText.Text = Convert.ToString(result);
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter valid numbers for Frequency and Reactance!", "Format Error", MessageBoxButton.OK);
            }
        }

        private void CalReact(object sender, System.EventArgs e)
        {
        	// TODO: Add event handler implementation here.
            try
            {// TODO: Add event handler implementation here.
                double frequen = Convert.ToDouble(freqText.Text);
                double Capatica = Convert.ToDouble(capText.Text);

                double result = (2 * 3.14 * frequen * Capatica);
                reacText.Text = Convert.ToString(result);
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter valid numbers for Frequency and Inductance!", "Format Error", MessageBoxButton.OK);
            }
        }
    }
}