using System;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CDAlumno
    {
        CDConexion conexion = new CDConexion();
        private SqlDataReader ConfirmarGrupo;
        public bool RegistrarAlumno(String id, String nombre, String grado, String grupo)
        {

            bool agregado = false;
            int i = 0;
            SqlCommand Registro = new SqlCommand("insert into Alumno values('" + id + "','" + nombre + "','" + grado + "','" + grupo + "')", conexion.AbrirConexion());
            i = Registro.ExecuteNonQuery();

            if (i > 0) agregado = true;

            conexion.CerrarConexion();

            return agregado;
        }

        public bool EliminarAlunmo(String dato)
        {
            bool Eliminar = false;
            int i = 0;
            SqlCommand EliminarA = new SqlCommand("delete from Alumno where Nombre_Alumno = "+ "'"+dato+"'",conexion.AbrirConexion());
            i = EliminarA.ExecuteNonQuery();

            if (i > 0) Eliminar = true;

            conexion.CerrarConexion();

            return Eliminar;
        }

        public bool ModificarAlumno(String id, String nombre, String grado, String grupo)
        {

            bool modi = false;
            int i = 0;
            SqlCommand Modificar = new SqlCommand("Update Alumno Set  Nombre_Alumno = '" + nombre + "', Grado = '" + grado + "', Id_Grupo = '" + grupo + "' Where Id_Alumno = '" + id + "'", conexion.AbrirConexion());
            i = Modificar.ExecuteNonQuery();

            if (i > 0) modi = true;

            conexion.CerrarConexion();

            return modi;
        }
        public SqlDataReader IdGrupoConfirmacion(String codigo)
        {

            SqlCommand VerificacionIdGrupo = new SqlCommand("SPValidarGrupoCinco", conexion.AbrirConexion());
            VerificacionIdGrupo.CommandType = CommandType.StoredProcedure;
            VerificacionIdGrupo.Parameters.AddWithValue("@grupo",codigo);

            ConfirmarGrupo = VerificacionIdGrupo.ExecuteReader();                    
            return ConfirmarGrupo;
        }
    }
}
