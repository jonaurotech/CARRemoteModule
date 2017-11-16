using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Configuration;

namespace CAR.Views
{
    /// <summary>
    /// Interaction logic for Recover.xaml
    /// </summary>
    public partial class Recover : Page
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CARConnectionString"].ToString());
        public Recover()
        {
            InitializeComponent();
            CAR.user_controls.banner brBanner = new user_controls.banner();
            rrStack.Children.Add(brBanner);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {


            BrushConverter bc = new BrushConverter();
            Brush brush = (Brush)bc.ConvertFrom("#008db1");
            brush.Freeze();
            BrushConverter tc = new BrushConverter();
            Brush trush = (Brush)tc.ConvertFrom("#EDEFEF");
            trush.Freeze();

            recoverPage.Background = trush;
            twoGrid.Background = trush;
            resetLabel.Foreground = brush;
            emailPasslabel.FontSize = 14;
            emailPasslabel.Foreground = brush;
            submitBut.Background = brush;

        }

        private void submitBut_Click(object sender, RoutedEventArgs e)
        {
            SqlDataAdapter sa = new SqlDataAdapter(string.Format("select * from login where email = '{0}'", "sanoirni@gmail.com"), con);
            DataTable dt = new DataTable();
            sa.Fill(dt);

            if (dt.Rows.Count > 0)
            {

                NavigationService.Navigate(new Uri("Views/Reset.xaml", UriKind.Relative));


            }
            else
            {
                MessageBox.Show("Your email is not in our records");
                emailPasswordMask.Text = "";
            }

        }
            
        
        
    }

}



