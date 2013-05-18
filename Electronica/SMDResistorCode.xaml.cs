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
    public partial class SMDResistorCode : PhoneApplicationPage
    {
        public SMDResistorCode()
        {
            InitializeComponent();
        }

        private void calSMD(object sender, System.Windows.Input.GestureEventArgs e)
        {
            try
            {
                int smd3;
                string inputSMD, smd1str, smd2str, smd3str, smd4str;
                char[] arr = new char[3];
                inputSMD = typeinSMD.Text;
                arr = inputSMD.ToCharArray();


                smd1str = Convert.ToString(arr[0]);
                smd2str = Convert.ToString(arr[1]);
                smd3str = Convert.ToString(arr[2]);

                smd3 = Convert.ToInt16(smd3str);

                switch (smd3)
                {
                    case 0:
                        SSSRESULT.Text = smd1str + smd2str + " Ω";

                        break;
                    case 1:
                        SSSRESULT.Text = smd1str + smd2str + "0 Ω";

                        break;
                    case 2:
                        SSSRESULT.Text = smd1str + "." + smd2str + " KΩ";

                        break;
                    case 3:
                        SSSRESULT.Text = smd1str + smd2str + " KΩ";

                        break;
                    case 4:
                        SSSRESULT.Text = smd1str + smd2str + "0 KΩ";

                        break;
                    case 5:
                        SSSRESULT.Text = smd1str + "." + smd2str + " MΩ";

                        break;
                    case 6:
                        SSSRESULT.Text = smd1str + smd2str + " MΩ";

                        break;
                    case 7:
                        SSSRESULT.Text = smd1str + smd2str + "0 MΩ";

                        break;
                    case 8:
                        SSSRESULT.Text = smd1str + "." + smd2str + " GΩ";

                        break;
                    case 9:
                        SSSRESULT.Text = smd1str + smd2str + " GΩ";

                        break;
                }

            }
            catch(Exception)
            {
                MessageBox.Show("Enter valid numbers in the text box \n Ignore R while entering in the SMD value","Format Error",MessageBoxButton.OK);
            }
        }

        private void calSMD4digit(object sender, System.Windows.Input.GestureEventArgs e)
        {
            try
            {
                int smd4;
                string inputSMD, smd1str, smd2str, smd3str, smd4str;
                char[] arr = new char[4];
                inputSMD = typeinSMD_Copy.Text;
                arr = inputSMD.ToCharArray();


                smd1str = Convert.ToString(arr[0]);
                smd2str = Convert.ToString(arr[1]);
                smd3str = Convert.ToString(arr[2]);
                smd4str = Convert.ToString(arr[3]);

                smd4 = Convert.ToInt16(smd4str);

                switch (smd4)
                {
                    case 0:
                        SSSRESULT.Text = smd1str + smd2str + smd3str + " Ω";

                        break;
                    case 1:
                        SSSRESULT.Text = smd1str + smd2str + smd3str + "0 Ω";

                        break;
                    case 2:
                        SSSRESULT.Text = smd1str + smd2str + "." + smd3str + " KΩ";

                        break;
                    case 3:
                        SSSRESULT.Text = smd1str + smd2str + smd3str + " KΩ";

                        break;
                    case 4:
                        SSSRESULT.Text = smd1str + smd2str + smd3str + "0 KΩ";

                        break;
                    case 5:
                        SSSRESULT.Text = smd1str + "." + smd2str + smd3str + " MΩ";

                        break;
                    case 6:
                        SSSRESULT.Text = smd1str + smd2str + "." + smd3str + " MΩ";

                        break;
                    case 7:
                        SSSRESULT.Text = smd1str + smd2str + smd3str + " MΩ";

                        break;
                    case 8:
                        SSSRESULT.Text = smd1str + "." + smd2str + smd3str + " GΩ";

                        break;
                    case 9:
                        SSSRESULT.Text = smd1str + smd2str + "." + smd3str + " GΩ";

                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Enter valid numbers in the text box \n Ignore R while entering in the SMD value", "Format Error", MessageBoxButton.OK);
            }
            
            
        }
        
    }
}