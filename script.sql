USE [master]
GO
/****** Object:  Database [AriplaneDB]    Script Date: 5/19/2016 6:58:17 PM ******/
CREATE DATABASE [AriplaneDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AriplaneDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\AriplaneDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'AriplaneDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\AriplaneDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [AriplaneDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AriplaneDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AriplaneDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AriplaneDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AriplaneDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AriplaneDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AriplaneDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [AriplaneDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AriplaneDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AriplaneDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AriplaneDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AriplaneDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AriplaneDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AriplaneDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AriplaneDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AriplaneDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AriplaneDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AriplaneDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AriplaneDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AriplaneDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AriplaneDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AriplaneDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AriplaneDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AriplaneDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AriplaneDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AriplaneDB] SET  MULTI_USER 
GO
ALTER DATABASE [AriplaneDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AriplaneDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AriplaneDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AriplaneDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [AriplaneDB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [AriplaneDB]
GO
/****** Object:  Table [dbo].[tbl_BookingDetail]    Script Date: 5/19/2016 6:58:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_BookingDetail](
	[id_booking] [int] NOT NULL,
	[id_customer] [int] NOT NULL,
	[no_seat] [varchar](5) NOT NULL,
	[id_consumption] [int] NOT NULL,
	[quantity] [int] NOT NULL,
 CONSTRAINT [PK_tbl_BookingDetail] PRIMARY KEY CLUSTERED 
(
	[id_booking] ASC,
	[id_customer] ASC,
	[id_consumption] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_BookingMaster]    Script Date: 5/19/2016 6:58:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_BookingMaster](
	[id_booking] [int] IDENTITY(1,1) NOT NULL,
	[date_booking] [datetime] NOT NULL,
	[id_schedule] [varchar](50) NOT NULL,
	[total_price] [float] NOT NULL,
 CONSTRAINT [PK_tbl_BookingMaster] PRIMARY KEY CLUSTERED 
(
	[id_booking] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Class]    Script Date: 5/19/2016 6:58:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Class](
	[id_class] [int] IDENTITY(1,1) NOT NULL,
	[name_class] [varchar](100) NOT NULL,
	[price_class] [float] NOT NULL,
 CONSTRAINT [PK_tbl_Class] PRIMARY KEY CLUSTERED 
(
	[id_class] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Consumption]    Script Date: 5/19/2016 6:58:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Consumption](
	[id_consumption] [int] IDENTITY(1,1) NOT NULL,
	[name_consumption] [varchar](100) NOT NULL,
	[price_consumption] [float] NOT NULL,
 CONSTRAINT [PK_tbl_Consumption] PRIMARY KEY CLUSTERED 
(
	[id_consumption] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Customer]    Script Date: 5/19/2016 6:58:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Customer](
	[id_customer] [int] NOT NULL,
	[name_customer] [varchar](100) NOT NULL,
	[address_customer] [text] NOT NULL,
	[email_customer] [varchar](100) NOT NULL,
	[phonenumber_customer] [varchar](20) NOT NULL,
 CONSTRAINT [PK_tbl_Customer] PRIMARY KEY CLUSTERED 
(
	[id_customer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Place]    Script Date: 5/19/2016 6:58:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Place](
	[id_place] [int] IDENTITY(1,1) NOT NULL,
	[name_place] [varchar](100) NOT NULL,
 CONSTRAINT [PK_tbl_Place] PRIMARY KEY CLUSTERED 
(
	[id_place] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Plane]    Script Date: 5/19/2016 6:58:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Plane](
	[id_plane] [int] NOT NULL,
	[name_plane] [varchar](100) NOT NULL,
	[seat_plane] [int] NOT NULL,
	[id_class] [int] NULL,
	[price_plane] [float] NOT NULL,
 CONSTRAINT [PK_tbl_Plane_1] PRIMARY KEY CLUSTERED 
(
	[id_plane] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Route]    Script Date: 5/19/2016 6:58:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Route](
	[id_route] [int] IDENTITY(1,1) NOT NULL,
	[departure_place] [int] NOT NULL,
	[arrival_place] [int] NOT NULL,
 CONSTRAINT [PK_tbl_Route] PRIMARY KEY CLUSTERED 
(
	[id_route] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Schedule]    Script Date: 5/19/2016 6:58:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Schedule](
	[id_schedule] [varchar](50) NOT NULL,
	[price] [float] NOT NULL,
	[total_seat] [int] NOT NULL,
	[date] [datetime] NOT NULL,
	[arrival_date] [datetime] NOT NULL,
	[id_plane] [int] NOT NULL,
	[departure_origin] [int] NOT NULL,
	[arrival_origin] [int] NOT NULL,
 CONSTRAINT [PK_tbl_Schedule] PRIMARY KEY CLUSTERED 
(
	[id_schedule] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_ScheduleDetail]    Script Date: 5/19/2016 6:58:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ScheduleDetail](
	[id_schedule] [varchar](50) NOT NULL,
	[id_route] [int] NOT NULL,
 CONSTRAINT [PK_tbl_ScheduleDetail] PRIMARY KEY CLUSTERED 
(
	[id_schedule] ASC,
	[id_route] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbl_BookingDetail] ([id_booking], [id_customer], [no_seat], [id_consumption], [quantity]) VALUES (4, 2131245123, N'C12', 1, 5)
INSERT [dbo].[tbl_BookingDetail] ([id_booking], [id_customer], [no_seat], [id_consumption], [quantity]) VALUES (5, 123456789, N'B8', 1, 5)
INSERT [dbo].[tbl_BookingDetail] ([id_booking], [id_customer], [no_seat], [id_consumption], [quantity]) VALUES (5, 987654321, N'C5', 3, 2)
INSERT [dbo].[tbl_BookingDetail] ([id_booking], [id_customer], [no_seat], [id_consumption], [quantity]) VALUES (5, 2131245123, N'E10', 2, 2)
INSERT [dbo].[tbl_BookingDetail] ([id_booking], [id_customer], [no_seat], [id_consumption], [quantity]) VALUES (6, 2131245123, N'D13', 3, 5)
SET IDENTITY_INSERT [dbo].[tbl_BookingMaster] ON 

INSERT [dbo].[tbl_BookingMaster] ([id_booking], [date_booking], [id_schedule], [total_price]) VALUES (2, CAST(N'2016-05-17 15:07:04.930' AS DateTime), N'SCH-00001', 1525000)
INSERT [dbo].[tbl_BookingMaster] ([id_booking], [date_booking], [id_schedule], [total_price]) VALUES (3, CAST(N'2016-05-17 15:09:16.713' AS DateTime), N'SCH-00001', 1525000)
INSERT [dbo].[tbl_BookingMaster] ([id_booking], [date_booking], [id_schedule], [total_price]) VALUES (4, CAST(N'2016-05-17 15:11:48.467' AS DateTime), N'SCH-00001', 1525000)
INSERT [dbo].[tbl_BookingMaster] ([id_booking], [date_booking], [id_schedule], [total_price]) VALUES (5, CAST(N'2016-05-17 15:17:52.840' AS DateTime), N'SCH-00001', 1605000)
INSERT [dbo].[tbl_BookingMaster] ([id_booking], [date_booking], [id_schedule], [total_price]) VALUES (6, CAST(N'2016-05-19 09:30:31.830' AS DateTime), N'SCH-00001', 1500000)
SET IDENTITY_INSERT [dbo].[tbl_BookingMaster] OFF
SET IDENTITY_INSERT [dbo].[tbl_Class] ON 

INSERT [dbo].[tbl_Class] ([id_class], [name_class], [price_class]) VALUES (5, N'Economy', 1200000)
SET IDENTITY_INSERT [dbo].[tbl_Class] OFF
SET IDENTITY_INSERT [dbo].[tbl_Consumption] ON 

INSERT [dbo].[tbl_Consumption] ([id_consumption], [name_consumption], [price_consumption]) VALUES (1, N'Nasi Padang', 25000)
INSERT [dbo].[tbl_Consumption] ([id_consumption], [name_consumption], [price_consumption]) VALUES (2, N'Nasi Ramen', 20000)
INSERT [dbo].[tbl_Consumption] ([id_consumption], [name_consumption], [price_consumption]) VALUES (3, N'Nasi Uduk', 20000)
SET IDENTITY_INSERT [dbo].[tbl_Consumption] OFF
INSERT [dbo].[tbl_Customer] ([id_customer], [name_customer], [address_customer], [email_customer], [phonenumber_customer]) VALUES (123456789, N'Jono Joni', N'Bogor', N'jonojoni@gmail.com', N'081291665400')
INSERT [dbo].[tbl_Customer] ([id_customer], [name_customer], [address_customer], [email_customer], [phonenumber_customer]) VALUES (344342876, N'Manuk Dadali', N'Jakarta', N'manuk@gmail.com', N'9081212')
INSERT [dbo].[tbl_Customer] ([id_customer], [name_customer], [address_customer], [email_customer], [phonenumber_customer]) VALUES (987654321, N'Jino Joni', N'Bogor', N'jinojoni@gmail.com', N'081291665400')
INSERT [dbo].[tbl_Customer] ([id_customer], [name_customer], [address_customer], [email_customer], [phonenumber_customer]) VALUES (2131245123, N'Muchammad Ilham', N'Jakarta', N'muh.ilham0606@gmail.com', N'081291665400')
SET IDENTITY_INSERT [dbo].[tbl_Place] ON 

INSERT [dbo].[tbl_Place] ([id_place], [name_place]) VALUES (3, N'Bali')
INSERT [dbo].[tbl_Place] ([id_place], [name_place]) VALUES (4, N'Surabaya')
INSERT [dbo].[tbl_Place] ([id_place], [name_place]) VALUES (5, N'Jakarta')
INSERT [dbo].[tbl_Place] ([id_place], [name_place]) VALUES (6, N'Ambon')
INSERT [dbo].[tbl_Place] ([id_place], [name_place]) VALUES (7, N'Makassar')
SET IDENTITY_INSERT [dbo].[tbl_Place] OFF
INSERT [dbo].[tbl_Plane] ([id_plane], [name_plane], [seat_plane], [id_class], [price_plane]) VALUES (231231, N'Garuda Indonesia', 100, 5, 0)
SET IDENTITY_INSERT [dbo].[tbl_Route] ON 

INSERT [dbo].[tbl_Route] ([id_route], [departure_place], [arrival_place]) VALUES (1, 5, 3)
INSERT [dbo].[tbl_Route] ([id_route], [departure_place], [arrival_place]) VALUES (2, 4, 3)
INSERT [dbo].[tbl_Route] ([id_route], [departure_place], [arrival_place]) VALUES (3, 3, 7)
INSERT [dbo].[tbl_Route] ([id_route], [departure_place], [arrival_place]) VALUES (4, 7, 6)
SET IDENTITY_INSERT [dbo].[tbl_Route] OFF
INSERT [dbo].[tbl_Schedule] ([id_schedule], [price], [total_seat], [date], [arrival_date], [id_plane], [departure_origin], [arrival_origin]) VALUES (N'SCH-00001', 1400000, 100, CAST(N'2016-05-20 14:00:52.000' AS DateTime), CAST(N'2016-05-17 16:13:58.897' AS DateTime), 231231, 5, 6)
INSERT [dbo].[tbl_ScheduleDetail] ([id_schedule], [id_route]) VALUES (N'SCH-00001', 1)
INSERT [dbo].[tbl_ScheduleDetail] ([id_schedule], [id_route]) VALUES (N'SCH-00001', 2)
INSERT [dbo].[tbl_ScheduleDetail] ([id_schedule], [id_route]) VALUES (N'SCH-00001', 3)
ALTER TABLE [dbo].[tbl_BookingDetail]  WITH CHECK ADD  CONSTRAINT [FK_tbl_BookingDetail_tbl_BookingMaster] FOREIGN KEY([id_booking])
REFERENCES [dbo].[tbl_BookingMaster] ([id_booking])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_BookingDetail] CHECK CONSTRAINT [FK_tbl_BookingDetail_tbl_BookingMaster]
GO
ALTER TABLE [dbo].[tbl_BookingDetail]  WITH CHECK ADD  CONSTRAINT [FK_tbl_BookingDetail_tbl_Consumption] FOREIGN KEY([id_consumption])
REFERENCES [dbo].[tbl_Consumption] ([id_consumption])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_BookingDetail] CHECK CONSTRAINT [FK_tbl_BookingDetail_tbl_Consumption]
GO
ALTER TABLE [dbo].[tbl_BookingDetail]  WITH CHECK ADD  CONSTRAINT [FK_tbl_BookingDetail_tbl_Customer] FOREIGN KEY([id_customer])
REFERENCES [dbo].[tbl_Customer] ([id_customer])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_BookingDetail] CHECK CONSTRAINT [FK_tbl_BookingDetail_tbl_Customer]
GO
ALTER TABLE [dbo].[tbl_BookingMaster]  WITH CHECK ADD  CONSTRAINT [FK_tbl_BookingMaster_tbl_Schedule] FOREIGN KEY([id_schedule])
REFERENCES [dbo].[tbl_Schedule] ([id_schedule])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_BookingMaster] CHECK CONSTRAINT [FK_tbl_BookingMaster_tbl_Schedule]
GO
ALTER TABLE [dbo].[tbl_Plane]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Plane_tbl_Class] FOREIGN KEY([id_class])
REFERENCES [dbo].[tbl_Class] ([id_class])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[tbl_Plane] CHECK CONSTRAINT [FK_tbl_Plane_tbl_Class]
GO
ALTER TABLE [dbo].[tbl_Route]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Route_tbl_Place] FOREIGN KEY([departure_place])
REFERENCES [dbo].[tbl_Place] ([id_place])
GO
ALTER TABLE [dbo].[tbl_Route] CHECK CONSTRAINT [FK_tbl_Route_tbl_Place]
GO
ALTER TABLE [dbo].[tbl_Route]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Route_tbl_Place1] FOREIGN KEY([arrival_place])
REFERENCES [dbo].[tbl_Place] ([id_place])
GO
ALTER TABLE [dbo].[tbl_Route] CHECK CONSTRAINT [FK_tbl_Route_tbl_Place1]
GO
ALTER TABLE [dbo].[tbl_Schedule]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Schedule_tbl_Place] FOREIGN KEY([departure_origin])
REFERENCES [dbo].[tbl_Place] ([id_place])
GO
ALTER TABLE [dbo].[tbl_Schedule] CHECK CONSTRAINT [FK_tbl_Schedule_tbl_Place]
GO
ALTER TABLE [dbo].[tbl_Schedule]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Schedule_tbl_Place1] FOREIGN KEY([arrival_origin])
REFERENCES [dbo].[tbl_Place] ([id_place])
GO
ALTER TABLE [dbo].[tbl_Schedule] CHECK CONSTRAINT [FK_tbl_Schedule_tbl_Place1]
GO
ALTER TABLE [dbo].[tbl_Schedule]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Schedule_tbl_Plane] FOREIGN KEY([id_plane])
REFERENCES [dbo].[tbl_Plane] ([id_plane])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Schedule] CHECK CONSTRAINT [FK_tbl_Schedule_tbl_Plane]
GO
ALTER TABLE [dbo].[tbl_ScheduleDetail]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ScheduleDetail_tbl_Route] FOREIGN KEY([id_route])
REFERENCES [dbo].[tbl_Route] ([id_route])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_ScheduleDetail] CHECK CONSTRAINT [FK_tbl_ScheduleDetail_tbl_Route]
GO
ALTER TABLE [dbo].[tbl_ScheduleDetail]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ScheduleDetail_tbl_Schedule] FOREIGN KEY([id_schedule])
REFERENCES [dbo].[tbl_Schedule] ([id_schedule])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_ScheduleDetail] CHECK CONSTRAINT [FK_tbl_ScheduleDetail_tbl_Schedule]
GO
ALTER TABLE [dbo].[tbl_BookingDetail]  WITH CHECK ADD  CONSTRAINT [CK_ID_BOOKING] CHECK  (([id_booking] like replicate('%[0-9]%',len([id_booking]))))
GO
ALTER TABLE [dbo].[tbl_BookingDetail] CHECK CONSTRAINT [CK_ID_BOOKING]
GO
ALTER TABLE [dbo].[tbl_BookingDetail]  WITH CHECK ADD  CONSTRAINT [CK_ID_CONSUMPTION] CHECK  (([id_consumption] like replicate('%[0-9]%',len([id_consumption]))))
GO
ALTER TABLE [dbo].[tbl_BookingDetail] CHECK CONSTRAINT [CK_ID_CONSUMPTION]
GO
ALTER TABLE [dbo].[tbl_BookingDetail]  WITH CHECK ADD  CONSTRAINT [CK_ID_CUSTOMER] CHECK  (([id_customer] like replicate('%[0-9]%',len([id_customer]))))
GO
ALTER TABLE [dbo].[tbl_BookingDetail] CHECK CONSTRAINT [CK_ID_CUSTOMER]
GO
ALTER TABLE [dbo].[tbl_Customer]  WITH CHECK ADD  CONSTRAINT [CK_EMAIL_CUSTOMER] CHECK  (([email_customer] like '_%@_%._%'))
GO
ALTER TABLE [dbo].[tbl_Customer] CHECK CONSTRAINT [CK_EMAIL_CUSTOMER]
GO
ALTER TABLE [dbo].[tbl_Customer]  WITH CHECK ADD  CONSTRAINT [CK_PHONENUMBER_CUSTOMER] CHECK  (([phonenumber_customer] like replicate('%[0-9]%',len([phonenumber_customer]))))
GO
ALTER TABLE [dbo].[tbl_Customer] CHECK CONSTRAINT [CK_PHONENUMBER_CUSTOMER]
GO
ALTER TABLE [dbo].[tbl_Customer]  WITH CHECK ADD  CONSTRAINT [CK_PK_ID_CUSTOMER] CHECK  (([id_customer] like replicate('%[0-9]%',len([id_customer]))))
GO
ALTER TABLE [dbo].[tbl_Customer] CHECK CONSTRAINT [CK_PK_ID_CUSTOMER]
GO
ALTER TABLE [dbo].[tbl_Plane]  WITH CHECK ADD  CONSTRAINT [CK_ID_CLASS] CHECK  (([id_class] like replicate('%[0-9]%',len([id_class]))))
GO
ALTER TABLE [dbo].[tbl_Plane] CHECK CONSTRAINT [CK_ID_CLASS]
GO
ALTER TABLE [dbo].[tbl_Plane]  WITH CHECK ADD  CONSTRAINT [CK_SEAT_PLANE] CHECK  (([seat_plane] like replicate('%[0-9]%',len([seat_plane]))))
GO
ALTER TABLE [dbo].[tbl_Plane] CHECK CONSTRAINT [CK_SEAT_PLANE]
GO
ALTER TABLE [dbo].[tbl_Plane]  WITH CHECK ADD  CONSTRAINT [CK_TOTAL_SEAT_PLANE] CHECK  (([seat_plane]>=(100)))
GO
ALTER TABLE [dbo].[tbl_Plane] CHECK CONSTRAINT [CK_TOTAL_SEAT_PLANE]
GO
ALTER TABLE [dbo].[tbl_Route]  WITH CHECK ADD  CONSTRAINT [CK_ARRIVAL_PLACE] CHECK  (([arrival_place] like replicate('%[0-9]%',len([arrival_place]))))
GO
ALTER TABLE [dbo].[tbl_Route] CHECK CONSTRAINT [CK_ARRIVAL_PLACE]
GO
ALTER TABLE [dbo].[tbl_Route]  WITH CHECK ADD  CONSTRAINT [CK_DEPARTURE_PLACE] CHECK  (([departure_place] like replicate('%[0-9]%',len([departure_place]))))
GO
ALTER TABLE [dbo].[tbl_Route] CHECK CONSTRAINT [CK_DEPARTURE_PLACE]
GO
ALTER TABLE [dbo].[tbl_Schedule]  WITH CHECK ADD  CONSTRAINT [CK_ID_PLANE] CHECK  (([id_plane] like replicate('%[0-9]%',len([id_plane]))))
GO
ALTER TABLE [dbo].[tbl_Schedule] CHECK CONSTRAINT [CK_ID_PLANE]
GO
ALTER TABLE [dbo].[tbl_Schedule]  WITH CHECK ADD  CONSTRAINT [CK_TOTAL_SEAT] CHECK  (([total_seat] like replicate('%[0-9]%',len([total_seat]))))
GO
ALTER TABLE [dbo].[tbl_Schedule] CHECK CONSTRAINT [CK_TOTAL_SEAT]
GO
USE [master]
GO
ALTER DATABASE [AriplaneDB] SET  READ_WRITE 
GO
