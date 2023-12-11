using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
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

namespace radik227ms2016
{
    /// <summary>
    /// Логика взаимодействия для new_bugyn.xaml
    /// </summary>
    public partial class new_bugyn : Page
    {
        public new_bugyn()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new rg_new_bugyn());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new str1());
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox a = (TextBox)sender;
            if (a.Text == a.Tag.ToString())
            {
                a.Text = "";
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox a = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(a.Text))
            {
                a.Text = a.Tag.ToString();
            }
        }
    }
}
