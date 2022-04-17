use ventaflores;

create table Articulos(
	IdArticulo int identity(1,1) NOT NULL,
	Nombre varchar(180)NOT NULL,
	Precio float,
	Img image,
	PRIMARY KEY CLUSTERED([IdArticulo]ASC)
);

SELECT*FROM Articulos;