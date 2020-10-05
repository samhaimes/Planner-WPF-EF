using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                if (DayBox.SelectedItem.ToString() == "Monday")
                {
                    _crudManager.SetSelectActivity(TextBox2.SelectedItem);
                    _crudManager.SaveActivityDay(TextBox2.SelectedItem.ToString(), "Monday", _crudManager.SelectActivity.ActivitiesId, 1);
                }


                if (DayBox.SelectedItem.ToString() == "Tuesday")
                {
                    _crudManager.SetSelectActivity(TextBox2.SelectedItem);                 
                    _crudManager.SaveActivityDay(TextBox2.SelectedItem.ToString(), "Tuesday", _crudManager.SelectActivity.ActivitiesId, 2);
                }

                if (DayBox.SelectedItem.ToString() == "Wednesday")
                {
                    _crudManager.SetSelectActivity(TextBox2.SelectedItem);
                    _crudManager.SaveActivityDay(TextBox2.SelectedItem.ToString(), "Wednesday", _crudManager.SelectActivity.ActivitiesId, 3);
                }

                if (DayBox.SelectedItem.ToString() == "Thursday")
                {
                    _crudManager.SetSelectActivity(TextBox2.SelectedItem);
                    _crudManager.SaveActivityDay(TextBox2.SelectedItem.ToString(), "Thursday", _crudManager.SelectActivity.ActivitiesId, 4);
                }

                if (DayBox.SelectedItem.ToString() == "Friday")
                {
                    _crudManager.SetSelectActivity(TextBox2.SelectedItem);
                    _crudManager.SaveActivityDay(TextBox2.SelectedItem.ToString(), "Friday", _crudManager.SelectActivity.ActivitiesId, 5);
                }

                if (DayBox.SelectedItem.ToString() == "Saturday")
                {
                    _crudManager.SetSelectActivity(TextBox2.SelectedItem);
                    _crudManager.SaveActivityDay(TextBox2.SelectedItem.ToString(), "Saturday", _crudManager.SelectActivity.ActivitiesId, 6);
                }
                if (DayBox.SelectedItem.ToString() == "Sunday")
                {
                    _crudManager.SetSelectActivity(TextBox2.SelectedItem);
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

        private void Delete_Button(object sender, RoutedEventArgs e)
        {
            {

                var bye = MondayList.SelectedItem;
            _crudManager.DeleteWeeklyActivity(bye.ToString(), "Monday", 1);



                if (DayBox.SelectedItem.ToString() == "Monday")
            {
                // _crudManager.SetSelectActivity(Monday.SelectedItem);
               // _crudManager.DeleteWeeklyActivity(MondayList.SelectedItem.ToString(), "Monday.ActivitiesId, 1);
            }


            if (DayBox.SelectedItem.ToString() == "Tuesday")
            {
                _crudManager.SetSelectActivity(TextBox2.SelectedItem);
                //  TuesdayList.ItemsSource = (_crudManager.SelectActivity);
                _crudManager.SaveActivityDay(TextBox2.SelectedItem.ToString(), "Tuesday", _crudManager.SelectActivity.ActivitiesId, 2);
            }

            if (DayBox.SelectedItem.ToString() == "Wednesday")
            {
                _crudManager.SetSelectActivity(TextBox2.SelectedItem);
                //WednesdayList.Items.Add(_crudManager.SelectActivity);
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
                //FridayList.Items.Add(_crudManager.SelectActivity);
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
                // SundayList.Items.Add(_crudManager.SelectActivity);
                _crudManager.SaveActivityDay(TextBox2.SelectedItem.ToString(), "Sunday", _crudManager.SelectActivity.ActivitiesId, 7);
            }
        }

        }

        private void Button_Refresh(object sender, RoutedEventArgs e)
        {
            var window = new Planner();
            window.ShowDialog();
        }
    }
}