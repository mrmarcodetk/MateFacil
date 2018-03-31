using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CDConexion
    {
        //private SqlConnection Conexion = new SqlConnection("Server=MR-MARCKO\SQLEXPRESS;DataBase=MateFacil;Integrated Security=true");
        // private SqlConnection Conexion = new SqlConnection(@"Data Source=MR-MARCKO\SQLEXPRESS;Initial catalog=MateFacil; User Id = Usuaririo; Password = contra; Integrated Security=true");
        public SqlConnection Conexion = new SqlConnection(@"Data Source=MR-MARCKO\SQLEXPRESS;Initial catalog=MateFacil;Integrated Security=true");

        

        public SqlConnection AbrirConexion() {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }

    }
}
