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
    public partial class yonetimekle : Form
    {
        public yonetimekle()
        {
            InitializeComponent();
        }
        context dbislem = new context();
        okulyonetim veriler = new okulyonetim();

        private void button1_Click(object sender, EventArgs e)
        {
            dbislem.okulyonetimveri.Add(new okulyonetim
            {
                AdSoyad = textBox1.Text,
                Gorevi = textBox2.Text,
                YonetimTip = Convert.ToInt32(numericUpDown1.Text),
               
            });
            dbislem.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var za = from i in dbislem.okulyonetimveri
                     select i;
            dataGridView1.DataSource = za.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yonetimguncelle guncelleform = new yonetimguncelle();
            guncelleform.ShowDialog();
        }

        
    }
}
