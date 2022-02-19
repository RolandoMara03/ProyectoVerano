using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFletes.Data
{
    public class Conexion
    {
        public  SqlConnection connect = new SqlConnection();
        public Conexion(String user, String pass)
        {
            try
            {

                connect = new SqlConnection(@"Data Source=DESKTOP-JNDQ2L1\SQLEXPRESS;Initial Catalog=RyW;UID=" + user + ";PWD=" + pass);
                connect.Open();
            }
            catch (Exception)
            {


            }
        }
        //MAE AQUI PUSE LAS ONDAS DE SUCURSAL
        //PARA CARGAR DEPARTAMENTOS 
        public DataTable CargarComa(int index)
        {

            string query = "select NombreComa from Comarca where Id_Muni = " + index;
            SqlCommand cmd = new SqlCommand(query);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = connect;

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public DataTable CargarMuni(int index)
        {

            string query = "select NombreMuni from Municipio where id_Dep = " + index;
            SqlCommand cmd = new SqlCommand(query);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = connect;

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public DataTable CmbDep()
        {

            SqlCommand cmd = new SqlCommand();
            SqlDataReader leer;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "CmbDep";
            cmd.Connection = connect;
            

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;

        }



    }
}
