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
            //Planner.Notes.Items.Add(_crudManager.SelectActivity);
        }
        private void Activity_SelectionChanged(object sender, SelectionChangedEventArgs e) { }

        

        private void ToPlanner_Click(object sender, RoutedEventArgs e)
        {
            var window = new Planner();
            window.ShowDialog();
        }

        private void TextBox_Activity(object sender, TextChangedEventArgs e) { }
        private void TextBox_ActivityDetails(object sender, TextChangedEventArgs e) { }

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

        private void EditActivityDetail_TextChanged(object sender, TextChangedEventArgs e)
        {
            _crudManager.SetSelectActivity(TextBox2.SelectedItem);
            EditActivityDetail.Text = _crudManager.SelectActivity.ActivityDetails;
            var name = TextBox2.SelectedItem.ToString();
            var details = EditActivityDetail.Text;
            _crudManager.ChangeActivityDetail(name, details);
            // call the selected activity 
            //output the activity detail
            //allow editing 
            //save changes

        }
    }
}
