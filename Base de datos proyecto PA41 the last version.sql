create database bd_cpventas
go
use bd_cpventas

create table cliente (clienteid int identity(1,1)primary key,nombre varchar(30),apellido varchar (30),
					dni char(10),direccion varchar (50),sexo char (1))
					go
create table categoria (idcategoria int identity(1,1) primary key, nombre varchar(30))
go
create table marca (idmarca int identity(1,1)primary key,nombre varchar(39))
go

create table producto (idprod int identity(1,1)primary key ,nombre varchar(30),stock int, idmarca int foreign key references marca(idmarca),idcategoria int foreign 
					key references categoria(idcategoria),precio smallmoney)
go


create table tipo_Empl (idtipoEmpl int primary key, nombreTipo varchar(30));
alter table tipo_empl add contraseña char(10)
go


create table empleado (idempleado char(8) primary key, nombreEmpleado varchar(30),Apellido varchar(30), sexo char(1),direccion varchar(30),claveEmpleado char(10),
idtipoempl int foreign key references tipo_Empl(idtipoEmpl) );

create table venta (id_venta int identity(1,1)primary key,id_Cliente int foreign key references cliente(clienteid),id_producto int foreign key 
					references producto(idprod),fecha datetime,igv smallmoney,subtotal smallmoney,id_enpleado char(8) foreign key references empleado(idempleado));
go
create table detalle_VentProd(id_ventProd int identity(1,1)primary key,id_venta int foreign key references venta(id_venta),
cod_producto int foreign key references producto(idprod),cantidad int,precioventa smallmoney,total smallmoney)



insert into tipo_Empl values (1,'Administrador','admin12345')
insert into tipo_Empl values (2,'Usuario','users12345')
insert into empleado values('75380483','ivan','gaspar quispe','m','en su casa','75380483',1)
insert into cliente values('ivan','gaspar quispe','7538044483','en mi casa','m')
insert into categoria values('Audio y video')
insert into marca values('samsung')
insert into producto values ('televisor',50,1,1,1500)

--categoria
insert into categoria values ('audio')
insert into categoria values ('camaras y accesorios')
insert into categoria values ('celulares')
insert into categoria values ('computacion')
select * from categoria

--marca 
insert into marca values ('SOUNDCORE')
insert into marca values ('XIAOMI')
insert into marca values ('HUAWEI')
insert into marca values ('SONY')
insert into marca values ('USAMS')
insert into marca values ('PHILIPS')
insert into marca values ('CANON')
insert into marca values ('GOPRO')
insert into marca values ('SAMSUNG')
insert into marca values ('HP')
insert into marca values ('APPLE')
insert into marca values ('ACER')
insert into marca values ('LG')

select * from marca

--producto 
insert into producto values ('life 2 NC',30,1,1,199)
insert into producto values ('Redmi Airdots',40,2,1,199)
insert into producto values ('fREEBUDS 3',50,3,1,599)
insert into producto values ('WH-1000XM3',35,4,1,999)
insert into producto values ('WF-1000XM4',45,5,1,899)
insert into producto values ('Freebuds 3 black',60,6,1,599)
insert into producto values ('Serie LQ',25,7,1,89)
insert into producto values ('Bass+Shb3175bk',10,8,1,172)
insert into producto values ('Deportivo Shq6500cl',25,9,1,159)
insert into producto values ('Over-Ear EXTRA BASS XB550AP',35,10,1,199)

insert into producto values ('EOS 80DW18',30,11,2,6999)
insert into producto values ('EOS T7i18-55',45,12,2,4099)
insert into producto values ('GoPro Hero 7',50,13,2,1499)
insert into producto values ('GoPro Fusion',35,14,2,2599)

















insert into producto values ('Laptop Pavilion',30,3,4,2649)
insert into producto values ('MacBook',40,5,4,4199)
insert into producto values ('Notebook Pavilion',50,6,4,3499)
insert into producto values ('iMac',60,7,4,4799)
insert into producto values ('Laptop Gamer Omen 15.6',25,8,4,3699)
insert into producto values ('Laptop Spin3',35,9,4,1999)
insert into producto values ('iMac 27',45,10,4,10199)
insert into producto values ('Laptip Gamer Omen 15.6',65,11,4,4399)
insert into producto values ('AIO 23.8P ci3',45,12,4,2699)
insert into producto values ('AIO 23.8P ci5',35,13,4,3499)
select * from marca
select * from producto
SET ANSI_PADDING OFF
SET IDENTITY_INSERT venta On
set identity_insert venta off
go
select * from producto where idprod=1

