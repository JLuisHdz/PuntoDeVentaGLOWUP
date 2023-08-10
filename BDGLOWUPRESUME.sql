CREATE DATABASE DBSISTEMA_GLOWUP

 GO

USE DBSISTEMA_GLOWUP

 GO

create table ROL(
IdRol int primary key identity,
Descripcion varchar(50),
FechaCreacion datetime default getdate()
)

 go

create table PERMISO(
IdPermiso int primary key identity,
IdRol int references ROL(IdRol),
NombreMenu varchar(100),
FechaCreacion datetime default getdate()
)

 go

create table PROVEEDOR(
IdProveedor int primary key identity,
Documento varchar(50),
RazonSocial varchar(50),
Correo varchar(50),
Telefono varchar(50),
Estado bit,
FechaCreacion datetime default getdate()
)

 go

create table CLIENTE(
IdCliente int primary key identity,
Documento varchar(50),
NombreCompleto varchar(50),
Correo varchar(50),
Telefono varchar(50),
Estado bit,
FechaCreacion datetime default getdate()
)

 go

 create table CATEGORIA(
 IdCategoria int primary key identity,
 Descripcion varchar(50),
 Estado bit,
 FechaCreacion datetime default getdate()
 )

 go

create table USUARIO(
IdUsuario int primary key identity,
Documento varchar(50),
NombreCompleto varchar(50),
Clave varchar(50),
IdRol int references ROL(IdRol),
Estado bit,
FechaCreacion datetime default getdate()
)

go

create table PRODUCTO(
IdProducto int primary key identity,
Codigo varchar(50),
Nombre varchar(50),
Descripcion varchar(50),
IdCategoria int references CATEGORIA(IdCategoria),
Stock int default 0,
PrecioCompra decimal(10,2) default 0,
PrecioVenta decimal(10,2) default 0,
Estado bit,
FechaRegistro datetime default getdate()
)

 go

create table COMPRA(
IdCompra int primary key identity,
IdUsuario int references USUARIO(IdUsuario),
IdProveedor int references PROVEEDOR(IdProveedor),
TipoDocumento varchar(50),
NumeroDocumento varchar(50),
MontoTotal decimal(10,2),
FechaRegistro datetime default getdate()
)

 go

 create table DETALLE_COMPRA(
IdDetalleCompra int primary key identity,
IdCompra int references COMPRA(IdCompra),
IdProducto int references PRODUCTO(IdProducto),
PrecioCompra decimal(10,2) default 0,
PrecioVenta decimal(10,2) default 0,
Cantidad int,
MontoTotal decimal(10,2),
FechaRegistro datetime default getdate()
)

 go

create table VENTA(
IdVenta int primary key identity,
IdUsuario int references USUARIO(IdUsuario),
TipoDocumento varchar(50),
NumeroDocumento varchar(50),
MontoPago decimal(10,2),
Descuento decimal (10,2),
MontoCambio decimal(10,2),
MontoTotal decimal (10,2),
FechaRegistro datetime default getdate()
)

go

create table DETALLE_VENTA(
IdDetalleVenta int primary key identity,
IdVenta int references VENTA(IdVenta),
IdProducto int references PRODUCTO(IdProducto),
PrecioVenta decimal(10,2),
Cantidad int,
SubTotal decimal(10,2),
Descuento decimal(10,2),
FechaRegistro datetime default getdate()
)

go

create table SALIDA(
IdSalida int primary key identity,
Nombre varchar(50),
Monto int,
Descripcion varchar(100),
FechaRegistro datetime default getdate()
)

 go

create table DETALLE_SALIDA(
IdDetalleSalida int primary key identity,
IdSalida int references SALIDA(IdSalida),
Monto int,
Descripcion varchar(100),
FechaRegistro datetime default getdate()
)

 go

create table NEGOCIO(
IdNegocio int primary key,
Nombre varchar(50),
RUC varchar(50),
Direccion varchar(50),
Logo varbinary(max) NULL
)

go

