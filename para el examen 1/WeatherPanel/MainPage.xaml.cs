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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace WeatherPanel
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ciudad.Text = "in "+cajitacontexto.Text;
        }

        private void mapa(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ErMapa),cajitacontexto.Text);
        }

        private void Muestra_Boton(object sender, KeyRoutedEventArgs e)
        {
            if (boton.Visibility == Visibility.Collapsed && e.Key == Windows.System.VirtualKey.Enter)
                boton.Visibility = Visibility.Visible;
            else if (boton.Visibility == Visibility.Visible  && cajitacontexto.Text=="" && e.Key == Windows.System.VirtualKey.Back)
                boton.Visibility = Visibility.Collapsed;
        }
    }
}
