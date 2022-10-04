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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Login(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=MALIKWAQAS\SQLSERVER2017;Initial Catalog=MOBILESHOP;Integrated Security=True");



            try
            {
                sqlCon.Open();
                string Find_Data = "SELECT COUNT(1) FROM [dbo].[Login]  WHERE Username=@username AND Password=@password";
                SqlCommand sqlCmd = new SqlCommand(Find_Data, sqlCon);
                sqlCmd.CommandType = System.Data.CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@username",txtUserName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@password", txtPassword.Password.Trim());
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    MainWindow k = new MainWindow();
                    k.Show();
                        
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect.");
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_signup(object sender, RoutedEventArgs e)
        {
            RegisterNewUser k = new RegisterNewUser();
            k.Show();
        }
    }
}
