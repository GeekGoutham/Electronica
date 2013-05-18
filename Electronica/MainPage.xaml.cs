using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;

namespace Electronica
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        // Load data for the ViewModel Items
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void LoadChargeDef(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            NavigationService.Navigate(new Uri("/ChargeDef.xaml", UriKind.Relative));
        }

        private void VoltDefNav(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            NavigationService.Navigate(new Uri("/VoltDef.xaml", UriKind.Relative));
        }

        private void CurrentDefNAv(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            NavigationService.Navigate(new Uri("/CurrentDef.xaml", UriKind.Relative));
        }

        private void OhmsNAv(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            NavigationService.Navigate(new Uri("/OhmsDef.xaml", UriKind.Relative));
        }

        private void ResisDefNav(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            NavigationService.Navigate(new Uri("/ResistoDef.xaml", UriKind.Relative));
        }

        private void CapDefNav(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            NavigationService.Navigate(new Uri("/CapDef.xaml", UriKind.Relative));
        }

        private void InductDef(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            NavigationService.Navigate(new Uri("/InducDef.xaml", UriKind.Relative));
        }

        private void SCDefNav(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            NavigationService.Navigate(new Uri("/SemiConDef.xaml", UriKind.Relative));
        }

        private void GotoOhmsCal(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            NavigationService.Navigate(new Uri("/OhmsLawPage.xaml", UriKind.Relative));
        }

        private void GotoReactanceCal(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            NavigationService.Navigate(new Uri("/ReactanceChkPoint.xaml", UriKind.Relative));
        }

        private void GotoResistorCal(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            NavigationService.Navigate(new Uri("/ResistorColor.xaml", UriKind.Relative));
        }

        private void gotoinduccal(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            NavigationService.Navigate(new Uri("/InductorColor.xaml", UriKind.Relative));
        }

        private void gotoSMD(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            NavigationService.Navigate(new Uri("/SMDResistorCode.xaml", UriKind.Relative));
        }

        private void reportbug(object sender, System.Windows.Input.GestureEventArgs e)
        {
            sendBug();
        }

        private void feedbackmail(object sender, System.Windows.Input.GestureEventArgs e)
        {
            sendFeed();
        }

        private void ratereview(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ratemyapp();
        }

        private void reportbugimage(object sender, System.Windows.Input.GestureEventArgs e)
        {
            sendBug();
        }

        private void reportbugtxt(object sender, System.Windows.Input.GestureEventArgs e)
        {
            sendBug();
        }

       
        private void feedtxt(object sender, System.Windows.Input.GestureEventArgs e)
        {
            sendFeed();
        }

        private void fivestartxt(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ratemyapp();
        }

        private void star1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ratemyapp();
        }

        private void star2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ratemyapp();
        }

        private void star3(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ratemyapp();
        }

        private void star4(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ratemyapp();
        }

        private void star5(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ratemyapp();
        }
        public void sendBug()
        {
            Microsoft.Phone.Tasks.EmailComposeTask emailComposeTask = new Microsoft.Phone.Tasks.EmailComposeTask();
            emailComposeTask.To = "geekgoutham@live.com";
            emailComposeTask.Subject = "Bug Report (Electronica)";
            emailComposeTask.Body = "Enter the details of the bug you encountered below";
            emailComposeTask.Show();
        }
        public void sendFeed()
        {
            Microsoft.Phone.Tasks.EmailComposeTask emailComposeTask = new Microsoft.Phone.Tasks.EmailComposeTask();
            emailComposeTask.To = "geekgoutham@live.com";
            emailComposeTask.Subject = "Feedback (Electronica)";
            emailComposeTask.Body = "Give your feedback below";
            emailComposeTask.Show(); 
        }

        public void ratemyapp()
        {
            try
            {
                var rateTask = new MarketplaceReviewTask();
                rateTask.Show();
            }
            catch
            {
            }
        }

        private void feedimage(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	sendFeed();
        }

        private void gotone555(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/NE555.xaml", UriKind.Relative));
        }

        private void navusbpin(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/USBpins.xaml", UriKind.Relative));
        }

        private void navserialout(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Serialport.xaml", UriKind.Relative));
        }

        private void parallelpinout(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/parallelport.xaml", UriKind.Relative));
        }

        private void ethernetpinout(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	NavigationService.Navigate(new Uri("/ethernetregjack.xaml", UriKind.Relative));
        }

        private void ApplicationStarted(object sender, System.Windows.RoutedEventArgs e)
        {
            ReviewBugger.CheckNumOfRuns();
            if (ReviewBugger.IsTimeForReview())
            {
                ReviewBugger.PromptUser();
            }
        }
    }
}