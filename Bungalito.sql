create database Bungalito
Use bungalito

create table TipoBebida(
idTipoBebida int primary key identity(1,1) NOT NULL,
Tipo varchar(50) NOT NULL
)

create table TipoPlato(
idTipoPlato int primary key identity(1,1) NOT NULL,
Tipo varchar(50) NOT NULL
)

create table Bebida(
idBebida int primary key identity(1,1) NOT NULL,
Bebida varchar(50) NOT NULL,
idTipoBebida int not null,
foreign key (idTipoBebida) references TipoBebida(idTipoBebida)
)

create table Plato(
idPlato int primary key identity(1,1) NOT NULL,
Plato varchar(50) NOT NULL,
idTipoPlato int not null,
foreign key (idTipoPlato) references TipoPlato(idTipoPlato)
)

create table DetalleBebida(
idDetalleBebida int primary key identity(1,1) NOT NULL,
Especialidad varchar(50) NOT NULL,
Precio decimal NOT NULL,
Descripcion varchar(100) not null,
idBebida int not null,
foreign key (idBebida) references Bebida(idBebida)
)

create table DetallePlato(
idDetallePlato int primary key identity(1,1) NOT NULL,
Especialidad varchar(50) NOT NULL,
Precio decimal NOT NULL,
Descripcion varchar(100) not null,
idPlato int not null,
foreign key (idPlato) references Plato(idPlato)
)

create table DetalleFactura(
idDetalleFactura int primary key identity(1,1) NOT NULL,
idDetalleBebida int NOT NULL,
idDetallePlato int not null,
foreign key (idDetalleBebida) references DetalleBebida(idDetalleBebida),
foreign key (idDetallePlato) references DetallePlato(idDetallePlato)
)

create table Factura(
idFactura int primary key identity(1,1) NOT NULL,
Cliente varchar(50) NOT NULL,
PagoTotal decimal NOT NULL,
idDetalleFactura int not null,
foreign key (idDetalleFactura) references DetalleFactura(idDetalleFactura)
)

create table Administracion(
idAdmin int primary key identity(1,1) not null,
Nombre varchar(50) not null,
Pass varchar(50) not null
)