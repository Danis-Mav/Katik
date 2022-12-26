using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using Katik.DB;
using Microsoft.Win32;

namespace Katik.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAddApartment.xaml
    /// </summary>
    public partial class PageAddApartment : Page
    {
        public static ObservableCollection<Region> metro { get; set; }
        int m { get; set; }
        public User User { get; set; }
        public Apartment apartment { get; set; }
        public PageAddApartment(User user)
        {
            User = user;
            apartment = new Apartment();
            InitializeComponent();
            metro = new ObservableCollection<Region>(DBConnection.connection.Region.ToList());
            this.DataContext = this;
        }
        private void cb_metro(object sender, SelectionChangedEventArgs e)
        {
            var a = (sender as ComboBox).SelectedItem as Region;
            m = a.Id;
        }
        private void AddClick(object sender, RoutedEventArgs e)
        {
            var a = new Apartment();
            a.Photo = apartment.Photo;
            a.LivingSpace = Convert.ToInt32(tb_space.Text);
            a.Adress = tb_Adress.Text;
            a.Price = Convert.ToInt32(tb_Price.Text);
            a.Id_Region = Convert.ToInt32(m);
            a.RoomSum = Convert.ToInt32(tb_room.Text);
            a.Id_User = User.Id;
            DBConnection.connection.Apartment.Add(a);
            DBConnection.connection.SaveChanges();
            NavigationService.Navigate(new PageApartments(User));
        }

        private void PhotoClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "*.jpg|*.jpg|*.png|*.png*|.jpeg|*.jpeg"
            };
            if (openFile.ShowDialog().GetValueOrDefault())
            {
                apartment.Photo = File.ReadAllBytes(openFile.FileName);
                img_prod.Source = new BitmapImage(new Uri(openFile.FileName));

            }
        }
        private void BackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageApartments(User));
        }
    }
}
