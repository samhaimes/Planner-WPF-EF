using System.Windows;
using System.Windows.Controls;
using ProjectBusiness;
using Planner;

namespace ProjectWPF
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class UpdatePlanner : Window
    {
        readonly CRUDManager _crudManager = new CRUDManager();
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
            ActivityName.Text= (_crudManager.SelectActivity).ToString();
            ActivityDetail.Text = (_crudManager.SelectActivity.ActivityDetails).ToString();
        }

        private void Button_UpdateActivityDetail(object sender, RoutedEventArgs e)
        {
            var name = ActivityName.Text;
            var details = ActivityDetail.Text;
            _crudManager.ChangeActivityDetail(name, details);
        }
        private void EditActivityDetail_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            var name = ActivityName.Text;
            var details = ActivityDetail.Text;
            _crudManager.ChangeActivityDetail(name, details);
            
        }
        private void Activity_SelectionChanged(object sender, SelectionChangedEventArgs e) { }

        private void ToPlanner_Click(object sender, RoutedEventArgs e)
        {
            new Planner().Show();
            this.Close();
        }

        private void TextBox_Activity(object sender, TextChangedEventArgs e) { }
        private void TextBox_ActivityDetails(object sender, TextChangedEventArgs e) { }

        private void Button_UpdateActivities(object sender, RoutedEventArgs e)
        {
            _crudManager.CreateActivity(Activity.Text, ActivityDetails.Text);
        }

        private void Button_DeleteActivity(object sender, RoutedEventArgs e)
        {
            var DeletedActivity = TextBox2.SelectedItem.ToString();
            _crudManager.DeleteActivity(DeletedActivity);

        }

        private void Button_Refresh(object sender, RoutedEventArgs e)
        {
            new UpdatePlanner().Show();
            this.Close();
        }

    }
}
