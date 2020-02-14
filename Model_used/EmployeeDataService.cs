using System;
using System.Collections.Generic;
using System.Text;

namespace Model_used
{
    public class EmployeeDataService : IDataService<Employee>
    {
        private List<Employee> employees;

        public EmployeeDataService()
        {
            employees = new List<Employee>
            {
                new Employee() {Age = 45, LastName = "Simpson", Name="Homer", PicturePath = "images/homer.png"},
                new Employee() {Age = 60, LastName = "Griffin", Name="Peter", PicturePath = "images/peter_griffin.png"},
                new Employee() {Name = "Sacha", LastName = "Mccullough", Age = 29, Department = "Sales and Marketing", PicturePath = "images/user.png"},
                new Employee() {Name = "Emerald", LastName = "Riddle", Age = 61, Department = "Payroll", PicturePath = "images/user.png"},
                new Employee() {Name = "Neil", LastName = "Burris", Age = 54, Department = "Finances", PicturePath = "images/user.png"},
                new Employee() {Name = "Samson", LastName = "Curtis", Age = 34, Department = "Legal Department", PicturePath = "images/user.png"},
                new Employee() {Name = "Gavin", LastName = "Knapp", Age = 31, Department = "Asset Management", PicturePath = "images/user.png"},
                new Employee() {Name = "Petra", LastName = "Farrell", Age = 46, Department = "Legal Department", PicturePath = "images/user.png"},
                new Employee() {Name = "Aidan", LastName = "Garrett", Age = 23, Department = "Payroll", PicturePath = "images/user.png"},
                new Employee() {Name = "Zenia", LastName = "Simmons", Age = 40, Department = "Quality Assurance", PicturePath = "images/user.png"},
                new Employee() {Name = "Miranda", LastName = "Stein", Age = 44, Department = "Customer Service", PicturePath = "images/user.png"},
                new Employee() {Name = "Simone", LastName = "Russell", Age = 40, Department = "Asset Management", PicturePath = "images/user.png"},
                new Employee() {Name = "Cairo", LastName = "Boyle", Age = 24, Department = "Human Resources", PicturePath = "images/user.png"},
                new Employee() {Name = "Carl", LastName = "Lott", Age = 30, Department = "Public Relations", PicturePath = "images/user.png"},
                new Employee() {Name = "Kaden", LastName = "Lowery", Age = 56, Department = "Finances", PicturePath = "images/user.png"},
                new Employee() {Name = "Kamal", LastName = "Gamble", Age = 38, Department = "Sales and Marketing", PicturePath = "images/user.png"},
                new Employee() {Name = "Phelan", LastName = "Cannon", Age = 65, Department = "Sales and Marketing", PicturePath = "images/user.png"},
                new Employee() {Name = "Elvis", LastName = "Moran", Age = 21, Department = "Finances", PicturePath = "images/user.png"},
                new Employee() {Name = "Linda", LastName = "Mclean", Age = 51, Department = "Accounting", PicturePath = "images/user.png"},
                new Employee() {Name = "Rae", LastName = "Stewart", Age = 30, Department = "Human Resources", PicturePath = "images/user.png"},
                new Employee() {Name = "Norman", LastName = "Becker", Age = 27, Department = "Finances", PicturePath = "images/user.png"},
                new Employee() {Name = "Allistair", LastName = "Davis", Age = 54, Department = "Media Relations", PicturePath = "images/user.png"},
                new Employee() {Name = "Justin", LastName = "Randolph", Age = 39, Department = "Customer Service", PicturePath = "images/user.png"},
                new Employee() {Name = "Kareem", LastName = "Walls", Age = 39, Department = "Asset Management", PicturePath = "images/user.png"},
                new Employee() {Name = "Bevis", LastName = "Bentley", Age = 24, Department = "Human Resources", PicturePath = "images/user.png"},
                new Employee() {Name = "Stuart", LastName = "Butler", Age = 62, Department = "Legal Department", PicturePath = "images/user.png"},
                new Employee() {Name = "Zoe", LastName = "Savage", Age = 61, Department = "Customer Relations", PicturePath = "images/user.png"},
                new Employee() {Name = "Felicia", LastName = "Peterson", Age = 34, Department = "Customer Service", PicturePath = "images/user.png"},
                new Employee() {Name = "Plato", LastName = "Sutton", Age = 36, Department = "Sales and Marketing", PicturePath = "images/user.png"},
                new Employee() {Name = "Amy", LastName = "Bruce", Age = 63, Department = "Sales and Marketing", PicturePath = "images/user.png"},
                new Employee() {Name = "Daphne", LastName = "Simmons", Age = 38, Department = "Legal Department", PicturePath = "images/user.png"},
                new Employee() {Name = "Barclay", LastName = "Emerson", Age = 25, Department = "Legal Department", PicturePath = "images/user.png"},
                new Employee() {Name = "Candace", LastName = "Barry", Age = 31, Department = "Customer Service", PicturePath = "images/user.png"},
                new Employee() {Name = "Carol", LastName = "Henry", Age = 33, Department = "Human Resources", PicturePath = "images/user.png"},
                new Employee() {Name = "Kato", LastName = "George", Age = 58, Department = "Legal Department", PicturePath = "images/user.png"},
                new Employee() {Name = "Callum", LastName = "Osborne", Age = 21, Department = "Finances", PicturePath = "images/user.png"},
                new Employee() {Name = "Erich", LastName = "Bryan", Age = 36, Department = "Payroll", PicturePath = "images/user.png"},
                new Employee() {Name = "Hanae", LastName = "Carter", Age = 21, Department = "Payroll", PicturePath = "images/user.png"},
                new Employee() {Name = "Akeem", LastName = "Yang", Age = 20, Department = "Legal Department", PicturePath = "images/user.png"},
                new Employee() {Name = "Dahlia", LastName = "Cooper", Age = 45, Department = "Asset Management", PicturePath = "images/user.png"},
                new Employee() {Name = "Rama", LastName = "Holland", Age = 41, Department = "Customer Relations", PicturePath = "images/user.png"},
                new Employee() {Name = "Veda", LastName = "Travis", Age = 21, Department = "Quality Assurance", PicturePath = "images/user.png"},
                new Employee() {Name = "September", LastName = "Livingston", Age = 28, Department = "Payroll", PicturePath = "images/user.png"},
                new Employee() {Name = "Oscar", LastName = "Joseph", Age = 56, Department = "Accounting", PicturePath = "images/user.png"},
                new Employee() {Name = "Iris", LastName = "Alexander", Age = 49, Department = "Legal Department", PicturePath = "images/user.png"},
                new Employee() {Name = "Oren", LastName = "Madden", Age = 60, Department = "Advertising", PicturePath = "images/user.png"},
                new Employee() {Name = "Pandora", LastName = "Patterson", Age = 37, Department = "Finances", PicturePath = "images/user.png"},
                new Employee() {Name = "Armand", LastName = "Madden", Age = 59, Department = "Customer Service", PicturePath = "images/user.png"},
                new Employee() {Name = "Bernard", LastName = "Erickson", Age = 44, Department = "Research and Development", PicturePath = "images/user.png"},
                new Employee() {Name = "Colette", LastName = "Davidson", Age = 18, Department = "Quality Assurance", PicturePath = "images/user.png"},
                new Employee() {Name = "Kiara", LastName = "Rosario", Age = 35, Department = "Legal Department", PicturePath = "images/user.png"},
                new Employee() {Name = "Martina", LastName = "Mcclure", Age = 64, Department = "Sales and Marketing", PicturePath = "images/user.png"},
                new Employee() {Name = "Eric", LastName = "Fulton", Age = 59, Department = "Public Relations", PicturePath = "images/user.png"},
                new Employee() {Name = "Mollie", LastName = "Mullins", Age = 37, Department = "Tech Support", PicturePath = "images/user.png"},
                new Employee() {Name = "Cora", LastName = "Patel", Age = 39, Department = "Human Resources", PicturePath = "images/user.png"},
                new Employee() {Name = "Erasmus", LastName = "Heath", Age = 41, Department = "Customer Service", PicturePath = "images/user.png"},
                new Employee() {Name = "Hamilton", LastName = "Small", Age = 63, Department = "Legal Department", PicturePath = "images/user.png"},
                new Employee() {Name = "Arden", LastName = "Knapp", Age = 55, Department = "Finances", PicturePath = "images/user.png"},
                new Employee() {Name = "Sierra", LastName = "Ellis", Age = 62, Department = "Accounting", PicturePath = "images/user.png"},
                new Employee() {Name = "Skyler", LastName = "Larson", Age = 43, Department = "Legal Department", PicturePath = "images/user.png"},
                new Employee() {Name = "Yetta", LastName = "Whitaker", Age = 40, Department = "Advertising", PicturePath = "images/user.png"},
                new Employee() {Name = "Ezekiel", LastName = "Cannon", Age = 59, Department = "Quality Assurance", PicturePath = "images/user.png"},
                new Employee() {Name = "Wade", LastName = "Collins", Age = 63, Department = "Quality Assurance", PicturePath = "images/user.png"},
                new Employee() {Name = "Gray", LastName = "Golden", Age = 35, Department = "Legal Department", PicturePath = "images/user.png"},
                new Employee() {Name = "Aurora", LastName = "Skinner", Age = 33, Department = "Accounting", PicturePath = "images/user.png"},
                new Employee() {Name = "Ashton", LastName = "Simmons", Age = 37, Department = "Public Relations", PicturePath = "images/user.png"},
                new Employee() {Name = "Morgan", LastName = "Hahn", Age = 36, Department = "Legal Department", PicturePath = "images/user.png"},
                new Employee() {Name = "Kalia", LastName = "Byers", Age = 61, Department = "Accounting", PicturePath = "images/user.png"},
                new Employee() {Name = "Beatrice", LastName = "Goodwin", Age = 42, Department = "Research and Development", PicturePath = "images/user.png"},
                new Employee() {Name = "Risa", LastName = "Guzman", Age = 60, Department = "Human Resources", PicturePath = "images/user.png"},
                new Employee() {Name = "Sebastian", LastName = "Massey", Age = 64, Department = "Tech Support", PicturePath = "images/user.png"},
                new Employee() {Name = "Timothy", LastName = "Wagner", Age = 60, Department = "Advertising", PicturePath = "images/user.png"},
                new Employee() {Name = "Lane", LastName = "Mendez", Age = 64, Department = "Sales and Marketing", PicturePath = "images/user.png"},
                new Employee() {Name = "Frances", LastName = "Dennis", Age = 45, Department = "Customer Service", PicturePath = "images/user.png"},
                new Employee() {Name = "Shad", LastName = "Velez", Age = 25, Department = "Accounting", PicturePath = "images/user.png"},
                new Employee() {Name = "Raymond", LastName = "Higgins", Age = 45, Department = "Advertising", PicturePath = "images/user.png"},
                new Employee() {Name = "Justine", LastName = "Puckett", Age = 38, Department = "Finances", PicturePath = "images/user.png"},
                new Employee() {Name = "Aphrodite", LastName = "Greene", Age = 35, Department = "Payroll", PicturePath = "images/user.png"},
                new Employee() {Name = "Flynn", LastName = "Skinner", Age = 36, Department = "Human Resources", PicturePath = "images/user.png"},
                new Employee() {Name = "Beck", LastName = "Beck", Age = 29, Department = "Tech Support", PicturePath = "images/user.png"},
                new Employee() {Name = "Sarah", LastName = "Brady", Age = 30, Department = "Tech Support", PicturePath = "images/user.png"},
                new Employee() {Name = "Roary", LastName = "Curry", Age = 27, Department = "Finances", PicturePath = "images/user.png"},
                new Employee() {Name = "Kellie", LastName = "Haney", Age = 42, Department = "Sales and Marketing", PicturePath = "images/user.png"},
                new Employee() {Name = "Quynn", LastName = "Dean", Age = 26, Department = "Legal Department", PicturePath = "images/user.png"},
                new Employee() {Name = "Lynn", LastName = "Pacheco", Age = 21, Department = "Payroll", PicturePath = "images/user.png"},
                new Employee() {Name = "Reed", LastName = "Joyce", Age = 55, Department = "Research and Development", PicturePath = "images/user.png"},
                new Employee() {Name = "Georgia", LastName = "Obrien", Age = 20, Department = "Customer Service", PicturePath = "images/user.png"},
                new Employee() {Name = "Beau", LastName = "Alston", Age = 24, Department = "Customer Service", PicturePath = "images/user.png"},
                new Employee() {Name = "Rae", LastName = "Koch", Age = 47, Department = "Customer Relations", PicturePath = "images/user.png"},
                new Employee() {Name = "Wang", LastName = "Santos", Age = 23, Department = "Accounting", PicturePath = "images/user.png"},
                new Employee() {Name = "Stewart", LastName = "Herman", Age = 50, Department = "Human Resources", PicturePath = "images/user.png"},
                new Employee() {Name = "Isabella", LastName = "Stevens", Age = 63, Department = "Customer Relations", PicturePath = "images/user.png"},
                new Employee() {Name = "Ivory", LastName = "Kane", Age = 21, Department = "Human Resources", PicturePath = "images/user.png"},
                new Employee() {Name = "Macy", LastName = "Britt", Age = 53, Department = "Customer Service", PicturePath = "images/user.png"},
                new Employee() {Name = "Quyn", LastName = "Valenzuela", Age = 27, Department = "Quality Assurance", PicturePath = "images/user.png"},
                new Employee() {Name = "Savannah", LastName = "Lindsay", Age = 29, Department = "Legal Department", PicturePath = "images/user.png"},
                new Employee() {Name = "Desirae", LastName = "Rios", Age = 25, Department = "Accounting", PicturePath = "images/user.png"},
                new Employee() {Name = "Juliet", LastName = "Perez", Age = 47, Department = "Asset Management", PicturePath = "images/user.png"},
                new Employee() {Name = "Eliana", LastName = "Briggs", Age = 60, Department = "Customer Relations", PicturePath = "images/user.png"},
                new Employee() {Name = "Rhoda", LastName = "Owen", Age = 40, Department = "Asset Management", PicturePath = "images/user.png"},
                new Employee() {Name = "Uma", LastName = "Bright", Age = 35, Department = "Finances", PicturePath = "images/user.png"},
                new Employee() {Name = "Benjamin", LastName = "Colon", Age = 28, Department = "Sales and Marketing", PicturePath = "images/user.png"},
            };
        }

        public IEnumerable<Employee> GetAll()
        {
            foreach (Employee e in employees)
            {
                yield return e;
            }
        }
    }
}
