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

namespace RegistrationForm
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ResultGrid.Visibility = Visibility.Hidden;
   
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string name, lustName, email, phoneNumber, info, gender=null;
            bool checkName = true, checkLustName = true, checkEmail = true, chekPhoneNumber = true,
                checkInfo = true, checkDay= true, checkMonth = true, checkYear = true, checkGender= true;
            int day=0, month=0, year=0;
            string MessageError = null;
            
            
            #region check  name
            name = Name_txtbx.Text;
            if (name.Length > 0 && name.Length < 255)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i] >= '0' && name[i] <= '9')
                    {
                        checkName = false;
                        break;
                    }
                }
            }
            else { checkName = false; }
            #endregion

            #region check  lustname
            lustName = lust_txtbx.Text;
            if (lustName.Length > 0 && lustName.Length < 255)
            {
                for (int i = 0; i < lustName.Length; i++)
                {
                    if (lustName[i] >= '0' && lustName[i] <= '9')
                    {
                        checkLustName = false;
                        break;
                    }
                }
            }
            else { checkLustName = false; }
            #endregion

            #region check  email
            email = email_txtbx.Text;
            if (email.Length > 0 && email.Length < 255 && email.Contains('@'));
            else { checkEmail = false; }
            #endregion

            #region check phoneNumber
            phoneNumber = phoneNumber_txtbx.Text;
            if (phoneNumber.Length>0 && phoneNumber.Length < 255)
            {
                for (int i = 0; i < phoneNumber.Length; ++i)
                {
                    if (char.IsLetter(phoneNumber[i]))
                    {
                        chekPhoneNumber = false;
                    }
                }
            }
            else { chekPhoneNumber = false; }


            #endregion

            #region check Info

            info = info_txtbx.Text;
            if (info.Length>2500)
            { checkInfo = false; }

            #endregion

            #region check day
            if (day_txtbx.Text.Length != 0) {
                for (int i = 0; i < day_txtbx.Text.Length; i++)
                {
                    if (char.IsLetter(day_txtbx.Text[i]))
                    {
                        checkDay = false;
                        break;
                    }
                    else {

                        day = Int32.Parse(day_txtbx.Text);
                        if (day <= 0 || day > 31) { checkDay = false; }
                    }
                }
            }
            else { checkDay = false; }


            #endregion

            #region check month
            if (month_txtbx.Text.Length != 0) {
                for (int i = 0; i < month_txtbx.Text.Length; i++)
                {
                    if (char.IsLetter(month_txtbx.Text[i]))
                    {
                        checkMonth = false;
                        break;
                    }
                    else
                    {

                        month = Int32.Parse(month_txtbx.Text);
                        if (month <= 0 || month >= 12) { checkMonth = false; }
                    }
                }
            }
            else { checkMonth = false; }
            #endregion

            #region check year
            if (year_txtbx.Text.Length != 0) {
                for (int i = 0; i < year_txtbx.Text.Length; i++)
                {
                    if (char.IsLetter(year_txtbx.Text[i]))
                    {
                        checkYear = false;
                        break;
                    }
                    else
                    {

                        year = Int32.Parse(year_txtbx.Text);
                        if (year <= 1900 || year >= 2016) { checkYear = false; }
                    }
                }
            }
            else { checkYear = false; }
            #endregion

            #region check gender
            switch (gender_combx.SelectedIndex)
            {
                case 0:
                    gender = "male";
                    break;
                case 1:
                    gender = "famele";
                    break;
                default:
                    checkGender = false;
                    break;
            }
            #endregion


            #region  message
            if (checkName == false)
            {
                MessageError += "\nНе верно введено имя";
                Name_txtbx.Clear();
            }
            if (checkLustName == false)
            {
                MessageError += "\nНе верно введена фамилия";
                lust_txtbx.Clear();
            }
            if (checkEmail == false)
            {
                MessageError += "\nНе верно введен Email";
                email_txtbx.Clear();
            }
            if (chekPhoneNumber == false)
            {
                MessageError += "\nНе верно введен телефон";
                phoneNumber_txtbx.Clear();
            }
            if (checkInfo == false)
            {
                MessageError += "\nНе верно введенa информация о себе";
                info_txtbx.Clear();
            }
            if (checkDay == false)
            {
                MessageError += "\nНе верно введен день";
                day_txtbx.Clear();
            }
            if (checkMonth == false)
            {
                MessageError += "\nНе верно введен месяць";
                month_txtbx.Clear();
            }
            if (checkYear == false)
            {
                MessageError += "\nНе верно введен год";
                year_txtbx.Clear();
            }
            if (checkGender == false)
            {
                MessageError += "\nНе выбран пол";
                
            }

            if (MessageError == null)
            {
                MessageBox.Show("Все данные введины верно!");
                RegGrid.Visibility = Visibility.Hidden;
                ResultGrid.Visibility = Visibility.Visible;
                resul_lbl.Content = "Имя: "+ name+"\nФамилия: "+lustName+"\nДата рождения: "+day+"/"+month+"/"+year+
                    "\nПол: "+gender+"\nEmail: "+email+"\nНомер телевона: "+phoneNumber+"\nИнформация о себе: " + info;
            }
            else
            {
                MessageBox.Show(MessageError, "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                checkName = true;
                checkLustName = true; checkEmail = true; chekPhoneNumber = true;
                checkInfo = true; checkDay = true; checkMonth = true; checkYear = true; checkGender = true;
            }
            #endregion

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
