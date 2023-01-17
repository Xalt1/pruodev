using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baris
{
    public partial class OgrenciListele : Form
    {
        context dbislem = new context();
        public OgrenciListele()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                var za = from i in dbislem.ogrenciveri
                         select i;
                dataGridView1.DataSource = za.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string aranacak = textBox1.Text;
            var arabakalım = (from i in dbislem.ogrenciveri
                              where i.OgrenciNo.ToString().Contains(aranacak)
                              select i).ToList();
            dataGridView1.DataSource = arabakalım;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
