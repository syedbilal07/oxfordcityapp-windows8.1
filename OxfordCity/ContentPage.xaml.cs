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

namespace OxfordCity
{
    public sealed partial class ContentPage : Page
    {
        public ContentPage()
        {
            this.InitializeComponent();
        }

        private void Go_Back(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Connection));
        }

        private void Shopping_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Shopping));
        }
        private void Restaurants_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Restaurants));
        }

        private void Accomodations_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Accomodations));
        }
    }
}
