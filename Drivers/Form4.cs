using Drivers.qwe;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model1 db =new Model1();
            qwe.Drivers dr = db.Drivers.Find(Convert.ToInt32(textBox1.Text));
            dr = db.Drivers.Remove(dr);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            kdgfojidgfs frm = new kdgfojidgfs();
            frm.Show();
            this.Close();
        }
    }
}
