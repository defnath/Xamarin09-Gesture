using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarion09Gesture
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class TapDemo : ContentPage
    {
        bool isTap = false;

        bool isVisible = false;
        public TapDemo()
        {
            InitializeComponent();

            var tap1 = new TapGestureRecognizer();
            tap1.Tapped += EventTap;
            lblTap1.GestureRecognizers.Add(tap1);

            var tap2 = new TapGestureRecognizer();
            tap2.Tapped += EventTapImage;
            lblTap2.GestureRecognizers.Add(tap2);
        }

        void EventTap(object sender, EventArgs e)
        {
            isTap = !isTap;

            if (isTap)
                btnTap1.BackgroundColor = Color.Red;
            else
                btnTap1.BackgroundColor = Color.Green;
        }

        void EventTapImage(object sender, EventArgs e)
        {
            isVisible = !isVisible;

            if (isVisible)
                image1.Source = "tapped.png";
            else
                image1.Source = "tapped_bw.png";
        }
    }
}