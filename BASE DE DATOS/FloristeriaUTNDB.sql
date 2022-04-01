USE master
GO

CREATE DATABASE FloristeriaUTN_DB
ON PRIMARY
(
NAME = 'FloristeriaUTN',
FILENAME = 'C:\Bases de datos\FloristeriaUTN\FloristeriaUTN.mdf',
SIZE = 5 MB,
MAXSIZE = UNLIMITED,
FILEGROWTH = 1 MB
)
LOG ON
(
NAME = 'FloristeriaUTN_log',
FILENAME = 'C:\Bases de datos\FloristeriaUTN\FloristeriaUTN.log',
SIZE = 1 MB,
MAXSIZE = UNLIMITED,
FILEGROWTH = 10%
);

USE FloristeriaUTN_DB
GO
--Creacion de tablas

CREATE TABLE EmpresaFloristeria
(
idCedulaJuridica int NOT NULL,
nombre varchar(50) NOT NULL,
direccion varchar(50) NOT NULL,
numeroTelefono int NOT NULL,
emailAtencionCliente varchar(50) NOT NULL,
logo image NOT NULL,
IBAN varchar(22) NOT NULL
);

CREATE TABLE CategoriaProducto
(
idCategoria int IDENTITY(1,1) NOT NULL,
nombre varchar(10) NOT NULL,
descripcion varchar(50) NULL
);

CREATE TABLE Puesto
(
idPuesto int NOT NULL,
descripcion varchar(20) NOT NULL
);

CREATE TABLE Proveedor
(
idProveedor int NOT NULL,
nombre varchar(50) NOT NULL,
direccion varchar(50) NOT NULL,
email varchar(50) NOT NULL,
activo bit NOT NULL
);

CREATE TABLE Cliente
(
idCliente int NOT NULL,
nombre varchar(20) NOT NULL,
apellido1 varchar(20) NOT NULL,
apellido2 varchar(20) NOT NULL,
email varchar(50) NOT NULL,
direccion varchar(50) NOT NULL,
activo bit NOT NULL
);

CREATE TABLE Empleado
(
idEmpleado int NOT NULL,
nombre varchar(20) NOT NULL,
apellido1 varchar(20) NOT NULL,
apellido2 varchar(20) NOT NULL
);

CREATE TABLE Usuario
(
idUsuario int IDENTITY(1,1) NOT NULL,
idPuesto int NOT NULL,
idEmpleado int NOT NULL,
clave varchar(20) NOT NULL
);

CREATE TABLE TipoPago
(
idPago char CHECK(idPago in('T', 'D', 'C')) NOT NULL,
nombre varchar(20) NOT NULL,
);

CREATE TABLE Pago
(
idPago int IDENTITY(1,1) NOT NULL,
tipoPago char CHECK (tipoPago IN ('T', 'D', 'C'))  NOT NULL,
importe money NULL,
numeroAutorizacionTarjeta int NULL,
numeroTransaccionDeposito int NULL
);

CREATE TABLE EntregaDomicilio
(
idEntrega int IDENTITY(1,1) NOT NULL,
direccionEncargo varchar(50) NOT NULL,
idCliente int NOT NULL,
autorizacion bit NOT NULL
);

CREATE TABLE Producto
(
codigo int NOT NULL,
nombre varchar(50) NOT NULL,
descripcion varchar(50) NULL,
idCategoria int NOT NULL,
activo bit NOT NULL
);

CREATE TABLE Imagen_Producto
(
idProducto int NOT NULL,
idImagen int NOT NULL,
logo VARBINARY(MAX) NOT NULL
);


CREATE TABLE Material
(
idMaterial int NOT NULL,
descripcion varchar(50) NOT NULL,
precio money NOT NULL,
stock int NOT NULL,
idProveedor int NOT NULL,
minimoStockPermitido int NOT NULL,
activo bit NOT NULL
);

CREATE TABLE ProductoMaterial
(
idProducto int NOT NULL,
idMaterial int NOT NULL,
cantidad int NOT NULL
);

CREATE TABLE TelefonoCliente
(
idCliente int NOT NULL,
numero int NOT NULL
);

CREATE TABLE EntregaDomicilio_Producto
(
idProducto int NOT NULL,
idEncargo int NOT NULL,
cantidadProducto int NOT NULL
);

