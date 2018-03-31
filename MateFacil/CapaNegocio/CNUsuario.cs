using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.SqlClient;
using System.Data;
namespace CapaNegocio
{
    public class CNUsuario
    {
        //Encapsular variables
        private CDUsuarios objDato = new CDUsuarios();//instancia a la capa datos de usuario
        //Variables
        //Login
        private String _Usuario;
        private String _Contraseña;
        //Codigo Verficacion de registro
        private String _CodigoVerificacion;
        //Registro Maestro
        private String _IDUsuario;
        private String _Password;
        private String _NombreProfesor;
        private String _ApellidoProfesor;
        private String _CorreoProfesor;
        //todas las demas 
        //METODOS GET Y SET --> PARA EL MANEJO DE VARIABLES


            //Abre Manejo de variables ---- Login 
        public String Usuario
        {
            set {
                if(value == "") { _Usuario = "Ingrese Usuario"; }
                else { _Usuario = value; }
            }
            get { return _Usuario; }
        }
        public String Contraseña
        {
            set {
                if (value == "Contrasena") { _Contraseña = "Ingrese Contraseña"; } 
                else{ _Contraseña = value; }
            }
            get { return _Contraseña; }
        }
            //Cierra manejo de variables ----- Login

            //Abre manejo de variables ------ Codigo de verificacion del registro profesor
        public String CodigoVerificacion
        {
            set {
                if(value == "") { _CodigoVerificacion = "Ingrese Codigo"; }
                else { _CodigoVerificacion = value; }
            }
            get { return _CodigoVerificacion; }
        }
            //Cierra manejo de variables ------ Codigo de verificacion del registro profesor

            //Abre manejo de varibales ---- Registro Profesor
        public String IDUsuario
        {
            set{
                if (value == "") { _IDUsuario = "Ingrese ID de Usuario"; }
                else { _IDUsuario = value; }
            }
            get { return _IDUsuario; }
        }
        public String Password
        {
            set
            {
                if(value == "") { _Password = "Ingrese contraseña"; }
                else { _Password = value; }
            }
            get { return _Password; }
        }
        public String NombreProfesor
        {
            set
            {
                if(value == "") { _NombreProfesor = "Ingrese El nombre"; }
                else { _NombreProfesor = value; }
            }
            get { return _NombreProfesor; }
        }
        public String ApellidoProfesor
        {
            set
            {
                if(value == "") { _ApellidoProfesor = "Ingrese el Apelldio"; }
                else { _ApellidoProfesor = value; }
            }
            get { return _ApellidoProfesor; }
        }
        public String CorreoProfesor
        {
            set
            {
                if(value == "") { _CorreoProfesor = "Ingrese su Correo Electronico"; }
                else { _CorreoProfesor = value; }
            }
            get { return _CorreoProfesor; }
        }
            //Cierra manejo de variables ------ Registro Profesor
        //CONTRUCTOR
        public CNUsuario() { }
        //FUNCIONES O METODOS
        public SqlDataReader IniciarSesion()
        {
            SqlDataReader Loguear;
            Loguear = objDato.IniciarSesion(Usuario,Contraseña);

            return Loguear;
        }
        public SqlDataReader CodigoVerif()
        {
            SqlDataReader ver;
            ver = objDato.CodigoConfirmacion(CodigoVerificacion);

            return ver;
        }
    }
}
