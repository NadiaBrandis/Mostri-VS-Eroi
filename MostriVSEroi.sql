USE [master]
GO
/****** Object:  Database [MostriVSEroi1]    Script Date: 18/06/2021 14:02:46 ******/
CREATE DATABASE [MostriVSEroi1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MostriVSEroi1', FILENAME = N'C:\Users\39347\MostriVSEroi1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MostriVSEroi1_log', FILENAME = N'C:\Users\39347\MostriVSEroi1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [MostriVSEroi1] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MostriVSEroi1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MostriVSEroi1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MostriVSEroi1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MostriVSEroi1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MostriVSEroi1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MostriVSEroi1] SET ARITHABORT OFF 
GO
ALTER DATABASE [MostriVSEroi1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MostriVSEroi1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MostriVSEroi1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MostriVSEroi1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MostriVSEroi1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MostriVSEroi1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MostriVSEroi1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MostriVSEroi1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MostriVSEroi1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MostriVSEroi1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MostriVSEroi1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MostriVSEroi1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MostriVSEroi1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MostriVSEroi1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MostriVSEroi1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MostriVSEroi1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MostriVSEroi1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MostriVSEroi1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MostriVSEroi1] SET  MULTI_USER 
GO
ALTER DATABASE [MostriVSEroi1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MostriVSEroi1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MostriVSEroi1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MostriVSEroi1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MostriVSEroi1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MostriVSEroi1] SET QUERY_STORE = OFF
GO
USE [MostriVSEroi1]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [MostriVSEroi1]
GO
/****** Object:  Table [dbo].[Utenti]    Script Date: 18/06/2021 14:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Utenti](
	[IdUtente] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](30) NOT NULL,
	[Password] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Utenti] PRIMARY KEY CLUSTERED 
(
	[IdUtente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LivelloUtente]    Script Date: 18/06/2021 14:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LivelloUtente](
	[IdUtente] [int] NOT NULL,
	[Livello] [int] NOT NULL,
	[PuntiVita] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VistaUtenteLivelloPuntiVita]    Script Date: 18/06/2021 14:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VistaUtenteLivelloPuntiVita]
AS
SELECT        dbo.Utenti.*, dbo.LivelloUtente.Livello, dbo.LivelloUtente.PuntiVita
FROM            dbo.Utenti INNER JOIN
                         dbo.LivelloUtente ON dbo.Utenti.IdUtente = dbo.LivelloUtente.IdUtente
GO
/****** Object:  Table [dbo].[ArmiEroi]    Script Date: 18/06/2021 14:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ArmiEroi](
	[NomeArma] [nvarchar](30) NOT NULL,
	[PuntiDanno] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_ArmiEroi] PRIMARY KEY CLUSTERED 
(
	[NomeArma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Eroi]    Script Date: 18/06/2021 14:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Eroi](
	[IdEroe] [int] IDENTITY(1,1) NOT NULL,
	[NomeEroe] [nvarchar](30) NOT NULL,
	[Categoria] [nvarchar](30) NOT NULL,
	[NomeArma] [nvarchar](30) NOT NULL,
	[LivelloEroe] [int] NULL,
	[PuntiVita] [int] NULL,
 CONSTRAINT [PK_Eroi] PRIMARY KEY CLUSTERED 
(
	[IdEroe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VistaEroiArmi]    Script Date: 18/06/2021 14:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VistaEroiArmi]
AS
SELECT        dbo.Eroi.NomeEroe, dbo.Eroi.Categoria, dbo.Eroi.NomeArma, dbo.ArmiEroi.PuntiDanno, dbo.Eroi.IdEroe, dbo.Eroi.LivelloEroe, dbo.Eroi.PuntiVita
FROM            dbo.ArmiEroi INNER JOIN
                         dbo.Eroi ON dbo.ArmiEroi.NomeArma = dbo.Eroi.NomeArma
GO
/****** Object:  Table [dbo].[Mostri]    Script Date: 18/06/2021 14:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mostri](
	[IdMostro] [int] IDENTITY(1,1) NOT NULL,
	[NomeMostro] [nvarchar](30) NOT NULL,
	[Categoria] [nvarchar](30) NOT NULL,
	[NomeArma] [nvarchar](30) NOT NULL,
	[PuntiVita] [int] NULL,
	[LivelloMostro] [int] NULL,
 CONSTRAINT [PK_Mostri] PRIMARY KEY CLUSTERED 
(
	[IdMostro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ArmiMostri]    Script Date: 18/06/2021 14:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ArmiMostri](
	[NomeArma] [nvarchar](30) NOT NULL,
	[PuntiDanno] [int] NOT NULL,
 CONSTRAINT [PK_ArmiMostri] PRIMARY KEY CLUSTERED 
(
	[NomeArma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VistaMostriArmi]    Script Date: 18/06/2021 14:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VistaMostriArmi]
AS
SELECT        dbo.Mostri.NomeMostro, dbo.Mostri.Categoria, dbo.Mostri.NomeArma, dbo.Mostri.PuntiVita, dbo.ArmiMostri.PuntiDanno
FROM            dbo.Mostri INNER JOIN
                         dbo.ArmiMostri ON dbo.Mostri.NomeArma = dbo.ArmiMostri.NomeArma
GO
/****** Object:  Table [dbo].[AssociazioneUtenteEroe]    Script Date: 18/06/2021 14:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AssociazioneUtenteEroe](
	[IdUtente] [int] NOT NULL,
	[IdEroe] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VistaPuntiVitaUtenteDannoArma]    Script Date: 18/06/2021 14:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VistaPuntiVitaUtenteDannoArma]
AS
SELECT        dbo.AssociazioneUtenteEroe.IdUtente, dbo.AssociazioneUtenteEroe.IdEroe, dbo.VistaUtenteLivelloPuntiVita.PuntiVita, dbo.Eroi.NomeArma, dbo.ArmiEroi.PuntiDanno
FROM            dbo.Eroi INNER JOIN
                         dbo.AssociazioneUtenteEroe ON dbo.Eroi.IdEroe = dbo.AssociazioneUtenteEroe.IdEroe INNER JOIN
                         dbo.ArmiEroi ON dbo.Eroi.NomeArma = dbo.ArmiEroi.NomeArma CROSS JOIN
                         dbo.VistaUtenteLivelloPuntiVita
GO
/****** Object:  View [dbo].[VistaUtentiCompleta]    Script Date: 18/06/2021 14:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VistaUtentiCompleta]
AS
SELECT        dbo.Utenti.IdUtente, dbo.Utenti.Username, dbo.Utenti.Password, dbo.LivelloUtente.Livello, dbo.LivelloUtente.PuntiVita
FROM            dbo.Utenti INNER JOIN
                         dbo.LivelloUtente ON dbo.Utenti.IdUtente = dbo.LivelloUtente.IdUtente
GO
/****** Object:  View [dbo].[VistaUtentiEroi]    Script Date: 18/06/2021 14:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VistaUtentiEroi]
AS
SELECT        dbo.Utenti.IdUtente, dbo.Eroi.IdEroe, dbo.VistaEroiArmi.NomeEroe, dbo.VistaEroiArmi.Categoria, dbo.VistaEroiArmi.NomeArma, dbo.VistaEroiArmi.PuntiDanno, dbo.VistaEroiArmi.LivelloEroe, dbo.VistaEroiArmi.PuntiVita
FROM            dbo.Utenti INNER JOIN
                         dbo.AssociazioneUtenteEroe ON dbo.Utenti.IdUtente = dbo.AssociazioneUtenteEroe.IdUtente INNER JOIN
                         dbo.Eroi ON dbo.AssociazioneUtenteEroe.IdEroe = dbo.Eroi.IdEroe INNER JOIN
                         dbo.VistaEroiArmi ON dbo.Eroi.IdEroe = dbo.VistaEroiArmi.IdEroe
GO
INSERT [dbo].[ArmiEroi] ([NomeArma], [PuntiDanno]) VALUES (N'Alabarda', N'15')
INSERT [dbo].[ArmiEroi] ([NomeArma], [PuntiDanno]) VALUES (N'Ascia', N'8')
INSERT [dbo].[ArmiEroi] ([NomeArma], [PuntiDanno]) VALUES (N'Bacchetta', N'5')
GO
INSERT [dbo].[ArmiMostri] ([NomeArma], [PuntiDanno]) VALUES (N'Arco', 7)
INSERT [dbo].[ArmiMostri] ([NomeArma], [PuntiDanno]) VALUES (N'Clava', 5)
INSERT [dbo].[ArmiMostri] ([NomeArma], [PuntiDanno]) VALUES (N'Divinazione ', 15)
GO
INSERT [dbo].[AssociazioneUtenteEroe] ([IdUtente], [IdEroe]) VALUES (1, 3)
INSERT [dbo].[AssociazioneUtenteEroe] ([IdUtente], [IdEroe]) VALUES (4, 4)
INSERT [dbo].[AssociazioneUtenteEroe] ([IdUtente], [IdEroe]) VALUES (3, 5)
GO
SET IDENTITY_INSERT [dbo].[Eroi] ON 

INSERT [dbo].[Eroi] ([IdEroe], [NomeEroe], [Categoria], [NomeArma], [LivelloEroe], [PuntiVita]) VALUES (3, N'Guerriero Alato', N'Guerriero', N'Alabarda', 1, 20)
INSERT [dbo].[Eroi] ([IdEroe], [NomeEroe], [Categoria], [NomeArma], [LivelloEroe], [PuntiVita]) VALUES (4, N'Nano Assassino', N'Guerriero', N'Ascia', 3, 40)
INSERT [dbo].[Eroi] ([IdEroe], [NomeEroe], [Categoria], [NomeArma], [LivelloEroe], [PuntiVita]) VALUES (5, N'Gandalf', N'Mago', N'bacchetta', 2, 38)
INSERT [dbo].[Eroi] ([IdEroe], [NomeEroe], [Categoria], [NomeArma], [LivelloEroe], [PuntiVita]) VALUES (6, N'Achille', N'Guerriero', N'Ascia', 2, 40)
SET IDENTITY_INSERT [dbo].[Eroi] OFF
GO
INSERT [dbo].[LivelloUtente] ([IdUtente], [Livello], [PuntiVita]) VALUES (1, 2, 40)
GO
SET IDENTITY_INSERT [dbo].[Mostri] ON 

INSERT [dbo].[Mostri] ([IdMostro], [NomeMostro], [Categoria], [NomeArma], [PuntiVita], [LivelloMostro]) VALUES (1, N'Orco delle paludi', N'Orco', N'Clava', 20, 1)
INSERT [dbo].[Mostri] ([IdMostro], [NomeMostro], [Categoria], [NomeArma], [PuntiVita], [LivelloMostro]) VALUES (2, N'Nano Peloso', N'Orco', N'Arco', 30, 2)
INSERT [dbo].[Mostri] ([IdMostro], [NomeMostro], [Categoria], [NomeArma], [PuntiVita], [LivelloMostro]) VALUES (3, N'Saruman', N'Signore del male', N'Divinazione', 40, 3)
SET IDENTITY_INSERT [dbo].[Mostri] OFF
GO
SET IDENTITY_INSERT [dbo].[Utenti] ON 

INSERT [dbo].[Utenti] ([IdUtente], [Username], [Password]) VALUES (1, N'N.bra', N'1234')
INSERT [dbo].[Utenti] ([IdUtente], [Username], [Password]) VALUES (2, N'Gino', N'4567')
INSERT [dbo].[Utenti] ([IdUtente], [Username], [Password]) VALUES (3, N'Mila', N'1234')
INSERT [dbo].[Utenti] ([IdUtente], [Username], [Password]) VALUES (4, N'Bla', N'1234')
INSERT [dbo].[Utenti] ([IdUtente], [Username], [Password]) VALUES (5, N'Pino', N'8765')
INSERT [dbo].[Utenti] ([IdUtente], [Username], [Password]) VALUES (6, N'Pippo', N'1234')
INSERT [dbo].[Utenti] ([IdUtente], [Username], [Password]) VALUES (7, N'V.bra', N'1234')
INSERT [dbo].[Utenti] ([IdUtente], [Username], [Password]) VALUES (8, N'B.bagh', N'1234')
INSERT [dbo].[Utenti] ([IdUtente], [Username], [Password]) VALUES (9, N'G.ina', N'1234')
INSERT [dbo].[Utenti] ([IdUtente], [Username], [Password]) VALUES (10, N'Pippo', N'1234')
SET IDENTITY_INSERT [dbo].[Utenti] OFF
GO
ALTER TABLE [dbo].[AssociazioneUtenteEroe]  WITH CHECK ADD  CONSTRAINT [FK_AssociazioneUtenteEroe_Eroi] FOREIGN KEY([IdEroe])
REFERENCES [dbo].[Eroi] ([IdEroe])
GO
ALTER TABLE [dbo].[AssociazioneUtenteEroe] CHECK CONSTRAINT [FK_AssociazioneUtenteEroe_Eroi]
GO
ALTER TABLE [dbo].[AssociazioneUtenteEroe]  WITH CHECK ADD  CONSTRAINT [FK_AssociazioneUtenteEroe_Utenti] FOREIGN KEY([IdUtente])
REFERENCES [dbo].[Utenti] ([IdUtente])
GO
ALTER TABLE [dbo].[AssociazioneUtenteEroe] CHECK CONSTRAINT [FK_AssociazioneUtenteEroe_Utenti]
GO
ALTER TABLE [dbo].[Eroi]  WITH CHECK ADD  CONSTRAINT [FK_Eroi_ArmiEroi] FOREIGN KEY([NomeArma])
REFERENCES [dbo].[ArmiEroi] ([NomeArma])
GO
ALTER TABLE [dbo].[Eroi] CHECK CONSTRAINT [FK_Eroi_ArmiEroi]
GO
ALTER TABLE [dbo].[LivelloUtente]  WITH CHECK ADD  CONSTRAINT [FK_LivelloUtente_Utenti] FOREIGN KEY([IdUtente])
REFERENCES [dbo].[Utenti] ([IdUtente])
GO
ALTER TABLE [dbo].[LivelloUtente] CHECK CONSTRAINT [FK_LivelloUtente_Utenti]
GO
ALTER TABLE [dbo].[Mostri]  WITH CHECK ADD  CONSTRAINT [FK_Mostri_ArmiMostri] FOREIGN KEY([NomeArma])
REFERENCES [dbo].[ArmiMostri] ([NomeArma])
GO
ALTER TABLE [dbo].[Mostri] CHECK CONSTRAINT [FK_Mostri_ArmiMostri]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[14] 2[5] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ArmiEroi"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 228
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Eroi"
            Begin Extent = 
               Top = 6
               Left = 266
               Bottom = 136
               Right = 550
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaEroiArmi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaEroiArmi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[8] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Mostri"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 228
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "ArmiMostri"
            Begin Extent = 
               Top = 50
               Left = 457
               Bottom = 146
               Right = 647
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaMostriArmi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaMostriArmi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[27] 2[6] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Eroi"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 228
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "VistaUtenteLivelloPuntiVita"
            Begin Extent = 
               Top = 6
               Left = 266
               Bottom = 136
               Right = 456
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "AssociazioneUtenteEroe"
            Begin Extent = 
               Top = 6
               Left = 494
               Bottom = 102
               Right = 684
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ArmiEroi"
            Begin Extent = 
               Top = 102
               Left = 494
               Bottom = 198
               Right = 684
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
  ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaPuntiVitaUtenteDannoArma'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'       Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaPuntiVitaUtenteDannoArma'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaPuntiVitaUtenteDannoArma'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[44] 4[18] 2[11] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Utenti"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 228
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LivelloUtente"
            Begin Extent = 
               Top = 6
               Left = 266
               Bottom = 119
               Right = 456
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaUtenteLivelloPuntiVita'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaUtenteLivelloPuntiVita'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[19] 2[5] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Utenti"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 228
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LivelloUtente"
            Begin Extent = 
               Top = 6
               Left = 266
               Bottom = 119
               Right = 456
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaUtentiCompleta'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaUtentiCompleta'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[32] 4[5] 2[5] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Utenti"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 228
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "AssociazioneUtenteEroe"
            Begin Extent = 
               Top = 6
               Left = 266
               Bottom = 102
               Right = 456
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Eroi"
            Begin Extent = 
               Top = 6
               Left = 494
               Bottom = 136
               Right = 684
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "VistaEroiArmi"
            Begin Extent = 
               Top = 12
               Left = 252
               Bottom = 142
               Right = 442
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaUtentiEroi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaUtentiEroi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaUtentiEroi'
GO
USE [master]
GO
ALTER DATABASE [MostriVSEroi1] SET  READ_WRITE 
GO
