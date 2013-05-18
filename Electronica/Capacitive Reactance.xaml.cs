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
    public partial class Capacitive_Reactance : PhoneApplicationPage
    {
        public Capacitive_Reactance()
        {
            InitializeComponent();
        }

        private void CalFreq(object sender, System.EventArgs e)
        {
            try
            {// TODO: Add event handler implementation here.
                double reactanceCapacitive = Convert.ToDouble(reacText.Text);
                double Capatica = Convert.ToDouble(capText.Text);

                double result = 1 / (2 * 3.14 * reactanceCapacitive * Capatica);
                freqText.Text = Convert.ToString(result);
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter valid numbers for Reactance and Capacitance!", "Format Error", MessageBoxButton.OK);
            }
        }

        private void CalCapacitance(object sender, System.EventArgs e)
        {
            try
            {// TODO: Add event handler implementation here.
                double reactanceCapacitive = Convert.ToDouble(reacText.Text);
                double Frequen = Convert.ToDouble(freqText.Text);

                double result = 1 / (2 * 3.14 * reactanceCapacitive * Frequen);
                capText.Text = Convert.ToString(result);
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter valid numbers for Frequency and Reactance!", "Format Error", MessageBoxButton.OK);
            }
        }

        private void CalReactance(object sender, System.EventArgs e)
        {
            try
            {// TODO: Add event handler implementation here.
                double frequen = Convert.ToDouble(freqText.Text);
                double Capatica = Convert.ToDouble(capText.Text);

                double result = 1 / (2 * 3.14 * frequen * Capatica);
                reacText.Text = Convert.ToString(result);
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter valid numbers for Frequency and Capacitance!", "Format Error", MessageBoxButton.OK);
            }
        }
    }
}