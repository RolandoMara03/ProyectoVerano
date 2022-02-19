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
        public string  logon;

        //public SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-JNDQ2L1\SQLEXPRESS;Initial Catalog=RyW;UID=" + "sa" + ";PWD=" + "1234");

       

        public DProducto(Conexion con , string logon)
        {
            this.con = con;
            this.logon = logon;

        }

        public DataTable CargarClientes(string logon)
        {

           SqlConnection connect = new SqlConnection(logon);
            Console.WriteLine("imprimimos cone" + logon);
            Console.WriteLine(connect);
            if (con.connect.State == ConnectionState.Open)
            {
                Console.WriteLine("si ta abierta");
            }
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

        public DataTable CargarCategorias(string logon)
        {
            SqlConnection connect = new SqlConnection(logon);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ListarCategorias";
            cmd.Connection = connect;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

    }
   
}
