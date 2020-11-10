use master
create database Concesionario

use Concesionario

/*Creamos la tabla*/
create table Tipo_Vehiculo
(
	id int primary key,
	nombre varchar(25)
)

/*creamos el procedimiento para almacenar*/
create proc addTipoVehiculo
(
	@id int,
	@nombre varchar(25)
)
as insert into Tipo_Vehiculo values(@id, @nombre)

select * from Tipo_Vehiculo

exec addTipoVehiculo '1','Camion'
exec addTipoVehiculo '2','Camion'

/*Creamos la tabla*/
create table Vehiculo
(
	id int primary key,
	marca varchar(25) unique,
	modelo varchar(25) not null,
	placa varchar(6) not null,
	anio int not null,
	id_tv int not null,
	constraint rel_a_tipovehi foreign key (id_tv) references Tipo_Vehiculo (id) 	
)
/*creamos el procedimiento para almacenar*/

create proc addVehiculo
(
	@id int,
	@marca varchar(25),
	@modelo varchar(25),
	@placa varchar(6),
	@anio int,
	@id_tv int
)
as insert into Vehiculo values (@id, @marca,@modelo,@placa,@anio,@id_tv)

exec addVehiculo 1,'Foton','CX3','TRT250',2020,1
exec addVehiculo 2,'Chevy','Argo','TTR225',2019,2

/*Ver la tabla creada*/
select * from Vehiculo

create table Ruta
(
	id int primary key,
	estacion varchar(25) unique,
	id_vh int not null,
	constraint rel_a_vehi foreign key (id_vh) references Vehiculo (id) 	
)

create proc addRuta
(
	@id int,
	@estacion varchar(25),
	@id_vh int
)
as insert into Ruta values (@id, @estacion,@id_vh)

exec addRuta 1,'Principal',1

select * from Ruta

create table Tipo_Conductor
(
	id int primary key,
	tipo_persona varchar(25)
)

/*creamos el procedimiento para almacenar*/
create proc addTipoConductor
(
	@id int,
	@tipo_persona varchar(25)
)
as insert into Tipo_Conductor values(@id, @tipo_persona)

select * from Tipo_Conductor

exec addTipoConductor 1126586475,'Motorizado'

/*Creamos la tabla*/
create table Conductor
(
	id int primary key,
	nombre varchar(25) unique,
	tipolicencia varchar(4) not null,
	id_vh int not null,
	id_tc int not null,

	constraint rel_a_tvehiculo foreign key (id_vh) references Vehiculo (id),
	constraint rel_a_ttconducc foreign key (id_tc) references Tipo_Conductor (id)
	
)

/*creamos el procedimiento para almacenar*/

create proc addConductor
(
	@id int,
	@nombre varchar(25),
	@tipolicencia varchar(4),
	@id_vh int,
	@id_tc int
)
as insert into Conductor values (@id, @nombre,@tipolicencia,@id_vh,@id_tc)

exec addConductor 1126586475,'Camilo Ortega','C3','1',1126586475

select * from Conductor

create table Contrato
(
	id int primary key,
	id_vehiculo int,
	id_conductor int,

	constraint rel_a_tdbvehiculo foreign key (id_vehiculo) references Vehiculo (id),
	constraint rel_a_tconducc foreign key (id_conductor) references Conductor (id)
)

create proc addContrato
(
	@id int,
	@id_vehiculo int,
	@id_conductor int
)
as insert into Contrato values (@id,@id_vehiculo,@id_conductor)

exec addContrato '202001','1',1126586475

select * from Contrato