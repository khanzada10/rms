using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Conf_Order_Click(object sender, EventArgs e)
        {
            if (SmallPizza.Checked == true)
            {
                ListViewItem item = new ListViewItem("Small Pizza");
                item.SubItems.Add(SPizza.Text);
                int qty = Convert.ToInt32(Console.ReadLine());
                double cost = qty * 350;
                string dcost = cost.ToString();
                item.SubItems.Add(dcost);
                listView1.Items.Add(item);
            }
            else
            {
                SPizza.Text = " ";
            }

           
        }  
    }
}
