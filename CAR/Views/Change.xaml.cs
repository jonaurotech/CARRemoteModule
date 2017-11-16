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
    /// Interaction logic for Change.xaml
    /// </summary>
    public partial class Change : Page
    {
        public Change()
        {
            InitializeComponent();
            CAR.user_controls.banner brBanner = new user_controls.banner();
            mcStack.Children.Add(brBanner);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            BrushConverter bc = new BrushConverter();
            Brush brush = (Brush)bc.ConvertFrom("#008db1");
            brush.Freeze();

            BrushConverter cc = new BrushConverter();
            Brush crush = (Brush)cc.ConvertFrom("#EDEFEF");
            crush.Freeze();

            changePage.Background = crush;
            fourGrid.Background = crush;

            rlabel.Foreground = brush;
            nLabel.Foreground = brush;
            resetLabel.Foreground = brush;
            oldPassLabel.Foreground = brush;
            password3Box.BorderBrush = brush;
            submitBut.Background = brush;
        }
    }
}
