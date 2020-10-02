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
using ProjectModel;
using ProjectBusiness;
using System.Globalization;
using System.Diagnostics;

namespace ProjectWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CRUDManager _crudManager = new CRUDManager();
        public MainWindow()
        {
            InitializeComponent();
            PopulateListBox();
        }
        
        private void PopulateListBox()
        {
            TextBox2.ItemsSource = _crudManager.RetrieveActivities();
            //TextBox1.ItemsSource = _crudManager.RetrieveDays();
         

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
            _crudManager.SetSelectActivity(TextBox2.SelectedItem);
            Notes.Items.Add(_crudManager.SelectActivity);

            //TextBox1.Text = Day OF WEEK;
            //TextBox2.Text = Activity;
            //TextBox3.Text = _crudManager.StartTime;
            //TextBox4.Text = _crudManager.EndTime;

            //string TheDay = TextBox1.Text;
            //string Output = $"{TextBox2.Text}: {TextBox3.Text} - {TextBox4.Text}";
            //SundayList.Items.Add(Output);
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

        private void StartTime_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void EndTime_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
