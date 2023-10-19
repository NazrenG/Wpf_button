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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();

            RandomBackgroundColor(btn_1);
            RandomBackgroundColor(btn_2);
            RandomBackgroundColor(btn_3);
            RandomBackgroundColor(btn_4);
            RandomBackgroundColor(btn_5);
            RandomBackgroundColor(btn_6);
        }

        private void RandomBackgroundColor(Button button)
        {
            byte r = (byte)random.Next(256);
            byte g = (byte)random.Next(256);
            byte b = (byte)random.Next(256);

            SolidColorBrush brush = new SolidColorBrush(Color.FromRgb(r, g, b));
            button.Background = brush;
        }

        private void btn_1_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

            var button = sender as Button;
            grid.Children.Remove(button);
            Title = "1";
        }

        private void btn_2_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

            var button = sender as Button;
            grid.Children.Remove(button);
            Title = "2";
        }

        private void btn_3_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            var button = sender as Button;
            grid.Children.Remove(button);
            Title = "3";
        }

        private void btn_4_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            var button = sender as Button;
            grid.Children.Remove(button);
            Title = "4";
        }

        private void btn_5_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            var button = sender as Button;
            grid.Children.Remove(button);
            Title = "5";
        }

        private void btn_6_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            var button = sender as Button;
            grid.Children.Remove(button);
            Title = "6";
        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Size: {btn_1.ActualWidth}x{btn_1.ActualHeight} Color:{((SolidColorBrush)btn_1.Background).Color}");
        }
        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Size: {btn_2.ActualWidth}x{btn_2.ActualWidth} Color:{((SolidColorBrush)btn_2.Background).Color}");
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Size: {btn_3.ActualWidth}x{btn_3.ActualWidth} Color:{((SolidColorBrush)btn_3.Background).Color}");
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Size: {btn_4.ActualWidth}x{btn_4.ActualWidth} Color:{((SolidColorBrush)btn_4.Background).Color}");
        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Size: {btn_5.ActualWidth}x{btn_5.ActualWidth} Color:{((SolidColorBrush)btn_5.Background).Color}");
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Size: {btn_6.ActualWidth}x{btn_6.ActualWidth} Color:{((SolidColorBrush)btn_6.Background).Color}");
        }

        private void btn_1_MouseEnter(object sender, MouseEventArgs e)
        {
            RandomBackgroundColor(btn_1);
        }

        private void btn_2_MouseEnter(object sender, MouseEventArgs e)
        {
            RandomBackgroundColor(btn_2);
        }

        private void btn_3_MouseEnter(object sender, MouseEventArgs e)
        {
            RandomBackgroundColor(btn_3);
        }

        private void btn_4_MouseEnter(object sender, MouseEventArgs e)
        {
            RandomBackgroundColor(btn_4);
        }

        private void btn_5_MouseEnter(object sender, MouseEventArgs e)
        {
            RandomBackgroundColor(btn_5);
        }

        private void btn_6_MouseEnter(object sender, MouseEventArgs e)
        {
            RandomBackgroundColor(btn_6);
        }
    }
}
