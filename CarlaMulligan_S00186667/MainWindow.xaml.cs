using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name : Carla Mulligan 
 * Student Number: S00186667
 * Date: 13/05/2020
 * Subject: Final ODD Exam Sem2
 * */

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

       

        PhoneData db = new PhoneData(); 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


            //selecting phone name
            var query = from n in db.Phones
                        select n.Name;


            //selecting images
            lbxPhones.ItemsSource = query.ToList();

            var images = from i in db.Phones
                         select i.OS_Image;

             


        }

        private void lbxPhones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //trying to select images
            if(lbxPhones != null)
            {
                switch(Name)
                {
                    case "Samsung s20":
                        lbxImages.ItemsSource = "/images/android.png";
                        
                        break;

                    case "iPhone 11":
                        lbxImages.ItemsSource = "/images/apple.png";
                        break;
                }
            }


            //selecting the price
            var query = from p in db.Phones
                        select p.Price;

            tbxPrice.Text = Convert.ToString(query.ToString()); 


        }
    }
}
