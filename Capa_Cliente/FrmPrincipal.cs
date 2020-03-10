using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Cliente
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void tablaTbventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMto_TbVentas fox = new FrmMto_TbVentas();
            fox.MdiParent = this;
            fox.Show();
        }

        private void tbproductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_productos_busqueda mierda = new frm_productos_busqueda();
            mierda.MdiParent = this;
            mierda.Show();
        }

        private void MantinimientoproductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmventas tushiahh = new Frmventas();
            tushiahh.MdiParent = this;
            tushiahh.Show();
        }

        private void AgregarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmventa a = new Frmventa();
            a.MdiParent = this;
            a.Show();
        }

        private void TbventasquiebreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_bcpventas a = new Frm_bcpventas();
            a.MdiParent = this;
            a.Show();
        }

        private void AgregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmventa a = new Frmventa();
            a.MdiParent = this;
            a.Show();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SalirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
