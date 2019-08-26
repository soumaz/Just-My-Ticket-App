using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Device.Location;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Controls.Maps;

namespace JustMyTicket
{
    public partial class Journey : PhoneApplicationPage
    {
        GeoCoordinateWatcher myGeoLocator;
        string textBlockLocationLatitute;
        string textBlockLocationLongitute;
        BusReference.Service1Client busDetail = null;
        MapLayer markerLayer = null;
        public Journey()
        {
            InitializeComponent();
            busDetail = new BusReference.Service1Client();
            button2.IsEnabled = false;
            button3.IsEnabled = false;
            string Rush = PhoneApplicationService.Current.State["Rush"].ToString();
            if(Rush == "Low" )
            {
                RectStatus.Fill = new SolidColorBrush(System.Windows.Media.Colors.Green); 
            }
            else if (Rush == "Medium")
            {
                RectStatus.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow); 
            }
            else
            {
                RectStatus.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red); 
            }
            
         }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            myGeoLocator = new GeoCoordinateWatcher(GeoPositionAccuracy.Default);
            //myGeoLocator.DesiredAccuracy = GeoPositionAccuracy.Default;
            myGeoLocator.MovementThreshold = 50;
           // myGeoLocator.StatusChanged += myGeoLocator_StatusChanged;
            button1.IsEnabled = false;
            button3.IsEnabled = true;
            button2.IsEnabled = true;
            myGeoLocator.PositionChanged += new EventHandler<System.Device.Location.GeoPositionChangedEventArgs<GeoCoordinate>>(myGeoLocator_PositionChanged);
            markerLayer = new MapLayer();
            map2.Children.Add(markerLayer);
            myGeoLocator.Start();
        }
        //void myGeoLocator_StatusChanged(object sender, StatusChangedEventArgs args)
        //{
        //    PositionStatus ps = args.Status;
        //    Dispatcher.BeginInvoke(() =>
        //    {
        //        textBoxGPSStatus.Text = ps.ToString();
        //    });
        //}
        void myGeoLocator_PositionChanged(object sender, System.Device.Location.GeoPositionChangedEventArgs<GeoCoordinate> args)
        {
            Dispatcher.BeginInvoke(() =>
            {
                Pushpin locationPushpin = new Pushpin();
                locationPushpin.Background = new SolidColorBrush(Colors.Red);
                locationPushpin.Content = "You are here";
                locationPushpin.Tag = "locationPushpin";
                locationPushpin.Location = myGeoLocator.Position.Location;
                this.map2.Children.Add(locationPushpin);
                this.map2.SetView(myGeoLocator.Position.Location, 10.0);
                myGeoLocator.Stop();
                textBlockLocationLatitute = args.Position.Location.Latitude.ToString("0.00");
                textBlockLocationLongitute = args.Position.Location.Longitude.ToString("0.00");
             //   textSpeed = args.Position.Location.Speed.ToString(); //gets the speed
                busDetail.RetrieveFormatedAddressAsync(textBlockLocationLatitute, textBlockLocationLongitute);
             //   busDetail.RetrieveFormatedAddressCompleted += new EventHandler<BusReference.RetrieveFormatedAddressCompletedEventArgs>(busDetail_RetrieveFormatedAddressCompleted);
                WebClient client = new WebClient();
                client.DownloadStringCompleted += client_DownloadStringCompleted;
                string Url = "https://maps.googleapis.com/maps/api/geocode/json?latlng=" + textBlockLocationLatitute + "," + textBlockLocationLongitute + "&key=AIzaSyBadZUbLHooRyZ1HUEfEsYw-uhU9GNhtuo";
                client.DownloadStringAsync(new Uri(Url, UriKind.RelativeOrAbsolute));

            });
        }
        void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            var data = e.Result.ToList();
         //   var url = (string)obj.SelectToken("data.img_url");
            Console.WriteLine(data);
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            myGeoLocator.PositionChanged -= new EventHandler<System.Device.Location.GeoPositionChangedEventArgs<GeoCoordinate>>(myGeoLocator_PositionChanged); 
           // myGeoLocator.StatusChanged -= myGeoLocator_StatusChanged;
            
            myGeoLocator = null;
          //  buttonEnableGPS.IsEnabled = true;
          //  buttonDisableGPS.IsEnabled = false;
            //button2.IsEnabled = false;
            //button1.IsEnabled = true;
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            //BusReference.REGISTER res = new BusReference.REGISTER();
            //BusReference.Bus bs = new BusReference.Bus();
            //PhoneApplicationService.Current.State["Email"] = res.Email_ID;
            //PhoneApplicationService.Current.State["Bus_No"] = bs.Bus_No;
            NavigationService.Navigate(new Uri("/QRCode.xaml", UriKind.Relative));
        }
        
    }
}