using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CarlaMulligan_S00186667; 


namespace DataManagement
{
    class Program
    {

       
        static void Main(string[] args)
        {
           
            PhoneData db = new PhoneData();

            using (db)
            {

               List<PhoneData> Phones = new List<PhoneData>();

                Phone p1 = new Phone() { Name = "Samsung s20", Price = 500, Operating_System = "Android", OS_Image = "images/android.jpg", Phone_Image = "images/s20.jpg" };

                Phone p2 = new Phone() { Name = "iPhone 11", Price = 600, Operating_System = "IOS", OS_Image = "images/apple.jpg", Phone_Image = "images/iphone11.jpg" };


                Phone p3 = new Phone("Samsung S20", 500, "Android", "images/android.jpg", "images/s20.jpg"); 



            }


        }
    }
}
