USE [picoplaca]
GO
/****** Object:  Table [dbo].[Dias]    Script Date: 19/12/2016 18:12:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Dias](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Dia] [varchar](50) NULL,
	[Codigo] [varchar](50) NULL,
 CONSTRAINT [PK_Dias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Digito]    Script Date: 19/12/2016 18:12:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Digito](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Digito] [varchar](1) NULL,
	[CodigoDias] [varchar](50) NULL,
 CONSTRAINT [PK_Digito] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Horarios]    Script Date: 19/12/2016 18:12:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Horarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HoraInicio] [time](7) NULL,
	[HoraFin] [time](7) NULL,
	[TipoHora] [varchar](1) NULL,
 CONSTRAINT [PK_Horarios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Dias] ON 

INSERT [dbo].[Dias] ([Id], [Dia], [Codigo]) VALUES (1, N'Lunes', N'001')
INSERT [dbo].[Dias] ([Id], [Dia], [Codigo]) VALUES (2, N'Martes', N'002')
INSERT [dbo].[Dias] ([Id], [Dia], [Codigo]) VALUES (3, N'Miércoles', N'003')
INSERT [dbo].[Dias] ([Id], [Dia], [Codigo]) VALUES (4, N'Jueves', N'004')
INSERT [dbo].[Dias] ([Id], [Dia], [Codigo]) VALUES (5, N'Viernes', N'005')
SET IDENTITY_INSERT [dbo].[Dias] OFF
SET IDENTITY_INSERT [dbo].[Digito] ON 

INSERT [dbo].[Digito] ([Id], [Digito], [CodigoDias]) VALUES (1, N'1', N'001')
INSERT [dbo].[Digito] ([Id], [Digito], [CodigoDias]) VALUES (2, N'2', N'001')
INSERT [dbo].[Digito] ([Id], [Digito], [CodigoDias]) VALUES (3, N'3', N'002')
INSERT [dbo].[Digito] ([Id], [Digito], [CodigoDias]) VALUES (4, N'4', N'002')
INSERT [dbo].[Digito] ([Id], [Digito], [CodigoDias]) VALUES (5, N'5', N'003')
INSERT [dbo].[Digito] ([Id], [Digito], [CodigoDias]) VALUES (6, N'6', N'003')
INSERT [dbo].[Digito] ([Id], [Digito], [CodigoDias]) VALUES (7, N'7', N'004')
INSERT [dbo].[Digito] ([Id], [Digito], [CodigoDias]) VALUES (8, N'8', N'004')
INSERT [dbo].[Digito] ([Id], [Digito], [CodigoDias]) VALUES (9, N'9', N'005')
INSERT [dbo].[Digito] ([Id], [Digito], [CodigoDias]) VALUES (10, N'0', N'005')
SET IDENTITY_INSERT [dbo].[Digito] OFF
SET IDENTITY_INSERT [dbo].[Horarios] ON 

INSERT [dbo].[Horarios] ([Id], [HoraInicio], [HoraFin], [TipoHora]) VALUES (1, CAST(0x0700D85EAC3A0000 AS Time), CAST(0x0700DCC9A04F0000 AS Time), N'M')
INSERT [dbo].[Horarios] ([Id], [HoraInicio], [HoraFin], [TipoHora]) VALUES (2, CAST(0x070080461C860000 AS Time), CAST(0x0700EC7572A30000 AS Time), N'T')
SET IDENTITY_INSERT [dbo].[Horarios] OFF
