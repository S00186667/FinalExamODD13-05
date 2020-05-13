using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CarlaMulligan_S00186667
{
    public class Phone
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public string Operating_System { get; set; }

        public string OS_Image { get; set; }

        public string Phone_Image { get; set; }
   

        public void IncreasePrice(decimal Pvalue)
        {

            Pvalue = (Pvalue + 100) / 100 * Price;


        }

       

    }

    public class PhoneData : DbContext
    {
        public PhoneData() : base("MyPhoneData") { }

        public DbSet<Phone> Phones { get; set;  }



    }
        

    
}