create table LOGOIMP(
IdLogoImp int primary key,
Logo varbinary(max) NULL
)

 go

 --------------------------------------------
 -------------- PROCEDIMIENTO REPORTES COMPRAS------------------
create PROCEDURE sp_ReporteCompras(
@fechainicio varchar(10),
@fechafin varchar(10),
@idproveedor int
)
 as
begin
 SET DATEFORMAT dmy; 
  select
  convert(char(10),c.FechaRegistro,103)[FechaRegistro],c.TipoDocumento,c.NumeroDocumento,c.MontoTotal,
  u.NombreCompleto[UsuarioRegistro],
  pr.Documento[DocumentoProveedor],pr.RazonSocial,
  p.Codigo[CodigoProducto],p.Nombre[NombreProducto],dc.PrecioCompra,dc.PrecioVenta,dc.Cantidad,dc.MontoTotal[SubTotal]
  from COMPRA c
  inner join USUARIO u on u.IdUsuario = c.IdUsuario
  inner join PROVEEDOR pr on pr.IdProveedor = c.IdProveedor
  inner join DETALLE_COMPRA dc on dc.IdCompra = c.IdCompra
  inner join PRODUCTO p on p.IdProducto = dc.IdProducto
  where CONVERT(date,c.FechaRegistro) between @fechainicio and @fechafin
  and pr.IdProveedor = iif(@idproveedor=0,pr.IdProveedor,@idproveedor)
  end

  -------------- PROCEDIMIENTO REPORTES VENTAS------------------
create PROCEDURE sp_ReporteVentas(
@fechainicio varchar(10),
@fechafin varchar(10)
)
 as
begin
 
 SET DATEFORMAT dmy; 
  select
  convert(char(10),v.FechaRegistro,103)[FechaRegistro],v.TipoDocumento,v.NumeroDocumento,v.MontoTotal,
  u.NombreCompleto[UsuarioRegistro],
  p.Codigo[CodigoProducto],p.Nombre[NombreProducto],dv.PrecioVenta,dv.Cantidad,dv.SubTotal,dv.Descuento
  from VENTA v
  inner join USUARIO u on u.IdUsuario = v.IdUsuario
  inner join DETALLE_VENTA dv on dv.IdVenta = v.IdVenta
  inner join PRODUCTO p on p.IdProducto = dv.IdProducto
  where CONVERT(date,v.FechaRegistro) between @fechainicio and @fechafin
  end
  
    -------------- PROCEDIMIENTO REPORTES SALIDAS ------------------
create procedure sp_ReporteSalidas(
@fechainicio varchar(10),
@fechafin varchar(10)
)
 as
begin

 SET DATEFORMAT dmy; 
  select
  convert(char(10),FechaRegistro,103)[FechaRegistro],Nombre,Monto,Descripcion
  from SALIDA
  where CONVERT(date,FechaRegistro) between @fechainicio and @fechafin
  end

 -------------- PROCEDIMIENTO PARA PRODUCTO-------------------

 Create procedure sp_RegistrarProducto(
 @Codigo varchar(50),
 @Nombre varchar(50),
 @Descripcion varchar(50),
 @IdCategoria int,
 @Estado bit,
 @Resultado int output,
 @Mensaje varchar(500) output
 )as
 begin
	SET @Resultado = 0
	IF NOT EXISTS (SELECT * FROM producto WHERE Codigo = @Codigo)
	begin 
		insert into producto(Codigo,Nombre,Descripcion,IdCategoria) values (@Codigo,@Nombre,@Descripcion,@IdCategoria)
		set @Resultado = SCOPE_IDENTITY()
	end
	ELSE
		SET @Mensaje = 'Ya existe un producto con el mismo codigo'

end

