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
on delete cascade
on update cascade
)

create table Plato(
idPlato int primary key identity(1,1) NOT NULL,
Plato varchar(50) NOT NULL,
idTipoPlato int not null,
foreign key (idTipoPlato) references TipoPlato(idTipoPlato)
on delete cascade
on update cascade
)

create table DetalleBebida(
idDetalleBebida int primary key identity(1,1) NOT NULL,
Especialidad varchar(50) NOT NULL,
Precio float NOT NULL,
Descripcion varchar(100) not null,
idBebida int not null,
foreign key (idBebida) references Bebida(idBebida)
on delete cascade
on update cascade
)

create table DetallePlato(
idDetallePlato int primary key identity(1,1) NOT NULL,
Especialidad varchar(50) NOT NULL,
Precio float NOT NULL,
Descripcion varchar(100) not null,
idPlato int not null,
foreign key (idPlato) references Plato(idPlato)
on delete cascade
on update cascade
)

create table Orden(
idOrden int primary key not null,
Cliente varchar(50)
)


create table DetalleFacturaPlato(
idDetalleFacturaPlato int primary key identity(1,1) NOT NULL,
idDetallePlato int not null,
Cantidad int not null,
SubTotal float not null,
NumOrden int not null
foreign key (idDetallePlato) references DetallePlato(idDetallePlato),
foreign key (NumOrden) references Orden(idOrden)
on delete cascade
on update cascade
)

create table DetalleFacturaBebida(
idDetalleFacturaBebida int primary key identity(1,1) NOT NULL,
idDetalleBebida int not null,
Cantidad int not null,
SubTotal float not null,
NumOrden int not null
foreign key (NumOrden) references Orden(idOrden),
foreign key (idDetalleBebida) references DetalleBebida(idDetalleBebida)
on delete cascade
on update cascade
)

create table Factura(
idFactura int primary key identity(1,1) NOT NULL,
PagoTotal float NOT NULL,
Orden int
foreign key (Orden) references Orden(idOrden)
on delete cascade
on update cascade
)

create table Administracion(
idAdmin int primary key identity(1,1) not null,
Nombre varchar(50) not null,
Pass varchar(50) not null
)