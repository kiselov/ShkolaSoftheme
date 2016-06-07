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

namespace RandomNumberGenerator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Random Rand = new Random();
        private void button_Click(object sender, RoutedEventArgs e)
        {
            int userNamber;
            int randomNamber;
            randomNamber = Rand.Next(1, 10);
            try
            {
                userNamber = Int32.Parse(userNumber_txtBx.Text);
                
                if (userNamber >= 1 && userNamber <= 10)
                {
                    if (userNamber == randomNamber)
                    {
                        MessageBox.Show("Вы угадали число!\nПоздравляю!", "Успех");
                    }
                    else
                    {
                        MessageBox.Show("Увы вы не отгадали число.\nНаше число: "+randomNamber, "Неудача");
                    }
                }
                else
                {
                    throw new Exception();
                }
            }

            catch
            {
                MessageBox.Show ("Неправильно введены данные! Введите число от 1 до 10.","Ошибочка",MessageBoxButton.OK, MessageBoxImage.Error );
            }
            userNumber_txtBx.Clear();
        }

        private void quit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
