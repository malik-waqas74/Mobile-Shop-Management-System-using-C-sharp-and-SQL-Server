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
using System.Data.SqlClient;
using System.Data;

namespace MobileShopManagement
{
    /// <summary>
    /// Interaction logic for SalesInformation.xaml
    /// </summary>
    public partial class SalesInformation : Window
    {
        public SalesInformation()
        {
            InitializeComponent();
        }

        private void SalesEn(object sender, RoutedEventArgs e)
        {

            try
            {
                SqlConnection sqlCon = new SqlConnection(@"Data Source=MALIKWAQAS\SQLSERVER2017;Initial Catalog=MOBILESHOP;Integrated Security=True");
                sqlCon.Open();
                string DisplayAll = "select MobileName,SoldDate,Customer.C_Name,(PriceInfo.PurchasePrice*Sales.Quantity)as PurchasedPrice,(Sales.Quantity*PriceInfo.SalePrice)as SalesPrice,(Sales.Quantity*PriceInfo.SalePrice-PriceInfo.PurchasePrice*Sales.Quantity)as Profit,Sales.Quantity as Total_Mobiles_Bought from Mobiles inner join Inventry on Mobiles.MobileID =Inventry.MobileID inner join Sales on Mobiles.MobileID=Sales.MobileID inner join PriceInfo on Sales.MobileID=PriceInfo.MobileID inner join Customer on Customer.CustomerID=Sales.CustomerID ";
                SqlCommand sqlCmd = new SqlCommand(DisplayAll, sqlCon);
                sqlCmd.ExecuteNonQuery();
                SqlDataAdapter ad = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable("Mobiles");
                ad.Fill(dt);
                Dgrid.ItemsSource = dt.DefaultView;
                ad.Update(dt);

                sqlCon.Close();





            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
