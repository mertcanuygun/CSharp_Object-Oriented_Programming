using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class__Constructor_and_Property
{
    public class Streaming_Services
    {
        public string Brand { get; set; }
        public double Price { get; set; }
        public double UserAmount { get; set; }
        public string CountryOrigin { get; set; }
        public int LaunchYear { get; set; }


        public Streaming_Services(string brand, double price)
        {
            this.Brand = brand;
            this.Price = price;

            MessageBox.Show($"Brand: {this.Brand}, Price: {this.Price}$");
        }

        public Streaming_Services()
        {
           
        }
    }
}
