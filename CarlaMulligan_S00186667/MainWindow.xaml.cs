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

namespace CarlaMulligan_S00186667
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Phone> phones = new List<Phone>(); 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Phone p1 = new Phone() { Name = "Samsung s20", Price = 500, Operating_System = "Android", OS_Image = "images/android.png", Phone_Image = "images/s20.png" };

            Phone p2 = new Phone() { Name = "iPhone 11", Price = 600, Operating_System = "IOS", OS_Image = "images/apple.png", Phone_Image = "images/iphone11.png" };



        }

        private void lbxPhones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
