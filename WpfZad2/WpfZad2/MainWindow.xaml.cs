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

namespace WpfZad2
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void TopButtonClick(object sender, RoutedEventArgs e)
        {
            foreach (Button item in UpperPanel.Children.OfType<Button>())
            {
                item.BorderBrush = Brushes.Plum;
                item.Foreground = Brushes.Purple;
                TopButton.BorderBrush = item.BorderBrush;
                TopButton.Foreground = item.Foreground;
            }
        }

        private void LeftButtonClick(object sender, RoutedEventArgs e)
        {
            foreach (Button item in LeftPanel.Children.OfType<Button>())
            {
                item.BorderBrush = Brushes.Brown;
                item.Foreground = Brushes.Orange;
                LeftButtonNewColor.BorderBrush = item.BorderBrush;
                LeftButtonNewColor.Foreground = item.Foreground;
            }
        }

        private void DownButtonClick(object sender, RoutedEventArgs e)
        {
            foreach (Button item in BottomPanel.Children.OfType<Button>())
            {
                item.BorderBrush = Brushes.Yellow;
                item.Foreground = Brushes.Pink;
                NewStyleBottomButton.BorderBrush = item.BorderBrush;
                NewStyleBottomButton.Foreground = item.Foreground;
            }
        }

    }
}
