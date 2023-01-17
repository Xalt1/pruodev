using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace baris
{
    public partial class yonetimguncelle : Form
    {
        public yonetimguncelle()
        {
            InitializeComponent();
        }
        context dbislem = new context();
        okulyonetim veriler = new okulyonetim();

        private void button2_Click(object sender, EventArgs e)
        {
            int idal = Convert.ToInt32(textBox1.Text);
            var idsorgula = dbislem.okulyonetimveri.Find(idal);
            idsorgula.AdSoyad = textBox2.Text;
            idsorgula.Gorevi = textBox3.Text;
            idsorgula.YonetimTip = Convert.ToInt32(numericUpDown1.Text);
            dbislem.SaveChanges();
            var za = from i in dbislem.okulyonetimveri
                     select i;
            dataGridView1.DataSource = za.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idal = Convert.ToInt32(textBox1.Text);
            var idsorgula = dbislem.okulyonetimveri.Find(idal);
            textBox2.Text = idsorgula.AdSoyad;
            textBox3.Text = idsorgula.Gorevi;
            numericUpDown1.Value = idsorgula.YonetimTip;
            
        }
    }
}
