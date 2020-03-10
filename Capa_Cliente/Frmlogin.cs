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

    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();

            cbousuario.Items.Add("Administrador");
            cbousuario.Items.Add("Usuario");
        }
        SqlConnection con = new SqlConnection("Initial Catalog =bd_cpventas; Data Source =.;uid=sa;pwd=sqladmin");

        void Listar()
        {
            try
            {
                con.Open();
                MessageBox.Show("conexion correcta");
                String qu = " select * from tipo_Empl ";
                SqlCommand cm = new SqlCommand(qu, con);
                con.Close();



            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex.Message);
            }
        }


        void logear()
        {
            try
            {
                con.Open();

                string sql = "usp_logeo";
                SqlCommand cm = new SqlCommand();
                cm.Connection = con;
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = sql;
                cm.Parameters.AddWithValue("@usuario", cbousuario.Text);
                cm.Parameters.AddWithValue("@contraseña", txtcontraseña.Text);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);

                con.Close();
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    MessageBox.Show("se logeo correctamente");
                    FrmPrincipal frm = new FrmPrincipal();
                    frm.Show();
                }

                else
                {
                    MessageBox.Show("Error de logeo");


                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e + "");
            }
        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            logear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            con.Close();
            Application.Exit();
        }
    }
}
