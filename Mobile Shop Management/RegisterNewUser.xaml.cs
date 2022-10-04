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
    /// Interaction logic for RegisterNewUser.xaml
    /// </summary>
    public partial class RegisterNewUser : Window
    {
        public RegisterNewUser()
        {
            InitializeComponent();
        }

        private void RegisterUser(object sender, RoutedEventArgs e)
        {

            if (txtUserName.Text == "" || txtPassword.Text == "")
                MessageBox.Show("please fill mandatory fields");
            else if (txtPassword.Text != txtCP.Text)
                MessageBox.Show("Password does not match");
            else
            {

                try
                {
                    SqlConnection sqlCon = new SqlConnection(@"Data Source=MALIKWAQAS\SQLSERVER2017;Initial Catalog=MOBILESHOP;Integrated Security=True");
                    sqlCon.Open();
                    string add_Data = "INSERT INTO[dbo].[Login] VALUES(@Username,@password)";
                    SqlCommand sqlCmd = new SqlCommand(add_Data, sqlCon);
                    

                    sqlCmd.Parameters.AddWithValue("@Username", txtUserName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                  
                    



                    sqlCmd.ExecuteNonQuery();
                    sqlCon.Close();
                    MessageBox.Show("User Successfully Registerd");
                    
                    this.Close();
                 

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }
}
    }