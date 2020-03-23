USE [master]
GO
/****** Object:  Database [SistemaDeGruas]    Script Date: 22/3/2020 19:38:45 ******/
CREATE DATABASE [SistemaDeGruas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SistemaDeGruas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\SistemaDeGruas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SistemaDeGruas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\SistemaDeGruas_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [SistemaDeGruas] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SistemaDeGruas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SistemaDeGruas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SistemaDeGruas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SistemaDeGruas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SistemaDeGruas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SistemaDeGruas] SET ARITHABORT OFF 
GO
ALTER DATABASE [SistemaDeGruas] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SistemaDeGruas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SistemaDeGruas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SistemaDeGruas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SistemaDeGruas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SistemaDeGruas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SistemaDeGruas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SistemaDeGruas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SistemaDeGruas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SistemaDeGruas] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SistemaDeGruas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SistemaDeGruas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SistemaDeGruas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SistemaDeGruas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SistemaDeGruas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SistemaDeGruas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SistemaDeGruas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SistemaDeGruas] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SistemaDeGruas] SET  MULTI_USER 
GO
ALTER DATABASE [SistemaDeGruas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SistemaDeGruas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SistemaDeGruas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SistemaDeGruas] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SistemaDeGruas] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SistemaDeGruas', N'ON'
GO
ALTER DATABASE [SistemaDeGruas] SET QUERY_STORE = OFF
GO
USE [SistemaDeGruas]
GO
/****** Object:  Table [dbo].[Caso]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Caso](
	[idCaso] [int] IDENTITY(1,1) NOT NULL,
	[idGrua] [int] NOT NULL,
	[nombreCaso] [varchar](50) NOT NULL,
	[estadoGrua] [varchar](50) NOT NULL,
	[kilometraje] [float] NOT NULL,
	[costoPorKilometros] [int] NOT NULL,
	[costoCaso] [float] NOT NULL,
 CONSTRAINT [PK_Caso] PRIMARY KEY CLUSTERED 
(
	[idCaso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chofer]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chofer](
	[idChofer] [int] NOT NULL,
	[nombreChofer] [varchar](50) NOT NULL,
	[ingresoObtenido] [int] NOT NULL,
	[estadoChofer] [bit] NOT NULL,
 CONSTRAINT [PK_Chofer_IdChofer] PRIMARY KEY CLUSTERED 
(
	[idChofer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grua]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grua](
	[idGrua] [int] IDENTITY(1,1) NOT NULL,
	[idChofer] [int] NULL,
	[ubicacion] [varchar](50) NOT NULL,
	[estadoGrua] [varchar](50) NOT NULL,
	[cantServiciosAtendidos] [int] NOT NULL,
 CONSTRAINT [PK_Grua] PRIMARY KEY CLUSTERED 
(
	[idGrua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfil]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfil](
	[idPerfil] [int] IDENTITY(1,1) NOT NULL,
	[nombrePerfil] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Perfiles_IdPerfil] PRIMARY KEY CLUSTERED 
(
	[idPerfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[nomUsuario] [varchar](15) NOT NULL,
	[pass] [varchar](15) NOT NULL,
	[estado] [bit] NOT NULL,
	[Intento] [int] NULL,
 CONSTRAINT [PK_Usuario_IdUsuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuariosPorPerfiles]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuariosPorPerfiles](
	[idUsuario] [int] NOT NULL,
	[idPerfil] [int] NOT NULL,
 CONSTRAINT [PK_UsuariosPorPerfiles] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC,
	[idPerfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Chofer] ([idChofer], [nombreChofer], [ingresoObtenido], [estadoChofer]) VALUES (0, N'Sin chofer', 0, 1)
INSERT [dbo].[Chofer] ([idChofer], [nombreChofer], [ingresoObtenido], [estadoChofer]) VALUES (1, N'Pablos', 0, 1)
INSERT [dbo].[Chofer] ([idChofer], [nombreChofer], [ingresoObtenido], [estadoChofer]) VALUES (2, N'jose', 0, 1)
INSERT [dbo].[Chofer] ([idChofer], [nombreChofer], [ingresoObtenido], [estadoChofer]) VALUES (3, N'Jose', 5000, 0)
INSERT [dbo].[Chofer] ([idChofer], [nombreChofer], [ingresoObtenido], [estadoChofer]) VALUES (4, N'Hans2', 0, 1)
INSERT [dbo].[Chofer] ([idChofer], [nombreChofer], [ingresoObtenido], [estadoChofer]) VALUES (5, N'pedro', 0, 1)
INSERT [dbo].[Chofer] ([idChofer], [nombreChofer], [ingresoObtenido], [estadoChofer]) VALUES (6, N'karen', 0, 0)
SET IDENTITY_INSERT [dbo].[Grua] ON 

INSERT [dbo].[Grua] ([idGrua], [idChofer], [ubicacion], [estadoGrua], [cantServiciosAtendidos]) VALUES (1, 0, N'Cartago', N'En espera', 0)
INSERT [dbo].[Grua] ([idGrua], [idChofer], [ubicacion], [estadoGrua], [cantServiciosAtendidos]) VALUES (3, 2, N'Heredia', N'En espera', 0)
INSERT [dbo].[Grua] ([idGrua], [idChofer], [ubicacion], [estadoGrua], [cantServiciosAtendidos]) VALUES (4, 3, N'San Jose', N'En espera', 0)
INSERT [dbo].[Grua] ([idGrua], [idChofer], [ubicacion], [estadoGrua], [cantServiciosAtendidos]) VALUES (5, 0, N'San jose', N'En espera', 0)
SET IDENTITY_INSERT [dbo].[Grua] OFF
SET IDENTITY_INSERT [dbo].[Perfil] ON 

INSERT [dbo].[Perfil] ([idPerfil], [nombrePerfil]) VALUES (1, N'Secretaria')
INSERT [dbo].[Perfil] ([idPerfil], [nombrePerfil]) VALUES (2, N'Reportes')
INSERT [dbo].[Perfil] ([idPerfil], [nombrePerfil]) VALUES (5, N'Administrador')
SET IDENTITY_INSERT [dbo].[Perfil] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([idUsuario], [nomUsuario], [pass], [estado], [Intento]) VALUES (1, N'Juanita', N'445566', 1, 1)
INSERT [dbo].[Usuario] ([idUsuario], [nomUsuario], [pass], [estado], [Intento]) VALUES (2, N'Hans', N'1234', 1, 0)
INSERT [dbo].[Usuario] ([idUsuario], [nomUsuario], [pass], [estado], [Intento]) VALUES (4, N'Juan', N'778899', 0, 0)
INSERT [dbo].[Usuario] ([idUsuario], [nomUsuario], [pass], [estado], [Intento]) VALUES (5, N'Pedro', N'1379', 0, 0)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
INSERT [dbo].[UsuariosPorPerfiles] ([idUsuario], [idPerfil]) VALUES (1, 1)
INSERT [dbo].[UsuariosPorPerfiles] ([idUsuario], [idPerfil]) VALUES (2, 2)
INSERT [dbo].[UsuariosPorPerfiles] ([idUsuario], [idPerfil]) VALUES (5, 5)
ALTER TABLE [dbo].[Caso]  WITH CHECK ADD  CONSTRAINT [FK_Grua_idGrua] FOREIGN KEY([idGrua])
REFERENCES [dbo].[Grua] ([idGrua])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Caso] CHECK CONSTRAINT [FK_Grua_idGrua]
GO
ALTER TABLE [dbo].[Grua]  WITH CHECK ADD  CONSTRAINT [FK_Grua_idChofer] FOREIGN KEY([idChofer])
REFERENCES [dbo].[Chofer] ([idChofer])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Grua] CHECK CONSTRAINT [FK_Grua_idChofer]
GO
ALTER TABLE [dbo].[UsuariosPorPerfiles]  WITH CHECK ADD  CONSTRAINT [FK_UsuariosPorPerfiles_IdPerfil] FOREIGN KEY([idPerfil])
REFERENCES [dbo].[Perfil] ([idPerfil])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[UsuariosPorPerfiles] CHECK CONSTRAINT [FK_UsuariosPorPerfiles_IdPerfil]
GO
ALTER TABLE [dbo].[UsuariosPorPerfiles]  WITH CHECK ADD  CONSTRAINT [FK_UsuariosPorPerfiles_IdUsuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[UsuariosPorPerfiles] CHECK CONSTRAINT [FK_UsuariosPorPerfiles_IdUsuario]
GO
/****** Object:  StoredProcedure [dbo].[PA_ActIntento]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[PA_ActIntento] 
@Usuario varchar(20)
as
begin
	update Usuario set Intento = Intento + 1
	where nomUsuario=@Usuario
end
GO
/****** Object:  StoredProcedure [dbo].[PA_Chofer_Update]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Chofer_Update]
	-- Add the parameters for the stored procedure here
@id int,
@chofer varchar (50),
@estado bit

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Chofer
	SET nombreChofer=@chofer, estadoChofer=@estado 
	WHERE idChofer = @id
END
GO
/****** Object:  StoredProcedure [dbo].[PA_Choferes_Add]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Choferes_Add]
	-- Add the parameters for the stored procedure here
@chofer varchar(50),
@estado bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert Chofer (nombreChofer,ingresoObtenido,estadoChofer) 
	values (@chofer,0,@estado)
END
GO
/****** Object:  StoredProcedure [dbo].[PA_Choferes_Consultar]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PA_Choferes_Consultar]  
@chofer varchar(50)  
AS  
BEGIN  
 -- SET NOCOUNT ON added to prevent extra result sets from  
 -- interfering with SELECT statements.  
 SET NOCOUNT ON;  
  
    -- Insert statements for procedure here  
 SELECT idChofer,nombreChofer, ingresoObtenido, estadoChofer
 FROM   Chofer

 WHERE  (LEN(@chofer) = 0 or nombreChofer = @chofer)  
END  
GO
/****** Object:  StoredProcedure [dbo].[PA_Choferes_Consuta_No_Relacionado]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Choferes_Consuta_No_Relacionado]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT DISTINCT c.idChofer, nombreChofer
	FROM  grua g 
	right join Chofer c 
	ON   (c.idChofer = g.idChofer)
	where g.idChofer is null AND C.estadoChofer = 1 OR g.idChofer = 0
END
GO
/****** Object:  StoredProcedure [dbo].[PA_Choferes_Relacionados]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Choferes_Relacionados]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT DISTINCT c.idChofer,c.nombreChofer
	from Grua g
	INNER JOIN Chofer c
	ON g.idChofer= c.idChofer
END
GO
/****** Object:  StoredProcedure [dbo].[PA_ConsultarAutenticacion]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[PA_ConsultarAutenticacion] 
@nomus varchar(15),
@passw varchar(15)
AS
BEGIN
	
	SELECT idUsuario,nomUsuario, pass, estado
	FROM Usuario
	WHERE nomUsuario = @nomus
	AND	  pass = @passw

END
GO
/****** Object:  StoredProcedure [dbo].[PA_ConsultarPerfilesUsuario]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PA_ConsultarPerfilesUsuario]
@nomusuario varchar(15)
as
begin
select p.idPerfil, p.nombrePerfil

from	   Usuario u
inner join UsuariosPorPerfiles uxp 
on		   u.idUsuario = uxp.idPerfil
inner join Perfil p	
on		   p.idPerfil = uxp.idPerfil

where u.nomUsuario = @nomusuario
end
GO
/****** Object:  StoredProcedure [dbo].[PA_ConsultarPPPPP]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[PA_ConsultarPPPPP]
@nomusuario varchar(15)
as
begin
select u.nomUsuario,u.pass,u.estado, p.nombrePerfil

from	   Usuario u
inner join UsuariosPorPerfiles uxp 
on		   u.idUsuario = uxp.idUsuario
inner join Perfil p	
on		   p.idPerfil = uxp.idPerfil

 where u.nomUsuario = @nomusuario
end
GO
/****** Object:  StoredProcedure [dbo].[PA_ConsultarUsuarioporEstado]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_ConsultarUsuarioporEstado]
@est int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
select u.nomUsuario,u.pass,u.estado, p.nombrePerfil

from	   Usuario u
inner join UsuariosPorPerfiles uxp 
on		   u.idUsuario = uxp.idUsuario
inner join Perfil p	
on		   p.idPerfil = uxp.idPerfil

where u.estado =@est


END
GO
/****** Object:  StoredProcedure [dbo].[PA_Grua_Update]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Grua_Update]
	-- Add the parameters for the stored procedure here
@idGrua int,
@idChofer int,
@ubicacion varchar (50),
@estado varchar  (50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Grua
	SET idChofer = @idChofer, ubicacion = @ubicacion, estadoGrua = @estado
	WHERE idGrua = @idGrua
END
GO
/****** Object:  StoredProcedure [dbo].[PA_Gruas_Add]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Gruas_Add]
	-- Add the parameters for the stored procedure here
@idChofer int,
@ubicacion varchar(50),
@estado varchar(50) 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert grua (idChofer,ubicacion,estadoGrua,cantServiciosAtendidos) 
	values (@idChofer,@ubicacion,@estado,0)
END
GO
/****** Object:  StoredProcedure [dbo].[PA_Gruas_Consulta]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Gruas_Consulta]
	-- Add the parameters for the stored procedure here
	@id int 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT idGrua, idChofer, ubicacion, estadoGrua, cantServiciosAtendidos 
	FROM Grua
	WHERE (idGrua <> @id)
END
GO
/****** Object:  StoredProcedure [dbo].[PA_Perfiles_Consultar]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Perfiles_Consultar]
@perfil varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT idPerfil, nombrePerfil 
	FROM   Perfil
	WHERE  (LEN(@perfil) = 0 or nombrePerfil = @perfil)
END

GO
/****** Object:  StoredProcedure [dbo].[PA_Perfiles_Eliminar]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Perfiles_Eliminar]
@perfil varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM Perfil
	WHERE nombrePerfil = @perfil
END
GO
/****** Object:  StoredProcedure [dbo].[PA_Perfiles_Insertar]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Perfiles_Insertar]
@nombPerfil varchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Perfil 
	(nombrePerfil) 
	VALUES 
	(@nombPerfil)
END
GO
/****** Object:  StoredProcedure [dbo].[PA_Perfiles_Modificar]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Perfiles_Modificar]
@nombPer varchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Perfil
	SET nombrePerfil =@nombPer
	WHERE nombrePerfil = @nombPer
END
GO
/****** Object:  StoredProcedure [dbo].[Pa_ResetIntento]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Pa_ResetIntento]
@Usuario varchar(20)
as
begin 
update Usuario set Intento =0
	where nomUsuario=@Usuario

end
GO
/****** Object:  StoredProcedure [dbo].[PA_Usuarios_Consultar]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Usuarios_Consultar]
@usuario varchar(15)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT idUsuario,nomUsuario, pass, estado
	FROM   Usuario
	WHERE  (LEN(@usuario) = 0 or nomUsuario = @usuario)
END
GO
/****** Object:  StoredProcedure [dbo].[PA_Usuarios_ConsultarId]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Usuarios_ConsultarId]
@usuario varchar(15)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT idUsuario
	FROM   Usuario
	WHERE  (LEN(@usuario) = 0 or nomUsuario = @usuario)
END
GO
/****** Object:  StoredProcedure [dbo].[PA_Usuarios_Eliminar]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Usuarios_Eliminar]
@usuario varchar(15)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM Usuario
	WHERE nomUsuario = @usuario
END
GO
/****** Object:  StoredProcedure [dbo].[PA_Usuarios_Insertar]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Usuarios_Insertar]
@usuario varchar(15),
@clave   varchar(15),
@estado  bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Usuario 
	(nomUsuario, pass,   estado) 
	VALUES 
	(@usuario,   @clave, @estado)
END
GO
/****** Object:  StoredProcedure [dbo].[PA_Usuarios_Modificar]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_Usuarios_Modificar]
@usuario varchar(15),
@clave   varchar(15),
@estado  bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Usuario
	SET nomUsuario=@usuario, pass = @clave, estado = @estado
	WHERE nomusuario = @usuario
END
GO
/****** Object:  StoredProcedure [dbo].[PA_UsuariosPorPerfiles_Consultar]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_UsuariosPorPerfiles_Consultar]
@idus int,
@idper int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT idUsuario,idPerfil
	FROM   UsuariosPorPerfiles
	WHERE  (LEN(@idus) = 0 and LEN(@idper) = 0    or idUsuario = @idus and idPerfil=@idper)
END
GO
/****** Object:  StoredProcedure [dbo].[PA_UsuariosPorPerfiles_Eliminar]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_UsuariosPorPerfiles_Eliminar]
@idU int 

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM UsuariosPorPerfiles
	WHERE idUsuario = @idU 
END
GO
/****** Object:  StoredProcedure [dbo].[PA_UsuariosPorPerfiles_Insertar]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_UsuariosPorPerfiles_Insertar]
@iU int,
@Ip   int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO UsuariosPorPerfiles 
	(idUsuario, idPerfil) 
	VALUES 
	(@iU,   @Ip)
END
GO
/****** Object:  StoredProcedure [dbo].[PA_UsuariosPorPerfiles_Modificar]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PA_UsuariosPorPerfiles_Modificar]
@Iu int,
@Ip   int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE UsuariosPorPerfiles
	SET idUsuario = @Iu, idPerfil = @Ip
	WHERE idUsuario = @Iu
END

GO
/****** Object:  StoredProcedure [dbo].[Pa_VerificarIntento]    Script Date: 22/3/2020 19:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Pa_VerificarIntento]
@Usuario varchar(50)
as
begin
select Intento from Usuario where nomUsuario=@Usuario 
end
GO
USE [master]
GO
ALTER DATABASE [SistemaDeGruas] SET  READ_WRITE 
GO
