--create database MateFacil
--use MateFacil

--create table Usuario
--(
--	NomUsuario varchar(30),
--	Contraseña varchar(15),
--	Nombres varchar(50), 
--	Apellido varchar(50), 
--	Email varchar(50)
--)
--create table CodigoConfirmacion
--(
--	idCodigoConfirmacion int,
--	CodigoMaestro varchar(15)
--)

----Tabla Alumnos 
select * from Alumno
Update Alumno Set Nombre_Alumno = 'bato modificado', Grado = '4', Id_Grupo = '1' Where Id_Alumno='18'
create table Alumno
(
	Id_Alumno int primary key not null,
	Nombre_Alumno varchar(35),
	Grado varchar(2),
	Id_Grupo int,
	foreign key(Id_Grupo) references Datos_Grupo(Id_Grupo)
)
-----1
delete from Alumno where Nombre_Alumno = 'Marco Antonio'

create procedure listar_registros
as
select * from Alumno
-----2
--Filtro_Busqueda
create procedure Filtro_BusquedaDos
@filtro varchar(200)
as
select Id_Alumno, Nombre_Alumno, Grado, Id_Grupo
from Alumno
where Nombre_Alumno like @filtro + '%'

Insert into Alumno values(1,'Daniel Villa Gtz','6',1)
insert into Datos_Grupo values(1,'MateFacil')
--select MAX(Id_Grupo) from Datos_Grupo

----Tabla Datos del grupo 

create table Datos_Grupo
(
	Id_Grupo int primary key not null,
	Nombre_Grupo varchar(10)
)

----Tabla Profesores
create table Profesor
(
	Id_Profesor varchar(5) primary key not null,
	Nombre_Profesor char(35),
	Id_Grupo int,
	foreign key (Id_Grupo) references Datos_Grupo(Id_Grupo)
)
--select * from Profesor

----Tabla Curso
--create table Curso
--(
--	Id_Curso varchar(2) primary key not null,
--	Nombre_Curso char(20)	
--)

----Tabla Lecciones
--alter table Lecciones
--(
--	Id_Leccion varchar(2) primary key not null,
--	Nombre_Leccion char(30),
--	Dia int,
--	Mes int,
--	Año int,
--	Calificacion_examen varchar(3),
--	Id_Curso varchar(2),
--	foreign key (Id_Curso) references Curso(Id_Curso) 
--)

----Tabla Ejercicios 
--create table Ejercicios
--(
--	Id_Ejercicios varchar(3) primary key not null,
--	Planteamiento varchar(250),
--	Respuesta char(15),
--	Calificacion_Parcial int,
--	Id_Leccion varchar(2)
--	Foreign key (Id_Leccion) references Lecciones(Id_Leccion)
--)

----Tabla Calificaciones
--create table Calificaciones
--(
--	Id_Calificaciones varchar(5) primary key not null,
--	Calificacion_General int,
--	Id_Alumno int,
--	foreign key (Id_Alumno) references Alumno(Id_Alumno)	
--	Id_Leccion varchar(2)
--	foreign k,ey (Id_Leccion) references Lecciones(Id_Leccion)
--)






-----------------METODOS 


--Metodo para el codigo de verificacion 
--create procedure SPCodigo
--@CodigoVeri varchar(15)
--as
--select * from CodigoConfirmacion
--where CodigoMaestro=@CodigoVeri;
--go

--exec SPCodigo '15290849'

--Metodo para iniciar sesion
--create procedure SPIniniarSesion
--@Usuario varchar(30),
--@Password varchar(30)
--as
--select * from Usuario
--where NomUsuario=@Usuario and Contraseña=@Password;
--go

---------------Metodo para Verificar que coninside el id_grupo con el ingrado

--create procedure SPValidarGrupoCinco
--@grupo varchar(10)
--as
--select * from Datos_Grupo
--where Id_Grupo=@grupo; 
--go

--CREATE LOGIN MateFacil   
--    WITH PASSWORD = 'argos'  
--GO 


-----OTROS METODOS

----PROCEDIMIENTO DANI;MODIFICAR ALUMNO
--create procedure modificar_alumno 
--@id as int, @nombre as varchar(35), @grado as varchar(2), @idgrupo as int
--as
--update Alumno set Nombre_Alumno=@nombre, Grado=@grado, Id_Grupo=@idgrupo where Id_Alumno=@id
--go

----PROCEDIMIENTO ELIMINAR ALUMNO
--create procedure eliminar_alumno 
--@id as int
--as
--delete from Alumno where Id_Alumno=@id
--go

---PROCEDIMIENTO AGREGAR ALUMNO HERNESTO CG
--create procedure Agregar_Alumno @id_Alu as int, @nombre as varchar(35), @grado as varchar(2), @id_grupo as int 
--	as
--	begin try
--		insert into Alumno values(@id_Alu,@nombre,@grado,@id_grupo)
--	end try
--	begin catch
--	no	print('No se pudo realizar')
--	end catch

--execute Agregar_Alumno(parametros)