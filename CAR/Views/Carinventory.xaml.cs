using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Forms;

namespace CAR.Views
{
    /// <summary>
    /// Interaction logic for CarInventory.xaml
    /// </summary>
    public partial class Carinventory : Window
    {

        

       

        public Carinventory()
        {
            InitializeComponent();

            


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            BrushConverter bc = new BrushConverter();
            Brush brush = (Brush)bc.ConvertFrom("#008db1");
            brush.Freeze();


            gridView.AlternateRowBackground = brush;
            gridView.Background = brush;
            gridViewApo.AlternateRowBackground = brush;
            gridViewApo.Background = brush;
            gridViewOne.AlternateRowBackground = brush;
            gridViewOne.Background = brush;
            gridViewCenter.AlternateRowBackground = brush;
            gridViewCenter.Background = brush;
            sLabel.Foreground = brush;
            seLabel.Foreground = brush;
            nuLb.Foreground = brush;
            luLb.Foreground = brush;
            reuLb.Foreground = brush;
            nnLb.Foreground = brush;
            exLb.Foreground = brush;
            reLb.Foreground = brush;
            scsTextbox.BorderBrush = brush;
            scTextbox.BorderBrush = brush;
            submitButton_Copy.Background = brush;
            submit2Button_Copy.Background = brush;
            welcomeLabel.FontSize = 14;
           



            CAR.user_controls.banner brBanner = new user_controls.banner();
            brStack.Children.Add(brBanner);


            CAREntitiesOne dbContext4 = new CAREntitiesOne();
            var queryapo = from p in dbContext4.APO_PCO
                          select new { APO_PCO_PIV_BADGE_NUM= p.APO_PCO_PIV_BADGE_NUM, enabled = p.enabled, can_send_reminder=p.can_send_reminder, last_name=p.last_name,firstname=p.first_name,email=p.email,created = p.created, middle_initial=p.middle_initial, last_updated=p.last_updated, password_reminder=p.password_reminder, phone_num=p.phone_num, password=p.password,must_change_pwd=p.must_change_pwd,CAR_admin=p.CAR_admin,center=p.center, user_id=p.user_id };


            CAREntitiesOne dbContext3 = new CAREntitiesOne();
            var querycenters = from p in dbContext3.CENTERS
                               select new {location_code= p.location_code,last_updated= p.last_updated,center= p.center1,created= p.created };



            CAREntitiesOne dbContext2 = new CAREntitiesOne();
            var queryusers = from p in dbContext2.Users
                            select new {barcode= p.barcode,last_name= p.last_name,first_name= p.first_name,email= p.email,created= p.created,datetime_assigned= p.datetime_assigned, middle_initial= p.middle_initial,outstanding_asset= p.outstanding_asset, previous_barcode= p.previous_barcode, USER_PIV_badge_num= p.USER_PIV_BADGE_NUM};


            CAREntitiesOne dbContext = new CAREntitiesOne();
            var queryassets = from p in dbContext.Assets
                              select new {barcode = p.Barcode, computer_name = p.Computer_Name, serial_num = p.Serial_Number, created = p.Created, datetime_received = p.Datetime_Received, last_updated= p.Last_Updated, model= p.Model, state = p.State, APO_PCO_PIV_BADGE_NUM = p.APO_PCO_PIV_BADGE_NUM, Manufacturer = p.Manufacturer };



            this.gridViewCenter.ItemsSource = querycenters.ToList();
            this.gridViewApo.ItemsSource = queryapo.ToList();
           this.gridViewOne.ItemsSource = queryusers.ToList();
            this.gridView.ItemsSource = queryassets.ToList();

            CAR.Inventory.Users us = new CAR.Inventory.Users();
            welcomeLabel.Content = "Welcome " + us.firstname;

        }

        private void carTabControl_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

            
            

        }

