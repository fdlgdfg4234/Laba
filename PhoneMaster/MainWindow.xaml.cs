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

namespace PhoneMaster
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Reg reg = new Reg();    
            reg.Show();
            this.Close();
        }

        private void Enter_Click_1(object sender, RoutedEventArgs e)
        {

            if (LoginTBox.Text == "" || PasswordPBox.Password == "")
            {
                MessageBox.Show("Введите логин и пароль");
            }
            else
            {
                User user = Helper.db.Users.FirstOrDefault(q => q.Login == LoginTBox.Text && q.Password == PasswordPBox.Password);
                if (user != null)
                {
                    Helper.user = user;
                    Helper.db.SaveChanges();
                    new Menu().Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль");
                }
            }



            
        }
    }
}
