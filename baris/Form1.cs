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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenciekle gösterbakalım = new ogrenciekle();
            gösterbakalım.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yonetimekle gösterbakalım = new yonetimekle();
            gösterbakalım.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dersekle gösterbakalım = new dersekle();
            gösterbakalım.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ogrencidersekle gösterbakalım = new ogrencidersekle();
            gösterbakalım.ShowDialog();
        }

        private void ogrenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ogrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogrenciekle gösterbakalım = new ogrenciekle();
            gösterbakalım.ShowDialog();
        }

        private void ogrenciListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciListele gösterbakalım = new OgrenciListele();
            gösterbakalım.ShowDialog();
        }

        private void ogrenciGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciListele gösterbakalım = new OgrenciListele();
            gösterbakalım.ShowDialog();
        }

        private void yonetimEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yonetimekle guncelleform = new yonetimekle();
            guncelleform.ShowDialog();
        }

        private void yonetimListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yonetimlistele guncelleform = new yonetimlistele();
            guncelleform.ShowDialog();
        }

        private void yonetimGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yonetimguncelle guncelleform = new yonetimguncelle();
            guncelleform.ShowDialog();
        }

        private void dersEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dersekle guncelleform = new dersekle();
            guncelleform.ShowDialog();
        }

        private void dersListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            derslistele guncelleform = new derslistele();
            guncelleform.ShowDialog();
        }

        private void dersGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dersguncelle guncelleform = new dersguncelle();
            guncelleform.ShowDialog();
        }

        private void ogrenciDersEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogrencidersekle guncelleform = new ogrencidersekle();
            guncelleform.ShowDialog();
        }

        private void ogrenciDersListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogrenciderslistele guncelleform = new ogrenciderslistele();
            guncelleform.ShowDialog();
        }

        private void ogrenciDersGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
