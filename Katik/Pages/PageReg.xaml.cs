﻿using Katik.DB;
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
    /// Логика взаимодействия для PageReg.xaml
    /// </summary>
    public partial class PageReg : Page
    {
        public PageReg()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        private void RegClick(object sender, RoutedEventArgs e)
        {
            var a = new User();
            a.FullName = tb_FullName.Text;
            a.Phone = tb_Phone.Text;
            a.Login = tb_Login.Text;
            a.Password = pb_Password.Password;
            a.Id_Role = 2;
            DBConnection.connection.User.Add(a);
            DBConnection.connection.SaveChanges();
            MessageBox.Show("Вы успешно зарегестрированы " + a.FullName);
            NavigationService.GoBack();
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        private void tbPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
                e.Handled = true;
        }
    }
}
