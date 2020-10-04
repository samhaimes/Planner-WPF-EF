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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ToUpdater_Click(object sender, RoutedEventArgs e)
        {
            var window = new UpdatePlanner();
            window.ShowDialog();
        }

        private void ToPlanner_Click(object sender, RoutedEventArgs e)
        {
            var window = new Planner();
            window.ShowDialog();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
