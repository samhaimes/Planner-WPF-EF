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
using Planner;
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
        private readonly CRUDManager _crudManager = new CRUDManager();
        public MainWindow()
        {
            InitializeComponent();
            FamilyMembers.ItemsSource = _crudManager.RetrieveFamily();
        }

        

        private void ToUpdater_Click(object sender, RoutedEventArgs e)
        {
            new UpdatePlanner().Show();
            this.Close();
           
        }

        private void ToPlanner_Click(object sender, RoutedEventArgs e)
        {
            
           new Planner().Show();
            this.Close();
        }

        //protected override void FamilyMember_PreviewMouseDown(System.Windows.Input.MouseButtonEventArgs e)
        //{
        //    base.OnMouseDown
        //    _crudManager.SetSelectedMember(FamilyMembers.SelectedItem);
        //    string output = $"{_crudManager.SelectedFamilyMember}'s";

        //    Member.AppendText(output);

        //}

        //        private void Member_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
           
                
        //}
    }
}
