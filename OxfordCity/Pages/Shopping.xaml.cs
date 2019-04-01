using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace OxfordCity.Pages
{
    public sealed partial class Shopping
    {
        public Shopping()
        {
            this.InitializeComponent();
        }

        private void Go_Back(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ContentPage));
        }
        private void Open_Maps(object sender, RoutedEventArgs e)
        {
            entersite.Text = "https://www.google.com/maps/search/shopping+mall/@51.7609299,-1.2612069,14z/data=!3m1!4b1";
            Uri targeturi = new Uri(entersite.Text);
            web.Navigate(targeturi);
            web.Visibility = Visibility.Visible;
        }
    }
}
