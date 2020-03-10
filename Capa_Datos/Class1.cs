using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;



namespace Capa_Datos
{
    public class BDConnect
    {
      public SqlConnection abrirconexion()
        {
            SqlConnection cn = null;
            try
            {
                cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnInfordata"].ConnectionString);
                
                cn.Open();
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            return cn;
        }
        public void cerrarconexion(SqlConnection cnx)
        {
            try
            {
                if (cnx.State==ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        public DataTable ejecutarconsulta(string sql)
        {
            DataTable dt = null;
            try
            {
                SqlConnection cn = abrirconexion();
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                dt = new DataTable();
                da.Fill(dt);
                cerrarconexion(cn);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return dt;
        }



    }
}
