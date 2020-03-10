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
    public partial class frm_productos_busqueda : Form
    {
        SqlConnection cn= new SqlConnection("Initial Catalog =bd_cpventas; Data Source =.;uid=sa;pwd=sqladmin");
        void listar()
        {
            try
            {
                cn.Open();
                MessageBox.Show("conexion correcta");
                String qu = " select * from producto ";
                SqlCommand cm = new SqlCommand(qu, cn);
                SqlDataAdapter data = new SqlDataAdapter(cm);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgv1.DataSource = tabla;
                cn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("desconectado");
                cn.Close();
            }
        }
        void consulta()
        {
            try
            {
                if (rbtcodigo.Checked)
                {
                    cn.Open();
                    MessageBox.Show("conexion correcta");
                    String qu = " select * from producto where idprod='"+ txtconsulta.Text+"'";
                    SqlCommand cm = new SqlCommand(qu, cn);
                    SqlDataAdapter data = new SqlDataAdapter(cm);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dgv1.DataSource = tabla;
                    cn.Close();
                    int i = cm.ExecuteNonQuery();
                    cn.Close();
                    if (i > 0)
                    {
                        MessageBox.Show("SE AGREGO CORRECTAMENTE");
                        listar();
                        cn.Close();
                    }
                    else
                    {
                        MessageBox.Show("hubo un problema en el ingreso");
                    }
                }
                else
                {
                    cn.Open();
                    MessageBox.Show("conexion correcta");
                    String qu = " select * from Producto where nombre like'" + txtconsulta.Text+"%'";
                    SqlCommand cm = new SqlCommand(qu, cn);
                    SqlDataAdapter data = new SqlDataAdapter(cm);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dgv1.DataSource = tabla;
                    cn.Close();
                    int i = cm.ExecuteNonQuery();
                    cn.Close();
                    if (i > 0)
                    {
                        MessageBox.Show("SE AGREGO CORRECTAMENTE");
                        listar();
                        cn.Close();
                    }
                    else
                    {
                        MessageBox.Show("hubo un problema en el ingreso");
                    }
                }
            }
            
            catch (Exception e)
            {

                
                cn.Close();
            }
        }
        public frm_productos_busqueda()
        {
            InitializeComponent();
        }

        private void frm_productos_busqueda_Load(object sender, EventArgs e)
        {
            listar();
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consulta();
            cn.Close();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
