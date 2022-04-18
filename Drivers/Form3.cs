using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Drivers.qwe;

namespace Drivers
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driversDataSet.Drivers". При необходимости она может быть перемещена или удалена.
            this.driversTableAdapter.Fill(this.driversDataSet.Drivers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            qwe.Drivers dr = new qwe.Drivers();
            if (textBox1.Text != "")
            {
                dr.Идентификатор__GUID_ = Convert.ToInt32(textBox1.Text);
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
                db.Drivers.Add(dr);
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
            else
                MessageBox.Show("Значение идентификатора не должно быть пустым");
        }
    }
}