CREATE TABLE Pedido_Material
(
idPedido int NOT NULL,
idProveedor int NOT NULL,
idMaterial int NOT NULL,
cantidad int NOT NULL
);

CREATE TABLE Factura
(
idFactura int IDENTITY(1,1) NOT NULL,
idEmpresa int NOT NULL,
fechaHora smallDateTime NOT NULL,
idUsuario int NOT NULL,
idCliente int NOT NULL,
idEntregaDomicilio int NULL,
pago int NOT NULL,
subTotal money NOT NULL,
IVA float NOT NULL,
total money NOT NULL,
vuelto money NULL,
anulacion bit NOT NULL
);

CREATE TABLE Detalle
(
idFactura int NOT NULL,
idProducto int NOT NULL,
cantidad int NOT NULL,
precio money NOT NULL,
descuento float NULL
);


CREATE TABLE Reporte
(
idReporte int IDENTITY(1,1) NOT NULL,
nombre varchar(20) NOT NULL,
fechaCreacion smallDateTime NOT NULL,
idUsuario int NOT NULL,
subTotal money NOT NULL,
total money NOT NULL
);


--CREACION DE CONSTRAINT LLAVES PRIMARIAS

--Empresa
ALTER TABLE EmpresaFloristeria ADD
CONSTRAINT EmpresaFloristeria_PK PRIMARY KEY(idCedulaJuridica);

--CategoriaProducto
ALTER TABLE CategoriaProducto ADD
CONSTRAINT CategoriaProducto_PK PRIMARY KEY(idCategoria);

--Puesto
ALTER TABLE Puesto ADD
CONSTRAINT Puesto_PK PRIMARY KEY(idPuesto);

--Proveedor
ALTER TABLE Proveedor ADD
CONSTRAINT Proveedor_PK PRIMARY KEY(idProveedor);

--Cliente
ALTER TABLE Cliente ADD
CONSTRAINT Cliente_PK PRIMARY KEY(idCliente);

--Empleado
ALTER TABLE Empleado ADD
CONSTRAINT Empleado_PK PRIMARY KEY(idEmpleado);

--Usuario
ALTER TABLE Usuario ADD
CONSTRAINT Usuario_PK PRIMARY KEY(idUsuario);

--TipoPago
ALTER TABLE TipoPago ADD
CONSTRAINT TipoPago_PK PRIMARY KEY(idPago);

--Pago
ALTER TABLE Pago ADD
CONSTRAINT Pago_PK PRIMARY KEY(idPago);

--Encargo
ALTER TABLE EntregaDomicilio ADD
CONSTRAINT EntregaDomicilio_PK PRIMARY KEY(idEntrega);


--Producto
ALTER TABLE Producto ADD
CONSTRAINT Producto_PK PRIMARY KEY(codigo);

--Imagen_Producto
ALTER TABLE Imagen_Producto ADD
CONSTRAINT Imagen_Producto_PK PRIMARY KEY(idProducto, idImagen);

--Material
ALTER TABLE Material ADD
CONSTRAINT Material_PK PRIMARY KEY(idMaterial);

--ProductoMaterial
ALTER TABLE ProductoMaterial ADD
CONSTRAINT ProductoMaterial_PK PRIMARY KEY (idProducto, idMaterial);

--TelefonoCliente
ALTER TABLE TelefonoCliente ADD
CONSTRAINT TelefonoCliente_PK PRIMARY KEY(idCliente, numero);

--EntregaDomicilio_Cliente
ALTER TABLE EntregaDomicilio_Producto ADD
CONSTRAINT EntregaDomicilio_Producto_PK PRIMARY KEY(idProducto, idEncargo);

--Pedido_Material
ALTER TABLE Pedido_Material ADD
CONSTRAINT Pedido_Material_PK PRIMARY KEY(idPedido, idMaterial, idProveedor);

--Factura
ALTER TABLE Factura ADD
CONSTRAINT Factura_PK PRIMARY KEY(idFactura);

--Detalle
ALTER TABLE Detalle ADD
CONSTRAINT Detalle_PK PRIMARY KEY(idFactura, idProducto);

