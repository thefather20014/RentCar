

CREATE TABLE MARCA (
IdMarca INT NOT NULL CONSTRAINT pk_MARCA PRIMARY KEY IDENTITY(1, 1),
Despcricion VARCHAR(100) NOT NULL,
Estado CHAR(1) CHECK (Estado in ('A', 'I')) NOT NULL 
);

CREATE TABLE MODELO (
IdModelo INT NOT NULL CONSTRAINT pk_Modelo PRIMARY KEY IDENTITY(1, 1),
Despcricion VARCHAR(100) NOT NULL,
Estado CHAR(1) CHECK (Estado in ('A', 'I')) NOT NULL,
IdMarca int not null,
Constraint fk_Marca foreign key(IdMarca) References MARCA(IdMarca)
);

CREATE TABLE TIPOVEHICULO (
IdTipoVehiculo INT NOT NULL CONSTRAINT pk_TipoVehiculo PRIMARY KEY IDENTITY(1, 1),
Despcricion VARCHAR(100) NOT NULL,
Estado CHAR(1) CHECK (Estado in ('A', 'I')) NOT NULL
);

CREATE TABLE TIPOCOMBUSTIBLE (
IdTipoCombustible INT NOT NULL CONSTRAINT pk_TipoCombustible PRIMARY KEY IDENTITY(1, 1),
Despcricion VARCHAR(100) NOT NULL,
Estado CHAR(1) CHECK (Estado in ('A', 'I')) NOT NULL
);

CREATE TABLE VEHICULO (
IdVehiculo INT NOT NULL CONSTRAINT pk_Vehiculo PRIMARY KEY IDENTITY(1, 1),
IdMarca int not null,
IdModelo int not null,
IdTipoVehiculo int not null,
IdTipoCombustible int not null,
Despcricion VARCHAR(100) NOT NULL,
NoChasis int not null,
NoMotor int not null,
NoPlaca int not null,
Estado CHAR(1) CHECK (Estado in ('D', 'R', 'M', 'I')) NOT NULL,
Constraint fk_VehiculoMarca foreign key(IdMarca) References MARCA(IdMarca),
Constraint fk_VehiculoModelo foreign key(IdModelo) References MODELO(IdModelo),
Constraint fk_VehiculoTipoVehiculo foreign key(IdTipoVehiculo) References TIPOVEHICULO(IdTipoVehiculo),
Constraint fk_VehiculoCombustible foreign key(IdTipoCombustible) References TIPOCOMBUSTIBLE(IdTipoCombustible)
);

CREATE TABLE EMPLEADO (
IdEmpleado INT NOT NULL CONSTRAINT pk_Empleado PRIMARY KEY IDENTITY(1, 1),
Nombre VARCHAR(200) NOT NULL,
Documento VARCHAR(11) NOT NULL,
Tanda CHAR CHECK (Tanda in ('M', 'V', 'N')) NOT NULL,
PorcientoComision VARCHAR(100) NOT NULL,
FechaIngreso DATETIME NOT NULL,
FechaSalida DATETIME NULL,
Usuario VARCHAR(100) NOT NULL,
Password VARCHAR(100) NOT NULL,
Estado CHAR(1) CHECK (Estado in ('A', 'I')) NOT NULL
);

CREATE TABLE CLIENTE (
IdCliente INT NOT NULL CONSTRAINT pk_Cliente PRIMARY KEY IDENTITY(1, 1),
Nombre VARCHAR(200) NOT NULL,
Documento VARCHAR(11) NOT NULL,
TarjetaCredito VARCHAR(15) NOT NULL,
LimiteCredito VARCHAR(50) NULL,
TipoPersona CHAR(1) CHECK (TipoPersona in ('F', 'J')) NOT NULL,
Estado CHAR(1) CHECK (Estado in ('A', 'I')) NOT NULL
);

