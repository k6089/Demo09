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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace T1cars
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void carsCount_Click(object sender, RoutedEventArgs e)
        {
            int cars = int.Parse(carsCount.Text);
            cars++;
            carsCount.Text = Convert.ToString(cars);
        }

        private void trucksCount_Click(object sender, RoutedEventArgs e)
        {
            // "0" --> 0
            int trucks = int.Parse(trucksCount.Text);
            trucks++;
            trucksCount.Text = trucks.ToString();
        }

        
    }
}
