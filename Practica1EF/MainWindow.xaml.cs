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

namespace Practica1EF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Hobby_shopEntities context = new Hobby_shopEntities();

        public MainWindow()
        {
            InitializeComponent();
            EmployeesDgr.ItemsSource = context.Shop_Employees_Rus.ToList();
            EmployeesDgr.DisplayMemberPath = "Имя Сотрудника";

            ProductsDgr.ItemsSource = context.Products_Rus.ToList();
            ProductsDgr.DisplayMemberPath = "Название товара";
        }
        public void ShowEmployees_Click(object sender, RoutedEventArgs e)
        {
            EmployeesDgr.Visibility = Visibility.Visible;
            ProductsDgr.Visibility = Visibility.Collapsed;
        }

        public void ShowProducts_Click(object sender, RoutedEventArgs e)
        {
            EmployeesDgr.Visibility = Visibility.Collapsed;
            ProductsDgr .Visibility = Visibility.Visible;
        }
    }
}
