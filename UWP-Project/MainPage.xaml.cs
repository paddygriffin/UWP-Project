using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP_Project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        string Lat, Lng;
        public MainPage()
        {
            this.InitializeComponent();
            HideStatusBar();
        }

        private async void HideStatusBar()
        {
            if (ApiInformation.IsApiContractPresent("Windows.Phone.PhoneContract", 1, 0))
            {
                var statusBar = StatusBar.GetForCurrentView();
                await statusBar.HideAsync();
            }
        }

        private async void weatherButton_Click(object sender, RoutedEventArgs e)
        {
            progressRing.IsActive = true; //activate the progress ring while data loads
            

            // adapted from-http://stackoverflow.com/questions/24238373/geolocation-in-c-sharp
            var geoLocator = new Geolocator(); //Create object
            geoLocator.DesiredAccuracy = PositionAccuracy.High; //Add accuracy
            Geoposition pos = await geoLocator.GetGeopositionAsync();//async operation to get current location
            Lat = pos.Coordinate.Point.Position.Latitude.ToString(); //
            Lng = pos.Coordinate.Point.Position.Longitude.ToString();
     
           
            var data = await Helper.Helper.GetWeather(Lat, Lng);

            if (data != null)
            {
                txtCity.Text = $"{data.name},{data.sys.country}"; //location name = area 
                txtLastUpdate.Text = $"Last updated : {DateTime.Now.ToString("dd MMMM yyyy HH:mm")}"; // last updated 
                //imgWeather from XAML needs to be sorted
                //Its one of these
               // BitmapImage image = new BitmapImage(new Uri($"http://openweathermap.org/img/w/{data.weather[0].icon}.png", UriKind.Absolute));
                BitmapImage image = new BitmapImage(new Uri($"http://openweathermap.org/img/w/10d.png", UriKind.Absolute));
                imgWeather.Source = image; //this is passed to the grid on XAML

                //"XAML Page text block name".Text = the WeatherAttributes
                txtDescription.Text = $"{data.weather[0].description}";
                txtHumidity.Text = $"Humidity : {data.main.humidity}%";
                //getting the time of the sunrise and sunset 
                txtTime.Text = $"Sunrise/Sunset: {Common.APIclass.ConvertUnixTimeToDateTime(data.sys.sunrise).ToString("HH:mm")}/ {Common.APIclass.ConvertUnixTimeToDateTime(data.sys.sunset).ToString("HH:mm")}";
                
                txtCel.Text = $"Temperature: {data.main.temp} °C"; // temperature
                windSpeed.Text = $"Wind: {data.wind.speed} km/h"; // speed of wind 
                windDeg.Text = $"{data.wind.deg} degree direction";//direction of wind
                
            }
            progressRing.IsActive = false; // deactivate the progress ring when close
        }
    }
}