GO

 Create procedure sp_ModificarProducto(
 @IdProducto int,
 @Codigo varchar(50),
 @Nombre varchar(50),
 @Descripcion varchar(50),
 @IdCategoria int,
 @Estado bit,
 @Resultado int output,
 @Mensaje varchar(500) output
 )as
 begin
	SET @Resultado = 1
	IF NOT EXISTS (SELECT * FROM producto WHERE Codigo = @Codigo and @IdProducto != @IdProducto)
	
		update PRODUCTO set
		Codigo = @Codigo,
		Nombre = @Nombre,
		Descripcion = @Descripcion,
		IdCategoria = @IdCategoria,
		Estado = @Estado

		where IdProducto = @IdProducto
	ELSE
	begin
		SET @Resultado = 0
		SET @Mensaje = 'Ya existe un producto con el mismo codigo'
	end
end

GO


 Create procedure sp_EliminarProducto(
 @IdProducto int,
 @Respuesta int output,
 @Mensaje varchar(500) output
 )as
 begin
	SET @Respuesta = 0
	SET @Mensaje = ''
	declare @pasoreglas bit = 1

	IF EXISTS (SELECT * FROM DETALLE_COMPRA dc
	INNER JOIN PRODUCTO p ON p.IdProducto = dc.IdProducto
	WHERE p.IdProducto = @IdProducto
	)
	BEGIN
		set @pasoreglas = 0
		set @Respuesta = 0
		SET @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado a una VENTA\n'
	END

	IF EXISTS (SELECT * FROM DETALLE_VENTA dv
	INNER JOIN PRODUCTO p ON p.IdProducto = dv.IdProducto
	WHERE p.IdProducto = @IdProducto
	)
	BEGIN
		set @pasoreglas = 0
		set @Respuesta = 0
		SET @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado a una VENTA\n'
	END

	if(@pasoreglas = 1)
	begin
		delete from PRODUCTO where IdProducto = @IdProducto
		set @Respuesta = 1
	end
end
GO
 -------------- PROCEDIMIENTO PARA USUARIO-------------------

 Create procedure sp_RegistrarUsuario(
 @Documento varchar(50),
 @NombreCompleto varchar(50),
 @Clave varchar(50),
 @IdRol int,
 @Estado bit,
 @IdUsuarioResultado int output,
 @Mensaje varchar(500) output
 )as
 begin
	SET @IdUsuarioResultado = 0
	set @Mensaje = ''

	IF NOT EXISTS (SELECT * FROM USUARIO WHERE NombreCompleto = @NombreCompleto)
	begin 
		insert into USUARIO(Documento,NombreCompleto,Clave,IdRol,Estado) values (@Documento,@NombreCompleto,@Clave,@IdRol,@Estado)
		set @IdUsuarioResultado = SCOPE_IDENTITY()
	end
	ELSE
		SET @Mensaje = 'Ya existe un Usuario con el mismo codigo'

end

GO


 Create procedure sp_ModificarUsuario(
 @IdUsuario int,
 @Documento varchar(50),
 @NombreCompleto varchar(50),
 @Clave varchar(50),
 @IdRol int,
 @Estado bit,
 @Respuesta int output,
 @Mensaje varchar(500) output
 )as
 begin
	SET @Respuesta = 0
	set @Mensaje = ''

	IF NOT EXISTS (SELECT * FROM USUARIO WHERE NombreCompleto = @NombreCompleto and @IdUsuario != @IdUsuario)
	begin
		update USUARIO set
		 Documento = @Documento,
		 NombreCompleto = @NombreCompleto,
		 Clave = @Clave,
		 IdRol = @IdRol,
		 Estado = @Estado
		where IdUsuario = @IdUsuario

		SET @Respuesta = 1
		end
		else
		SET @Mensaje = 'Ya existe un Usuario con el mismo codigo'
end

