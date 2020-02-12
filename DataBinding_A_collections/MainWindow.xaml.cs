using Model_used;
using System.Collections.ObjectModel;
using System.Windows;

namespace DataBinding_A_collections
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Employee> Employees { get; private set; }

        public MainWindow()
        {
            Employees = new ObservableCollection<Employee>()
            {
                new Employee() {Age = 45, LastName = "Simpson", Name="Homer", PicturePath = "images/homer.png"},
                new Employee() {Age = 60, LastName = "Griffin", Name="Peter", PicturePath = "images/peter_griffin.png"},
            };

            InitializeComponent();
        }

        private void AddEmployee_click(object sender, RoutedEventArgs e)
        {
            var emp = new Employee() { Age = 52, LastName = "Gripson", Name = "Petmer", PicturePath = "images/Peter-Homer.jpg" };
            Employees.Add(emp);

        }
    }
}
