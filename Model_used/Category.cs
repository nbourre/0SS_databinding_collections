using System.Collections.ObjectModel;

namespace Model_used
{
    public class Category
    {
        private ObservableCollection<Product> products;

        public string Name { get; set; }
        public string Description { get; set; }

        public ObservableCollection<Product> Products { get => products; set => products = value; }

        public Category()
        {
            Products = new ObservableCollection<Product>();
        }


    }
}