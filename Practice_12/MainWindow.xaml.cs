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
using System.Windows.Threading;

namespace Practice_12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            timer.IsEnabled = true;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            time.Text = d.ToString("HH:mm");
            date.Text = d.ToString("dd.MM.yyyy");
        }

        private void Task1CountButton(object sender, RoutedEventArgs e)
        {
            gipotenuzaBox.Text = Convert.ToString(Math.Sqrt(Math.Pow(Convert.ToInt32(firstSideBox.Text), 2) + Math.Pow(Convert.ToInt32(secondSideBox.Text), 2)));
            perimetrBox.Text = Convert.ToString(Convert.ToInt32(firstSideBox.Text) + Convert.ToInt32(secondSideBox.Text) + Convert.ToInt32(gipotenuzaBox.Text));
            firstSideBox.Focus();
        }

        private void Task2CountButton(object sender, RoutedEventArgs e)
        {
            int hundredthDigit = 0;
            hundredthDigit = Convert.ToInt32(inputNumber.Text) / 100 % 10;
            digitsBox.Text = hundredthDigit.ToString();
            inputNumber.Focus();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил студент группы исп-31 \nШестаков Артём \nДаны катеты прямоугольного треугольника a и b. Найти его гипотенузу c и  периметр P. \nДано целое число, большее 999.Используя одну операцию деления нацело и одну операцию взятия остатка от деления, найти цифру, соответствующую разряду сотен в записи этого числа.");
        }
    }
}
