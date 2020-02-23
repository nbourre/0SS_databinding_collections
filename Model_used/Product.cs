using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Model_used
{
    public class Product : INotifyPropertyChanged
    {
        private Category category;

        public string UPC { get; set; }
        public string Code { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }

        public string Category { get; set; }

        public string PicturePath { get; set; }

        public Category ParentCategory
        {
            get => category;
            set
            {
                category = value;

                category.Products.Add(this);

                OnPropertyChanged();
            }
        }

        public string Info => ShortDescription;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
