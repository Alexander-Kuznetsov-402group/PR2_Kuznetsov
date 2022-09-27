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

namespace PR2_Kuznetsov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Itog.Text = "Ст. гр. ИСП Кузнецов А.А.";
            Pi.Text = "3,14";
            g.Text = "9.81" + "м/с*2";
        }

        private void Schet_Click(object sender, RoutedEventArgs e)
        {
            Itog.Text += Environment.NewLine + "Практическая работа 2";
            // Считывание значения I
            double i = double.Parse(I.Text);
            // Вывод значения I в окно
            Itog.Text += Environment.NewLine + "I =" + I.ToString();
            // Считывает значение Pi
            double pi = double.Parse(Pi.Text);
            // Вывод значения Pi в окно
            Itog.Text += Environment.NewLine + "Pi = " + Pi.ToString();
            // Считывание значения g
            double G = double.Parse(g.Text);
            // Вывод значения g в окно
            Itog.Text += Environment.NewLine + "G = " + g.ToString();
            

            // Вычисляем математический маятник
            double c = I / g;
            double t = 2*pi*(Math.Sqrt(с));
            // Выводим результат в окно
            Itog.Text += Environment.NewLine + "Результат t = " + t.ToString();
        }
    }
}