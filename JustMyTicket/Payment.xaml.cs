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
using Microsoft.Phone.Shell;

namespace JustMyTicket
{
    public partial class Payment : PhoneApplicationPage
    {
        BusReference.Service1Client busDetail = null;
        BusReference.REGISTER userObj = new BusReference.REGISTER();
        public Payment()
        {
            InitializeComponent();
            busDetail = new BusReference.Service1Client();
            busDetail.Current_BalanceAsync(PhoneApplicationService.Current.State["Email"].ToString());
            busDetail.Current_BalanceCompleted+=new EventHandler<BusReference.Current_BalanceCompletedEventArgs>(busDetail_Current_BalanceCompleted);
        }
        string data;
        private void txtNameOnCard_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox t = sender as TextBox;
            data = t.Text;
            t.Text = string.Empty;
            t.Background = new SolidColorBrush(Colors.Cyan);

        }

        private void txtCardNo_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox t = sender as TextBox;
            data = t.Text;
            t.Text = string.Empty;
            t.Background = new SolidColorBrush(Colors.Cyan);

        }

        private void txtMonth_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox t = sender as TextBox;
            data = t.Text;
            t.Text = string.Empty;
            t.Background = new SolidColorBrush(Colors.Cyan);

        }

        private void txtYear_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox t = sender as TextBox;
            data = t.Text;
            t.Text = string.Empty;
            t.Background = new SolidColorBrush(Colors.Cyan);

        }

        private void txtCVV_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox t = sender as TextBox;
            data = t.Text;
            t.Text = string.Empty;
            t.Background = new SolidColorBrush(Colors.Cyan);

        }

        private void txtNameOnCard_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Equals(string.Empty))
            {
                t.Text = data;
            }

        }

        private void txtCardNo_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Equals(string.Empty))
            {
                t.Text = data;
            }

        }

        private void txtMonth_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Equals(string.Empty))
            {
                t.Text = data;
            }

        }

        private void txtYear_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Equals(string.Empty))
            {
                t.Text = data;
            }

        }


        private void txtCVV_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Equals(string.Empty))
            {
                t.Text = data;
            }

        }

        public void busDetail_Current_BalanceCompleted(object sender,BusReference.Current_BalanceCompletedEventArgs e)
        {
            txtBalance.Text = e.Result;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {

        }
        
    }
}