GO


 Create procedure sp_EliminarUsuario(
 @IdUsuario int,
 @Respuesta int output,
 @Mensaje varchar(500) output
 )as
 begin
	SET @Respuesta = 0
	SET @Mensaje = ''
	declare @pasoreglas bit = 1

	IF EXISTS (SELECT * FROM COMPRA C
	INNER JOIN USUARIO U ON U.IdUsuario = C.IdUsuario
	WHERE U.IdUsuario = @IdUsuario
	)
	BEGIN
		set @pasoreglas = 0
		set @Respuesta = 0
		SET @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado a un Usuario\n'
	END

	IF EXISTS (SELECT * FROM VENTA V
	INNER JOIN USUARIO U ON U.IdUsuario = V.IdUsuario
	WHERE U.IdUsuario = @IdUsuario
	)
	BEGIN
		set @pasoreglas = 0
		set @Respuesta = 0
		SET @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado a un Usuario\n'
	END

	if(@pasoreglas = 1)
	begin
		delete from USUARIO where IdUsuario = @IdUsuario
		set @Respuesta = 1
	end
	end
GO


IF EXISTS (SELECT * FROM  DETALLE_SALIDA dc
	INNER JOIN PRODUCTO p ON p.IdProducto = dc.IdProducto
	WHERE p.IdProducto = @Id.Producto
	)
	begin 
		set @pasoreglas = 0
		set Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado a una COMPRA\n'
	end

	 -------------- PROCEDIMIENTO PARA PROVEEDORES-------------------

 Create procedure sp_RegistrarProveedor(
 @Documento varchar(50),
 @RazonSocial varchar(50),
 @Correo varchar(50),
 @Telefono varchar(50),
 @Estado bit,
 @Resultado int output,
 @Mensaje varchar(500) output
 )as
 begin
	SET @Resultado = 0
	DECLARE @IDPERSONA int
	IF NOT EXISTS (SELECT * FROM PROVEEDOR WHERE Documento = @Documento)
	begin 
		insert into PROVEEDOR(Documento,RazonSocial,Correo,Telefono,Estado) values (@Documento,@RazonSocial,@Correo,@Telefono,@Estado)
		set @Resultado = SCOPE_IDENTITY()
	end
	ELSE
		SET @Mensaje = 'El numero de documento ya existe'

end

GO

Create procedure sp_ModificarProveedor(
 @IdProveedor int,
 @Documento varchar(50),
 @RazonSocial varchar(50),
 @Correo varchar(50),
 @Telefono varchar(50),
 @Estado bit,
 @Resultado int output,
 @Mensaje varchar(500) output
 )as
 begin
	SET @Resultado = 1
	DECLARE @IDPERSONA int
	IF NOT EXISTS (SELECT * FROM PROVEEDOR WHERE Documento = @Documento and @IdProveedor != @IdProveedor)
	 begin
		update PROVEEDOR set
		Documento = @Documento,
		RazonSocial = @RazonSocial,
		Correo = @Correo,
		Telefono = @Telefono,
		Estado = @Estado
		where IdProveedor = @IdProveedor
		end
	ELSE
	begin
		SET @Resultado = 0
		SET @Mensaje = 'El numero de documento ya existe'
	end
end

GO


 Create procedure sp_EliminarProveedor(
 @IdProveedor int,
 @Resultado bit output,
 @Mensaje varchar(500) output
 )as
 begin
	SET @Resultado = 1
	IF NOT EXISTS (SELECT * FROM PROVEEDOR p
	INNER JOIN COMPRA c ON p.IdProveedor = c.IdProveedor
	WHERE p.IdProveedor = @IdProveedor
	)
	BEGIN
		delete top(1) from PROVEEDOR where IdProveedor = @IdProveedor
		end
		else
		begin
		set @Resultado = 0
		SET @Mensaje = @Mensaje + 'El proveedor se encuentra relacionada a una compra\n'
	END
end

GO

----------- PROCEDIMIENTOS PARA REGISTRAR COMPRA ---------------

CREATE TYPE [dbo].[EDetalle_Compra] AS TABLE(
	[IdProducto] int NULL,
	[PrecioCompra] decimal(18,2) NULL,
	[PrecioVenta] decimal(18,2) NULL,
	[Cantidad] int NULL,
	[MontoTotal] decimal(18,2) NULL
)

go

