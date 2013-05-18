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
    public partial class InductorColor : PhoneApplicationPage
    {
        public InductorColor()
        {
            InitializeComponent();
        }

        private void black1(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            a1band.Fill = blacky.Fill;
            calculteValue();
        }

        private void black2(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            b2band.Fill = blacky.Fill;
            calculteValue();
        }

        private void black3(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            dband.Fill = blacky.Fill;
            calculteValue();
        }

        private void black4(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            tolband.Fill = blacky.Fill;
            calculteValue();
        }

        private void brown1(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            a1band.Fill = browny.Fill;
            calculteValue();
        }

        private void brown2(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            b2band.Fill = browny.Fill;
            calculteValue();
        }

        private void brown3(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            dband.Fill = browny.Fill;
            calculteValue();
        }

        private void brown4(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            tolband.Fill = browny.Fill;
            calculteValue();
        }

        private void red1(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            a1band.Fill = reddy.Fill;
            calculteValue();
        }

        private void red2(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            b2band.Fill = reddy.Fill;
            calculteValue();
        }

        private void red3(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            dband.Fill = reddy.Fill;
            calculteValue();
        }

        private void red4(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            tolband.Fill = reddy.Fill;
            calculteValue();
        }

        private void orange1(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            a1band.Fill = orangy.Fill;
            calculteValue();
        }

        private void orange2(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            b2band.Fill = orangy.Fill;
            calculteValue();
        }

        private void orange3(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            dband.Fill = orangy.Fill;
            calculteValue();
        }

        private void orange4(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            tolband.Fill = orangy.Fill;
            calculteValue();
        }

        private void yellow1(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            a1band.Fill = yellowy.Fill;
            calculteValue();
        }

        private void yellow2(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            b2band.Fill = yellowy.Fill;
            calculteValue();
        }

        private void yellow3(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            dband.Fill = yellowy.Fill;
            calculteValue();
        }

        private void yellow4(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            tolband.Fill = yellowy.Fill;
            calculteValue();
        }

        private void green1(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            a1band.Fill = greeny.Fill;
            calculteValue();
        }

        private void green2(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            b2band.Fill = greeny.Fill;
            calculteValue();
        }

        private void blue1(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            a1band.Fill = bluy.Fill;
            calculteValue();
        }

        private void blue2(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            b2band.Fill = bluy.Fill;
            calculteValue();
        }

        private void lavender1(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            a1band.Fill = lavendery.Fill;
            calculteValue();
        }
        private void lavender2(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            b2band.Fill = lavendery.Fill;
            calculteValue();
        }

        private void grey1(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            a1band.Fill = greyyy.Fill;
            calculteValue();
        }

        private void grey2(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            b2band.Fill = greyyy.Fill;
            calculteValue();
        }

        private void gold1(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            dband.Fill = goldy.Fill;
            calculteValue();
        }

        private void gold2(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            tolband.Fill = goldy.Fill;
            calculteValue();
        }

        private void white1(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            a1band.Fill = wity.Fill;
            calculteValue();
        }

        private void white2(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            b2band.Fill = wity.Fill;
            calculteValue();
        }

        private void silver1(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            dband.Fill = silvery.Fill;
            calculteValue();
        }

        private void silver2(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            tolband.Fill = silvery.Fill;
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
            else if (dband.Fill == goldy.Fill)
                resBand3 = 5;
            else 
                resBand3 = 6;
            
            resBand3str = Convert.ToString(resBand3);

            if (tolband.Fill == blacky.Fill)
                tolBand = 20;
            else if (tolband.Fill == browny.Fill)
                tolBand = 1;
            else if (tolband.Fill == reddy.Fill)
                tolBand = 2;
            else if (tolband.Fill == orangy.Fill)
                tolBand = 3;
            else if (tolband.Fill == yellowy.Fill)
                tolBand = 4;
            else if (tolband.Fill == goldy.Fill)
                tolBand = 5;
            else
                tolBand = 10;
            tolBandstr = Convert.ToString(tolBand);

            switch (resBand3)
            {
                case 0:
                    restxt1.Text = resBandstr + resBand2str + " μH";
                    restxttol.Text = tolBandstr + "%";
                    break;
                case 1:
                    restxt1.Text = resBandstr + resBand2str + "0 μH";
                    restxttol.Text = tolBandstr + "%";
                    break;
                case 2:
                    restxt1.Text = resBandstr +"."+ resBand2str + " mH";
                    restxttol.Text = tolBandstr + "%";
                    break;
                case 3:
                    restxt1.Text = resBandstr + resBand2str + " mH";
                    restxttol.Text = tolBandstr + "%";
                    break;
                case 4:
                    restxt1.Text = resBandstr + resBand2str + "0 mH";
                    restxttol.Text = tolBandstr + "%";
                    break;
                case 5:
                    restxt1.Text = resBandstr + resBand2str + "00 nH";
                    restxttol.Text = tolBandstr + "%";
                    break;
                case 6:
                    restxt1.Text = resBandstr + resBand2str + "0 nH";
                    restxttol.Text = tolBandstr + "%";
                    break;
                
            }
        }
    }
}