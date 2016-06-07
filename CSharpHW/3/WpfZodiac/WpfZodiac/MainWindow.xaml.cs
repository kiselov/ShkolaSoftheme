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

namespace WpfZodiac
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ImageSourceConverter img_converter = new ImageSourceConverter();
        public MainWindow()
        {
            InitializeComponent();
          
        }
        

       

        private void In_btn_Click(object sender, RoutedEventArgs e)
        {
            int day=0, month=0, year=0;

            string zodiac = null;

            try
            {

                day = int.Parse(day_txtbx.Text);
                if (day < 1 || day > 31)
                {
                    
                    throw new Exception();

                }


                month = int.Parse(month_txtbx.Text);
                if (month < 1 || month > 12)
                {
                    
                    throw new Exception();
                }

                year = int.Parse(year_txbx.Text);
                if (year < 1900 || year > 2016)
                {
                    
                    throw new Exception();
                }

                switch (month)
                {
                    case 1:
                        if (day <= 20)
                        {
                            zodiac = "Козерог";
                            img_zodiac.SetValue(Image.SourceProperty, img_converter.ConvertFromString("img/козерог.PNG"));
                        }
                        else
                        {
                            img_zodiac.SetValue(Image.SourceProperty, img_converter.ConvertFromString("img/водолей.PNG"));
                            zodiac = "Водолей";
                        }
                        break;
                    case 2:
                        if (day <= 19)
                        {
                            img_zodiac.SetValue(Image.SourceProperty, img_converter.ConvertFromString("img/водолей.PNG"));
                            zodiac = "Водолей";
                        }
                        else
                        {
                            zodiac = "Рыбы";
                            img_zodiac.SetValue(Image.SourceProperty, img_converter.ConvertFromString("img/рыбы.PNG"));
                        }
                        break;
                    case 3:
                        if (day <= 20)
                        {
                            img_zodiac.SetValue(Image.SourceProperty, img_converter.ConvertFromString("img/рыбы.PNG"));
                            zodiac = "Рыбы";
                        }
                        else
                        {
                            img_zodiac.SetValue(Image.SourceProperty, img_converter.ConvertFromString("img/овен.PNG"));
                            zodiac = "Овен";
                        }
                        break;
                    case 4:
                        if (day <= 20)
                        {
                            zodiac = " Овен";
                            img_zodiac.SetValue(Image.SourceProperty, img_converter.ConvertFromString("img/овен.PNG"));
                        }
                        else
                        {
                            zodiac = "Телец";
                            img_zodiac.SetValue(Image.SourceProperty, img_converter.ConvertFromString("img/телец.PNG"));
                        }
                        break;
                    case 5:
                        if (day <= 21)
                        {
                            zodiac = " Телец";
                            img_zodiac.SetValue(Image.SourceProperty, img_converter.ConvertFromString("img/телец.PNG"));
                        }
                        else
                        {
                            zodiac = "Близнецы";
                            img_zodiac.SetValue(Image.SourceProperty, img_converter.ConvertFromString("img/близнецы.PNG"));
                        }
                        break;
                    case 6:
                        if (day <= 21)
                        {
                            zodiac = " Близнецы";
                            img_zodiac.SetValue(Image.SourceProperty, img_converter.ConvertFromString("img/близнецы.PNG"));
                        }
                        else
                        {
                            zodiac = "Рак";
                            img_zodiac.SetValue(Image.SourceProperty, img_converter.ConvertFromString("img/рак.PNG"));
                        }
                        break;
                    case 7:
                        if (day <= 23)
                        {
                            zodiac = " Рак";
                            img_zodiac.SetValue(Image.SourceProperty, img_converter.ConvertFromString("img/рак.PNG"));
                        }
                        else
                        {
                            zodiac = "Лев";
                            img_zodiac.SetValue(Image.SourceProperty, img_converter.ConvertFromString("img/лев.PNG"));
                        }
                        break;
                    case 8:
                        if (day <= 21)
                        {
                            zodiac = "Лев";
                            img_zodiac.SetValue(Image.SourceProperty, img_converter.ConvertFromString("img/лев.PNG"));
                        }
                        else
                        {
                            zodiac = "Дева";
                            img_zodiac.SetValue(Image.SourceProperty, img_converter.ConvertFromString("img/дева.PNG"));
                        }
                        break;
                    case 9:
                        if (day <= 23)
                        {
                            zodiac = "Дева";
                            img_zodiac.SetValue(Image.SourceProperty, img_converter.ConvertFromString("img/дева.PNG"));
                        }
                        else
                        {
                            zodiac = "Весы";
                            img_zodiac.SetValue(Image.SourceProperty, img_converter.ConvertFromString("img/весы.PNG"));
                        }
                        break;
                    case 10:
                        if (day <= 23)
                        {
                            zodiac = " Весы";
                            img_zodiac.SetValue(Image.SourceProperty, img_converter.ConvertFromString("img/весы.PNG"));
                        }
                        else
                        {
                            zodiac = "Скорпион";
                            img_zodiac.SetValue(Image.SourceProperty, img_converter.ConvertFromString("img/скорпион.PNG"));
                        }
                        break;
                    case 11:
                        if (day <= 22)
                        {
                            zodiac = "Скорпион";
                            img_zodiac.SetValue(Image.SourceProperty, img_converter.ConvertFromString("img/скорпион.PNG"));
                        }
                        else
                        {
                            zodiac = "Стрелец";
                            img_zodiac.SetValue(Image.SourceProperty, img_converter.ConvertFromString("img/стрелец.PNG"));
                        }
                        break;
                    case 12:
                        if (day <= 22)
                        {
                            zodiac = " Стрелец";
                            img_zodiac.SetValue(Image.SourceProperty, img_converter.ConvertFromString("/img/стрелец.PNG"));
                        }
                        else
                        {
                            zodiac = "Козерог";
                            img_zodiac.SetValue(Image.SourceProperty, img_converter.ConvertFromString("/img/козерог.PNG"));
                        }
                        break;
                    default:
                        MessageBox.Show("");
                        break;
                }



               date_txblk.Text = "Дата вашего рождения\n" + day + "/" + month + "/" + year + "\nВаш зодиак: " + zodiac;



        }
            catch
            {
                year_txbx.Clear();
                day_txtbx.Clear();
                month_txtbx.Clear();

                MessageBox.Show("Не верно заполненны даные. \nЗаполните заново", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }


}
    }
    }


