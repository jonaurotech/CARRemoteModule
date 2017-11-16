using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Text.RegularExpressions;
using System.Data.Entity;
using Microsoft.Win32;
using System.IO;
using System.Windows.Data;
using Telerik.Windows.Controls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
//Telerik.Windows.Documents.Core.dll
//Telerik.Windows.Documents.Spreadsheet.dll
//Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.dll
//Telerik.Windows.Zip.dll
//Telerik.Windows.Controls.GridView.Export.dll

namespace CAR.Views
{
    /// <summary>
    /// Interaction logic for CARsystem.xaml
    /// </summary>
    public partial class CARsystem : Page
    {
        CarContext dbContext = new CarContext();
        //CAREntities dbContext3 = new CAREntities();
        //CAREntities dbContext2 = new CAREntities();
        //CAREntities dbContext = new CAREntities();
        private List<object> _user;

        public CARsystem()
        {
            InitializeComponent();
            
            //var queryapo = from p in dbContext
            //               select new { APO_PCO_PIV_BADGE_NUM = p.APO_PCO_PIV_BADGE_NUM, enabled = p.ENABLED, can_send_reminder = p.CAN_SEND_REMINDER, last_name = p.LAST_NAME, firstname = p.FIRST_NAME, email = p.EMAIL, created = p.CREATED, middle_initial = p.MIDDLE_INITIAL, last_updated = p.LAST_UPDATED, password_reminder = p.PASSWORD_REMINDER, phone_num = p.PHONE_NUM, password = p.PASSWORD, must_change_pwd = p.MUST_CHANGE_PWD, CAR_admin = p.CAR_ADMIN, center = p.CENTER, user_id = p.USER_ID };
            //var querycenters = from p in dbContext3.CENTERS
            //                   select new { location_code = p.LOCATION_CODE, last_updated = p.LAST_UPDATED, center = p.CENTER1, created = p.CREATED };
            //var queryusers = from p in dbContext2.USERS
            //                 select new { barcode = p.BARCODE, last_name = p.LAST_NAME, first_name = p.FIRST_NAME, email = p.EMAIL, created = p.CREATED, datetime_assigned = p.DATETIME_ACCEPTED, middle_initial = p.MIDDILE_INITIAL, outstanding_asset = p.OUTSTANDING_ASSET, previous_barcode = p.PREVIOUS_BARCODE, USER_PIV_badge_num = p.USER_PIV_BADGE_NUM };
            //var queryassets = from p in dbContext.ASSETS
            //                  select new { barcode = p.BARCODE, computer_name = p.COMPUTER_NAME, serial_num = p.SERIAL_NUM, created = p.CREATED, datetime_received = p.DATETIME_RECEIVED, last_updated = p.LAST_UPDATED, model = p.MODEL, state = p.STATE, APO_PCO_PIV_BADGE_NUM = p.APO_PCO_PIV_BADGE_NUM, Manufacturer = p.MANUFACTURER };


            //this.gridViewCenter.ItemsSource = querycenters.ToList();
            //this.gridViewApo.ItemsSource = queryapo.ToList();
            this.gridViewOne.ItemsSource = dbContext.Users.ToList();
            this.assetgridView.ItemsSource = dbContext.Users.ToList();

            _user = ApplicationState.GetValue<List<object>>("User");
            if (Convert.ToBoolean(_user[3]) )
            {
                cenTabitem.Visibility = Visibility.Visible;
                apoTabitem.Visibility = Visibility.Visible;
            }

        }
        

