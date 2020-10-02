using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ProjectBusiness;
using ProjectModel;

namespace ProjectWPF
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class UpdatePlanner : Window
    {
        CRUDManager _crudManager = new CRUDManager();
        public UpdatePlanner()
        {
            InitializeComponent();
            PopulateListBox();
        }

        private void PopulateListBox()
        {
            TextBox2.ItemsSource = _crudManager.RetrieveActivities();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _crudManager.SetSelectActivity(TextBox2.SelectedItem);
            Planner.Notes.Items.Add(_crudManager.SelectActivity);
        }
        

        private void Activity_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {

            }
        

        private void ToPlanner_Click(object sender, RoutedEventArgs e)
        {
            var window = new Planner();
            window.ShowDialog();
        }

        private void TextBox_Activity(object sender, TextChangedEventArgs e)
        {
            //Activity.Text=_crudManager.SelectActivity.Activity;
        }

        private void TextBox_ActivityDetails(object sender, TextChangedEventArgs e)
        {
           // ActivityDetails.Text = _crudManager.SelectActivity.ActivityDetails;
        }

        private void Button_UpdateActivities(object sender, RoutedEventArgs e)
        {
            _crudManager.CreateActivity(Activity.Text, ActivityDetails.Text);
        }

        private void Button_DeleteActivity(object sender, RoutedEventArgs e)
        {
            var bye = TextBox2.SelectedItem.ToString();
            _crudManager.DeleteActivity(bye);
            
        }

        private void Button_Refresh(object sender, RoutedEventArgs e)
        {
            var window = new UpdatePlanner();
            window.ShowDialog();
        }
    }
}
