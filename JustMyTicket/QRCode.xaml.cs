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
    public partial class QRCode : PhoneApplicationPage
    {
        BusReference.Service1Client objService = null;
        BusReference.REGISTER userObj = new BusReference.REGISTER();
        string email, busNo;
        int dt,dtM;
        public QRCode()
        {
            InitializeComponent();
            objService = new BusReference.Service1Client();
            email = PhoneApplicationService.Current.State["Email"].ToString();
            busNo = PhoneApplicationService.Current.State["Bus_No"].ToString();
            dt = DateTime.Today.Day;
            dtM = DateTime.Today.Month;
            QR.Text = email.Substring(0,1) + busNo.ToString() + Convert.ToString(dt)+Convert.ToString(dtM);

        }
    }
}