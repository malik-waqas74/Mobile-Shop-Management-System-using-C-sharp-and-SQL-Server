using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Windows.Media.Animation;

namespace MobileShopManagement
{
    /// <summary>
    /// Interaction logic for SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : Window
    {
        DispatcherTimer k = new DispatcherTimer();

        public SplashScreen()
        {
        
            InitializeComponent();
            k.Tick += new EventHandler(Timer1_Tick);
            k.Interval = new TimeSpan(0, 0, 5);
            k.Start();
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LoginPage j = new LoginPage();
            j.Show();
            k.Stop();
            this.Close();


        }
    }
}
