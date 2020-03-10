using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Capa_Datos;
using System.Data;


namespace Capa_Negocios
{
    public class Bs_ventas

    {
        public DataTable ventastotales()
        {
            String sql = "select case tipodoc when 'BOL' then 'BOLETAS DE VENTA when" +
                "'FAC' then 'FACTURAS' end as 'TIPO DOC',numerodocumento as " +
                "'NUM DOC',fechaventa as 'FECHA VENTA',igv as IGV,subtotal as SUBTOTAL" +
                "from tb_ventas";

            BDConnect conexion = new BDConnect();
            return conexion.ejecutarconsulta(sql);
        }

    }
}
