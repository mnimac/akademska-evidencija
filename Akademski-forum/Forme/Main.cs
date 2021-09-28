using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace Akademski_forum
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void predmetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Predmeti predmeti = new Predmeti();
            predmeti.MdiParent = this;
            predmeti.Show();
        }

        private void studentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Studenti studenti = new Studenti();
            studenti.MdiParent = this;
            studenti.WindowState = FormWindowState.Maximized;
            studenti.Show();
        }
            
        private void profesoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profesori profesori = new Profesori();
            profesori.MdiParent = this;
            profesori.Show();
        }

        private void ocjeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ocjene ocjene = new Ocjene();
            ocjene.MdiParent = this;
            ocjene.Show();
        }
    }
}
