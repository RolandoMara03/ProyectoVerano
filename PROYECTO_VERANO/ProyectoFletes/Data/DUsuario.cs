using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFletes.Data
{
    class DUsuario
    {
        public static void crearParametro(SqlCommand cmd, string nombreParametro, SqlDbType tipoDato, object valor, int tamaño)
        {

            SqlParameter sqlpar = new SqlParameter();
            sqlpar.ParameterName = nombreParametro;
            sqlpar.SqlDbType = tipoDato;
            sqlpar.Size = tamaño;




            if (int.TryParse(valor.ToString(), out int valorReal))
            {

                sqlpar.Value = valor;


            }
            else
            {
                sqlpar.Value = valor.ToString();
            }

            cmd.Parameters.Add(sqlpar);
        }

        public DataTable Validar_Acceso(string user, string pass)
        {
            DataTable DtResultado = new DataTable("Inicio_Sesion");
            SqlConnection SqlCon = new SqlConnection(); 

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Validar_Acceso";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 80;
                ParUsuario.Value = user;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParContra = new SqlParameter();
                ParContra.ParameterName = "@contraseña";
                ParContra.SqlDbType = SqlDbType.VarChar;
                ParContra.Size = 80;
                ParContra.Value = pass;
                SqlCmd.Parameters.Add(ParContra);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch(Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }    
    }
}
