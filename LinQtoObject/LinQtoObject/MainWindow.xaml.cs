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

namespace LinQtoObject
{
    public class Product : BaseViewModel
    {
        public int ID { set; get; } // Ma
        private int id { get { return id; } set { id = value; OnPropertyChanged(nameof(ID)); } }
        public string Name { set; get; }         // tên
        private string name { get { return name; } set { name = value; OnPropertyChanged(nameof(Name)); } }
        public double Price { set; get; }        // giá
        private double price { get { return price; } set { price = value; OnPropertyChanged(nameof(Price)); } }
        public int Numbers { set; get; }     // so luong
        private int numbers { get { return numbers; } set { numbers = value; OnPropertyChanged(nameof(Numbers)); } }
        public string Original { set; get; } // xuat xu
        private string original { get { return original; } set { original = value; OnPropertyChanged(nameof(Original)); } }
        public DateTime Expiry { set; get; } // han su dung
        private DateTime expiry { get { return expiry; } set { expiry = value; OnPropertyChanged(nameof(Expiry)); } }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
