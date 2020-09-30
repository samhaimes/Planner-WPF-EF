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
        }

        //select which member week we are looking at 

        private void MondayList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if the day of the week is Monday add the activity to here
            //if (DayOfWeek == Monday)
            //{ 
            //   return  _crudManager.Action     // this is the activty & the timing 

            //}
        }

        private void TuesdayList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void WednesdayList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ThurdayList_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
            // allow inputting data 
        }

        //repeat this for every day of the week 

    }
}
