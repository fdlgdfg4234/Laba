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
    /// Логика взаимодействия для Description.xaml
    /// </summary>
    public partial class Description : Window
    {
        HelpContext _context;
        public Description()
        {
            InitializeComponent();
            _context = new HelpContext();
            CmbMaster.ItemsSource = _context.Statuses.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Status status = CmbMaster.SelectedItem as Status;
            
            
            Pay pay = new Pay();    
            pay.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Request request = new Request();
            request.Show();
            this.Close();
        }
    }
}