--Reporte
ALTER TABLE Reporte ADD
CONSTRAINT Reporte_PK PRIMARY KEY(idReporte);



--CREACION DE CONSTRAINT LLAVES FORANEAS
--Usuario
ALTER TABLE Usuario ADD
CONSTRAINT Puesto_Usuario_FK FOREIGN KEY(idPuesto) REFERENCES Puesto(idPuesto);

ALTER TABLE Usuario ADD
CONSTRAINT Empleado_Usuario_FK FOREIGN KEY(idEmpleado) REFERENCES Empleado(idEmpleado);

--Producto
ALTER TABLE Producto ADD
CONSTRAINT Categoria_Producto_FK FOREIGN KEY(idCategoria) REFERENCES CategoriaProducto(idCategoria);

--Imagen_Producto
ALTER TABLE Imagen_Producto ADD
CONSTRAINT Producto_Imagen_Producto_FK FOREIGN KEY(idProducto) REFERENCES Producto(codigo);

--Material
ALTER TABLE Material ADD
CONSTRAINT Proveedor_Material_FK FOREIGN KEY(idProveedor) REFERENCES Proveedor(idProveedor);

--ProductoMaterial
ALTER TABLE ProductoMaterial ADD
CONSTRAINT Producto_ProductoMaterial_FK FOREIGN KEY (idProducto) REFERENCES Producto(codigo);

ALTER TABLE ProductoMaterial ADD
CONSTRAINT Material_ProductoMaterial_FK FOREIGN KEY (idMaterial) REFERENCES Material(idMaterial);

--TelefonoCliente
ALTER TABLE TelefonoCliente ADD
CONSTRAINT Cliente_TelefonoCliente FOREIGN KEY(idCliente) REFERENCES Cliente(idCliente);

--EntregaDomicilio_Producto
ALTER TABLE EntregaDomicilio_Producto ADD
CONSTRAINT Producto_EntregaDomicilio_Producto_FK FOREIGN KEY(idProducto) REFERENCES Producto(codigo);

ALTER TABLE EntregaDomicilio_Producto ADD
CONSTRAINT EntregaDomicilio_EntregaDomicilio_Producto_FK FOREIGN KEY(idEncargo) REFERENCES EntregaDomicilio(idEntrega);

--Pedido_Material
ALTER TABLE Pedido_Material ADD
CONSTRAINT Proveedor_Pedido_Material_FK FOREIGN KEY(idProveedor) REFERENCES Proveedor(idProveedor);

ALTER TABLE Pedido_Material ADD
CONSTRAINT Material_Pedido_Material_FK FOREIGN KEY(idMaterial) REFERENCES Material(idMaterial);

--Pago
ALTER TABLE Pago ADD 
CONSTRAINT TipoPago_Pago_FK FOREIGN KEY(tipoPago) REFERENCES TipoPago(idPago);

--Factura
ALTER TABLE Factura ADD
CONSTRAINT Usuario_Factura_FK FOREIGN KEY(idUsuario) REFERENCES Usuario(idUsuario);

ALTER TABLE Factura ADD
CONSTRAINT Cliente_Factura_FK FOREIGN KEY(idCliente) REFERENCES Cliente(idCliente);

ALTER TABLE Factura ADD
CONSTRAINT Empresa_Factura_FK FOREIGN KEY(idEmpresa) REFERENCES EmpresaFloristeria(idCedulaJuridica);

ALTER TABLE Factura ADD
CONSTRAINT Pago_Factura_FK FOREIGN KEY(pago) REFERENCES Pago(idPago);

ALTER TABLE Factura ADD
CONSTRAINT EntregaDomicilio_Factura_FK FOREIGN KEY(idEntregaDomicilio) REFERENCES EntregaDomicilio(idEntrega);

--Detalle
ALTER TABLE Detalle ADD
CONSTRAINT Factura_Detalle_FK FOREIGN KEY(idFactura) REFERENCES Factura(idFactura);

ALTER TABLE Detalle ADD
CONSTRAINT Producto_Detalle_FK FOREIGN KEY(idProducto) REFERENCES Producto(codigo);

--Reporte
ALTER TABLE Reporte ADD
CONSTRAINT Usuario_Reporte_FK FOREIGN KEY(idUsuario) REFERENCES Usuario(idUsuario);
