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
    public partial class derslistele : Form
    {
        context dbislem = new context();
        public derslistele()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var za = from i in dbislem.dersveri
                     select i;
            dataGridView1.DataSource = za.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string aranacak = textBox1.Text;
            var arabakalım = (from i in dbislem.dersveri
                              where i.ad.ToString().Contains(aranacak)
                              select i).ToList();
            dataGridView1.DataSource = arabakalım;
        }
    }
}