        private void Carsys_Loaded(object sender, RoutedEventArgs e)
        {

            
            BrushConverter bc = new BrushConverter();
            Brush brush = (Brush)bc.ConvertFrom("#008db1");
            brush.Freeze();

            BrushConverter cs = new BrushConverter();
            Brush csrush = (Brush)cs.ConvertFrom("#EDEFEF");
            csrush.Freeze();

            Carsys.Background = csrush;

            assetgridView.AlternateRowBackground = brush;
            assetgridView.Background = brush;
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
            logoutBu.Content = "Logout";
            logoutBu.FontSize = 14;
            welcomeLabel.Content = "Welcome";
            welcomeLabel.FontSize = 14;
           




            CAR.user_controls.banner brBanner = new user_controls.banner();
            brStack.Children.Add(brBanner);



            //CAR.Inventory.Users us = new CAR.Inventory.Users();
            //welcomeLabel.Content = "Welcome " + us.firstname;
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

            }
        }

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

       
        private void scsTextbox_TextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            
           
        }

        private void scTextbox_TextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
           
        }

        private void carTabControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void scTextbox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            
        }

        private void scTextbox_MouseDown(object sender, MouseButtonEventArgs e)
        {
          
        }

        private void scsTextbox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void submitButton_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (scTextbox.Text.Length < 1 || scTextbox.Text.Length > 7 || !Regex.IsMatch(scTextbox.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Value must contain 7 numbers - no letters or special characters allowed");

            }

            else if (exLb.IsChecked == true && scTextbox.Text.Length == 7)
            {

                MessageBox.Show("Your receiving of an asset was a success");
                dissTabitem.IsSelected = true;
            }
            else
            {
                messageBusy.IsBusy = true;
                MessageBox.Show("Your receiving of an asset was a success");
                var barcode = scTextbox.Text;


                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CARConnectionString"].ToString());
                con.Open();
                var cmdText = $"insert into assets (BARCODE, APO_PCO_PIV_BADGE_NUM) VALUES('{barcode}', {_user[0]})";
                SqlCommand cmd = new SqlCommand(cmdText);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.ExecuteScalar();
                
                con.Close();

                scTextbox.Text = "";
                nnLb.IsChecked = false;
                exLb.IsChecked = false;
                reuLb.IsChecked = false;
                messageBusy.IsBusy = false;
            }
        }

        private void submit2Button_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (scsTextbox.Text.Length < 1 || scsTextbox.Text.Length > 7 || !Regex.IsMatch(scsTextbox.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Value must contain 7 numbers - no letters or special characters allowed");

            }
            else
            {

                messageBusy.IsBusy = true;
                MessageBox.Show("Your assigning of an asset was a success");
                scTextbox.Text = "";
                nuLb.IsChecked = false;
                luLb.IsChecked = false;
                reLb.IsChecked = false;
                messageBusy.IsBusy = false;
            }

        }

 private void AddButton_Click(object sender, RoutedEventArgs e)
        {

            this.assetgridView.BeginInsert();
            //var obj = new { barcode = "asd", computer_name ="sdf", serial_num = "asd", created = "asd", datetime_received = "10/21/2017", last_updated = "10/21/2017", model = p.MODEL, state = p.STATE, APO_PCO_PIV_BADGE_NUM = p.APO_PCO_PIV_BADGE_NUM, Manufacturer = p.MANUFACTURER }
            //this.assetgridView.Items.Add()
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            this.assetgridView.BeginEdit();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            this.assetgridView.Items.Remove(this.assetgridView.SelectedItem);
        }

        private void ExportButton_Click(object sender, RoutedEventArgs e)
        {
            string extension = "xls";
            SaveFileDialog dialog = new SaveFileDialog()
            {
                DefaultExt = extension,
                Filter = String.Format("{1} files (*.{0})|*.{0}|All files (*.*)|*.*", extension, "Excel"),
                FilterIndex = 1
            };
            if (dialog.ShowDialog() == true)
            {
                using (Stream stream = dialog.OpenFile())
                {
                    assetgridView.Export(stream,
                     new GridViewExportOptions()
                     {
                         Format = ExportFormat.Html,
                         ShowColumnHeaders = true,
                         ShowColumnFooters = true,
                         ShowGroupFooters = false,
                     });
                }
            }
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            var printDialog = new System.Windows.Controls.PrintDialog();
            printDialog.ShowDialog();
        }

        private void SaveBut_Click(object sender, RoutedEventArgs e)
        {
            //dbContext.SaveChanges();
        }

        private void addUserButton_Click(object sender, RoutedEventArgs e)
        {
            this.gridViewOne.BeginInsert();
        }

        private void editUserButton_Click(object sender, RoutedEventArgs e)
        {
            this.gridViewOne.BeginEdit();
        }

        private void deleteUserButton_Click(object sender, RoutedEventArgs e)
        {
            this.gridViewOne.Items.Remove(this.gridViewOne.SelectedItem);
        }

        private void exportUserButton_Click(object sender, RoutedEventArgs e)
        {
            string extension = "xls";
            SaveFileDialog dialog = new SaveFileDialog()
            {
                DefaultExt = extension,
                Filter = String.Format("{1} files (*.{0})|*.{0}|All files (*.*)|*.*", extension, "Excel"),
                FilterIndex = 1
            };
            if (dialog.ShowDialog() == true)
            {
                using (Stream stream = dialog.OpenFile())
                {
                    gridViewOne.Export(stream,
                     new GridViewExportOptions()
                     {
                         Format = ExportFormat.Html,
                         ShowColumnHeaders = true,
                         ShowColumnFooters = true,
                         ShowGroupFooters = false,
                     });
                }
            }

        }

        private void printUserButton_Click(object sender, RoutedEventArgs e)
        {
            var printDialog = new System.Windows.Controls.PrintDialog();
            printDialog.ShowDialog();
        }

        private void saveUserBut_Click(object sender, RoutedEventArgs e)
        {
            //dbContext2.SaveChanges();
        }

        private void addApoButton_Click(object sender, RoutedEventArgs e)
        {
            this.gridViewApo.BeginInsert();
        }

        private void editApoButton_Click(object sender, RoutedEventArgs e)
        {
            this.gridViewApo.BeginEdit();
        }

        private void deleteApoButton_Click(object sender, RoutedEventArgs e)
        {
            this.gridViewApo.Items.Remove(this.gridViewApo.SelectedItem);
        }

        private void exportApoButton_Click(object sender, RoutedEventArgs e)
        {
            string extension = "xls";
            SaveFileDialog dialog = new SaveFileDialog()
            {
                DefaultExt = extension,
                Filter = String.Format("{1} files (*.{0})|*.{0}|All files (*.*)|*.*", extension, "Excel"),
                FilterIndex = 1
            };
            if (dialog.ShowDialog() == true)
            {
                using (Stream stream = dialog.OpenFile())
                {
                    gridViewApo.Export(stream,
                     new GridViewExportOptions()
                     {
                         Format = ExportFormat.Html,
                         ShowColumnHeaders = true,
                         ShowColumnFooters = true,
                         ShowGroupFooters = false,
                     });
                }
            }

        }

        private void printApoButton_Click(object sender, RoutedEventArgs e)
        {
            var printDialog = new System.Windows.Controls.PrintDialog();
            printDialog.ShowDialog();
        }

        private void saveApoBut_Click(object sender, RoutedEventArgs e)
        {
            //dbContext4.SaveChanges();
        }

        private void addCenterButton_Click(object sender, RoutedEventArgs e)
        {
            this.gridViewCenter.BeginInsert();
        }

        private void editCenterButton_Click(object sender, RoutedEventArgs e)
        {
            this.gridViewCenter.BeginEdit();
        }

        private void deleteCenterButton_Click(object sender, RoutedEventArgs e)
        {
            this.gridViewCenter.Items.Remove(this.gridViewCenter.SelectedItem);
        }

        private void exportCenterButton_Click(object sender, RoutedEventArgs e)
        {
            string extension = "xls";
            SaveFileDialog dialog = new SaveFileDialog()
            {
                DefaultExt = extension,
                Filter = String.Format("{1} files (*.{0})|*.{0}|All files (*.*)|*.*", extension, "Excel"),
                FilterIndex = 1
            };
            if (dialog.ShowDialog() == true)
            {
                using (Stream stream = dialog.OpenFile())
                {
                    gridViewCenter.Export(stream,
                     new GridViewExportOptions()
                     {
                         Format = ExportFormat.Html,
                         ShowColumnHeaders = true,
                         ShowColumnFooters = true,
                         ShowGroupFooters = false,
                     });
                }
            }
        }

        private void printCenterButton_Click(object sender, RoutedEventArgs e)
        {
            var printDialog = new System.Windows.Controls.PrintDialog();
            printDialog.ShowDialog();
        }

        private void saveCenterBut_Click(object sender, RoutedEventArgs e)
        {
            //dbContext3.SaveChanges();
        }

        private void assTabitem_Loaded(object sender, RoutedEventArgs e)
        {
            //var queryassets = from p in dbContext.ASSETS
            //                  select new { barcode = p.BARCODE, computer_name = p.COMPUTER_NAME, serial_num = p.SERIAL_NUM, created = p.CREATED, datetime_received = p.DATETIME_RECEIVED, last_updated = p.LAST_UPDATED, model = p.MODEL, state = p.STATE, APO_PCO_PIV_BADGE_NUM = p.APO_PCO_PIV_BADGE_NUM, Manufacturer = p.MANUFACTURER };
            
            //this.assetgridView.ItemsSource = queryassets.ToList();


        }
    }
    
}