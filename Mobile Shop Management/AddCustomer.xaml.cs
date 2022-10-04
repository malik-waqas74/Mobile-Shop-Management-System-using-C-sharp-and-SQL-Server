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

namespace MobileShopManagement
{
    /// <summary>
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : Window
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void buttonCliked(object sender, RoutedEventArgs e)
        {

            try
            {
                SqlConnection sqlCon = new SqlConnection(@"Data Source=MALIKWAQAS\SQLSERVER2017;Initial Catalog=MOBILESHOP;Integrated Security=True");
                sqlCon.Open();
                string add_Data = "INSERT INTO[dbo].[Customer] VALUES(@C_Name,@C_Address,@C_Contact,@C_Email)";
                SqlCommand sqlCmd = new SqlCommand(add_Data, sqlCon);


                sqlCmd.Parameters.AddWithValue("@C_Name", txtName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@C_Address",txtAddress.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@C_Contact",txtContact.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@C_Email",txtEmail. Text.Trim());





                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Customer Added Successfully ");

                this.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
