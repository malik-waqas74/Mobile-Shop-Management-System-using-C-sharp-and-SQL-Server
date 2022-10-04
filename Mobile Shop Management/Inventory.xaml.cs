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
    /// Interaction logic for Inventory.xaml
    /// </summary>
    public partial class Inventory : Window
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void CCC(object sender, RoutedEventArgs e)
        {


            try
            {
                SqlConnection sqlCon = new SqlConnection(@"Data Source=MALIKWAQAS\SQLSERVER2017;Initial Catalog=MOBILESHOP;Integrated Security=True");
                sqlCon.Open();
                string DisplayAll = "select MobileName, Quantity from Mobiles inner join Inventry on Mobiles.MobileID = Inventry.MobileID ";
                SqlCommand sqlCmd = new SqlCommand(DisplayAll, sqlCon);
                sqlCmd.ExecuteNonQuery();
                SqlDataAdapter ad = new SqlDataAdapter(sqlCmd);
                System.Data.DataTable dt = new DataTable("Inventry");
                ad.Fill(dt);
                DGrid.ItemsSource = dt.DefaultView;
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
