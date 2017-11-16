using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace CAR.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {

        //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["carEntities"].ToString());


        public Login()
        {
            InitializeComponent();

            CAR.user_controls.banner brBanner = new user_controls.banner();
            crStack.Children.Add(brBanner);

            BrushConverter bc = new BrushConverter();
            Brush brush = (Brush)bc.ConvertFrom("#008db1");
            brush.Freeze();

            BrushConverter lc = new BrushConverter();
            Brush lrush = (Brush)lc.ConvertFrom("#EDEFEF");
            lrush.Freeze();

            BrushConverter gc = new BrushConverter();
            Brush grush = (Brush)gc.ConvertFrom("#D3D3D3");
            grush.Freeze();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            usernameRadMask.Focus();
            BrushConverter bc = new BrushConverter();
            Brush brush = (Brush)bc.ConvertFrom("#008db1");
            brush.Freeze();

            BrushConverter lc = new BrushConverter();
            Brush lrush = (Brush)lc.ConvertFrom("#EDEFEF");
            lrush.Freeze();



            loginPage.Background = lrush;
            oneGrid.Background = lrush;

            labelUser.FontSize = 14;
            labelUser.Foreground = brush;
            labelPass.FontSize = 14;
            labelPass.Foreground = brush;
            loginBut.Background = brush;
            forgotLabel.FontSize = 14;
            forgotLabel.Foreground = brush;

        }

        private void forgotLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("Views/Recover.xaml", UriKind.Relative));
        }

        private void forgotLabel_MouseEnter(object sender, MouseEventArgs e)
        {
            BrushConverter gc = new BrushConverter();
            Brush grush = (Brush)gc.ConvertFrom("#000000");
            grush.Freeze();

            forgotLabel.Foreground = grush;
        }

        private void loginBut_Click(object sender, RoutedEventArgs e)
        {

            

            if (usernameRadMask.Text == "" || passwordRadBox.ToString() == "")
            {
                MessageBox.Show("Please provide Username and Password");
                return;
            }

            try
            {

                //messageBusy.IsBusy = true;
                //con.Open();
                //var cmdText = $"select * from APO_PCO where USER_ID = '{usernameRadMask.Text.Trim()}' and PASSWORD = '{passwordRadBox.Password}'";
                //SqlCommand cmd = new SqlCommand(cmdText);
                //cmd.CommandType = CommandType.Text;
                //cmd.Connection = con;
                //SqlDataAdapter sa = new SqlDataAdapter(cmd);
                //DataTable dt = new DataTable();
                //sa.Fill(dt);
                //con.Close();
                var context = new CarContext();
                var pcos = context.Pcos.Where(u => u.USER_ID == usernameRadMask.Text.Trim() && u.PASSWORD == passwordRadBox.Password);

                if (pcos.Count() > 0)
                {
                    ApplicationState.SetValue("User", pcos.ToList());
                    //var canAdmin = dt.Rows[0].ItemArray[0];
                    //MessageBox.Show("Login Successful!");
                    //usernameRadMask.Text = "";
                    //CAR.Inventoury.Users us = new CAR.Inventory.Users();
                  //  var uri = new Uri("Default.xaml",UriKind.Relative);
                    NavigationService.Navigate(new Uri("/Views/DefaultView.xaml", UriKind.Relative));

                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void registerLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("Views/Register.xaml", UriKind.Relative));
        }

        private void registerLabel_MouseEnter(object sender, MouseEventArgs e)
        {
            BrushConverter gc = new BrushConverter();
            Brush grush = (Brush)gc.ConvertFrom("#000000");
            grush.Freeze();

            registerLabel.Foreground = grush;
            forgotLabel.Foreground = grush;
        }


    }


}