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
    /// Логика взаимодействия для Pay.xaml
    /// </summary>
    public partial class Pay : Window
    {
        public Pay()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Description description = new Description();
            description.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Dostavka delivery = new Dostavka(); 
            delivery.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PayCard card = new PayCard();
            card.Show();
            this.Close();
        }
    }
}
