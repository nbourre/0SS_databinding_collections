using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Model_used
{
    public class Employee : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PicturePath { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
