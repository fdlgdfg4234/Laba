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
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Window
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            string Login = LoginBox.Text.Trim();
            string Name = NameBox.Text.Trim();
            string Surname = SurnameBox.Text.Trim();
            string Email = EmailBox.Text.Trim();
            string Password = PassBox.Password.Trim();

            if (Login.Length < 3)
            {
                LoginBox.ToolTip = "Логин введен не правильно!";
                LoginBox.Background = Brushes.DarkGoldenrod;
            }
            else if (Name.Length < 3)
            {
                NameBox.ToolTip = "Пароль введен не правильно!";
                NameBox.Background = Brushes.DarkGoldenrod;
            }
            else if (Surname.Length < 3)
            {
                SurnameBox.ToolTip = "Имя введено не правильно!";
                SurnameBox.Background = Brushes.DarkGoldenrod;
            }
            else if (Email.Length < 3)
            {
                EmailBox.ToolTip = "Фамилия введена не правильно!";
                EmailBox.Background = Brushes.DarkGoldenrod;
            }
            else if (Password.Length < 3)
            {
                PassBox.ToolTip = "Отчество введено не правильно!";
                PassBox.Background = Brushes.DarkGoldenrod;
            }
            else
            {
                NameBox.ToolTip = "";
                NameBox.Background = Brushes.Transparent;

                SurnameBox.ToolTip = "";
                SurnameBox.Background = Brushes.Transparent;

                EmailBox.ToolTip = "";
                EmailBox.Background = Brushes.Transparent;

                

                LoginBox.ToolTip = "";
                LoginBox.Background = Brushes.Transparent;

                PassBox.ToolTip = "";
                PassBox.Background = Brushes.Transparent;


                MessageBox.Show("Регистрация прошла успешно!");

                User users = new User()
                {
                    Login = Login,
                    Password = Password,
                    FirstName = Name,
                    LastName = Surname,
                    Email = Email,
                    

                };

                Helper.db.Users.Add(users);
                Helper.db.SaveChanges();

                Menu ok = new Menu();
                ok.Show();
                this.Close();
            }


        }
       
    }
}
