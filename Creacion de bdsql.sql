delete from Usuarios;

select*from Usuarios;

insert into Usuarios(Username,Password,Nombre_Completo)
values('administrador','123456','Gleni Perez Martinez');

CREATE TABLE [dbo].[Usuarios] (
    [Id]              INT     IDENTITY (1, 1) NOT NULL,
    [Username]        VARCHAR (50)  NOT NULL,
    [Password]        VARCHAR (50)  NOT NULL,
    [Nombre_Completo] VARCHAR (200) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);