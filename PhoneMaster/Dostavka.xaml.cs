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
using System.Windows.Shapes;

namespace PhoneMaster
{
    /// <summary>
    /// Логика взаимодействия для Delivery.xaml
    /// </summary>
    public partial class Dostavka : Window
    {
        public Dostavka()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Final final = new Final();
            final.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Pay pay = new Pay();
            pay.Show();
            this.Close();
        }
    }
}








