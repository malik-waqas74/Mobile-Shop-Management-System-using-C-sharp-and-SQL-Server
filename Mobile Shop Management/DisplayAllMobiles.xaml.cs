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

using System.Data;
using System.Data.SqlClient;


namespace MobileShopManagement
{
    /// <summary>
    /// Interaction logic for DisplayAllMobiles.xaml
    /// </summary>
    public partial class DisplayAllMobiles : Window
    {
        public DisplayAllMobiles()
        {
            InitializeComponent();
        }

        private void Datadisplayer(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(@"Data Source=MALIKWAQAS\SQLSERVER2017;Initial Catalog=MOBILESHOP;Integrated Security=True");
                sqlCon.Open();
                string DisplayAll = "SELECT * FROM Mobiles ";
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
