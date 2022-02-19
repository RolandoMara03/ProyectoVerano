using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFletes.Data
{
    public class DProducto
    {
        public Conexion con;

        public SqlConnection connect = new SqlConnection();
        public DProducto(Conexion con)
        {
            this.con = con; 
        }

        public DataTable CargarClientes()
        {
            SqlCommand cmd = new SqlCommand();
        
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ListarClientes";
            cmd.Connection = connect;

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
    }
    
   
}
