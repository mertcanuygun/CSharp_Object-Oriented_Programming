using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class__Constructor_and_Property
{
    public partial class Class : Form
    {
        public Class()
        {
            InitializeComponent();
        }

        //One of the overloads of constructor is used below.
        private void btn_search_Click(object sender, EventArgs e)
        {
            Streaming_Services streaming_Services = new Streaming_Services("HBO Max", 5.99);
        }

        //Deafult overload of constructor is used in here. I created 3 objects according to the properties defined in the Streaming Services class. Then, 3 different string arrays are created to fit the objects to be able to listing in listview.
        private void btn_example2_Click(object sender, EventArgs e)
        {
            Streaming_Services ss = new Streaming_Services();

            ss.Brand = "Hulu";
            ss.Price = 7.99;
            ss.UserAmount = 1345000;
            ss.CountryOrigin = "United States";
            ss.LaunchYear = 2007;

            Streaming_Services ss2 = new Streaming_Services();

            ss2.Brand = "Disney +";
            ss2.Price = 6.99;
            ss2.UserAmount = 2489000;
            ss2.CountryOrigin = "United States";
            ss2.LaunchYear = 2019;

            Streaming_Services ss3 = new Streaming_Services();

            ss3.Brand = "Netflix";
            ss3.Price = 10.99;
            ss3.UserAmount = 22154000;
            ss3.CountryOrigin = "United States";
            ss3.LaunchYear = 1997;

            string [] rowa = {ss.Brand, ss.Price.ToString(), ss.UserAmount.ToString("N0"), ss.CountryOrigin, ss.LaunchYear.ToString()};

            string [] rowb = { ss2.Brand, ss2.Price.ToString(), ss2.UserAmount.ToString("N0"), ss2.CountryOrigin, ss2.LaunchYear.ToString() };

            string[] rowc = { ss3.Brand, ss3.Price.ToString(), ss3.UserAmount.ToString("N0"), ss3.CountryOrigin, ss3.LaunchYear.ToString() };

            ListViewItem listview1 = new ListViewItem(rowa);
            listView1.Items.Add(listview1);

            ListViewItem listview2 = new ListViewItem(rowb);
            listView1.Items.Add(listview2);

            ListViewItem listview3 = new ListViewItem(rowc);
            listView1.Items.Add(listview3);

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);        
        }
        
    }
}
