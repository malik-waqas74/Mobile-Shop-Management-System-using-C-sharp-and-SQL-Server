using System.Windows;

namespace MobileShopManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            AddNewMobile k = new AddNewMobile();
            k.Show();



        }

        private void Button_ClickCustomer(object sender, RoutedEventArgs e)
        {

        }

        private void DisplayMobiles(object sender, RoutedEventArgs e)
        {
            DisplayAllMobiles k = new DisplayAllMobiles();
            k.Show();

        }

        private void Addcustomer(object sender, RoutedEventArgs e)
        {
            AddCustomer k = new AddCustomer();
            k.Show();
        }

        private void SalesIno(object sender, RoutedEventArgs e)
        {
            SalesInformation k = new SalesInformation();
            k.Show();
        }

        private void Inv(object sender, RoutedEventArgs e)
        {
            Inventory k = new Inventory();
            k.Show();
        }

        private void Ss(object sender, RoutedEventArgs e)
        {
            SaleMobile k = new SaleMobile();
            k.Show();
        }
    }
}
