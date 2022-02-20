using Inheritance.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_television_Click(object sender, EventArgs e)
        {
           Television television = new Television();

            television.Brand = "Samsung";
            television.Price = 5000;
            television.Screen_Size = 55;
            television.Resolution = "HD";

            MessageBox.Show($"Brand: {television.Brand}\nPrice: {television.Price}$\nScreen Size: {television.Screen_Size} inch\nResolution: {television.Resolution}");
        }

        private void btn_car_Click(object sender, EventArgs e)
        {
            Car car = new Car();

            car.Brand = "Renault";
            car.Price = 55000;
            car.Speed = 150;

            MessageBox.Show($"Brand: {car.Brand}\nPrice: {car.Price.ToString("N0")} $\nSpeed Limit: {car.Speed} km/h");
        }

        private void btn_computer_Click(object sender, EventArgs e)
        {
            Computer computer = new Computer();

            computer.Brand = "Apple";
            computer.Price = 2000;
            computer.Memory = 16;
            computer.Storage = 512;

            MessageBox.Show($"Brand: {computer.Brand}\nPrice: {computer.Price.ToString("N0")} $\nMemory: {computer.Memory} GB\nStorage: {computer.Storage} GB");
        }
    }
}
