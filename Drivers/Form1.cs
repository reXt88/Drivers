using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drivers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string pass = "inspector";
        public int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            if (i < 5)
                if (textBox1.Text == "inspector" && textBox2.Text == Form1.pass)
                {
                    kdgfojidgfs frm = new kdgfojidgfs();
                    frm.Show();
                    this.Hide();
                }
            if (i >= 5)
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
        }
    }
}
