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
    public partial class Karta : Form
    {
        public Karta()
        {
            InitializeComponent();
        }

        private void Karta_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            qwe.Drivers dr = db.Drivers.Find(Convert.ToInt32(textBox1.Text));
            dr.Фамилия = (textBox2.Text);
            dr.Имя = (textBox3.Text);
            dr.Отчество = (textBox4.Text);
            dr.Пасспорт__серия_и_номер_ = (textBox5.Text);
            dr.Адрес_регистрации = (textBox6.Text);
            dr.Адрес_проживания = (textBox7.Text);
            dr.Место_работы = (textBox8.Text);
            dr.Должность = (textBox9.Text);
            dr.Мобильный_телефон = (maskedTextBox1.Text);
            dr.Email = (textBox12.Text);
            dr.Фотография = (textBox10.Text);
            dr.Замечания = (textBox13.Text);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            qwe.Drivers dr = db.Drivers.Find(Convert.ToInt32(textBox1.Text));
            textBox2.Text = dr.Фамилия;
            textBox3.Text = dr.Имя;
            textBox4.Text = dr.Отчество;
            textBox5.Text = dr.Пасспорт__серия_и_номер_;
            textBox6.Text = dr.Адрес_регистрации;
            textBox7.Text = dr.Адрес_проживания;
            textBox8.Text = dr.Место_работы;
            textBox9.Text = dr.Должность;
            maskedTextBox1.Text = dr.Мобильный_телефон;
            textBox12.Text = dr.Email;
            textBox10.Text = dr.Фотография;
            textBox13.Text = dr.Замечания;
        }
    }
}
