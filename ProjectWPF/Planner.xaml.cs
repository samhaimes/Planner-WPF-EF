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


        }

        //select which member week we are looking at 

        private void PopulateFields()
        {

            MondayList.Items.Add(_crudManager.SelectActivity);

        }
        private void MondayButton_Click(object sender, RoutedEventArgs e)
        {
            MondayList.Items.Add(MondayTextBox.Text);
        }

        private void TuesdayButton_Click(object sender, RoutedEventArgs e)
        {
            TuesdayList.Items.Add(TuesdayTextBox.Text);
        }

        private void WednesdayButton_Click(object sender, RoutedEventArgs e)
        {
            WednesdayList.Items.Add(WednesdayTextBox.Text);
        }

        private void ThursdayButton_Click(object sender, RoutedEventArgs e)
        {
            ThursdayList.Items.Add(ThursdayTextBox.Text);
        }

        private void FridayButton_Click(object sender, RoutedEventArgs e)
        {
            FridayList.Items.Add(FridayTextBox.Text);
        }

        private void SaturdayButton_Click(object sender, RoutedEventArgs e)
        {
            SaturdayList.Items.Add(SaturdayTextBox.Text);
        }

        private void SundayButton_Click(object sender, RoutedEventArgs e)
        {
            SundayList.Items.Add(SundayTextBox.Text);
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
                }


                if (DayBox.SelectedItem.ToString() == "Tuesday")
                {
                    _crudManager.SetSelectActivity(TextBox2.SelectedItem);
                    TuesdayList.Items.Add(_crudManager.SelectActivity);
                }

                if (DayBox.SelectedItem.ToString() == "Wednesday")
                {
                    _crudManager.SetSelectActivity(TextBox2.SelectedItem);
                    WednesdayList.Items.Add(_crudManager.SelectActivity);
                }

                if (DayBox.SelectedItem.ToString() == "Thursday")
                {
                    _crudManager.SetSelectActivity(TextBox2.SelectedItem);
                    ThursdayList.Items.Add(_crudManager.SelectActivity);
                }

                if (DayBox.SelectedItem.ToString() == "Friday")
                {
                    _crudManager.SetSelectActivity(TextBox2.SelectedItem);
                    FridayList.Items.Add(_crudManager.SelectActivity);
                }

                if (DayBox.SelectedItem.ToString() == "Saturday")
                {
                    _crudManager.SetSelectActivity(TextBox2.SelectedItem);
                    SaturdayList.Items.Add(_crudManager.SelectActivity);
                }
                if (DayBox.SelectedItem.ToString() == "Sunday")
                {
                    _crudManager.SetSelectActivity(TextBox2.SelectedItem);
                    SundayList.Items.Add(_crudManager.SelectActivity);
                }
            }
           
            _crudManager.SaveActivityDay(TextBox2.SelectedItem.ToString(), DayBox.SelectedItem.ToString(), _crudManager.SelectActivity.ActivitiesId, _crudManager.SelectedDay.DayId);

        
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


    }
}