CREATE PROCEDURE sp_RegistrarCompra(
@IdUsuario int,
@IdProveedor int,
@TipoDocumento varchar(500),
@NumeroDocumento varchar(500),
@MontoTotal decimal(18,2),
@DetalleCompra [EDetalle_Compra] READONLY,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
	
	begin try
		declare @idcompra int = 0
		set @Resultado = 1
		set @Mensaje = ''

		begin transaction registro
			insert into COMPRA(IdUsuario,IdProveedor,TipoDocumento,NumeroDocumento,MontoTotal)
			values (@IdUsuario,@IdProveedor,@TipoDocumento,@NumeroDocumento,@MontoTotal)

			set @idcompra = SCOPE_IDENTITY()

			insert into DETALLE_COMPRA(IdCompra,IdProducto,PrecioCompra,PrecioVenta,Cantidad,MontoTotal)
			select @idcompra,IdProducto,PrecioCompra,PrecioVenta,Cantidad,MontoTotal from @DetalleCompra

			UPDATE p SET p.Stock = p.Stock + dc.Cantidad,
			p.PrecioCompra = dc.PrecioCompra,
			p.PrecioVenta = dc.PrecioVenta
			from PRODUCTO p
			inner join @DetalleCompra dc on dc.IdProducto = p.IdProducto

		commit transaction registro

	end try
	begin catch
		set @Resultado = 0
		set @Mensaje = ERROR_MESSAGE()
		rollback transaction registro
	end catch
end

/* Proceso para registrar venta */
CREATE TYPE [dbo].[EDetalle_venta] AS TABLE(
	[IdProducto] int NULL,
	[PrecioVenta] decimal(18,2),
	[Cantidad] int NULL,
	[SubTotal] decimal(18,2) NULL,
	[Descuento] decimal(18,2) NULL
	)

	go

CREATE PROCEDURE Usp_RegistrarVenta(
@IdUsuario int,
@TipoDocumento varchar(50),
@NumeroDocumento varchar(50),
@MontoPago decimal(18,2),
@Descuento decimal (18,2),
@MontoCambio decimal (18,2),
@MontoTotal decimal (18,2),
@DetalleVenta [EDetalle_venta] READONLY,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
	
	begin try
		declare @idventa int = 0
		set @Resultado = 1
		set @Mensaje = ''

		begin transaction registro

			insert into VENTA(IdUsuario,TipoDocumento,NumeroDocumento,MontoPago,Descuento,MontoCambio,MontoTotal)
			values (@IdUsuario,@TipoDocumento,@NumeroDocumento,@MontoPago,@Descuento,@MontoCambio,@MontoTotal)

			set @idventa = SCOPE_IDENTITY()

			insert into DETALLE_VENTA(IdVenta,IdProducto,PrecioVenta,Cantidad,SubTotal,Descuento)
			select @idventa,IdProducto,PrecioVenta,Cantidad,SubTotal,Descuento from @DetalleVenta

		commit transaction registro

	end try
	begin catch
		set @Resultado = 0
		set @Mensaje = ERROR_MESSAGE()
		rollback transaction registro
	end catch
end
------- Procedimiento para Salidas -----------

Create procedure sp_RegistrarSalida(
 @Nombre varchar(50),
 @Monto decimal(18,2),
 @Descripcion varchar(100),
 @Resultado int output,
 @Mensaje varchar(500) output
 )as
 begin
	SET @Resultado = 0
	IF NOT EXISTS (SELECT * FROM salida WHERE Nombre = @Nombre)
	begin 
		insert into salida(Nombre,Monto,Descripcion) values (@Nombre,@Monto,@Descripcion)
		set @Resultado = SCOPE_IDENTITY()
	end
	ELSE
		SET @Mensaje = 'Ya existe una salida con el mismo nombre con el mismo codigo'

end

GO


 Create procedure sp_ModificarSalida(
 @IdSalida int,
 @Nombre varchar(50),
 @Monto decimal(18,2),
 @Descripcion varchar(50),
 @Resultado int output,
 @Mensaje varchar(500) output
 )as
 begin
	SET @Resultado = 1
	IF NOT EXISTS (SELECT * FROM salida WHERE Nombre = @Nombre and @IdSalida != @IdSalida)
	
		update SALIDA set
		Nombre = @Nombre,
		Monto = @Monto,
		Descripcion = @Descripcion
		where IdSalida = @IdSalida
	ELSE
	begin
		SET @Resultado = 0
		SET @Mensaje = 'Ya existe una salida con el mismo nombre'
	end
end

GO


 Create procedure sp_EliminarSalida(
 @IdSalida int,
 @Respuesta int output,
 @Mensaje varchar(500) output
 )as
 begin
	SET @Respuesta = 0
	SET @Mensaje = ''
	declare @pasoreglas bit = 1

	IF EXISTS (SELECT * FROM DETALLE_SALIDA ds
	INNER JOIN SALIDA s ON s.IdSalida = ds.IdSalida
	WHERE s.IdSalida = @IdSalida
	)
	BEGIN
		set @pasoreglas = 0
		set @Respuesta = 0
		SET @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado a una SALIDA\n'
	END
	end

	------- Procedimiento para Categorias -----------
CREATE procedure sp_RegistrarCategoria(
@Descripcion varchar (50),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)as
begin 
	SET @Resultado = 0
	IF NOT EXISTS (SELECT * FROM CATEGORIA WHERE Descripcion = @Descripcion)
	begin 
		insert into CATEGORIA(Descripcion,Estado) values (@Descripcion,@Estado)
		set @Resultado = SCOPE_IDENTITY()
		end
		ELSE
			set @Mensaje = 'No se puede repetir la descripcion de una categoria'
end

go

CREATE procedure sp_ModificarCategoria(
@IdCategoria int,
@Descripcion varchar (50),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)as
begin 
	SET @Resultado = 1
	IF NOT EXISTS (SELECT * FROM CATEGORIA WHERE Descripcion = @Descripcion and IdCategoria != @IdCategoria)
	
	update CATEGORIA set
	Descripcion = @Descripcion,
	Estado = @Estado
	where IdCategoria = @IdCategoria
		ELSE
		begin
			set @Mensaje = 0
			set @Mensaje = 'No se puede repetir la descripcion de una categoria'
		end
end

go

CREATE procedure sp_EliminarCategoria(
@IdCategoria int,
@Resultado int output,
@Mensaje varchar(500) output
)as
begin 
	SET @Resultado = 1
	IF NOT EXISTS (SELECT * FROM CATEGORIA c 
	inner join PRODUCTO p on p.IdCategoria = c.IdCategoria
	WHERE c.IdCategoria = @IdCategoria
	)
	begin 
		delete top(1) from CATEGORIA where IdCategoria = @IdCategoria
		end
		ELSE
		begin
			set @Mensaje = 0
			set @Mensaje = 'La categoria se encuentra relacionada a un producto'
		end
end

go

----------------------- Inserts ----------------------------------
select * from USUARIO;
INSERT INTO	ROL (Descripcion) values ('Administrador');
INSERT INTO	ROL (Descripcion) values ('Empleado');

INSERT INTO USUARIO (Documento,NombreCompleto,Clave,IdRol,Estado) values ('01','ADMIN','1q2w',1,1)

INSERT INTO PERMISO (IdRol,NombreMenu) values 
(1,'brnCS'),
(1,'btnCompras'),
(1,'btnVentas'),
(1,'btnSalidas'),
(1,'btnCotizacion'),
(1,'btnAgregarTodo'),
(1,'btnDetalles'),
(1,'btnDVentas'),
(1,'btnDCompra'),
(1,'btnNegocio'),
(1,'btnReporteVentas'),
(1,'btnReporteCompras'),
(1,'btnReporteSalidas'),
(1,'btnEstadisticas')

go

INSERT INTO PERMISO (IdRol,NombreMenu) values 
(2,'brnCS'),
(2,'btnVentas'),
(2,'btnSalidas'),
(2,'btnDetalles'),
(2,'btnDVentas'),
(2,'btnReporteVentas'),
(2,'btnEstadisticas')

go