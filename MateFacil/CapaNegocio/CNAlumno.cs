using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class CNAlumno
    {
        //Encapsular Variables 
        private CDAlumno ObjDatoAlumno = new CDAlumno();

        //Variables 
        //Registro Alumno
        private String _IdAlumno;
        private String _NombreAlumno;
        private String _GrupoAlumno;
        private String _GradoAlumno;

        private String _NuevoGrupo;
        private String _IDGrupo;

        //Metodo Get y Set --> Para el manejo de variables
       

        //Variables para Crear Grupo
        
        public String NuevoGrupo
        {
            set{
                if(value == "") { _NuevoGrupo = "Ingrese nombre del grupo"; }
                else { _NuevoGrupo = value; }
            }
            get { return _NuevoGrupo; }
        }
        public String IdGrupo
        {
            set
            {
                if (value == "") { _IDGrupo = "Error Conexión"; }
                else { _IDGrupo = value; }
            }
            get { return _IDGrupo; }
        }

        //Variables para Agreagr Alumno
        public String IdAlumno
        {
            set
            {
                if(value == "") { _IdAlumno = "Error conexión"; }
                else { _IdAlumno = value; }
            }
            get { return _IdAlumno; }
        }
        public String NombreAlumno
        {
            set
            {
                if(value == "") { _NombreAlumno = "Ingrese nombre del alumno"; }
                else { _NombreAlumno = value; }
            }
            get { return _NombreAlumno; }
        }
        public String GrupoAlumno
        {
            set
            {
                if(value == "") { _GrupoAlumno = "Elija grupo al alumno"; }
                else { _GrupoAlumno = value; }
            }
            get { return _GrupoAlumno; }
        }
        public String GradoAlumno
        {
            set
            {
                if(value == "") { _GradoAlumno = "Ingrese grado del alumno"; }
                else { _GradoAlumno = value; }
            }
            get { return _GradoAlumno; }
        }


        //FUNCIONES
        public SqlDataReader VerficacionDelGrupo()
        {
            SqlDataReader verificarGrupo;
            verificarGrupo = ObjDatoAlumno.IdGrupoConfirmacion(GrupoAlumno);

            return verificarGrupo;
        }
    }
}
