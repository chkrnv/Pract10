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

namespace Pract10
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
        List<int> list;

        private void Отчистить_Click(object sender, RoutedEventArgs e)
        {
            currentData.ItemsSource = null;
            inputItemsCount.Clear();
            list.Clear();
            positiveNumbers.Clear();
            negativeNumbers.Clear();
        }

        private void Выход_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void О_Программе_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Дан массив в диапазоне [-100;100] найти количество положительных и отрицательных.");
        }

        private void Создать_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                list = new();
                int itemsCount = Int32.Parse(inputItemsCount.Text);
                Random rnd = new();
                for (int i = 0; i < itemsCount; i++)
                {
                    list.Add(rnd.Next(-100, 100));
                }
                currentData.ItemsSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Найти_Click(object sender, RoutedEventArgs e)
        {
           int positiv = 0;
           int negativ = 0;
           for (int i = 0; i < list.Count; i++)
           {
                if (list[i]>0)
                {                
                    positiv++;
                }
                else if (list[i]<0)
                {
                    negativ++;
                }
           }
            positiveNumbers.Text = positiv.ToString();
            negativeNumbers.Text = negativ.ToString();
        }
    }
}
