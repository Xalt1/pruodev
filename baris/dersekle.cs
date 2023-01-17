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
    public partial class dersekle : Form
    {
        public dersekle()
        {
            InitializeComponent();
        }
        context dbislem = new context();
        ders veriler = new ders();

        private void dersekle_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbislem.dersveri.Add(new ders
            {
                ad = textBox1.Text,
                kredisi = Convert.ToInt32(textBox2.Text),
                okulyonetimid = Convert.ToInt32(textBox3.Text),

            });
            dbislem.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var za = from i in dbislem.dersveri
                     select i;
            dataGridView1.DataSource = za.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dersguncelle guncelleform = new dersguncelle();
            guncelleform.ShowDialog();
        }

        
    }
}
