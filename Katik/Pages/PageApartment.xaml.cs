using Katik.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Katik.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageApartment.xaml
    /// </summary>
    public partial class PageApartment : Page
    {
        Apartment Apartment;
        public static ObservableCollection<Apartment> apartment { get; set; }
        public static ObservableCollection<Region> region { get; set; }
        public PageApartment(Apartment apartment)
        {
            InitializeComponent();
            Apartment = apartment;
            var currentRecipes = KatikEntities.GetContext().Apartment.ToList();
            var currentRegion = KatikEntities.GetContext().Region.ToList();
            this.DataContext = Apartment;
            tb_Adress.Text = apartment.Adress;
            tb_Metro.Text = "Вахитовский район";
            tb_Price.Text = Convert.ToString(apartment.Price) + "  р/мес.";
            tb_Room.Text = apartment.RoomSum + "  комнат";
            tb_Space.Text = Convert.ToString(apartment.LivingSpace) + "  м²";
            tb_User.Text = apartment.User.FullName;
            tb_Phone.Text = apartment.User.Phone;
            
        }
        private void BackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
