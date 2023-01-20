using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ardin
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Mas f1 = new Mas();
            f1.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Price frm = new Price();
            frm.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void автомобилиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Car frm = new Car();
            frm.Show();
        }

        private void ремонтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remont frm = new Remont();
            frm.Show();
        }
    }
}