CREATE TABLE INSPECCION (
IdInspeccion INT NOT NULL CONSTRAINT pk_Inspeccion PRIMARY KEY IDENTITY(1, 1),
IdVehiculo int not null,
IdCliente int not null,
IdEmpleado int not null,
Ralladuras CHAR(1) CHECK (Ralladuras in ('S', 'N')) NOT NULL,
CantidadCombustible VARCHAR(10) NOT NULL,
GomaRepuesto CHAR(1) CHECK (GomaRepuesto in ('S', 'N')) NOT NULL,
Gato CHAR(1) CHECK (Gato in ('S', 'N')) NOT NULL,
RoturaCristal CHAR(1) CHECK (RoturaCristal in ('S', 'N')) NOT NULL,
EstadoNeumatico1 CHAR(1) CHECK (EstadoNeumatico1 in ('B', 'M')) NULL,
EstadoNeumatico2 CHAR(1) CHECK (EstadoNeumatico2 in ('B', 'M')) NULL,
EstadoNeumatico3 CHAR(1) CHECK (EstadoNeumatico3 in ('B', 'M')) NULL,
EstadoNeumatico4 CHAR(1) CHECK (EstadoNeumatico4 in ('B', 'M')) NULL,
Fecha DATETIME NOT NULL,
Estado CHAR(1) CHECK (Estado in ('A', 'I')) NOT NULL
Constraint fk_InspeccionVehiculo foreign key(IdVehiculo) References VEHICULO(IdVehiculo),
Constraint fk_InspeccionCliente foreign key(IdCliente) References CLIENTE(IdCliente),
Constraint fk_InspeccionEmpleado foreign key(IdEmpleado) References EMPLEADO(IdEmpleado)
);

DROP TABLE RENTADEVOLUCION

CREATE TABLE RENTADEVOLUCION (
IdRentaDevolucion INT NOT NULL CONSTRAINT pk_RentaDevolucion PRIMARY KEY IDENTITY(1, 1),
IdEmpleado int not null,
IdCliente int not null,
IdVehiculo int not null,
FechaRenta DATETIME NOT NULL,
FechaDevolucon DATETIME NULL,
MontoDia DECIMAL(13,2) NOT NULL,
CantidadDias VARCHAR(50) NOT NULL,
MontoAtraso DECIMAL(13,2) NULL,
Comentarios VARCHAR(150) NULL,
Estado CHAR(1) CHECK (Estado in ('A', 'I')) NOT NULL,
Constraint fk_RentaDevolucionCliente foreign key(IdCliente) References CLIENTE(IdCliente),
Constraint fk_RentaDevolucionEmpleado foreign key(IdEmpleado) References EMPLEADO(IdEmpleado),
Constraint fk_RentaDevolucionVehiculo foreign key(IdVehiculo) References VEHICULO(IdVehiculo)
);

CREATE TABLE RENTADEVOLUCIONCOPIA (
IdRentaDevolucion INT NOT NULL CONSTRAINT pk_RentaDevolucion2 PRIMARY KEY IDENTITY(1, 1),
IdEmpleado int not null,
IdCliente int not null,
IdVehiculo int not null,
FechaRenta DATETIME NOT NULL,
FechaDevolucon DATETIME NULL,
MontoDia DECIMAL(13,2) NOT NULL,
CantidadDias VARCHAR(50) NOT NULL,
MontoAtraso DECIMAL(13,2) NULL,
Comentarios VARCHAR(150) NULL,
Estado CHAR(1) CHECK (Estado in ('A', 'I')) NOT NULL,
Constraint fk_RentaDevolucionCliente2 foreign key(IdCliente) References CLIENTE(IdCliente),
Constraint fk_RentaDevolucionEmpleado2 foreign key(IdEmpleado) References EMPLEADO(IdEmpleado),
Constraint fk_RentaDevolucionVehiculo2 foreign key(IdVehiculo) References VEHICULO(IdVehiculo)
);

 CREATE TRIGGER RENTA ON RENTADEVOLUCION AFTER INSERT
  AS
  DECLARE @IDVEHICULO INT
  SELECT @IDVEHICULO = IdVehiculo from INSERTED

  UPDATE Vehiculo set Estado = 'R' WHERE IdVehiculo = @IDVEHICULO

  GO

  ---------------------------------------------------

  CREATE TRIGGER DEVOLUCIONCOPIA ON RENTADEVOLUCION AFTER UPDATE
  AS
  DECLARE @IDVEHICULO INT

  SELECT @IDVEHICULO = IdVehiculo from DELETED;

  UPDATE Vehiculo set Estado = 'D' WHERE IdVehiculo = @IDVEHICULO

 GO


