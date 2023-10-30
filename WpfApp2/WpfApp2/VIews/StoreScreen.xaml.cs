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

namespace WpfApp2.Views
{
    public partial class StoreScreen : UserControl
    {
        public StoreScreen()
        {
            InitializeComponent();
            List<Chair> items = new List<Chair>();

            items.Add(new Chair()
            {
                name = "Стул №1",
                material = "Дерево",
                height = 180,
                price = 2000,
                isAvaliable = true
            });
            items.Add(new Chair()
            {
                name = "Стул №2",
                material = "Говно",
                height = 1820,
                price = 2000,
                isAvaliable = true
            });
            items.Add(new Chair()
            {
                name = "Стул №3",
                material = "Железо",
                height = 1840,
                price = 20060,
                isAvaliable = true
            });

            LvChairs.ItemsSource = items;
        }

        public class Chair
        {
            public string name { get; set; }
            public string material { get; set; }
            public int height { get; set; }
            public double price { get; set; }
            public bool isAvaliable { get; set; }
            
            public override string ToString()
            {
                return $"[Название]: {name},\n" +
                       $"[Цена]: {price},\n" +
                       $"[Материал]: {material},\n" +
                       $"[Высота]: {height},\n" +
                       $"[Наличие]: {(isAvaliable ? "В наличии":" Нет в наличии")}";
            }
        }
    }
}