-- strore procedure de insert ,modificar,eliminar
create procedure usp_insert

@id_cliente int,
@id_producto int,
@fecha datetime,
@cantidad int,
@id_empleado int

as
begin
declare
@precio smallmoney,
@impuesto smallmoney,
@subtotal smallmoney,
@total smallmoney,
@id_venta int,
@descuento smallmoney
set @precio=(select precio from producto where idprod=@id_producto)
set @subtotal=@precio*@cantidad
set @impuesto=@subtotal*0.018
set @descuento=@subtotal+@impuesto
if (@cantidad>=10)
begin
set @total=@descuento*0.010
end
else 
set @total=@descuento
end

insert into venta values (@id_cliente,@id_producto,@fecha,@impuesto,@subtotal,@id_empleado)
set @id_venta=@@IDENTITY
insert into detalle_VentProd values(@id_venta,@id_producto,@cantidad,@precio,@total)
update producto set stock=stock-@cantidad where idprod=@id_producto
go
alter procedure usp_modificar
@id_cliente int,
@id_producto int,
@fecha datetime,
@cantidad int,
@id_empleado int,
@id_venta int
as
begin
declare
@precio smallmoney,
@impuesto smallmoney,
@subtotal smallmoney,
@descuento smallmoney,
@total smallmoney
set @precio=(select precio from producto where idprod=@id_producto)
set @subtotal=@precio*@cantidad
set @impuesto=@subtotal*0.018
set @descuento=@subtotal+@impuesto
if (@cantidad>=10)
begin
set @total=@descuento*0.010
end
else 
set @total=@descuento
end
update venta set id_Cliente=@id_cliente,id_producto=@id_producto,fecha=@fecha,igv=@impuesto,subtotal=@subtotal,id_enpleado=@id_empleado where id_venta=@id_venta
update detalle_VentProd set id_venta=@id_venta,cod_producto=@id_producto,cantidad=@cantidad,total=@total,precioventa=@precio where id_venta=@id_venta
go

create procedure usp_eliminar
@id_venta int
as
delete from detalle_VentProd where id_venta=@id_venta
delete from venta where id_venta=@id_venta

go
--store procesdure de login
create procedure usp_logeo
@usuario varchar(60),
@contraseña varchar(60)
as
select * from tipo_Empl where nombretipo=@usuario and contraseña=@contraseña

go

--ejecutar despues de crear la base de datos*****
--usp insert es (1=codigo-cliente,1=codigo-producto,20190612=fecha,5=cantidad,75380483=codigo-empleado)
--usp modificar es (1=codigo-cliente,1=codigo-producto,20190612=fecha,5=cantidad,75380483=codigo-empleado,1=idventa)
--usp eiminar es(1=idventa)
--usp logeo es(administrador=tipousuario,admin12345=contraseña)

--quitar los 2 guiones para ejecutar exec("--")


exec usp_insert 1,1,'20190612',5,'75380483'
--exec usp_modificar 1,1,'20190612',8,'75380483',1
--exec usp_eliminar 1
--exec usp_logeo 'administrador','admin12345'

--select * from venta
--select * from detalle_VentProd

select a.id_venta as 'cod_venta',c.nombre as 'nombre cliente',d.cantidad as 'cantidad',d.precioventa as 'precio',p.nombre as 'producto',d.total as 'total'from venta a inner join cliente c on a.id_cliente=c.clienteid inner join detalle_VentProd d on
a.id_venta=d.id_venta inner join producto p on d.cod_producto=p.idprod 

--select * from detalle_VentProd
--select * from producto
select * from producto
--select * from categoria
--select * from cliente
--select * from venta
--select * from detalle_VentProd
alter procedure agregar_producto
@nombre varchar(30),
@stock int,
@idmarca int,
@idcategoria int,
@precio smallmoney
as
insert into producto values(@nombre,@stock,@idmarca,@idcategoria,@precio)
go
execute agregar_producto 'ivan',22,3,4,1455.00
execute agregar_producto 'ivan',22,2,2,22




