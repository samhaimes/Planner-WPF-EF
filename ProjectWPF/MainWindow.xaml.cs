using System.Windows;
using ProjectBusiness;

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

    }
}
