using Model_used;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Products
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Product selectedProduct;
        private ProductDataService productDataService;
        private ObservableCollection<Product> products;
        private ObservableCollection<string> categories;
        private string selectedCategory;

        public ObservableCollection<Product> Products {
            get => products;
            set { 
                products = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<string> Categories
        {
            get => categories;
            set
            {
                categories = value;
                OnPropertyChanged();
            }
        }

        public Product SelectedProduct {
            get => selectedProduct;
            set
            {
                selectedProduct = value;
                OnPropertyChanged();
            }
        }

        public string SelectedCategory
        {
            get => selectedCategory;
            set
            {
                selectedCategory = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindow()
        {
            InitializeComponent();

            InitValues();
        }

        private void InitValues()
        {
            productDataService = new ProductDataService();
            Products = new ObservableCollection<Product>(productDataService.GetAll());
            Categories = new ObservableCollection<string>()
            {
                "Electronics", "Drugs", "Clothing", "Food", "Hardware"
            };
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
