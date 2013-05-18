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
    public partial class ResistorColor : PhoneApplicationPage
    {
        public ResistorColor()
        {
            InitializeComponent();
        }

        private void bb1(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            a1band.Fill = blacky.Fill;
            calculteValue();
        }

        private void bb2(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            b2band.Fill = blacky.Fill;
            calculteValue();
        }

        private void bb3(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            dband.Fill = blacky.Fill;
            calculteValue();
        }

        private void br1(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            a1band.Fill = browny.Fill;
            calculteValue();
        }

        private void br2(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            b2band.Fill = browny.Fill;
            calculteValue();
            
        }

        private void br3(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            dband.Fill = browny.Fill;
            calculteValue();
        }

        private void brsp(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	tolband.Fill = bsp.Fill;
            calculteValue();
        }

        private void or1(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            a1band.Fill = reddy.Fill;
            calculteValue();
        }

        private void or2(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            b2band.Fill = reddy.Fill;
            calculteValue();
        }

        private void or3(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            dband.Fill = reddy.Fill;
            calculteValue();
        }

        private void orsp(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tolband.Fill = rsp.Fill;
            calculteValue();
        }

        private void oo1(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            a1band.Fill = orangy.Fill;
            calculteValue();
        }

        private void oo2(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            b2band.Fill = orangy.Fill;
            calculteValue();
        }

        private void oo3(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            dband.Fill = orangy.Fill;
            calculteValue();
        }

        private void oosp(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tolband.Fill = osp.Fill;
            calculteValue();
        }

        private void ye1(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            a1band.Fill = yellowy.Fill;
            calculteValue();
        }

        private void ye2(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            
            b2band.Fill = yellowy.Fill;
            calculteValue();
        }

        private void ye3(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            dband.Fill = yellowy.Fill;
            calculteValue();
        }

        private void yesp(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tolband.Fill = ysp.Fill;
            calculteValue();
        }

        private void gr1(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            a1band.Fill = greeny.Fill;
            calculteValue();
        }

        private void gr2(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            b2band.Fill = greeny.Fill;
            calculteValue();
        }

        private void gr3(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            dband.Fill = greeny.Fill;
            calculteValue();
        }

        private void grsp(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tolband.Fill = gsp.Fill;
            calculteValue();
        }

        private void bl1(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            a1band.Fill = bluy.Fill;
            calculteValue();
        }

        private void bl2(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            b2band.Fill = bluy.Fill;
            calculteValue();
        }

        private void bl3(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            dband.Fill = bluy.Fill;
            calculteValue();
        }

        private void blsp(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tolband.Fill = bsp1.Fill;
            calculteValue();
        }

        private void la1(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            a1band.Fill = lavendery.Fill;
            calculteValue();
        }

        private void la2(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            b2band.Fill = lavendery.Fill;
            calculteValue();
        }

        private void la3(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            dband.Fill = lavendery.Fill;
            calculteValue();
        }

        private void lasp(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tolband.Fill = lsp.Fill;
            calculteValue();
        }

        private void gg1(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            a1band.Fill = greyyy.Fill;
            calculteValue();
        }

        private void gg2(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            b2band.Fill = greyyy.Fill;
            calculteValue();
        }

        private void gg3(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            dband.Fill = greyyy.Fill;
            calculteValue();
        }

        private void ggsp(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tolband.Fill = gsp1.Fill;
            calculteValue();
        }

        private void ww1(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            a1band.Fill = wity.Fill;
            calculteValue();
        }

        private void ww2(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            b2band.Fill = wity.Fill;
            calculteValue();
        }

        private void ww3(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            dband.Fill = wity.Fill;
            calculteValue();
        }
        public void calculteValue()
        {
            int resBand1, resBand2, resBand3;
            float tolBand;
            string resBandstr, resBand2str, resBand3str, tolBandstr;
            if (a1band.Fill == blacky.Fill)
                resBand1 = 0;
            else if (a1band.Fill == browny.Fill)
                resBand1 = 1;
            else if (a1band.Fill == reddy.Fill)
                resBand1 = 2;
            else if (a1band.Fill == orangy.Fill)
                resBand1 = 3;
            else if (a1band.Fill == yellowy.Fill)
                resBand1 = 4;
            else if (a1band.Fill == greeny.Fill)
                resBand1 = 5;
            else if (a1band.Fill == bluy.Fill)
                resBand1 = 6;
            else if (a1band.Fill == lavendery.Fill)
                resBand1 = 7;
            else if (a1band.Fill == greyyy.Fill)
                resBand1 = 8;
            else resBand1 = 9;
            resBandstr = Convert.ToString(resBand1);

            if (b2band.Fill == blacky.Fill)
                resBand2 = 0;
            else if (b2band.Fill == browny.Fill)
                resBand2 = 1;
            else if (b2band.Fill == reddy.Fill)
                resBand2 = 2;
            else if (b2band.Fill == orangy.Fill)
                resBand2 = 3;
            else if (b2band.Fill == yellowy.Fill)
                resBand2 = 4;
            else if (b2band.Fill == greeny.Fill)
                resBand2 = 5;
            else if (b2band.Fill == bluy.Fill)
                resBand2 = 6;
            else if (b2band.Fill == lavendery.Fill)
                resBand2 = 7;
            else if (b2band.Fill == greyyy.Fill)
                resBand2 = 8;
            else resBand2 = 9;
            resBand2str = Convert.ToString(resBand2);

            if (dband.Fill == blacky.Fill)
                resBand3 = 0;
            else if (dband.Fill == browny.Fill)
                resBand3 = 1;
            else if (dband.Fill == reddy.Fill)
                resBand3 = 2;
            else if (dband.Fill == orangy.Fill)
                resBand3 = 3;
            else if (dband.Fill == yellowy.Fill)
                resBand3 = 4;
            else if (dband.Fill == greeny.Fill)
                resBand3 = 5;
            else if (dband.Fill == bluy.Fill)
                resBand3 = 6;
            else if (dband.Fill == lavendery.Fill)
                resBand3 = 7;
            else if (dband.Fill == greyyy.Fill)
                resBand3 = 8;
            else resBand3 = 9;
            resBand3str = Convert.ToString(resBand3);
            
             if (tolband.Fill == bsp.Fill)
                tolBand = 1;
            else if (tolband.Fill == rsp.Fill)
                tolBand = 2;
            else if (tolband.Fill == osp.Fill)
                tolBand = 10;
            else if (tolband.Fill == ysp.Fill)
                tolBand = 5;
            else if (tolband.Fill == gsp.Fill)
                tolBand = 0.5F;
            else if (tolband.Fill == bsp1.Fill)
                tolBand = 0.25F;
            else if (tolband.Fill == lsp.Fill)
                tolBand = 0.1F;
            else 
                tolBand = 0.05F;
             tolBandstr = Convert.ToString(tolBand);

             switch (resBand3)
             {
                 case 0:
                     restxt1.Text = resBandstr + resBand2str + " Ω";
                     restxttol.Text = tolBandstr + "%";
                     break;
                 case 1:
                     restxt1.Text = resBandstr + resBand2str + "0 Ω";
                     restxttol.Text = tolBandstr + "%";
                     break;
                 case 2:
                     restxt1.Text = resBandstr + "." + resBand2str + " KΩ";
                     restxttol.Text = tolBandstr + "%";
                     break;
                 case 3:
                     restxt1.Text = resBandstr + resBand2str + " KΩ" ;
                     restxttol.Text = tolBandstr + "%";
                     break;
                 case 4:
                     restxt1.Text = resBandstr + resBand2str + "0 KΩ" ;
                     restxttol.Text = tolBandstr + "%";
                     break;
                 case 5:
                     restxt1.Text = resBandstr + "." + resBand2str + " MΩ";
                     restxttol.Text = tolBandstr + "%";
                     break;
                 case 6:
                     restxt1.Text = resBandstr + resBand2str + " MΩ";
                     restxttol.Text = tolBandstr + "%";
                     break;
                 case 7:
                     restxt1.Text = resBandstr + resBand2str + "0 MΩ";
                     restxttol.Text = tolBandstr + "%";
                     break;
                 case 8:
                     restxt1.Text = resBandstr + resBand2str + "00 MΩ";
                     restxttol.Text = tolBandstr + "%";
                     break;
                 case 9:
                     restxt1.Text = resBandstr + resBand2str + "000 MΩ";
                     restxttol.Text = tolBandstr + "%";
                     break;
             }
        }
    }
}