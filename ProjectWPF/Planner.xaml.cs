using System.Windows;
using System.Windows.Controls;
using ProjectBusiness;

namespace ProjectWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Planner : Window
    {
        private readonly CRUDManager _crudManager = new CRUDManager();
        public Planner()
        {
            InitializeComponent();
            PopulateListBox();
        }

        private void PopulateListBox()
        {
            TextBox2.ItemsSource = _crudManager.RetrieveActivities();
            DayBox.ItemsSource = _crudManager.RetrieveDays();

            MondayList.ItemsSource = (_crudManager.WeeklyActivity(1));
            TuesdayList.ItemsSource = ( _crudManager.WeeklyActivity(2));
            WednesdayList.ItemsSource = (_crudManager.WeeklyActivity(3));
            ThursdayList.ItemsSource = (_crudManager.WeeklyActivity(4));
            FridayList.ItemsSource = (_crudManager.WeeklyActivity(5));
            SaturdayList.ItemsSource = (_crudManager.WeeklyActivity(6));
            SundayList.ItemsSource = (_crudManager.WeeklyActivity(7));
           
        }
  
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            {
                _crudManager.SetSelectActivity(TextBox2.SelectedItem);
                _crudManager.SetSelectedDay(DayBox.SelectedItem);
                _crudManager.SaveActivityDay(TextBox2.SelectedItem, DayBox.SelectedItem, _crudManager.SelectActivity.ActivitiesId, _crudManager.SelectedDay.DayId);
           
            }
        }

        private void MondayList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TuesdayList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void WednesdayList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ThursdayList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void FridayList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SaturdayList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SundayList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Day_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Activity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }



        private void Delete_Button(object sender, RoutedEventArgs e)
        {

            if (MondayList.SelectedItem != null)
            {
                var DeleteFromMonday = MondayList.SelectedItem;
                _crudManager.DeleteWeeklyActivity(DeleteFromMonday, "Monday", 1);
            }
            if (TuesdayList.SelectedItem != null)
            {
                var DeleteFromTuesday = TuesdayList.SelectedItem;
                _crudManager.DeleteWeeklyActivity(DeleteFromTuesday, "Tuesday", 2);
            }
            if (WednesdayList.SelectedItem != null)
            { 
                var DeleteFromWednesday = WednesdayList.SelectedItem;
                _crudManager.DeleteWeeklyActivity(DeleteFromWednesday, "Wednesday", 3);
              }
            if (ThursdayList.SelectedItem != null)
            {
                var DeleteFromThursday = ThursdayList.SelectedItem;
                _crudManager.DeleteWeeklyActivity(DeleteFromThursday, "Thursday", 4);
            }
            if (FridayList.SelectedItem != null)
            {
                var DeleteFromFriday = FridayList.SelectedItem;
                _crudManager.DeleteWeeklyActivity(DeleteFromFriday, "Friday", 5);
            }
            if (SaturdayList.SelectedItem != null)
            {
                var DeleteFromSaturday = SaturdayList.SelectedItem;

                _crudManager.DeleteWeeklyActivity(DeleteFromSaturday, "Saturday", 6);
            }
            if (SundayList.SelectedItem != null)
            {
                var DeleteFromSunday = SundayList.SelectedItem;
                _crudManager.DeleteWeeklyActivity(DeleteFromSunday, "Sunday", 7);
            }
       
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Button_Refresh(object sender, RoutedEventArgs e)
        {
            new Planner().Show();
            this.Close();
        }

        private void ToUpdater_Click(object sender, RoutedEventArgs e)
        {
            new UpdatePlanner().Show();
            this.Close();
        }
    }
}