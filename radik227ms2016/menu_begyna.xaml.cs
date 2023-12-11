using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
    /// Логика взаимодействия для menu_begyna.xaml
    /// </summary>
    public partial class menu_begyna : Page
    {
        public menu_begyna()
        {
            InitializeComponent();
        }

        

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new rg_new_bugyn());
        }

      

        private void Mess_Click_3(object sender, RoutedEventArgs e)
        {
            new kontakt().Show();
        }
    }
}
