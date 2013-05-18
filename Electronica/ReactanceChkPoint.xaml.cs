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
    public partial class ReactanceChkPoint : PhoneApplicationPage
    {
        public ReactanceChkPoint()
        {
            InitializeComponent();
        }

        private void InductiveGotoCal(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            NavigationService.Navigate(new Uri("/Inductive Reactance.xaml", UriKind.Relative));
        }

        private void CapacitiveGotoCal(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            NavigationService.Navigate(new Uri("/Capacitive Reactance.xaml", UriKind.Relative));
        }
    }
}