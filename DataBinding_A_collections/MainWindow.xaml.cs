using Model_used;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;

namespace DataBinding_A_collections
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Employee> Employees { get; private set; }
        private EmployeeDataService employeeDataService = new EmployeeDataService();

        public MainWindow()
        {
            Employees = new ObservableCollection<Employee>(employeeDataService.GetAll());

            InitializeComponent();
        }

        private void AddEmployee_click(object sender, RoutedEventArgs e)
        {
            var emp = new Employee() { Age = 52, LastName = "Gripson", Name = "Petmer", PicturePath = "images/Peter-Homer.jpg" };
            Employees.Add(emp);

            Debug.WriteLine(Employees.Count);

        }
    }
}
