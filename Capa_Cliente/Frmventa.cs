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
    public partial class Frmventa : Form
    {
        SqlConnection con = new SqlConnection("Initial Catalog =bd_cpventas; Data Source =.;uid=sa;pwd=sqladmin");
        
        public string mensaje;
        public string cod;
        public string cantidad;
        public string precio;
        
        public Frmventa()
        {
            InitializeComponent();
            cbocomprobante.Items.Add("Boleta");
            cbocomprobante.Items.Add("Factura");
            
        }
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
                dgvmostrar.DataSource = tabla;
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex.Message);
            }
        }

        private bool isInsuficienteStock()
        {
            return Convert.ToInt32(cantidad) >= Convert.ToInt32(txtcantexist.Text);
        }
        void insertar()
        {
            if (isInsuficienteStock())
            {
                MessageBox.Show("Stock insuficiente");
                return;
            }

            try
            {
                con.Open();
                String sql = "usp_insert";
                SqlCommand cm = new SqlCommand(sql, con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@id_cliente", txtcodigo.Text);
                cm.Parameters.AddWithValue("@id_producto", txtcodigoproducto.Text);
                cm.Parameters.Add(new SqlParameter("@fecha", SqlDbType.DateTime)).Value = dtpfecha.Value.Date;
                cm.Parameters.AddWithValue("@cantidad", txtcantexist.Text);
                cm.Parameters.AddWithValue("@id_empleado",txtcodem.Text);




                
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
                cm.Parameters.AddWithValue("@id_cliente", txtcodigo.Text);
                cm.Parameters.AddWithValue("@id_producto", txtcodigoproducto.Text);
                cm.Parameters.Add(new SqlParameter("@fecha", SqlDbType.DateTime)).Value = dtpfecha.Value.Date;
                cm.Parameters.AddWithValue("@cantidad", txtcantexist.Text);
                cm.Parameters.AddWithValue("@id_empleado", txtcodem.Text);
                cm.Parameters.AddWithValue("@id_venta", txtnroventa.Text);
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
                cm.Parameters.AddWithValue("@id_venta", txtnroventa.Text);

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

        void buscararticulos(string nombre, DataGridView dgv)
        {
            SqlDataAdapter da;
            try
            {
                da = new SqlDataAdapter("SELECT * FROM producto WHERE nombre LIKE '%" + nombre + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception e)
            {

            }

        }
        void buscarcliente(string nombre, DataGridView dgv)
        {
            SqlDataAdapter da;
            try
            {
                da = new SqlDataAdapter("SELECT * FROM cliente WHERE nombre LIKE '%" + nombre + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception e)
            {

            }

        }
        void product()
        {
            try
            {
                con.Open();
                MessageBox.Show("conexion correcta");
                String qu = "select * from producto WHERE nombre LIKE '%" + txtarticulo.Text + "%'";
                SqlCommand cm = new SqlCommand(qu, con);
                SqlDataAdapter data = new SqlDataAdapter(cm);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgvproducto.DataSource = tabla;
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex.Message);
            }
        }




        private void Btnbuscarpro_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void Frmventa_Load(object sender, EventArgs e)
        {
            txtarticulo.Text = mensaje;
            txtcodigoproducto.Text = cod;
            txtcantidad.Text = cantidad;
            txtpreventa.Text = precio;
            Listar();
            dgvcliente.Visible = false;
            
        }

        private void Btnagregar_Click(object sender, EventArgs e)
        {
            insertar();
            dgvproducto.Visible = false;
            dgvcliente.Visible = false;
            txtigv.Text = (Convert.ToInt32(cantidad) * Convert.ToInt32(txtcantexist.Text) * 0.018).ToString();
            foreach (DataGridViewRow dgv in dgvmostrar.Rows)
            {
                txtnroventa.Text = dgv.Cells["cod_venta"].Value.ToString();
            }
            int cant = (Convert.ToInt32(cantidad) - Convert.ToInt32(txtcantexist.Text));
            txtcantidad.Text = cant.ToString();
       
        }

        private void Txtarticulo_TextChanged(object sender, EventArgs e)
        {
            buscararticulos(txtarticulo.Text, dgvproducto);
            dgvcliente.Visible = false;
            dgvproducto.Visible = true;

        }

        private void Txtigv_TextChanged(object sender, EventArgs e)
        {
            txtigv.Text = (Convert.ToInt32(cantidad) * Convert.ToInt32(txtcantexist.Text) * 0.018).ToString();

        }

        private void Txtcliente_TextChanged(object sender, EventArgs e)
        {
            buscarcliente(txtcliente.Text, dgvcliente);
            dgvcliente.Visible = true;
            dgvproducto.Visible = false;
        }

        private void Dgvcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dgvcliente.Rows[e.RowIndex];
            txtcodigo.Text = dgv.Cells[0].Value.ToString();
            txtcliente.Text = dgv.Cells[1].Value.ToString(); 
        }

        private void Dgvproducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtcodigoproducto.Text = Convert.ToString(dgvproducto.CurrentRow.Cells["idprod"].Value);
            txtarticulo.Text = Convert.ToString(dgvproducto.CurrentRow.Cells["Nombre"].Value);
            txtcantidad.Text = Convert.ToString(dgvproducto.CurrentRow.Cells["Stock"].Value);
            txtpreventa.Text = Convert.ToString(dgvproducto.CurrentRow.Cells["precio"].Value);
            dgvproducto.Visible = false;
        }


        private void Txtcantexist_TextChanged(object sender, EventArgs e)
        {
            if (txtcantexist.Text.Length>1)
            {
                if (Convert.ToInt32(txtcantexist.Text)>= 10)
                {
                    txtdsc.Text = (Convert.ToDouble(txtpreventa.Text) * Convert.ToInt32(txtcantexist.Text) * 0.010).ToString();
                }
                else
                {
                    txtdsc.Text = "0";
                }
            }
        }

        private void Btneliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void Txtcantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

