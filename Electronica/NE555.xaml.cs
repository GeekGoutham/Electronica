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
    public partial class NE555 : PhoneApplicationPage
    {
        public NE555()
        {
            InitializeComponent();
        }

        private void cal555(object sender, System.Windows.Input.GestureEventArgs e)
        {
            double resist = Convert.ToDouble(resis.Text);
            double capacti = Convert.ToDouble(capa.Text);
            double rere = 1.1*resist*capacti;
            reess.Text = "The Time period is " + Convert.ToString(rere)+" s";

        }
    }
}