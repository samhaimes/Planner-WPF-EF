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
using Planner;
using ProjectBusiness;

namespace ProjectWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Planner : Window
    {
        private CRUDManager _crudManager = new CRUDManager();
        public Planner()
        {
            InitializeComponent();
            PopulateListBox();
        }

        private void PopulateListBox()
        {
            TextBox2.ItemsSource = _crudManager.RetrieveActivities();
            DayBox.ItemsSource = _crudManager.RetrieveDays();

           // List<int> dayslist = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
             
            

            MondayList.Items.Add(_crudManager.WeeklyActivity(1));
            TuesdayList.Items.Add( _crudManager.WeeklyActivity(2));
            WednesdayList.Items.Add(_crudManager.WeeklyActivity(3));
            ThursdayList.Items.Add(_crudManager.WeeklyActivity(4));
            FridayList.Items.Add(_crudManager.WeeklyActivity(5));
            SaturdayList.Items.Add(_crudManager.WeeklyActivity(6));
            SundayList.Items.Add(_crudManager.WeeklyActivity(7));


        }

        //select which member week we are looking at 

        private void PopulateFields()
        {

            MondayList.Items.Add(_crudManager.SelectActivity);

        }

        private void NotesButton_Click(object sender, RoutedEventArgs e)
        {
            Notes.Items.Add(NotesTextBox.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            {
                if (DayBox.SelectedItem.ToString() == "Monday")
                {
                    _crudManager.SetSelectActivity(TextBox2.SelectedItem);
                    MondayList.Items.Add(_crudManager.SelectActivity);
                    _crudManager.SaveActivityDay(TextBox2.SelectedItem.ToString(), "Monday", _crudManager.SelectActivity.ActivitiesId, 1);
                }


                if (DayBox.SelectedItem.ToString() == "Tuesday")
                {
                    _crudManager.SetSelectActivity(TextBox2.SelectedItem);
                    TuesdayList.Items.Add(_crudManager.SelectActivity);
                    _crudManager.SaveActivityDay(TextBox2.SelectedItem.ToString(), "Tuesday", _crudManager.SelectActivity.ActivitiesId, 2);
                }

                if (DayBox.SelectedItem.ToString() == "Wednesday")
                {
                    _crudManager.SetSelectActivity(TextBox2.SelectedItem);
                    WednesdayList.Items.Add(_crudManager.SelectActivity);
                    _crudManager.SaveActivityDay(TextBox2.SelectedItem.ToString(), "Wednesday", _crudManager.SelectActivity.ActivitiesId, 3);
                }

                if (DayBox.SelectedItem.ToString() == "Thursday")
                {
                    _crudManager.SetSelectActivity(TextBox2.SelectedItem);
                    ThursdayList.Items.Add(_crudManager.SelectActivity);
                    _crudManager.SaveActivityDay(TextBox2.SelectedItem.ToString(), "Thursday", _crudManager.SelectActivity.ActivitiesId, 4);
                }

                if (DayBox.SelectedItem.ToString() == "Friday")
                {
                    _crudManager.SetSelectActivity(TextBox2.SelectedItem);
                    FridayList.Items.Add(_crudManager.SelectActivity);
                    _crudManager.SaveActivityDay(TextBox2.SelectedItem.ToString(), "Friday", _crudManager.SelectActivity.ActivitiesId, 5);
                }

                if (DayBox.SelectedItem.ToString() == "Saturday")
                {
                    _crudManager.SetSelectActivity(TextBox2.SelectedItem);
                    SaturdayList.Items.Add(_crudManager.SelectActivity);
                    _crudManager.SaveActivityDay(TextBox2.SelectedItem.ToString(), "Saturday", _crudManager.SelectActivity.ActivitiesId, 6);
                }
                if (DayBox.SelectedItem.ToString() == "Sunday")
                {
                    _crudManager.SetSelectActivity(TextBox2.SelectedItem);
                    SundayList.Items.Add(_crudManager.SelectActivity);
                    _crudManager.SaveActivityDay(TextBox2.SelectedItem.ToString(), "Sunday", _crudManager.SelectActivity.ActivitiesId, 7);
                }
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

        private void Notes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }



        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Day_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Activity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void ToUpdater_Click(object sender, RoutedEventArgs e)
        {
            var window = new UpdatePlanner();
            window.ShowDialog();
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Delete_Button(object sender, RoutedEventArgs e)
        {
//            _crudManager.DeleteWeeklyActivity(MondayList.SelectedItem, )


            MondayList.Items.Remove(MondayList.SelectedItem);
            TuesdayList.Items.Remove(TuesdayList.SelectedItem);
            WednesdayList.Items.Remove(WednesdayList.SelectedItem);
            ThursdayList.Items.Remove(ThursdayList.SelectedItem);
            FridayList.Items.Remove(FridayList.SelectedItem);
            SaturdayList.Items.Remove(SaturdayList.SelectedItem);
            SundayList.Items.Remove(SundayList.SelectedItem);

        }

        private void SelectedActivityDetail_TextChanged(object sender, TextChangedEventArgs e)
        {
            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MondayList.SelectedItem = _crudManager.SelectActivity;
            SelectedActivityDetail.Text = (_crudManager.SelectActivity.ActivityDetails).ToString();
        }
    }
}