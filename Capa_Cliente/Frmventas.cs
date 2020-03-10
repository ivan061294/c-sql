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
    public partial class Frmventas : Form
    {
        public Frmventas()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Initial Catalog =bd_cpventas; Data Source =.;uid=sa;pwd=sqladmin");

        void Listar()
        {
            try
            {
                con.Open();
                MessageBox.Show("conexion correcta");
                String qu = "select a.id_venta as 'cod_venta',c.nombre as 'nombre cliente',d.cantidad as 'cantidad',d.precioventa as 'precio',p.nombre as 'producto',d.total as 'total'from venta a inner join cliente c on a.id_cliente=c.clienteid inner join detalle_VentProd d on a.id_venta = d.id_venta inner join producto p on d.cod_producto = p.idprod ";
                SqlCommand cm = new SqlCommand(qu, con);
                SqlDataAdapter data = new SqlDataAdapter(cm);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgv1.DataSource = tabla;
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex.Message);
            }
        }
        void insertar()
        {
            try
            {
                con.Open();
                String sql = "usp_insert";
                SqlCommand cm = new SqlCommand(sql, con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@id_cliente", txtcodigocliente.Text);
                cm.Parameters.AddWithValue("@id_producto", txtcodigoprod.Text);
                cm.Parameters.Add(new SqlParameter("@fecha", SqlDbType.DateTime)).Value = dateTimePicker1.Value.Date;
                cm.Parameters.AddWithValue("@cantidad", txtcantidad.Text);
                cm.Parameters.AddWithValue("@id_empleado", txtcodenpleado.Text);
                int i = cm.ExecuteNonQuery();
                con.Close();
                if (i > 0)
                {
                    MessageBox.Show("SE AGREGO CORRECTAMENTE");
                    Listar();
                }
                else
                {
                    MessageBox.Show("hubo un problema en el ingreso");
                    con.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("error " + ex.Message);
                con.Close();
            }
        }
        void actualizar()
        {
            try
            {
                con.Open();
                String sql = "usp_modificar";
                SqlCommand cm = new SqlCommand(sql, con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@id_cliente", txtcodigocliente.Text);
                cm.Parameters.AddWithValue("@id_producto", txtcodigoprod.Text);
                cm.Parameters.AddWithValue("@fecha", dateTimePicker1.Value);
                cm.Parameters.AddWithValue("@cantidad", txtcantidad.Text);
                cm.Parameters.AddWithValue("@id_empleado", txtcodenpleado.Text);
                cm.Parameters.AddWithValue("@id_venta", lblid.Text);
                int i = cm.ExecuteNonQuery();
                con.Close();
                if (i > 0)
                {
                    MessageBox.Show("SE Actualizo CORRECTAMENTE");
                    Listar();
                }
                else
                {
                    MessageBox.Show("hubo un problema en el ingreso");
                    con.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("error " + ex.Message);
                con.Close();
            }
        }
        void eliminar()
        {
            try
            {
                con.Open();
                String sql = "usp_eliminar";
                SqlCommand cm = new SqlCommand(sql, con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@id_venta", lblid.Text);

                int i = cm.ExecuteNonQuery();
                con.Close();
                if (i > 0)
                {
                    MessageBox.Show("SE elimino CORRECTAMENTE");
                    Listar();
                }
                else
                {
                    MessageBox.Show("hubo un problema en el ingreso");
                    con.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("error " + ex.Message);
                con.Close();
            }
        }
        private void Frmventas_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            insertar();
        }

        private void Btnmodificar_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void Dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dgv1.Rows[e.RowIndex];
            lblid.Text= dgv.Cells[0].Value.ToString();

        }
    }
}
