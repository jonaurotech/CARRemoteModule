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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Page
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            BrushConverter bc = new BrushConverter();
            Brush brush = (Brush)bc.ConvertFrom("#008db1");
            brush.Freeze();

            BrushConverter cs = new BrushConverter();
            Brush csrush = (Brush)cs.ConvertFrom("#EDEFEF");
            csrush.Freeze();

            submitBut.Background = brush;
            resetBut.Background = brush;
            cancelBut.Background = brush;
            submitBut.FontSize = 14;
            resetBut.FontSize = 14;
            cancelBut.FontSize = 14;
            phoneLabel.FontSize = 14;
            userIDLabel.FontSize = 14;
            emailLabel.FontSize = 14;
            passwordLabel.FontSize = 14;
            confirmPwdLabel.FontSize = 14;
            centerLabel.FontSize = 14;
            reminderLabel.FontSize = 14;
            phoneLabel.Foreground = brush;
            userIDLabel.Foreground = brush;
            emailLabel.Foreground = brush;
            passwordLabel.Foreground = brush;
            confirmPwdLabel.Foreground = brush;
            centerLabel.Foreground = brush;
            reminderLabel.Foreground = brush;


        }

        private void submitBut_Click(object sender, RoutedEventArgs e)
        {

        }

        private void resetBut_Click(object sender, RoutedEventArgs e)
        {

            textBoxPhone.Text = "";
            textBoxUsername.Text = "";
            textBoxEmail.Text = "";
            passwordBox1.Clear();
            passwordBoxConfirm.Clear();
            textblockreminder.Text = "";
            textBoxCenter.Text = "";

        }

        private void cancelBut_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();


        }
    }
}
