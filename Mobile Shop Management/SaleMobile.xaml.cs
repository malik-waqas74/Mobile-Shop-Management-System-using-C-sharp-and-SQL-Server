using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace MobileShopManagement
{
    /// <summary>
    /// Interaction logic for SaleMobile.xaml
    /// </summary>
    public partial class SaleMobile : Window
    {
        public SaleMobile()
        {
            InitializeComponent();
        }

        private void Eve(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(@"Data Source=MALIKWAQAS\SQLSERVER2017;Initial Catalog=MOBILESHOP;Integrated Security=True");
                sqlCon.Open();
                string DisplayAll = "select MobileName,MobileID from Mobiles  ";
                string Dis = "select CustomerID,C_Name from Customer ";
                SqlCommand sqlCmd = new SqlCommand(DisplayAll, sqlCon);
                SqlCommand sq = new SqlCommand(Dis, sqlCon);
                sqlCmd.ExecuteNonQuery();
                sq.ExecuteNonQuery();
                SqlDataAdapter ad = new SqlDataAdapter(sqlCmd);
                System.Data.DataTable dt = new DataTable("Mobiles");
                ad.Fill(dt);
                gridMobile.ItemsSource = dt.DefaultView;
               
                ad.Update(dt);

                SqlDataAdapter a = new SqlDataAdapter(sq);
                System.Data.DataTable d = new DataTable("Customer");
                a.Fill(d);
                gridcustomer.ItemsSource = d.DefaultView;

                a.Update(d);

                sqlCon.Close();





            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsale(object sender, RoutedEventArgs e)
        {
            int MobileId = int.Parse(txtMID.Text);
            int CID = int.Parse(txtCID.Text);
            int pric = int.Parse(txtprice.Text);
            int qua = int.Parse(txtquant.Text);
                
           
            try
            {
                SqlConnection sqlCon = new SqlConnection(@"Data Source=MALIKWAQAS\SQLSERVER2017;Initial Catalog=MOBILESHOP;Integrated Security=True");
                sqlCon.Open();
                string Sael = "execute sp_SalesEntree '"+MobileId+"'," +qua  + "'," + pric + "',"+CID + "',"+ "',";
                SqlCommand sqlCmd = new SqlCommand(Sael, sqlCon);
                MessageBox.Show("SOld");
                txtquant.Text = "";
                txtMID.Text = "";
                txtCID.Text = "";
                txtprice.Text = "";
             
                sqlCon.Close();





                




               
                sqlCon.Close();
            


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
