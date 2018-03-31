using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace CapaDatos
{
    public class CDUsuarios
    {
        private CDConexion Conexion = new CDConexion();
        private SqlDataReader leer;
        private SqlDataReader Confirmacion;

        public SqlDataReader IniciarSesion(String user, String pass) {
        
            SqlCommand comando = new SqlCommand("SPIniniarSesion",Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Usuario",user);
            comando.Parameters.AddWithValue("@Password",pass);

            leer = comando.ExecuteReader();
            return leer;
        }
        public SqlDataReader CodigoConfirmacion(String codigo) {
            SqlCommand comandoVeri = new SqlCommand("SPCodigo", Conexion.AbrirConexion());
            comandoVeri.CommandType = CommandType.StoredProcedure;
            comandoVeri.Parameters.AddWithValue("@CodigoVeri",codigo);

            Confirmacion = comandoVeri.ExecuteReader();
            return Confirmacion;
        }
        public bool RegistrarMaestro(String NomUsuario, String Password, String Nombre, String Apellido, String Correo)
        {
            bool agregado = false;
            int i = 0;

            SqlCommand Registro = new SqlCommand("insert into Usuario values('"+NomUsuario+"','"+Password+"','"+Nombre+"','"+Apellido+"','"+Correo+"')",Conexion.AbrirConexion());
            i = Registro.ExecuteNonQuery();

            if (i > 0) agregado = true;

            Conexion.CerrarConexion();

            return agregado;
        }
    }
}
