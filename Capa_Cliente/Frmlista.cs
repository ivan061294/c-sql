using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Capa_Cliente
{
    public partial class Frmlista : Form
    {
SqlConnection con = new SqlConnection("Initial Catalog =bd_cpventas; Data Source =.;uid=sa;pwd=sqladmin");
        Frmventa v = new Frmventa();
        String precio;
        public Frmlista()
        {
            InitializeComponent();
        }
        void Listar()
        {
            try
            {
                con.Open();

                String qu = "select * from producto";
                SqlCommand cm = new SqlCommand(qu, con);
                SqlDataAdapter data = new SqlDataAdapter(cm);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgvlistado.DataSource = tabla;
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Dgvlistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dgvlistado.Rows[e.RowIndex];
            txtidpro.Text = dgv.Cells[0].Value.ToString();
            txtnombpro.Text = dgv.Cells[1].Value.ToString();
            lblid.Text = dgv.Cells[2].Value.ToString();
            lblprecio.Text = dgv.Cells[5].Value.ToString();

        }

        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void Btnagregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("agregado");
            
            
            v.cod = txtidpro.Text;
            v.mensaje = txtnombpro.Text;
            v.cantidad = lblid.Text;
            v.precio = lblprecio.Text;
            v.Show();
            this.Close();
        }

        private void Txtnombpro_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
