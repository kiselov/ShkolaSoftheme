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

namespace NumericDataTypes
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

        private void LeftBtnClic(object sender, MouseButtonEventArgs e)
        {
            string min_val = null, max_val = null, default_val = null;
            switch (listBox.SelectedIndex)
            {
                case 0:

                    min_val = "-2,147,483,648";
                    max_val = "2,147,483,647";
                    default_val = "0";

                    break;

                case 1:

                    min_val = "-9,223,372,036,854,775,808";
                    max_val = "9,223,372,036,854,775,807";
                    default_val = "0L";

                    break;

                case 2:

                    min_val = "-128";
                    max_val = "127";
                    default_val = "0";

                    break;

                case 3:

                    min_val = "-32,768";
                    max_val = "32,767";
                    default_val = "0";

                    break;

                case 4:

                    min_val = "0";
                    max_val = "4,294,967,295";
                    default_val = "0";

                    break;

                case 5:

                    min_val = "0";
                    max_val = "18,446,744,073,709,551,615";
                    default_val = "0";

                    break;

                case 6:

                    min_val = "0";
                    max_val = "65,535";
                    default_val = "0";

                    break;

                default:
                    break;
            }
            min_lbl.Content = "Min value: " + min_val;
            max_lbl.Content = "Max value: " + max_val;
            default_lbl.Content = "Default value: " + default_val;

        }

        private void quit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
