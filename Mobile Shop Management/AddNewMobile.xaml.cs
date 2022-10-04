using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;


namespace MobileShopManagement
{
    /// <summary>
    /// Interaction logic for AddNewMobile.xaml
    /// </summary>
    public partial class AddNewMobile : Window
    {
        public AddNewMobile()
        {
            InitializeComponent();
        }



        string company = "";
        private void Company(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            company += cmbCompany.SelectedItem;

        }


        private void SaveClicked(object sender, RoutedEventArgs e)
        {
          
         
            try
            {
                SqlConnection sqlCon = new SqlConnection(@"Data Source=MALIKWAQAS\SQLSERVER2017;Initial Catalog=MOBILESHOP;Integrated Security=True");
                sqlCon.Open();
                string add_Data = "INSERT INTO[dbo].[Mobiles] VALUES(@MobileName,@Model,@MobileCompany,@Ram,@InternalStorage,@BatteryCapacity,@FrontCamera,@RearCamera,@Display,@Price)";
                SqlCommand sqlCmd = new SqlCommand(add_Data, sqlCon);
                sqlCmd.Parameters.AddWithValue("@MobileName",txtmobileName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Model",txtMobileModel. Text.Trim());
                sqlCmd.Parameters.AddWithValue("@MobileCompany",company.Trim());

                sqlCmd.Parameters.AddWithValue("@Ram", txtRam.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@InternalStorage",txtstorage.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@BatteryCapacity",txtBattery.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@FrontCamera",txtFCamera.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@RearCamera",txtRCamera.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Display", txtDisplay.Text.Trim());
               
                sqlCmd.Parameters.AddWithValue("@Price",int.Parse(txtPrice.Text. Trim()));



                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("New Mobile Has been Added Successfully...");

                this.Close();
               
             

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