        private void recTabitem_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var tabItem = sender as TabItem;
            if (tabItem != null)
            {

                tabLabel.Content = "Receive an Asset";
                scTextbox.Focus();
                
            }     }       
        
            private void dissTabitem_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
             {

            

            var tabItem = sender as TabItem;
            if (tabItem != null)
            {
                tabLabel.Content = "Assign an Asset";
                scsTextbox.Focus();
            }
        }

        private void assTabitem_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var tabItem = sender as TabItem;
            if (tabItem != null)
            {

                tabLabel.Content = "Select an Asset";
            }
        }

        private void userTabitem_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var tabItem = sender as TabItem;
            if (tabItem != null)
            {
                tabLabel.Content = "Select a User";

            }
        }

        private void apoTabitem_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var tabItem = sender as TabItem;
            if (tabItem != null)
            {
                tabLabel.Content = "Administer an APO";
                gridViewApo.ShowSearchPanel = true;
            }
        }

        private void cenTabitem_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var tabItem = sender as TabItem;
            if (tabItem != null)
            {

                tabLabel.Content = "Administer a Center";
            }
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {

          

        }

        private void gridView_BeginningEdit(object sender, Telerik.Windows.Controls.GridViewBeginningEditRoutedEventArgs e)
        {
            e.Cancel = true;
           

        }

       

        private void gridViewOne_BeginningEdit(object sender, Telerik.Windows.Controls.GridViewBeginningEditRoutedEventArgs e)
        {
            e.Cancel = true;
        }

        private void gridViewApo_BeginningEdit(object sender, Telerik.Windows.Controls.GridViewBeginningEditRoutedEventArgs e)
        {
            e.Cancel = true;
        }

        private void gridViewCenter_BeginningEdit(object sender, Telerik.Windows.Controls.GridViewBeginningEditRoutedEventArgs e)
        {
            e.Cancel = true;
        }

        private void gridView_PreparingCellForEdit(object sender, Telerik.Windows.Controls.GridViewPreparingCellForEditEventArgs e)
        {
           
        }

        private void gridViewOne_PreparingCellForEdit(object sender, Telerik.Windows.Controls.GridViewPreparingCellForEditEventArgs e)
        {
            
        }

        private void gridViewApo_PreparingCellForEdit(object sender, Telerik.Windows.Controls.GridViewPreparingCellForEditEventArgs e)
        {
           
        }

        private void gridViewCenter_PreparingCellForEdit(object sender, Telerik.Windows.Controls.GridViewPreparingCellForEditEventArgs e)
        {
           
        }

        private void gridView_PreparedCellForEdit(object sender, Telerik.Windows.Controls.GridViewPreparingCellForEditEventArgs e)
        {
            

        }

        private void gridViewOne_PreparedCellForEdit(object sender, Telerik.Windows.Controls.GridViewPreparingCellForEditEventArgs e)
        {
           

        }

        private void gridViewApo_PreparedCellForEdit(object sender, Telerik.Windows.Controls.GridViewPreparingCellForEditEventArgs e)
        {
            
        }

        private void gridViewCenter_PreparedCellForEdit(object sender, Telerik.Windows.Controls.GridViewPreparingCellForEditEventArgs e)
        {
            

        }

        private void gridView_CellEditEnded(object sender, Telerik.Windows.Controls.GridViewCellEditEndedEventArgs e)
        {
            Asset editedAsset = e.Cell.DataContext as Asset;
            string propertyName = e.Cell.Column.UniqueName;
            //MessageBox.Show(string.Format("Property {0} is edited and newValue is {1}", propertyName, e.NewData));

        }

        private void gridViewOne_CellEditEnded(object sender, Telerik.Windows.Controls.GridViewCellEditEndedEventArgs e)
        {
            User editedUser = e.Cell.DataContext as User;
            string propertyName = e.Cell.Column.UniqueName;
            //MessageBox.Show(string.Format("Property {0} is edited and newValue is {1}", propertyName, e.NewData));
        }

        private void gridViewApo_CellEditEnded(object sender, Telerik.Windows.Controls.GridViewCellEditEndedEventArgs e)
        {
            AccountablePropertyOfficer editedAPO = e.Cell.DataContext as AccountablePropertyOfficer;
            string propertyName = e.Cell.Column.UniqueName;
            //MessageBox.Show(string.Format("Property {0} is edited and newValue is {1}", propertyName, e.NewData));
        }

        private void gridViewCenter_CellEditEnded(object sender, Telerik.Windows.Controls.GridViewCellEditEndedEventArgs e)
        {
            Center editedCenter = e.Cell.DataContext as Center;
            string propertyName = e.Cell.Column.UniqueName;
            //MessageBox.Show(string.Format("Property {0} is edited and newValue is {1}", propertyName, e.NewData));
        }

        private void scsTextbox_TextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            submit2Button_Copy.IsEnabled = true;
        }

        private void scTextbox_TextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            submitButton_Copy.IsEnabled = true;
        }

        private void carTabControl_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void scTextbox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            //if (Char.IsDigit(e.KeyChar) == false)
               // MessageBox.Show("You may only enter numerical values");
        }
    }
}
