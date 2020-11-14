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

namespace prc2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string a = a1.Text;//Vvod a
            string b = b1.Text;//Vvod b
            int a_num = Convert.ToInt32(a);
            double b_num = Convert.ToInt32(b);
            char[] c = b.ToCharArray();
            int z = b.Length - 1;

            for (; b_num > 0; z--)
            {
                if (c[c.Length - 1] == '3' || c[c.Length - 1] == '5' || c[c.Length - 1] == '7' || c[c.Length - 1] == '9')//vozmozhno li?
                {


                    if (b_num == a_num)
                    {
                        res.Text += "Возможно\n";
                        Console.WriteLine("Возможно\n");
                        break;
                    }
                    if (b_num < a_num)
                    {
                        res.Text += "Невозможно\n";
                        Console.WriteLine("Невозможно\n");
                        break;
                    }
                }
            }

        }
    }
}
