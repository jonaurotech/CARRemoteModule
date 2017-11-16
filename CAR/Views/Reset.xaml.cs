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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CAR.Views
{
    /// <summary>
    /// Interaction logic for Reset.xaml
    /// </summary>
    public partial class Reset : Page
    {
        public Reset()
        {
            InitializeComponent();
            CAR.user_controls.banner brBanner = new user_controls.banner();
            prStack.Children.Add(brBanner);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            BrushConverter bc = new BrushConverter();
            Brush brush = (Brush)bc.ConvertFrom("#008db1");
            brush.Freeze();

            BrushConverter rc = new BrushConverter();
            Brush rerush = (Brush)rc.ConvertFrom("#EDEFEF");
            rerush.Freeze();
            resetPage.Background = rerush;
            threeGrid.Background = rerush;

            passlabel.FontSize = 14;
            passlabel.Foreground = brush;
            labelPass.FontSize = 14;
            labelPass.Foreground = brush;
            password1Box.BorderBrush = brush;
            password2Box.BorderBrush = brush;
            submitBut.Background = brush;
        }

        private void submitBut_Click(object sender, RoutedEventArgs e)
        {
            if (password1Box.Text.Trim() == "" || password2Box.Text.Trim() == "")
            {
                MessageBox.Show("You must enter a value");
            }

            if (password1Box.Text.Trim() == password2Box.Text.Trim())
            {
                MessageBox.Show("Your password has been changed");
                NavigationService.Navigate(new Uri("Views/CARsystem.xaml", UriKind.Relative));

            }
            else
            {
                MessageBox.Show("Please try again");
                password1Box.Text = "";
                password2Box.Text = "";
            }
           
        }
    }
}
