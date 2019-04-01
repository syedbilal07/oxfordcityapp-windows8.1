using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace OxfordCity.Pages
{
    public sealed partial class Accomodations : Page
    {
        public Accomodations()
        {
            this.InitializeComponent();
        }
        private void Go_Back(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ContentPage));
        }

        private void Open_Maps(object sender, RoutedEventArgs e)
        {
            entersite.Text = "https://www.google.com/maps/search/accommodation/@51.7609351,-1.2612068,14z/data=!3m1!4b1!4m8!2m7!3m6!1saccommodation!2sOxford,+UK!3s0x48713380adc41faf:0xc820dba8cb547402!4m2!1d-1.2577263!2d51.7520209";
            Uri targeturi = new Uri(entersite.Text);
            web.Navigate(targeturi);
            web.Visibility = Visibility.Visible;
        }
    }
}
