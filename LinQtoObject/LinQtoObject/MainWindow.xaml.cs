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
        public List<Product> Products { get; set; }
        public List<Product> Custome_Products { get; set; }
        public MainWindow()
        {
            Products = new List<Product>
           {
               new Product{ ID=5, Name="Apple", Numbers=600, Expiry=new DateTime(2020,1,1), Original="Japan", Price=100 },
               new Product{ ID=1, Name="Bag of Rice", Numbers=100, Expiry=new DateTime(2020,1,1), Original="Japan", Price=300},
               new Product{ ID=2, Name="Sugar", Numbers=500,Expiry=new DateTime(2025,1,1), Original="Viet Nam", Price=50 },
               new Product{ ID=3, Name="Salt", Numbers=400, Expiry=new DateTime(2025, 1, 1), Original="Viet Nam", Price=40 },
               new Product{ ID=4, Name="Beef", Numbers=200, Expiry=new DateTime(2020, 1, 1), Original="America", Price=90 },
               new Product{ ID=5, Name="Egg", Numbers=600, Expiry=new DateTime(2020, 1, 1), Original="Japan", Price=10 },
           };
            InitializeComponent();
            ListProducts.ItemsSource = Products;
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Products != null && Products.Any())
            {
                var HighestPrice = Products.OrderByDescending(p => p.Price).FirstOrDefault();
                Custome_Products=new List<Product>();
                Custome_Products.Add(HighestPrice);
                ListProductCostumer.ItemsSource =Custome_Products;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Products != null && Products.Any())
            {
                var SPFromJapan = Products.Where(p => p.Original.Contains("Japan")).FirstOrDefault();
                Custome_Products = new List<Product>();
                Custome_Products.Add(SPFromJapan);
                ListProductCostumer.ItemsSource =Custome_Products;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Products != null && Products.Any())
            {
                var SPQuaHan= Products.Where(p=>p.Expiry < DateTime.Now).ToList();
                Custome_Products= new List<Product>();
                Custome_Products.AddRange(SPQuaHan);
                ListProductCostumer.ItemsSource=Custome_Products;
            }
        }
    }
}
