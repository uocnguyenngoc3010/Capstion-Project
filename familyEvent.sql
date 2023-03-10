USE [FamilyEvent]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 2/17/2023 1:00:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Phone] [float] NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Role] [nvarchar](50) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChatMessage]    Script Date: 2/17/2023 1:00:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChatMessage](
	[ChatID] [int] IDENTITY(1,1) NOT NULL,
	[EventBookerID] [int] NOT NULL,
	[StaffID] [int] NULL,
	[Message] [nvarchar](max) NOT NULL,
	[Date] [date] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_ChatMessage] PRIMARY KEY CLUSTERED 
(
	[ChatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DateTimeLocation]    Script Date: 2/17/2023 1:00:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DateTimeLocation](
	[EventID] [int] NOT NULL,
	[RoomID] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_DateTimeLocation] PRIMARY KEY CLUSTERED 
(
	[EventID] ASC,
	[RoomID] ASC,
	[Date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Decoration]    Script Date: 2/17/2023 1:00:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Decoration](
	[DecorationID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Price] [money] NOT NULL,
	[Image] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Decoration] PRIMARY KEY CLUSTERED 
(
	[DecorationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DecorationProduct]    Script Date: 2/17/2023 1:00:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DecorationProduct](
	[DecorationID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [money] NOT NULL,
 CONSTRAINT [PK_DecorationProduct] PRIMARY KEY CLUSTERED 
(
	[DecorationID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Drink]    Script Date: 2/17/2023 1:00:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drink](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[Detail] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Drink] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entertainment]    Script Date: 2/17/2023 1:00:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entertainment](
	[EntertainmentID] [int] IDENTITY(1,1) NOT NULL,
	[Status] [bit] NOT NULL,
	[Total] [money] NOT NULL,
 CONSTRAINT [PK_Entertainment] PRIMARY KEY CLUSTERED 
(
	[EntertainmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EntertainmentProduct]    Script Date: 2/17/2023 1:00:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntertainmentProduct](
	[EntertainmentID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_EntertainmentShow] PRIMARY KEY CLUSTERED 
(
	[EntertainmentID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Event]    Script Date: 2/17/2023 1:00:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Event](
	[EventID] [int] IDENTITY(1,1) NOT NULL,
	[ScriptID] [int] NOT NULL,
	[DecorationID] [int] NOT NULL,
	[EventTypeID] [int] NOT NULL,
	[MenuID] [int] NOT NULL,
	[EntertainmentID] [int] NOT NULL,
	[EventBookerID] [int] NOT NULL,
	[OrganizedPerson] [nvarchar](50) NOT NULL,
	[StartDate] [date] NOT NULL,
	[TotalPrice] [money] NOT NULL,
	[EndDate] [date] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Event] PRIMARY KEY CLUSTERED 
(
	[EventID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventBooker]    Script Date: 2/17/2023 1:00:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventBooker](
	[ID] [int] NOT NULL,
	[Fullname] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](max) NULL,
	[Gender] [bit] NULL,
	[DateOfBirth] [date] NULL,
	[Image] [nvarchar](max) NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_EventBooker] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventType]    Script Date: 2/17/2023 1:00:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventType](
	[EventTypeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Image] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_EventType] PRIMARY KEY CLUSTERED 
(
	[EventTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feedback]    Script Date: 2/17/2023 1:00:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feedback](
	[EventBookerID] [int] NOT NULL,
	[EventID] [int] NOT NULL,
	[Vote] [int] NOT NULL,
	[Message] [nvarchar](max) NOT NULL,
	[Date] [date] NOT NULL,
	[Reply] [nvarchar](max) NOT NULL,
	[Status] [bit] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 2/17/2023 1:00:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Dish] [nvarchar](50) NOT NULL,
	[Price] [money] NOT NULL,
	[ComboFood] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Ingredient] [nvarchar](max) NULL,
	[Origin] [nvarchar](max) NULL,
	[CookingRecipe] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NOT NULL,
	[FoodTypeID] [int] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Food] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodType]    Script Date: 2/17/2023 1:00:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodType](
	[FoodTypeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Detail] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_FoodType] PRIMARY KEY CLUSTERED 
(
	[FoodTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Game]    Script Date: 2/17/2023 1:00:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Game](
	[GameID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Price] [money] NOT NULL,
	[Details] [nvarchar](max) NOT NULL,
	[Rules] [nvarchar](max) NOT NULL,
	[Reward] [nvarchar](50) NOT NULL,
	[Supplies] [nvarchar](50) NOT NULL,
	[Image] [nvarchar](max) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Game] PRIMARY KEY CLUSTERED 
(
	[GameID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Location]    Script Date: 2/17/2023 1:00:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Location](
	[LocationID] [int] NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Image] [nvarchar](max) NOT NULL,
	[QuantityParticipants] [int] NOT NULL,
	[Status] [bit] NOT NULL,
	[RoomID] [int] NOT NULL,
 CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED 
(
	[LocationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 2/17/2023 1:00:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[MenuID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Status] [bit] NOT NULL,
	[PriceTotal] [money] NOT NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MenuDrink]    Script Date: 2/17/2023 1:00:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MenuDrink](
	[MenuID] [int] NOT NULL,
	[DrinkID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [money] NOT NULL,
 CONSTRAINT [PK_MenuDrink] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC,
	[DrinkID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MenuProduct]    Script Date: 2/17/2023 1:00:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MenuProduct](
	[MenuID] [int] NOT NULL,
	[Product] [int] NOT NULL,
	[Quatity] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[Type] [bit] NOT NULL,
 CONSTRAINT [PK_MenuFood] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC,
	[Product] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Participant]    Script Date: 2/17/2023 1:00:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Participant](
	[Phone] [float] NOT NULL,
	[Fullname] [nvarchar](50) NOT NULL,
	[Relation] [nvarchar](50) NOT NULL,
	[EventID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 2/17/2023 1:00:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[PaymentID] [int] IDENTITY(1,1) NOT NULL,
	[EventID] [int] NOT NULL,
	[Amount] [money] NOT NULL,
	[PayContent] [nvarchar](50) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[PaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2/17/2023 1:00:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Price] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Details] [nvarchar](max) NOT NULL,
	[Image] [nvarchar](max) NULL,
	[Supplier] [nvarchar](50) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 2/17/2023 1:00:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[RoomID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Parking] [int] NOT NULL,
	[Capacity] [int] NOT NULL,
	[Status] [bit] NOT NULL,
	[Image] [image] NOT NULL,
	[Description] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[RoomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Script]    Script Date: 2/17/2023 1:00:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Script](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Status] [bit] NOT NULL,
	[ScriptContent] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Script] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Show]    Script Date: 2/17/2023 1:00:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Show](
	[ShowID] [int] IDENTITY(1,1) NOT NULL,
	[Price] [money] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Light] [nvarchar](50) NOT NULL,
	[Sound] [nvarchar](50) NOT NULL,
	[Singer] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
	[Image] [nvarchar](max) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Show] PRIMARY KEY CLUSTERED 
(
	[ShowID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([ID], [Username], [Email], [Phone], [Password], [Role], [Status]) VALUES (5, N'uoc1', N'uoc1@gmail.com', 123456789, N'1', N'3', 1)
INSERT [dbo].[Account] ([ID], [Username], [Email], [Phone], [Password], [Role], [Status]) VALUES (6, NULL, N'uocnguyen123@gmail.com', 1219809226, N'1', N'3', 1)
INSERT [dbo].[Account] ([ID], [Username], [Email], [Phone], [Password], [Role], [Status]) VALUES (7, NULL, N'quyentran1@gmail.com', 933787869, N'1', N'2', 1)
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[Decoration] ON 

INSERT [dbo].[Decoration] ([DecorationID], [Name], [Price], [Image]) VALUES (1, N'Vật Dụng chi tiết', 0.0000, N'')
INSERT [dbo].[Decoration] ([DecorationID], [Name], [Price], [Image]) VALUES (2, N'Đồ dùng chuyên dụng', 0.0000, N'https://banghe123.com/wp-content/uploads/2020/12/thue-ban-ghe-chen-dia-1-450x285.jpg')
INSERT [dbo].[Decoration] ([DecorationID], [Name], [Price], [Image]) VALUES (3, N'Quần áo', 0.0000, N'https://file.hstatic.net/200000017614/file/trang_phuc_quan_ao_le_mung_tho_cu_ong_cu_ba_495aec1535d94c809c565cbf920fba1d.jpg')
INSERT [dbo].[Decoration] ([DecorationID], [Name], [Price], [Image]) VALUES (5, N'Đồ dùng trang trí', 0.0000, N'https://www.google.com/url?sa=i&url=https%3A%2F%2Fjoyfood.com.vn%2Fdo-dung-1-lan-cho-cac-bua-tiec-cuoi-nam-tai-van-phong-cong-ty-.html&psig=AOvVaw30mLhOTpPVTuh3LypP6SSE&ust=1676623144403000&source=images&cd=vfe&ved=0CBAQjRxqFwoTCIiy8InSmf0CFQAAAAAdAAAAABAJ')
SET IDENTITY_INSERT [dbo].[Decoration] OFF
GO
INSERT [dbo].[DecorationProduct] ([DecorationID], [ProductID], [Quantity], [Price]) VALUES (1, 1, 200, 50000.0000)
INSERT [dbo].[DecorationProduct] ([DecorationID], [ProductID], [Quantity], [Price]) VALUES (2, 2, 150, 15000.0000)
INSERT [dbo].[DecorationProduct] ([DecorationID], [ProductID], [Quantity], [Price]) VALUES (3, 3, 20, 500000.0000)
INSERT [dbo].[DecorationProduct] ([DecorationID], [ProductID], [Quantity], [Price]) VALUES (5, 4, 100, 20000.0000)
GO
SET IDENTITY_INSERT [dbo].[Drink] ON 

INSERT [dbo].[Drink] ([ProductID], [Name], [Quantity], [Price], [Detail], [Image], [Status]) VALUES (2, N'Bia Tiger', 100, 325000.0000, N'Tiger Beer là thương hiệu bia của Singapore ra mắt lần đầu tiên vào năm 1932. Hiện được sản xuất bởi Heineken Châu Á Thái Bình Dương, tiền thân là Nhà máy bia Châu Á Thái Bình Dương', N'https://www.google.com/search?q=bia+tiger&sxsrf=AJOqlzXNyXovX9X-cknlcZV9uzMs7lkPYA:1676562182402&tbm=isch&source=iu&ictx=1&vet=1&fir=iKjz8_bSkwQfjM%252CQgFDK0gssy77KM%252C%252Fg%252F1q6j1nn7z%253Bw5wuhLTGqXXxqM%252Ce2JOUkHGqF_dqM%252C_%253BqmQNHYWR1Nv3MM%252C2c41MHJ5aBf3kM%252C_%253BSO43qCzrGyBJjM%252C1GB39SZP8QV13M%252C_%253BfouoS0A7QG3XlM%252Crgox_Pjqw5GljM%252C_%253BSj-794LM9JyGmM%252Cd_dX8z9j_aXjwM%252C_&usg=AI4_-kS-VM1iwPfQkMalPc1WLlXesyYQDg&sa=X&ved=2ahUKEwjwqc3qsJr9AhVdplYBHQlwAKgQ_B16BAheEAE#imgrc=iKjz8_bSkwQfjM', 1)
INSERT [dbo].[Drink] ([ProductID], [Name], [Quantity], [Price], [Detail], [Image], [Status]) VALUES (4, N'Bia Sài Gòn', 100, 300000.0000, N'Tiền thân của công ty là một xưởng bia nhỏ do ông Victor Larue, một người Pháp tại Đông Dương, lập ra tại Sài Gòn vào năm 1875. Ba mươi lăm năm sau, năm 1910, xưởng phát triển thành một nhà máy hoàn chỉnh, sản xuất bia, nước ngọt và nước đá.', N'https://vi.wikipedia.org/wiki/T%E1%BA%ADp_tin:Bia_Saigon_Special_beer.jpg', 1)
INSERT [dbo].[Drink] ([ProductID], [Name], [Quantity], [Price], [Detail], [Image], [Status]) VALUES (5, N'Bia Heineken Lager', 100, 500000.0000, N' là một loại bia nhẹ có nồng độ cồn 5% được sản xuất bởi công ty sản xuất bia Hà Lan Heineken N.V. Bia Heineken được bán trong chai màu xanh lá cây với một ngôi sao màu đỏ.', N'https://upload.wikimedia.org/wikipedia/commons/thumb/9/96/Heineken_Bottle.jpg/320px-Heineken_Bottle.jpg', 1)
INSERT [dbo].[Drink] ([ProductID], [Name], [Quantity], [Price], [Detail], [Image], [Status]) VALUES (6, N'Rượu Vang Pháp', 45, 2100500.0000, N'Rượu vang (tiếng Pháp: vin) là loại đồ uống có cồn phổ biến tại Pháp, nghề trồng nho và làm rượu vang (viticulture) cũng là một phần quan trọng của nền nông nghiệp Pháp. Với nhiều nhãn hiệu rượu vang nổi tiếng, Pháp là nước giữ thị phần nhiều nhất trong lĩnh vực xuất khẩu rượu vang trên thế giới và tạo nên thương hiệu truyền thống trứ danh.', N'https://winegroup.vn/ruou-champagne-amour-de-deutz-rose', 1)
INSERT [dbo].[Drink] ([ProductID], [Name], [Quantity], [Price], [Detail], [Image], [Status]) VALUES (7, N'Nước Yến', 100, 310000.0000, N'Nước yến rất tốt cho người sử dụng nhờ chứa nhiều đạm; khoáng vi lượng và chất xơ; các dưỡng chất Glyco-protein; vitamin B; axit amin và các loại axit béo', N'https://cf.shopee.vn/file/8ac7bd2f0614385c9851802a363cd1e9', 1)
INSERT [dbo].[Drink] ([ProductID], [Name], [Quantity], [Price], [Detail], [Image], [Status]) VALUES (8, N'7-up', 100, 312000.0000, N'7UP là một nhãn hiệu đồ uống nhẹ vị chanh xanh-chanh vàng không chứa caffein. Bản quyền nhãn hiệu thuộc về Dr Pepper Snapple Group của Mỹ và PepsiCo (được nhượng giấy phép) ở bên ngoài nước Mỹ. Logo 7Up bao gồm một chấm đỏ nằm giữa "7" và "up".', N'https://www.google.com/imgres?imgurl=https%3A%2F%2Fstatic.wikia.nocookie.net%2Fthe-soda%2Fimages%2F3%2F35%2F7_Up_Logo.png%2Frevision%2Flatest%2Fscale-to-width-down%2F1200%3Fcb%3D20190902051159&imgrefurl=https%3A%2F%2Fthe-soda.fandom.com%2Fwiki%2F7_Up&tbnid=iegpmMf0KktMzM&vet=12ahUKEwiKopyxxJr9AhWRplYBHZvmAmYQMygBegQIARBI..i&docid=xrwYT-kak_6lFM&w=1200&h=1200&q=7up%20wiki&hl=vi&ved=2ahUKEwiKopyxxJr9AhWRplYBHZvmAmYQMygBegQIARBI', 1)
INSERT [dbo].[Drink] ([ProductID], [Name], [Quantity], [Price], [Detail], [Image], [Status]) VALUES (10, N'Pepsi', 100, 312000.0000, N'Pepsi một đồ uống giải khát có gas, lần đầu tiên được sản xuất bởi Bradham. Ban đầu ,Ông pha chế ra một loại nước uống dễ hấp thụ làm từ nước cacbonat, đường, vani và một ít dầu ăn dưới tên “Nước uống của Brad" năm 1892.', N'https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fen%2Fthumb%2F6%2F66%2FPepsi_355ml.png%2F150px-Pepsi_355ml.png&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FPepsi&tbnid=1-cRCONUgVyl5M&vet=12ahUKEwidrY7PxJr9AhXgm1YBHTK4CREQMygCegUIARC4AQ..i&docid=xwdJC7gE4gjVAM&w=150&h=287&q=pepsi%20wikipedia&hl=vi&ved=2ahUKEwidrY7PxJr9AhXgm1YBHTK4CREQMygCegUIARC4AQ', 1)
INSERT [dbo].[Drink] ([ProductID], [Name], [Quantity], [Price], [Detail], [Image], [Status]) VALUES (13, N'Sting', 100, 210000.0000, N'Nước tăng lực Sting (Tiếng Anh: Sting Energy) (hay Sting) là nước uống tăng lực có ga của PepsiCo và được sản xuất bởi Rockstar. Sting có sẵn các hương vị như Gold Rush nguyên bản, Gold (với nhân sâm), Power Pacq (Gold Rush với Chùm ngây), Power Lime (Kiwi/Chanh) và Berry Blast (Dâu tây)', N'https://asmart.com.vn/wp-content/uploads/2021/08/Nuoc-ngot-Sting-dau-lon-cao-330ml.jpg', 1)
INSERT [dbo].[Drink] ([ProductID], [Name], [Quantity], [Price], [Detail], [Image], [Status]) VALUES (14, N'Nước Suối Aquafina', 120, 100000.0000, N'Ở Việt Nam, Aquafina là thương hiệu nước tinh khiết thuộc tập đoàn Pepsico. Đây là tập đoàn nổi tiếng nhờ có lịch sử lâu dài trong lĩnh vực sản xuất và phân phối nước uống.', N'https://file.hstatic.net/1000394081/file/nuoc-tinh-khiet-aquafina_02877eb1e8024e628e63e54a6e003a80_grande.jpg', 1)
INSERT [dbo].[Drink] ([ProductID], [Name], [Quantity], [Price], [Detail], [Image], [Status]) VALUES (15, N'Coca-Cola', 80, 360000.0000, N'Coca-Cola (hay còn gọi là Coca, Coke) là một thương hiệu nước ngọt có ga chứa nước cacbon dioxide bão hòa được sản xuất bởi Công ty Coca-Cola. Coca-Cola được điều chế bởi dược sĩ John Pemberton vào cuối thế kỷ XIX với mục đích ban đầu là trở thành một loại biệt dược', N'https://upload.wikimedia.org/wikipedia/commons/thumb/8/87/CocaColaBottle_background_free.jpg/800px-CocaColaBottle_background_free.jpg', 1)
INSERT [dbo].[Drink] ([ProductID], [Name], [Quantity], [Price], [Detail], [Image], [Status]) VALUES (16, N'Rượu Cần', 50, 450000.0000, N'Rượu cần là loại rượu đặc sản của một số dân tộc tại Việt Nam, cũng như các nước ở khu vực Đông Nam Á. Rượu được ủ men trong hũ/bình/ché/chóe/ghè, không qua chưng cất, khi đem ra uống phải dùng các cần làm bằng tre/trúc đục thông lỗ để hút rượu.', N'https://vi.wikipedia.org/wiki/T%E1%BA%ADp_tin:Ruou_can_jars_in_E_De_long_house.png', 1)
SET IDENTITY_INSERT [dbo].[Drink] OFF
GO
SET IDENTITY_INSERT [dbo].[Entertainment] ON 

INSERT [dbo].[Entertainment] ([EntertainmentID], [Status], [Total]) VALUES (1, 1, 2080500.0000)
INSERT [dbo].[Entertainment] ([EntertainmentID], [Status], [Total]) VALUES (2, 1, 3000000.0000)
SET IDENTITY_INSERT [dbo].[Entertainment] OFF
GO
SET IDENTITY_INSERT [dbo].[Event] ON 

INSERT [dbo].[Event] ([EventID], [ScriptID], [DecorationID], [EventTypeID], [MenuID], [EntertainmentID], [EventBookerID], [OrganizedPerson], [StartDate], [TotalPrice], [EndDate], [Status]) VALUES (1, 1, 1, 1, 1, 1, 5, N'My Son', CAST(N'2023-02-16' AS Date), 3005000.0000, CAST(N'2023-02-16' AS Date), 1)
INSERT [dbo].[Event] ([EventID], [ScriptID], [DecorationID], [EventTypeID], [MenuID], [EntertainmentID], [EventBookerID], [OrganizedPerson], [StartDate], [TotalPrice], [EndDate], [Status]) VALUES (8, 3, 2, 2, 2, 1, 7, N'My Father', CAST(N'2023-02-16' AS Date), 1234560.0000, CAST(N'2023-02-16' AS Date), 1)
SET IDENTITY_INSERT [dbo].[Event] OFF
GO
INSERT [dbo].[EventBooker] ([ID], [Fullname], [Address], [Gender], [DateOfBirth], [Image], [Status]) VALUES (5, N'Nguyễn Ngọc Ước', N'123 Nguyễn Văn Tăng, Phường Long Thạnh Mỹ, tp.Thủ Đức', NULL, CAST(N'2000-10-30' AS Date), N'uoc', 1)
INSERT [dbo].[EventBooker] ([ID], [Fullname], [Address], [Gender], [DateOfBirth], [Image], [Status]) VALUES (7, N'Trần Văn Quyền', N'258 Lê Văn Việt, Phường Long Thạnh Mỹ, TP.Thủ Đức', 1, CAST(N'2001-12-06' AS Date), N'https://www.facebook.com/photo/?fbid=3328969510696823&set=a.1402224653371328&__tn__=%3C', 1)
GO
SET IDENTITY_INSERT [dbo].[EventType] ON 

INSERT [dbo].[EventType] ([EventTypeID], [Name], [Image], [Description]) VALUES (1, N'Thôi Nôi', N'data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAoHCBUVFBcUFRUYGBcYHBsaHBsbGhobGxcbGhcaGhcdGxobICwkGx0pIRoXJTYlKS4wMzMzGiI5PjkxPSwyMzABCwsLEA4QHhISHjIpJCkwMjI0NTsyMjQyMjIyMjIyNDIyOzQ1MjIyMjIyMjI0MjQyMjIyMjIyMjIyMjIyMjIyMv/AABEIALcBEwMBIgACEQEDEQH/xAAcAAACAgMBAQAAAAAAAAAAAAAEBQMGAAECBwj/xABEEAACAQIEAwUFBgMHAwMFAAABAhEAAwQSITEFQVEGImFxgRMykaHBQlJysdHwFCNiBzOCorLh8ZLC0iRDYxVTc4Oj/8QAGgEAAwEBAQEAAAAAAAAAAAAAAgMEAQAFBv/EADARAAIBAwMDAwIGAQUAAAAAAAECAAMRIQQSMSJBURMyYXHwBYGhscHRkSNCYuHx/9oADAMBAAIRAxEAPwB8grq4+VGboD/tWlqDH23a3lRSSSNiPr+9DSWNheEguwEr8kkmugKZ8Ov3LKuvsiwYwZDRpII0ENsfnTbBYtrjhTYK6MSSDpEkR3fCKjC37y8tbtN4ZBat66BFlj5asa8+x+KN241w/aM+Q2A9BpV87T8TNlJ9mGzkpBnLzJ2Go5R0mlOJ4jiEuC4+Fgeze3lHeWC6lpKgjkAQdySedVnxJV7mIOD4E3bq2+Uy3go1P6etelJCr0AGg8B0rjhz3She7bFtm+yrToPtMRz02nl4mpb15hssj8S89NjyFaMC8w9bWinEXMxNRrUy2HYucuoOo8Sa4W0c2XnMfrSTcmXrtAt4k+Ew5c+A3pssKOgFc2kCLA5UPduSaJmFNfmRO5qN8Tq5cJrkVoVsVISWNzCAAm66WuRUiW26VoBPE4kTVbFbKHpWq2xHMGbFTWr0aHaoVrdErFciYVvDHQMPrQV23FTWrseVbxt1FGp1OwG5/wBqpDqy3nUyytaVjtThr1y2q4e5kuZgdyJEEbjoYNScCuewlCsGAzBSCAQO9HM9YqHFXsXbuN7JLV242oV3gJ08/Ka4s4G9n9o8Z8p9oqSUDEEka7yCuo5zSC/+4eZURmxHaWniOFF22QNxqp8aqLLyO4q2cLuyo8ppP2gwmV842f8A1c/jVIO5Q0lA2MQYLwnFezuAn3W7p9dj6GrRireZT8apTVbuFYn2lpSdx3T5jT/euGcTHFjuEVuKjbrReMt5WNCtSDiUg3F45tvmUHqKxhQ3DnlSOh+R1/WiTVCm4vInWxInBrhqkNRNRRRE4isrdZW3nRYtCYvibWmyqqmQJmfHof3r1otar/FXm4fDSp6psspoLdo0fj22ROWuaN+UR+/AUy4TimuA6aDfXdiQTHQe6B5+tVNas/Be5bB2mW+en5ClUiWbMorAKMRd2ktX8Q72LdtctvI7NMElgyga8t9PDxE94fEYx2uItq0CroD3jAkDbWSInXfXQSNKviOOX2dmF64FzEqAxAUEyAANth+zTjsxjb9y8A912VVJILEjoBHSTt4U7kxXAl3yQuoGnPzg6aeR+FKruO190Hzn9/8AJ9DcTdIQ67/v6UlZpM1zm2IdBd2TDhjiT7o/TQj6mi+HW5m4dyTHx1pTaSSANzpT9QFEDYCK5PJhaghRtHecYl+VD1tmnWtVHUfe14pVsJ0KB4nxizh1JuXAI1j7R25etT47FC1auXW922jMfQaV4ZjsTdxdxrjSQSSPL98qbSp7sniYzdhPQL39qltT/LsErB3MNI29DU3Dv7VbLZRdtMhMyV1AM6fKK83PDlXdW8zy6mK4vYILEjQ+Akct/SqwV4EUVPefQnCuM2cQuezcDqDGnXfY0a6A18+cKxl3B3Uu22bJ0nSDuDG4+E173w7FC7at3F2dQw9RXGxxMsRNOkVqaLZZoNxBqapT25HEcjX5nU0iOKdsRcQ5soIXLtKwIjmRqTpTjNUiPGopV7xqttzFWNlCrZGygnMcpiOWYkajXasw92ZQ3O8oVpiBlHLTnrVhuqHRh94EfEVTOF3GUjLlVGiWaDmE6iN9+QoqqbSLcGNo1DUBvyI24ViIJUfZJjynT5U04rY9paYDeMw8xrSdGi+4AAE6R4aU+wryvlTNMenaYrUrkMJRmNOuzN+Ge31GYeY0P0+FLeKWfZ3HXlMjyOorOFXcl22fGD/i0+tOGDFtlZZuIpoD6UsNOcUsofjSV6XUFjDom6yfhr98jqPy/Zpm1JcK0XFPjHx0p01MpHpia4s04aomqVqjamRBkdZW4rK6DFoFVnFmbjeZ/OrMDVWc94nxqavwJbphkzpKsWOf2eFc81t/PLA+Zqv2hJA6kU37VvlwzDqVX/MD9KGj3MZqMkCUMVc+w9nu3bnUhR6CT+YqmzXoPZK3lwyn7xZvnA/KnLzFVPbGGPfSKWgUVxJtYoVTSqh6pTQFlEN4UkuT90fM/s0xxTaRQ3Ck7pPU/lXeJbWuc7af1iKh3VPpOFNd1GtS2RLAVKoubTTiJu3VonAOg+29sHyzho+VKOz+BtBApRToNwKsfa5ZsKOtxPyY/SkOGGQ7wKrbpsomUxe5j1eA4e4O9bXn1571Jd7JYZlAyRHMHWusBjF2zD401W9pRraa15Wn7GWFUoJgg9DU/YW21vDNZb/2rlxF/DIcf6iKdXXmo+GWgouRzuFviifpWr7otx0w2aivrIrsmtGjYXFosG0Cmtq1c3hBNcq1eccG0fDf4jJbdj9hS3wE1VeGYa3cC3MxtqhIMiQSWLSp66+lOOI3stp52Ig+UyY8YBpbw+4ly3DoVFoaZToQToIPPxo3e4AMdQS1yPMMFxjeYN4R4iND403wTakVX8O4a+zDbTQ8oURFOsK0OPGj0x5+s2svSR8RX2ptw6N95Y/6T/vSLNHpVo7UJNtW6N+YP+1VUmqWwZMmVl9Rs6A/eWfiKR3BrTPgzzYtn+mPhp9KX4kQxHiaCrwDOoYJEgBgg9DT41X2p9bMqp8B+VdR7ztQODMaomqVqjanyaR1lbrK6dFg2qqMdTVrXY1VG3NS1+0r0vJhGDE3EH9Q/Oju2bRYUdbg+SsaDwP94n4h+dEdtj/Kt/8A5P8Asaupe0w6/vEp1el8BSMPaH9APx1+teaTXqXDBFq0P6F/0imrE1eIFj275qAGpMf75qCaS3Mtp+wR/gBFtfKfjUF1u8aJw/uL5D8qEY6mh1GFAkYyxM2DRWDGpNB0bg9jSqHvEKp7Yk7X4lk9mD/dNE6ahw6gene+VQ2MMzCUy5v6pj5CnfGMB7a2bekyCs7T/wATSrhtw23KtuCQfMGDVD4bPeFTIK2HM64bYxRZheFgoCcjW84aOUqw0+J38NW2Ms3FtMyp7RgpISQuYxoJOgnrUeNxbSAgU9QWyz01ANE2cXcjvW1EDcNPpEUy4nENaA8Ie66g3MOLR10FxXiCR3sumog6E70xwzjvATIMnTTXaOugFSfxKlJXnWIgAgVq84i39uZsmuaytE0d4mDYo6ioA1TYvYUIDUFbDGUJ7YPxO6c1pdIliR94BYjxmY9ah4ViWeUKKEjvADKFAO87zQ3G7ee5aiCVknUCNVg7+Bpkjlrly20C2TGfRQOa6/a8qEC8qpkBZprYVxdtzkICHqCCYn4/lTCwe+vmKDwdpipQo65TrI0YNpp5QDz50XbEMvmKbSFjOfNxJO0KzYfwKn/MKphNXXjY/kXPL6iqOapaR0+JcuzjTYXwLD5zUGOHfPnXXZk/yf8AE30rnHe+fOhq+0TaXvMEeneG9xPwj8qRtTvC/wB2n4RWUTkzdQMCSGo2rtqjaqJJOKysmsrp0WKaq133jVnWkfEsGysWAlT0qasMAynTMAxBkeDP8xPxD86L7ar/ACbZ/wDk/wCxq54Xw+5cZSEOUEEtEDTxO9WDivA/b2zbZsuoIMTBHhz51lEGxjK7DcJ5cK9T4aZtWvwL/pFKrXYS19q7cP4Qq/nNWXD8PVFVATCgAbbAR0pyi0S7A8RFj7ZDT1oQDlVrbAKdDrQr4Rbbe6J60DJm8cmo2rYidWlhQDyA/KgXEE0eprm5ZDedDVQsBaJV7HMCFG4QwsnrUa4UTqZ/fWsdyRA0BMadKjFRaTXPPiN2lhic43iOQQoBbxn6frVZfiYN4LcgO4zDSAYgEeeo86s1vAzJPmPI6VX+0XZz2ihl0ZTII8oMjmP0p6Fqi7mFvE5dqGwnPHMAL2RxcuIPdOViAfOPzqTgnAvZnMMRdZQNUzlkPSSw5eEUu4Q2LtdxlFwcpP15+tWexbvXVggW16L9Tp8B8aNSfEcXAW0PwOGJAIHdG3jRbVux/Ls2+eVUGvPQDWiWZWgEgeB+jfQ0fqKhsZK4L5gJNcNU2ItFTrtQ7Gm3ioNizpQYejbsHQ0E9g8iKkrU2LXEfTYAWMrnEEFzEWoIAdWJYazlnKPTSfM04drNzKjFk9n3M0Aq0GCSvI1V8S5W/bKhkV2yzmgBj3Scvw261ZuHXbfeFz2RubA98AsN8+wFL5xLBjMOCgZbaBptsX72ufkYA2HTwNEPfyl0RZZQNNST4GgcXdvlXB0YlFEdM2oGXULFHYXDsLhdlHfaDHLTTToYB9aBqqqwXzOPF5HfZjbe2W7xQ9wmSpB6/Q1VDVusWQjzDFtRDQQQDlJ8ZAJFC47s/mOayRDH3WPuzvr0FcNZTVtjGKdO4EM7Mj+QPxNUePPfNHcIwrW7So2+pPqZoDHAhzPWrGYMgIyIml7zBGp7hvcX8I/KkUSYG5qwIsADoIraI5nangCctUbVIaiY1RJJzWVqayunRQjVK1yATExr8KhVDUvs5EddKUbwhHGGxisBpFGrB51XeGtoKd2WrlN4ZWGpbHWpVtr4mhLmIVFLuYA5/vc0sPGrj/3VsBeReST/AIRyrHqqnJhpRZ+JYCQNhSzH7ig04zcQ/wA1Fy8ymaV8YO9G43WDWJVWoLgzHpMnMEFcX3IUkbwfSBXceNRY26y5UTK4I1AIGp8yJpdepsQmZTTc0EwGIKPlYyj6ofun7S/UeRphw+xmuHopNKL+q5XVlHWNjyIO2hrWD4gVt3FYxdtnNofeAiGHga8nT2eoN3Alrg7cS0N/7ngVH7+Nd/w4NDrczBj950/0KaYpXvDMhOIlv4UI3u6H9xRsQsgUHxzEquVNdO8fyExtzrjAPca5DJCZcysDM/0kdeenQ1M1N9xCmODDbciNcQo9mRyiPoPpUGgYp0iJ6VLinCoCxAAILEmAAssSTyGlBPel2boJny3HwrtTTDJ8iDTJBndu+MmVp30jf0oa/oSK6wrgnoR1qXiJByuOehgTqKm0dUkbSeIdVLG9otuPQt+8ACJidB5xy8akuuPHYnY8qExKiNRmBkAaETyLDoPCqaj4xMpLdrGVIcNNx8tpQSrqTOZRbgySRtm0+ydZpm2JeM1tUDIcrF4mT7rgtAYfE02w3ctnNq7AloGkjSBNKcDgs12CB7JmkqykMMuo5wdYE0jgASsNck9hLFw3BPnN1nEtlmGYAGNzGhnTQyNaYsGMHaCAR+E9KjDFXDqhIIgkRKx7sjmKhYSDqRIbyBO1eRqnHr3XsRxmHRBZTeZjrri5C6yAwHQR3mJ+NEjEwQqsG8999Z+VQ4jOyB0JFwoAANBOYmWJ0iP3tSHDceQ2SVfNeRm7xEq0tAIMQVylfivWgrUCzkr5/eb6i7QG8S4rihoCPCa1fRGjMAf31pPh+JBmVUEkidDO0AnukkDfQjymjDeEidmnYggEb6/vempqaumTzc8ERHprUPTCbeHRdVWPH/muzXabTyrg3E69flvXuaTUrVQHg9xIqqMrZkbGomNTF06/DX8qhe8nXfkOoqksPMVYzisqP+JH3W+VZW71m7DEw15841Gw8151Ip66T0PIbCGFRr+/3+/WpApPXx3+fjUcfCMB9ad2GpLgtG/f0p1bUHlTkgtFnG3LXbdv7KqXI6mSBPw+ZprhrUAKsAkSTuf3r+dKOID/ANT/APrHr32GlPcGvfPgqj86lturG/0lTm1IW8SG/ZmVaDoSD+dCWpayq6kozL4wCcv+UrTbEL3l9R+dKuH+9dXkGVh/iGU/6KaFC1beQYsEmmfixgzJl0I6czy+lS+xS3oAddZk/n08KmxzhVJI+AknwoW25cSRon5RPx0ilamlfpHMym3eFLhVI11nr4iNev1qu9pbPs7bOiFvZgwQCSFOjj72WNY6imYxjFiqkTAOvMnf6D0rn+LcKQUCnbUjnzAWSaBNKosScxododwS4Ws2Z3JBPov+1PWePSqXZxN32jAvlRVGViIGcnQQNdZ2328jzju0Bu2okhlYFipH2TInwkH1AqwVNq8SKqwVrNLA3EbgYBsPqZO6yY8iaFwfFwbz2/Z5JCsNDqASrAk85K6eJ6UhXjKnM8kaAEknTqPH/ihsfxO6BbuYcTlZXIggED7Lad0EHnyOnKlLUa9yYCVlqHaolr7W4X2lhUA3uDeSBKOASBuASNOfUb0q4UXZDmJiYMMWBYb5WP2fWPWmvGcWLuDL2zpdUBdY1YwQY57jzrnCd0BVQbbhTrHio+VK1jEkBe8tomwzJrftGOogdT/4nU+sVKihkYGIUE7RB8q3a1GYaHwM1u8uhJnpESNd5AqXTp1QnOIkeyOg3I25GoblvNAA2Hz6Ui412ia1iCmTRRqD3S+m8xpTbh+KW9bFzLBcyBEwQToT5CriuLwVM5xuHlG0032nU8oHjW+C4MgtceDcIAOUnKoWcuWfITXF/FhCxGU+zXPlHUkCNPX5Ufw4p3hahoMMNQVOgPyGmmtSalHZDs5/iOQhcHiRDiJzlQnkZAzctBvRwuDIdRPjJ9NKBx/DA7Sg2EAkGUnceY6UTmRbQVyNF1YsPiW39a8Ypttixlu4EXHn9JxOfDhc7IIILJGaAQTBIPWNqrX8Eb4ttbvPcsu5UM6IHSCQ+UhVKjuQBESNtas/D3iyp0I6Hu7nvQevh4UtxV+62Zbdt+6fdBK5idzmq0u61CB3t48ffeSmmri57f3CuHYS2qlFQIuYmSZJMhYAnXWY19KkxHtFuIpVMrFvc0MhZDEE+6QGHnFTcLwjoo9p7x7yT7w296R5x5UZiHJHdjcT0HWfCnmkz0T6gzm38RSlUqDbxJcPcDKBm1j/AIPj6VwyeI+B1npWrSZW+HxjWK7YyZ0nqJ/ceFZ+HU3S+4Qa7KTiQsOU8unwOp2qNvDz2G/6VKRGo9R9RP61y20zI6x+4r1JPBmsDovqBPrpWqm9ayssJ0Tg/vX5kDQetNcBZDJIzeMiB6Unzjw8PdPw11Pia3axbporEDoII8eep8a5HCm5nMpIxHqYQq0jY0fZWlicWcju2gWjbPH0Ndp2gtAd/MrDQrE68wDT1q02ODMNN15EF4ykYu0Z0Nsr696KsOE9/N1T8jVabtnYVyrgrG3MnzHL40DxLt2SP/TW9Ru1wchyCKefUn0pRCBt944szKFtxL3f1iNIM6/pSjE47D2czNdQE7iQWOpMBRrzNUbG9ssY6kJ7NAR7yg5teQLEwfGkOFR2MZAANzMx8t6x6wvdRczFpm1iZfV4n7UZp03AOnrvtXdvFqhkkxGwnvbyYjxNI8Pb7sGJI10GgFZizbRGe5CLG5MQvodz0pG8m1+YW0CS38aFcMrA5dAZADrMga7MDO+870xtcUVtVUzGuVQCfNzy8q8y4p2vY9ywmRBszSWaOcTA8tasHZjtrZYZMQBbYD3gO60Cf8J8KpWk4yYBqjiOuN4tEQvfCC2YUWzqHY7Cdz1nlVFx3FCrlrdyQ0HRpkbssncA9etdYy/d4hiTcy/yULBVP2VAmSOp0n4cqjxPDnFxSF9pI1EAkxpELqfMDl4UXQDtJzJ6v+oMiGYjiMAKoB7wnpqZ19AfjTQdrFtWmtuVZ3Z2bQ6lj3dtlChVET7vkTWL6NnyZGGZyZKnqY35dKF4zYa0WtkHKWDAkbHbc7kgGdfhWrTDYvJ6NIUx0z0zsXxizetsmcQrFijSQpPNZ1ggdN52q82rikDUHTYbV4b/AGfuDfNsx3hI2kkSIGbQ6GfSvV3xotDvtkA+8FQf9QMGuI2mwnor1KDHTPsw3zZD493MCfGNPhUuNAIjKCAI57xJqpcQ7UYazbzG4jmS2VHVmZoiFAPkOnMxVL4V2/vrfdrkvZuNJtzPsxED2ZOxAAnk2p0JmgFMElhAZrYnpmNwq3BDW7bDJswzfmK8u7VYy4t0qAyAEezRQQBoBKgRJ8q9VwuJS4lu5bYOjjQiNR/0/Kh8RhxAMAsrRPdkT4ECgB2m8PmUrg2JuW1V74JZgGed+4ZWQY12Jox0KWxcV5LXLjzOq5bQRNtjIk/ip1a7OZyWuHKhLRlIDGdNAZAqd+xiNmK3WQvsNHAkqTvBPu/Oh2s3AhhgOTIMXj71pmRWVyqJErJZu4JJEGTLHzNE4/iJgpcshlLMpGaDlE6jfWATy3FJuIXb1q6zXER3t5OoVhD5WmdNhrGlTvjw1y3cupkQQ5IYESYjUkDrvQE5I+YW0WBtHi30twBbMZwg7xB1aAdPMmuv/qLF2RVVCFZtBroyruTHOleHu5rtrMvcBe4MrF5YTlB5CJnmZFZh2b2l2VB9oBIhsyhWnmNNXO6xoNRWb7d5u2MbLksGzA57avJOhJJA18hRIuyAYJ5MdgPj+dBWbJKgMJMALm0AC7CIotZ0YkxsQqmiVri8WwzO017qmSNRv82M/Ktl8w/Pb4jnUTsB3NjuJJLH0FYr5RIOUfdmNeojUUYa2IsidBuW/Qjf6waiOh6TzGx/FG1dPcAyhtCxgAyVY8gCRE10RI6jbUEjybSPWtvMkU+MfH9ayuC5GmZxHKNv8tarL/d51omvSNDMnnPL+rvaDwFQWoe4gzZlk+ZI+lFOrAEBmj7RZZ9JG9A3nKsHgDLyCsO7zLdNKTVBKm0bTIDCM3X2b5uR+lLO0FpLqe2gk2x3oMSOR9Pr4Udjn9q6IvNcxqbhtvKCrbiQa89H2G4npsgZM8yiIh5SzHmdSelWPhHZ0G2TcJzsSQFOw25jejeM8OS09vE2xCSQ6ASBIjMBy8f3I1ntDZXUM2g6aztHSn+qag6R/wCyNAvcxo/BrHs8otgEc4yt8eZpD/BFXKDvZTvGhPLTwFPuC404klssWw0AnTOYBJj7okDfU00fAKLguHKAixljQkk6677/ABFPpUntdoNR14WAcKwACZjqT5fpXmnb/ihuYg2VPct7gbF+c9YBA+Neo8bxS2rZuZx4mdNdB868I4hezXbjH7TsfOWJrtJpGWuzub4x+cnqv02Ejy1DdSK7DHlEeR+tcP6R1Ar1xJJd+x+BzW2Chw7AyTEA69eoHjtVwweBcW3uL76sFAOkqCA+ijrJpT2Yst7FS10MFAKxuV2BE69QfGrfbVM3dMgAEg75tQxjnMA189qarGoxHmesumBQRFjOHWmPtBuhkpqVJBEheuk8+R1qodreEFLOdlhwczCICh27sDyjQDzivTkYFTlHMxI58j461Wu22Cz4W6NSwggjXNEGN9pB+nSi02ob1FB8iJq6MKCRPH7blSCCQRsQYI8jUl7F3H9+47fiYt+Zrm7YZfeUjzFR19Dg5kGRJUYVOriOdCJTjg/B8Rimy2bbPG52VfxMYA8t6E2GTOj/ALAdoWs31ss02rrAEGQUc6KwA6mFPmOletYh/eUnxE5vqtecWP7ML8BrmIso24AzNry73dj0Bq18Nt3CVw+KgXkXUgAret7K6PAno2gIPISKi1FRFUvfA5j6VybRZdx2O9q9u24a0T3J9nKiQwgtB02pxgb+LZsrvkE65CpInQABep0ptb7NWIJCMPFXdD/lYUjwOBvYfFObbtdtuBo+Z2SCSACJ11I5aeWsVHV72AyL8Y5jisYYnh1pXRSblxn96XY7ISuaI2AP6dMPB7jW8y3FkhZUIZgAd0OHUyDm1MzMU0sYkMhRwCekENEb5X1bYbTRRskQwWSNQJg8+vmRyqxU3dphqAd5Sr2LQ3EQXLZLJlgFXYiJfnMQNJkCrPw0KqgARp0qscY7Pxc9vbRUuBixXXcmdlHjTDCY7kZVuatofSdx4ivF/EVdWBXiOXqWWtVUjWluPxSWidRt7s7/ADoS5xfKpkivOeP8SuXWJWYnSOnLWu0lSo5smB3inUINxnoiYktlIyjcAgGfCSfDlWjY0aROYGZEyPI86pfZPjFwOLLwwOo5/ZkfIfIzV5W4DzBMUOoetTexaPpMtRbgSlcct3rClM7tbJBSdTbYSMuaSec8uXQmrNheOWnyy3fI1LKVVvjEVzxxQ1l4JBAkQYMjX18vGqvw5+6q3LeVQTNwpvrMOY0OsSdav0lc1E6uRIqtM06mDg/pLrC/f/zL+lZSy2FgZbZjlvWVRc+RCxIbndGwn7pQ5U8TrvS+/hWIOVJJ5iB6tqdPCj3hQGLI07K0z56mSaNwpAWKj1ep9FRYXJjaa3izs0p9o4bdQAPKmuLIVi3lQODuBMQTyYfMV1i7ntDdy7AfOKmDbwDPRpXYgmdcYxDthiqbkrrBMQZmB5RSrB3sSRm9laYnXNsV8wSDVgwVuFCnoPCsucKt3WllQsd83egdJIqmgoN7c3k2pAVscSu4bH4pbjANadhr7MGCARE7+A3PlTV+I424P7pF3gkrpMTuddqjx/BkH93bVEt87ZAPmANSfnUAyxBxj/h7+b4Zpn0qveVNr/pJu0rXbRnCziLwZpLJbTYMfta9Ph48qrPBOzeJxZPsbZYDdicqg9Mx3PgJirVxfhAcwisASM9y4YYKSM5VDrIEnYbc6r3E+1F1wLVljYw6DKltCVOUc3Yasx3OsfnVdEkrjn5k1TnMcH+zTHASPZHwDtPzUD51WOMcFv4dgl62yMdRMENrEqykgjbY8xUFrG3VOZblxT1DMD8QatnDuIvjcK1m+xuXbNy09p3JLlXupbuIzbkDOpk9fAUy7LkkWgAXjTsddTIIsMpzDTXISN8pYzuSeY0HSrql0MudRDnQrz0MaxzqrYbhd7DOmVz7MyTAa5qTJywJBMzrpTuxxBAVLNlaIbMpUE9dYrw9VTbeWAwfrPd07qyAXyI0I0EaLOojU60Lj7Wdcp0jQa5YEyNR6/GprRJ2BI6iSAeg5CjrWGYZcwcE6kDKfj86zT0iWvmZXdQpGJVsbwRWZRvA/wDuDp4iqfxXs0uVnAG/J1/QGvV7ikux72g+4tKcZhC1sghjJ521ivU3EZE82wnivEcFkywB0IBnfaTVw4zx65gLNrBYdsjZM7uACZck6Tsx1M9CsRU3aHhENlMww2W3lM6x6zVR7Ul2vm4w1dUnwZUVGHxWfIimofUYA8C/+e38xLrYXECu3WuNmdmdjzYlmPTUyTVv7PYvE4V7TXrV0WQTlLK0WwwhoJHdU90ldB3QeWsHZOzZw9v+LvEZtcgOsdMo5ufkD51DxrtPexJKyUt8kB+GYj3j4bUyoq1AUPHEwdFmPMvGI/tEsi4bRzhdBnQBhrv46a7BqkwmM/ibkYS2Ht7tiLqvlUmZVVYBnYaaH4gaUi7KdiGuMt3FArbiRbJId+mb7q+G58K9Ev3LVi3sqIggKAAPAKKClpKVEXtmZ6j1DZe8MwFsW7YLOWgSWblO8AaKPAdKV4/tMJyWternYeQ51WuJ8YuXe6CVTkvOPH/ehbTRH01+HU+NY9fss9Sh+HW6qn+P7lu4TxC5cYrcJYHmDEb7wNtPnU12xbuFrZysySdWYxG/KKD4MRbt3Lh95QZ8IXOQfHUflWcIuC3Yu3ftHMZPMqsj/MxpD9XMlqEBzt4i7HcIsuxCmSNGT2jtHI6EwPgarnH+BNahk0tsO8FnMpA5yNvEVZOAuMzMfKfmf34U5ZEdYMMsyNYjkdam3BX2w2p7kuZ5twDBw4eRA92DJI11+P1q4pjQGjMCd8u7HyG5NG4fs5hw05EbNtJaVPgTU1nB2w+UKAy7Sxb/AE0FbS+q25jNp1FprZRBWL5VuRAmCpU5o/CRTK1bESoInY+75g5fqKlvnu5oOU6GHET66ih8OqrpK5T4FoP4qfSprTG0cfeYmoxc3M6lT0H+Mf8AjWVIzdYPjO/xFZTsfEXmV/EWWcNLMDzcIBHgJpacXcQHTMo0B1Bb0Ip6zqQQHcWx4e9ULhmgguT9lcojzM1PVpLUFjmNRysq2Ix75w0ZTB05jTfaKtfCrQGHnmdT4zvSHituDB9pmOrE7eUDlTbhmPQYeGIEafpUz0gLKo+JXTqHaYzKxrRAvaRKydNVmB50DY43hhvcHnB/SmWH4lYf3blsz4iraGjKG+4RFavuABU47yNgD3RlyjUn2Zg1DibyoDcfKoGgJRVA8ZY0Zf4PbfXNdTY9y44HUd2Sp9RVU47/AGevfOcYu4zD3RdAYDwBWI84qsaX5kZrfE1xW6l221uxcV7jA6A29SRsYpPwL+ztcobElix+ypgL5sBJPwHnvQmI/s9xqe6tt/w3IPwcCt4fBcXw/upegcpW4vwlhTFolOJgqg+4Q3i39nK5S2HdlYfYchlPgGAlT4maj/sy4WRfvNcGRrYFshh9rMGcemRdfGirfa7GWoGKw2h55Wtk+UypPhpVr4Jdt+zuYm02l8hyrCSGCKhWB0yfEmgqXC2MYNrZWH3gjXJIt90cpPyFbTDIVLEIC3Ir+tSWkCoJeGYydIH72qe/cJKoWtkDrU+Ofu5jAxE09sAImW36GK1ANz3RoPvn9865DguTFuB/ST++dc2mEM3c1/pP751uLzrm333mlTuscu//AMn761FesH2Y/lsf8dTvbATe3r6Vl7D+6MinbZo6Vlv2/eZfMV8QwWZgMpGn2X158jVA7Q8KXLdBRpGuZzEHXntXqFyz/M/uuX3vCqj2m4S9xbkIQBJ7rTG+oBrrHdceYSleG4nnnZ3s9fxz5VOW2ndLtqqc4AnU+A8K9a7PdisNhYcD2twfbcDT8K7L57+NKeyeLt2cKhAgCdOZbMQZnnNa4lxu7c0zZV+6NJ8+bflVfrKogU9G9Y44lk4rxu3akA532gHQfiPL86qWNxT3WzuZ6DkPwjl50ELZPUnpGvoKYYPAtcbLBjmYJ+J2nyqV6jPzxPYpUaOlFyc+f6EEVCdAJnlv8Tz8qkxJeyvcUvdO3RPGToW6DYVacBwlQCCVBHOG1+dMTgVyAj2bdZAoACciT1tZu6VwJT+F4hxgrof3xnzayZKrOo8DU5xUYE+o/wD7RRHFuAOHb2XcW4DIBGUkiNjt6VV7tnFpbfDm2rjUqyEz7wYSoBnUdRvQlWv+ciwcx72axMKeYzbCJ84O+1WnCIAdFIDamAOZOuvrVD7Ii6VPtUKrm0VhuRzr0LC2wREV5lbU+lXsBc/WUswamBJH2ZM22oDr9aGw8tLDNI+6Ao+HOjLlqBoY8qGS3HfyEiYJza+cVdR1K1WtwR2+JIVsJrEMvMpDfeWCD5VHZaO4XMHY5NKIY7pmjmudfrQzXJENc1XaBVPBgdpv+KYaFxp/T/tWVn8V1c+qCsrr/wDKdb4iv24Iku2X7IAA9TXbhEXMHbM3WTWVlKDEk/SHbiLMaDGUXTmO5y7epquMR3kBJgSJ0k89vCaysrB7o+jzAlPiV+YqQdYB18RWVlOM9RIxwfFb1qMlx18JDD4GnuF7ZXAP5iK/iJU/UVlZWpUYcQamnpNysOXtja+1bceRB/Su07W2CdVcDyHL1rVZTvVaTHQUrd4ytYvD4pWt++CIKspgg+elVrgnBLmFxpFu5msNMqSe5zSQd+kj1rKyuqsdo+sgVQjsB4lzBFxpZhp0X9ZrdjDmGcN8h++larKBM2v8xbY/SbUOtsmQZ/46VlxnFsAqpn/msrK7bjntNH8zm+D3V9mPiK5uhfaCbf8AmrKytZBf8xOBnEW857rDyPl40Dcw9ts85tfLxrKylHkfUwpXsNwR1V1t6qWkSR3TzieVE4bsy7d9rqrygBmPqTHyrKyuTNr+JQtZ0XB7x1Y7MogUzmO/e2+G3xpuQyuoABEfr5Vqsp7oF4+JLvZz1fM0HOdgbYM+IqFYKsvs9v6v30rKygK3/Wb/ANQG73lACANykzQvFsMfYFQctzefDwjQVqspRAt+ULvEnDhcQLbuDYAqZBkeMbRVlw2JisrK+b1oC1MSse2FnFzXC3FJggwRuNCDyrKys0Ds2oBMVUAtOtWWRc1Xqs1zcVyBcXJI30IrVZX1K9Qz4kh5nMOdZXXzrdZWUzaIvcZ//9k=', N'Mừng tiệc thôi nôi')
INSERT [dbo].[EventType] ([EventTypeID], [Name], [Image], [Description]) VALUES (2, N'Sinh Nhật', N'data:image/jpeg;base64,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', N'Tiệc sinh nhật mừng bé được 2 tuổi')
INSERT [dbo].[EventType] ([EventTypeID], [Name], [Image], [Description]) VALUES (3, N'Mừng Thượng Thọ', N'https://sites.google.com/site/ojovietnam/_/rsrc/1429397733998/cam-nang-cuoc-song/tuyen-tap-bai-van-cung-khan-co-truyen/bai-van-cung-khan-ngay-le-thuong-tho/van%20khan%20thuong%20tho%20www.OJO.vn.jpg', N'Tiệc mừng đại thọ cho những người lớn tuổi.')
INSERT [dbo].[EventType] ([EventTypeID], [Name], [Image], [Description]) VALUES (4, N'Tiệc Đoàn Viên', N'https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.nhahangquangon.com%2Fnha-hang-to-chuc-tiec-hop-mat-doan-vien-ben-gia-dinh-mua-trung-thu%2F&psig=AOvVaw1wX1EotFM5rXceordr8_m4&ust=1676624016715000&source=images&cd=vfe&ved=0CBAQjRxqFwoTCOifxKnVmf0CFQAAAAAdAAAAABAE', N'Tiệc đàon viên được tổ chức dành cho 1 vài thành viên xa nhà lâu ngày')
SET IDENTITY_INSERT [dbo].[EventType] OFF
GO
SET IDENTITY_INSERT [dbo].[Food] ON 

INSERT [dbo].[Food] ([ProductID], [Name], [Dish], [Price], [ComboFood], [Description], [Ingredient], [Origin], [CookingRecipe], [Image], [FoodTypeID], [Status]) VALUES (1, N'Chả Giò Cuộn Tôm', N'Đồ chiên', 130000.0000, N'1', N'Chả giò tôm là món ăn quen thuộc luôn có mặt trong mâm cỗ đãi khách khứa, nhất là vào ngày Tết. Chả giò giòn rụm, vị tôm ngọt quyện với thịt đậm đà khiến món ăn thêm thú vị.', N'tôm, thịt, trứng gà, cà rốt, nắm mèo,...', N'Nó bắt nguồn từ châu á và Chả giò tôm là món ăn quen thuộc luôn có mặt trong mâm cỗ đãi khách khứa, nhất là vào ngày Tết', NULL, N'https://cdn.tgdd.vn/Files/2020/01/16/1231776/cach-lam-cha-gio-tom-thit-thom-ngon-gion-lau-don-gian-tai-nha-202202241337289905.jpg', 1, 1)
INSERT [dbo].[Food] ([ProductID], [Name], [Dish], [Price], [ComboFood], [Description], [Ingredient], [Origin], [CookingRecipe], [Image], [FoodTypeID], [Status]) VALUES (2, N'Gỏi Ngó Sen', N'Món Gỏi', 45000.0000, N'1', N'Gỏi ngó sen tôm thịt là món gỏi phổ biến trong các bữa tiệc, được nhiều người yêu thích bởi hương vị thanh ngọt của tôm, thịt, giòn giòn chua chua của rau củ. Cùng vào bếp với Điện máy XANH học ngay cách làm món gỏi thơm ngon đơn giản tại nhà mà ai cũng thực hiện được nhé!', N'Tôm sú, Thịt Ba chỉ, ngó sen, cà rốt, hành tây, đậu phộng, rau răm, nước mắm, muối,....', N'Nó có nguồn gốc từ châu á. Đây là món ăn hấp dẫn và mang nhiều nét văn hóa của châu á', NULL, N'https://cdn.tgdd.vn/Files/2020/05/25/1258272/cach-lam-goi-ngo-sen-tom-thit-gion-ngon-don-gian-t.png', 1, 1)
INSERT [dbo].[Food] ([ProductID], [Name], [Dish], [Price], [ComboFood], [Description], [Ingredient], [Origin], [CookingRecipe], [Image], [FoodTypeID], [Status]) VALUES (3, N'Gà luộc', N'Món Luộc', 200000.0000, N'1', N'Món gà luộc là món ăn quen thuộc của người dân châu á trong những bữa tiệc', N'gà, muối, nước sôi, củ hành,...', N'Nó là món ăn gắn liền với mọi người', NULL, N'https://www.google.com/imgres?imgurl=https%3A%2F%2Fdanviet.mediacdn.vn%2F296231569849192448%2F2022%2F1%2F5%2F2403934595972026447777088179741936280533947n-16413609296771577835143.jpg&imgrefurl=https%3A%2F%2Fdanviet.vn%2Fluoc-ga-da-vang-uom-hap-dan-chi-can-dung-thu-nuoc-nay-20220105124932906.htm&tbnid=NAPfGjMFNwLuHM&vet=12ahUKEwi3jJKk3Zn9AhXQL7cAHVs9BPoQMygGegUIARDRAQ..i&docid=i_VnqJ6tBU12vM&w=960&h=960&q=g%C3%A0%20lu%E1%BB%99c&ved=2ahUKEwi3jJKk3Zn9AhXQL7cAHVs9BPoQMygGegUIARDRAQ', 1, 1)
INSERT [dbo].[Food] ([ProductID], [Name], [Dish], [Price], [ComboFood], [Description], [Ingredient], [Origin], [CookingRecipe], [Image], [FoodTypeID], [Status]) VALUES (14, N'Gà luộc', N'Món Luộc', 200000.0000, N'1', N'Món gà luộc gắn liền với mọi người trong các bữa tiệc lớn', N'gà, muối, nước sôi,....', N'Đây là món ăn gắn liền với mọi ngườ', NULL, N'https://www.google.com/imgres?imgurl=http%3A%2F%2Fcdn.tgdd.vn%2FFiles%2F2020%2F08%2F11%2F1278766%2Fcach-moi-nhanh-va-de-giup-luoc-ga-khong-rach-da-chat-gon-dep-chi-muon-thu-ngay-202202141453268654.jpg&imgrefurl=https%3A%2F%2Fwww.bachhoaxanh.com%2Fkinh-nghiem-hay%2Fcach-moi-nhanh-va-de-giup-luoc-ga-khong-rach-da-chat-gon-dep-doc-xong-chi-muon-thu-ngay-1278766&tbnid=ccdVcPMvPwDpmM&vet=12ahUKEwi3jJKk3Zn9AhXQL7cAHVs9BPoQMygAegUIARDCAQ..i&docid=v1rzmFUvilqStM&w=760&h=442&q=g%C3%A0%20lu%E1%BB%99c&ved=2ahUKEwi3jJKk3Zn9AhXQL7cAHVs9BPoQMygAegUIARDCAQ', 2, 1)
INSERT [dbo].[Food] ([ProductID], [Name], [Dish], [Price], [ComboFood], [Description], [Ingredient], [Origin], [CookingRecipe], [Image], [FoodTypeID], [Status]) VALUES (20, N'Gà luộc', N'Món Luộc', 200000.0000, N'1', N'Món gà luộc gắn liền với mọi người trong các bữa tiệc lớn', N'gà, muối, nước sôi,....', N'Đây là món ăn gắn liền với mọi ngườ', NULL, N'https://www.google.com/imgres?imgurl=http%3A%2F%2Fcdn.tgdd.vn%2FFiles%2F2020%2F08%2F11%2F1278766%2Fcach-moi-nhanh-va-de-giup-luoc-ga-khong-rach-da-chat-gon-dep-chi-muon-thu-ngay-202202141453268654.jpg&imgrefurl=https%3A%2F%2Fwww.bachhoaxanh.com%2Fkinh-nghiem-hay%2Fcach-moi-nhanh-va-de-giup-luoc-ga-khong-rach-da-chat-gon-dep-doc-xong-chi-muon-thu-ngay-1278766&tbnid=ccdVcPMvPwDpmM&vet=12ahUKEwi3jJKk3Zn9AhXQL7cAHVs9BPoQMygAegUIARDCAQ..i&docid=v1rzmFUvilqStM&w=760&h=442&q=g%C3%A0%20lu%E1%BB%99c&ved=2ahUKEwi3jJKk3Zn9AhXQL7cAHVs9BPoQMygAegUIARDCAQ', 3, 1)
INSERT [dbo].[Food] ([ProductID], [Name], [Dish], [Price], [ComboFood], [Description], [Ingredient], [Origin], [CookingRecipe], [Image], [FoodTypeID], [Status]) VALUES (23, N'Súp Nghêu', N'Món Soup', 123000.0000, N'1', N'Trong các món ăn ngon, nổi tiếng ở Mỹ bạn không thể không nhắc tới món súp nghêu.  Món súp được chế biến một cách vô cùng đặc biệt và cẩn thận. Ở Mỹ có nhiều loại súp khác nhau. Nhưng đặc biệt nhất là loại súp có tên gọi Massachuset. Bạn có thể tự làm món ăn này với các nguyên liệu như thịt lợn muối, nghêu, khoai tây, hành tây, gia vị. Nhưng có một nguyên tắc bất thành văn là khi nấu món ngon này. Bạn nhất định không được cho cà chua vào nấu cùng nghêu.', N'Nghêu, thịt lợn muối, khoai tây, hành tây', N'nổi tiếng ở Mỹ bạn không thể không nhắc tới món súp nghêu', NULL, N'https://vanhoagiaoduc.com.vn/wp-content/uploads/2021/04/am-thuc-noi-tieng-nhat-chau-my-ban-nen-thu-mot-lan-trong-doi-clam-chowder-00-1024x576-1.jpg', 2, 1)
INSERT [dbo].[Food] ([ProductID], [Name], [Dish], [Price], [ComboFood], [Description], [Ingredient], [Origin], [CookingRecipe], [Image], [FoodTypeID], [Status]) VALUES (24, N'Coxinhas', N'Món Chiên', 100000.0000, N'1', N'Nhắc đến 59 món ngon châu Mỹ, không hề bỏ lỡ món Coxinhas – món ăn có hình giọt nước của Brazil. Với những nguyên vật liệu chính là thịt gà, hánh tây, trứng, cà rốt và gia vị. Bánh coxinhas có lớp vỏ giòn và nhân thơm, mềm ', N'thảo dược Guasa, thịt gà, khoai tây,kem chua,....', N' Món ăn có hình giọt nước của Brazil là một món ăn độc đáo và ngon', NULL, N'https://ximgo.com/upload/2020/06/24/118911_original.jpg', 2, 1)
INSERT [dbo].[Food] ([ProductID], [Name], [Dish], [Price], [ComboFood], [Description], [Ingredient], [Origin], [CookingRecipe], [Image], [FoodTypeID], [Status]) VALUES (25, N'Caesar salad', N'Salad', 50000.0000, N'1', N'Nhắc tới món ăn châu âu thì không thể thiếu  không thể thiếu salad ', N'xà lách, phô mai, thịt xông khói', N'Món ăn này bắt nguồn từ châu âu', NULL, N'https://cdn.tgdd.vn/2021/06/content/a2-800x450-1.jpg', 3, 1)
INSERT [dbo].[Food] ([ProductID], [Name], [Dish], [Price], [ComboFood], [Description], [Ingredient], [Origin], [CookingRecipe], [Image], [FoodTypeID], [Status]) VALUES (26, N'Bò Hầm Rau Củ', N'Món Hầm', 210000.0000, N'1', N'Mang hương vị của nhà hàng hạng sang về nhà bạn với món bò hầm rau củ kiểu Pháp độc đáo này thôi nào.', N'cà rốt, nấm, linh chi trắng, thịt bò, khoai tây', N'Điểm nhấn của món bò hầm rau củ này chính là phần nước sốt, vị ngọt của nước sốt chính là sự kết hợp hài hòa của vị ngọt từ thịt bò và ngọt thanh từ các loại rau củ như cà rốt, nấm linh chi trắng, khoai tây, hành tây,... nấu cùng.', NULL, N'https://cdn.tgdd.vn/2021/06/content/a6-800x450-1.jpg', 3, 1)
INSERT [dbo].[Food] ([ProductID], [Name], [Dish], [Price], [ComboFood], [Description], [Ingredient], [Origin], [CookingRecipe], [Image], [FoodTypeID], [Status]) VALUES (27, N'Cá hồi sốt chanh dây', N'sốt', 260000.0000, N'1', N'Cá hồi sốt chanh dây là món ăn vừa thơm ngon, vừa đầy dinh dưỡng. Phần thịt cá hồi áp chảo vàng thơm, pha thêm chút màu xanh tươi của măng tây và bông cải, màu đỏ của cà chua, cà rốt, màu vàng của khoai tây.', N'mỳ, cà chua, thịt cá hồi', N'Cá hồi sốt chanh dây là món ăn vừa thơm ngon, vừa đầy dinh dưỡng. Phần thịt cá hồi áp chảo vàng thơm, pha thêm chút màu xanh tươi của măng tây và bông cải, màu đỏ của cà chua, cà rốt, màu vàng của khoai tây.', NULL, N'https://cdn.tgdd.vn/2021/06/content/a7-800x450-1.jpg', 3, 1)
SET IDENTITY_INSERT [dbo].[Food] OFF
GO
SET IDENTITY_INSERT [dbo].[FoodType] ON 

INSERT [dbo].[FoodType] ([FoodTypeID], [Name], [Detail]) VALUES (1, N'Châu Á', N'các món ăn nổi tiếng được tuyển chọn từ thực đơn tại Châu Á')
INSERT [dbo].[FoodType] ([FoodTypeID], [Name], [Detail]) VALUES (2, N'Châu Mỹ', N'Các món ăn ngon, nổi tiếng được tuyển chọn từ thực đơn tại Châu Mỹ.')
INSERT [dbo].[FoodType] ([FoodTypeID], [Name], [Detail]) VALUES (3, N'Châu Âu', N'Món ngon, nổi tiếng được tuyển chọn từ thực đơn tại Châu Âu')
INSERT [dbo].[FoodType] ([FoodTypeID], [Name], [Detail]) VALUES (4, N'Châu Phi', N'các món ăn đến từ châu phi đa phần là món khô và dễ ăn')
SET IDENTITY_INSERT [dbo].[FoodType] OFF
GO
SET IDENTITY_INSERT [dbo].[Game] ON 

INSERT [dbo].[Game] ([GameID], [Name], [Price], [Details], [Rules], [Reward], [Supplies], [Image], [Status]) VALUES (1, N'Oẵn Tù Tì', 0.0000, N'Trò chơi nhân gian', N'Người chơi ra kéo búa bao tùy ý trong 3 tiếng điếm', N'3 phần thưởng dành cho thứ tự nhất,nhì và ba', N'Nhà Hàng', N'https://st.gamevui.com/images/image/2020/11/23/oan-tu-ti-640.jpg', 1)
INSERT [dbo].[Game] ([GameID], [Name], [Price], [Details], [Rules], [Reward], [Supplies], [Image], [Status]) VALUES (3, N'Đuổi hình bắt chữ', 0.0000, N'Trò chơi nhân gian', N'Người chơi nhìn hình ảnh đoán nội dung', N'3 phần thưởng dành cho thứ tự nhất,nhì và ba', N'Nhà Hàng', N'https://gpbanmethuot.net/uploads/news/2021_04/game-130421d.jpg', 1)
INSERT [dbo].[Game] ([GameID], [Name], [Price], [Details], [Rules], [Reward], [Supplies], [Image], [Status]) VALUES (4, N'Qủa bóng ma thuật', 0.0000, N'Trò chơi nhân gian', N'thành viên BTC sẽ chuẩn bị các phần quà và đánh số tương ứng. Sau đó ghi các nhiệm vụ và số của các phần quà vào mảnh giấy nhỏ, bỏ ngẫu nhiên vào các quả bóng bay. Mỗi quả bóng sẽ chứa 1 thẻ nhiệm vụ cùng 1 phần quà.', N'Các phần quà tương ứng nhiệm vụ', N'Nhà Hàng', N'https://www.google.com/url?sa=i&url=https%3A%2F%2Fgiadinh.suckhoedoisong.vn%2Fde-bong-khi-no-bong-bay-172130909113539626.htm&psig=AOvVaw38tnX0_0Fa0uXosDOG95KI&ust=1676610591751000&source=images&cd=vfe&ved=2ahUKEwixuKCno5n9AhVqQ2wGHUcgDvgQjRx6BAgAEAo', 1)
INSERT [dbo].[Game] ([GameID], [Name], [Price], [Details], [Rules], [Reward], [Supplies], [Image], [Status]) VALUES (6, N'Giọng Hát Vàng', 0.0000, N'Trò chơi random', N'chọn ngẫu nhiên 5 người chơi', N'1 phần quà giá trị', N'Nhà Hàng', N'data:image/png;base64,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', 1)
SET IDENTITY_INSERT [dbo].[Game] OFF
GO
SET IDENTITY_INSERT [dbo].[Menu] ON 

INSERT [dbo].[Menu] ([MenuID], [Name], [Status], [PriceTotal]) VALUES (1, N'Menu Thôi Nôi', 1, 1200000.0000)
INSERT [dbo].[Menu] ([MenuID], [Name], [Status], [PriceTotal]) VALUES (2, N'Menu Sinh Nhật', 1, 1520000.0000)
SET IDENTITY_INSERT [dbo].[Menu] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductID], [Name], [Price], [Quantity], [Details], [Image], [Supplier], [Status]) VALUES (1, N'Đèn', 0.0000, 50, N'Đèn Flash', N'https://www.google.com/url?sa=i&url=http%3A%2F%2Fphukienmayanhdslr.com%2Fden-flash-godox-ad100pro-godox-ad100-pro-100w&psig=AOvVaw35gvIGZXqHaqYzEp-C7KvG&ust=1676612499006000&source=images&cd=vfe&ved=2ahUKEwjyhdq0qpn9AhW9W2wGHdCsDNcQjRx6BAgAEAo', N'Nhà Hàng', 1)
INSERT [dbo].[Product] ([ProductID], [Name], [Price], [Quantity], [Details], [Image], [Supplier], [Status]) VALUES (2, N'Micro', 0.0000, 10, N'Micro chuyên dụng', N'https://baochauelec.com/cdn1/images/202006/goods_img/micro-shure-sm58--lc-G1593-1591070245259.jpg', N'Nhà Hàng', 1)
INSERT [dbo].[Product] ([ProductID], [Name], [Price], [Quantity], [Details], [Image], [Supplier], [Status]) VALUES (3, N'Đạo Cụ Chuyên Dụng', 0.0000, 100, N'Các đồ vật chuyên dụng', NULL, N'Nhà Hàng', 1)
INSERT [dbo].[Product] ([ProductID], [Name], [Price], [Quantity], [Details], [Image], [Supplier], [Status]) VALUES (4, N'Hoa trang trí', 0.0000, 100, N'Hoa chuyên dụng thường trang trí cho các sự kiện thích hợp', N'https://handydecor.com.vn/wp-content/uploads/2020/05/trang-tri-sinh-nhat-cho-be-tong-xanh-4.jpg', N'Nhà Hàng', 1)
INSERT [dbo].[Product] ([ProductID], [Name], [Price], [Quantity], [Details], [Image], [Supplier], [Status]) VALUES (5, N'Ghế', 0.0000, 1500, N'Ghế Ngồi cho khách', N'https://hoaphatgiasi.vn/wp-content/uploads/2019/08/Gh%E1%BA%BF-b%C3%A0n-%C4%83n-ga720tn.jpg', N'Nhà Hàng', 1)
INSERT [dbo].[Product] ([ProductID], [Name], [Price], [Quantity], [Details], [Image], [Supplier], [Status]) VALUES (6, N'bàn', 0.0000, 1000, N'Bàn cho khách ngồi', N'https://kalina.com.vn/wp-content/uploads/2019/07/goi-y-cach-sap-xep-cho-ngoi-hop-ly-trong-dam-cuoi-1.jpg', N'Nhà Hàng', 1)
INSERT [dbo].[Product] ([ProductID], [Name], [Price], [Quantity], [Details], [Image], [Supplier], [Status]) VALUES (8, N'Quần,áo', 0.0000, 35, N'Lễ Phục phù hợp', NULL, N'Nhà Hàng', 1)
INSERT [dbo].[Product] ([ProductID], [Name], [Price], [Quantity], [Details], [Image], [Supplier], [Status]) VALUES (9, N'Gìay', 0.0000, 20, N'Giay đạo cụ', NULL, N'Nhà Hàng', 1)
INSERT [dbo].[Product] ([ProductID], [Name], [Price], [Quantity], [Details], [Image], [Supplier], [Status]) VALUES (12, N'Máy Lạnh', 0.0000, 40, N'Máy lạnh công suất lớn', N'https://www.google.com/url?sa=i&url=https%3A%2F%2Fmaylanhgiasi.net%2Fcong-suat%2F-4-ngua-4-hp-7.html&psig=AOvVaw1anFwPXbNG9Prve2hv5x75&ust=1676616925749000&source=images&cd=vfe&ved=2ahUKEwjT_cTzupn9AhXKErcAHc2CAy4QjRx6BAgAEAo', N'Nhà Hàng', 1)
INSERT [dbo].[Product] ([ProductID], [Name], [Price], [Quantity], [Details], [Image], [Supplier], [Status]) VALUES (13, N'Banner', 0.0000, 10, N'Banner giúp cho bữa tiệc thêm sinh động', NULL, N'Nhà Hàng', 1)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[Script] ON 

INSERT [dbo].[Script] ([id], [Name], [Status], [ScriptContent]) VALUES (1, N'Tiệc Sinh Nhật Gia Khôi', 1, N'Mừng sinh nhật Gia Khôi được 5 tuổi')
INSERT [dbo].[Script] ([id], [Name], [Status], [ScriptContent]) VALUES (3, N'Tiệc Đại Thọ Cụ Ông Lê Ánh Dương ', 1, N'Đại gia đình và con cháu cùng tổ chức tiệc đại thọ cho cụ ông.')
INSERT [dbo].[Script] ([id], [Name], [Status], [ScriptContent]) VALUES (4, N'Tiệc Thôi Nôi Bé Hải Tú ', 1, N'Tiệc Thôi nôi chúc mừng bé Hải Tú tròn 1 tuổi')
SET IDENTITY_INSERT [dbo].[Script] OFF
GO
SET IDENTITY_INSERT [dbo].[Show] ON 

INSERT [dbo].[Show] ([ShowID], [Price], [Name], [Light], [Sound], [Singer], [Description], [Image], [Status]) VALUES (2, 500000.0000, N'Ca nhạc', N'6 đèn flash', N'6 đạo cụ ', N'Đan trường, Cẩm Ly, Thủy Tiên', N'', N'https://www.google.com/url?sa=i&url=https%3A%2F%2Fvideohive.net%2Fitem%2Fmusic-show%2F13932551&psig=AOvVaw3Q-2eq6w7VHaCxveiZ6XLt&ust=1676609016940000&source=images&cd=vfe&ved=0CBAQjRxqFwoTCLi4lbmdmf0CFQAAAAAdAAAAABAZ', 1)
INSERT [dbo].[Show] ([ShowID], [Price], [Name], [Light], [Sound], [Singer], [Description], [Image], [Status]) VALUES (5, 650000.0000, N'Ca Nhạc, Diễn kịch', N'6 Đèn Flash', N'Đạo cụ chuyên dụng', N'Nhóm Nhạc Five six, Nhóm Kịch Funny Day', N'Có nhiều năm kinh nghiệm biễu diễn cũng như ca hát', N'data:image/jpeg;base64,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', 1)
INSERT [dbo].[Show] ([ShowID], [Price], [Name], [Light], [Sound], [Singer], [Description], [Image], [Status]) VALUES (6, 550000.0000, N'MC, Ca Sỹ,', N'đèn flash, khói', N'', N'Đàm Vĩnh Hưng, Khắc Việt, Mỹ Tâm, Mc.Trấn Thành', N'Đây là những Ca Sỹ và Mc nổi tiếng thường được nhiều người hâm mộ yêu quý', N'https://www.google.com/url?sa=i&url=https%3A%2F%2Fphukiensankhau.com%2Fcach-thiet-ke-den-san-khau-sao-cho-hieu-qua&psig=AOvVaw3S53-q6TFKFBhJn8TDB-sf&ust=1676609743398000&source=images&cd=vfe&ved=2ahUKEwjZhN2SoJn9AhVeDLcAHcNfDXkQjRx6BAgAEAo', 1)
INSERT [dbo].[Show] ([ShowID], [Price], [Name], [Light], [Sound], [Singer], [Description], [Image], [Status]) VALUES (7, 450000.0000, N'MC,Ca sỹ', N'Đèn Flash', N'đàn ghi-ta', N'Ngô Kiến Huy', N'Tiệc mục hứa hẹn mang đến nhiều điều hấp dẫn', N'https://ely.com.vn/wp-content/uploads/2020/09/san-khau-cuoi-rooftop.jpg', 1)
SET IDENTITY_INSERT [dbo].[Show] OFF
GO
ALTER TABLE [dbo].[ChatMessage]  WITH CHECK ADD  CONSTRAINT [FK_ChatMessage_EventBooker] FOREIGN KEY([EventBookerID])
REFERENCES [dbo].[EventBooker] ([ID])
GO
ALTER TABLE [dbo].[ChatMessage] CHECK CONSTRAINT [FK_ChatMessage_EventBooker]
GO
ALTER TABLE [dbo].[DateTimeLocation]  WITH CHECK ADD  CONSTRAINT [FK_DateTimeLocation_Event] FOREIGN KEY([EventID])
REFERENCES [dbo].[Event] ([EventID])
GO
ALTER TABLE [dbo].[DateTimeLocation] CHECK CONSTRAINT [FK_DateTimeLocation_Event]
GO
ALTER TABLE [dbo].[DateTimeLocation]  WITH CHECK ADD  CONSTRAINT [FK_DateTimeLocation_Room] FOREIGN KEY([RoomID])
REFERENCES [dbo].[Room] ([RoomID])
GO
ALTER TABLE [dbo].[DateTimeLocation] CHECK CONSTRAINT [FK_DateTimeLocation_Room]
GO
ALTER TABLE [dbo].[DecorationProduct]  WITH CHECK ADD  CONSTRAINT [FK_DecorationProduct_Decoration] FOREIGN KEY([DecorationID])
REFERENCES [dbo].[Decoration] ([DecorationID])
GO
ALTER TABLE [dbo].[DecorationProduct] CHECK CONSTRAINT [FK_DecorationProduct_Decoration]
GO
ALTER TABLE [dbo].[DecorationProduct]  WITH CHECK ADD  CONSTRAINT [FK_DecorationProduct_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[DecorationProduct] CHECK CONSTRAINT [FK_DecorationProduct_Product]
GO
ALTER TABLE [dbo].[EntertainmentProduct]  WITH CHECK ADD  CONSTRAINT [FK_EntertainmentProduct_Entertainment] FOREIGN KEY([EntertainmentID])
REFERENCES [dbo].[Entertainment] ([EntertainmentID])
GO
ALTER TABLE [dbo].[EntertainmentProduct] CHECK CONSTRAINT [FK_EntertainmentProduct_Entertainment]
GO
ALTER TABLE [dbo].[EntertainmentProduct]  WITH CHECK ADD  CONSTRAINT [FK_EntertainmentProduct_Game] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Game] ([GameID])
GO
ALTER TABLE [dbo].[EntertainmentProduct] CHECK CONSTRAINT [FK_EntertainmentProduct_Game]
GO
ALTER TABLE [dbo].[EntertainmentProduct]  WITH CHECK ADD  CONSTRAINT [FK_EntertainmentShow_Show] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Show] ([ShowID])
GO
ALTER TABLE [dbo].[EntertainmentProduct] CHECK CONSTRAINT [FK_EntertainmentShow_Show]
GO
ALTER TABLE [dbo].[Event]  WITH CHECK ADD  CONSTRAINT [FK_Event_Decoration] FOREIGN KEY([DecorationID])
REFERENCES [dbo].[Decoration] ([DecorationID])
GO
ALTER TABLE [dbo].[Event] CHECK CONSTRAINT [FK_Event_Decoration]
GO
ALTER TABLE [dbo].[Event]  WITH CHECK ADD  CONSTRAINT [FK_Event_Entertainment] FOREIGN KEY([EntertainmentID])
REFERENCES [dbo].[Entertainment] ([EntertainmentID])
GO
ALTER TABLE [dbo].[Event] CHECK CONSTRAINT [FK_Event_Entertainment]
GO
ALTER TABLE [dbo].[Event]  WITH CHECK ADD  CONSTRAINT [FK_Event_EventBooker] FOREIGN KEY([EventBookerID])
REFERENCES [dbo].[EventBooker] ([ID])
GO
ALTER TABLE [dbo].[Event] CHECK CONSTRAINT [FK_Event_EventBooker]
GO
ALTER TABLE [dbo].[Event]  WITH CHECK ADD  CONSTRAINT [FK_Event_EventType] FOREIGN KEY([EventTypeID])
REFERENCES [dbo].[EventType] ([EventTypeID])
GO
ALTER TABLE [dbo].[Event] CHECK CONSTRAINT [FK_Event_EventType]
GO
ALTER TABLE [dbo].[Event]  WITH CHECK ADD  CONSTRAINT [FK_Event_Menu] FOREIGN KEY([MenuID])
REFERENCES [dbo].[Menu] ([MenuID])
GO
ALTER TABLE [dbo].[Event] CHECK CONSTRAINT [FK_Event_Menu]
GO
ALTER TABLE [dbo].[Event]  WITH CHECK ADD  CONSTRAINT [FK_Event_Script] FOREIGN KEY([ScriptID])
REFERENCES [dbo].[Script] ([id])
GO
ALTER TABLE [dbo].[Event] CHECK CONSTRAINT [FK_Event_Script]
GO
ALTER TABLE [dbo].[EventBooker]  WITH CHECK ADD  CONSTRAINT [FK_EventBooker_Account] FOREIGN KEY([ID])
REFERENCES [dbo].[Account] ([ID])
GO
ALTER TABLE [dbo].[EventBooker] CHECK CONSTRAINT [FK_EventBooker_Account]
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD  CONSTRAINT [FK_Food_FoodType] FOREIGN KEY([FoodTypeID])
REFERENCES [dbo].[FoodType] ([FoodTypeID])
GO
ALTER TABLE [dbo].[Food] CHECK CONSTRAINT [FK_Food_FoodType]
GO
ALTER TABLE [dbo].[MenuDrink]  WITH CHECK ADD  CONSTRAINT [FK_MenuDrink_Drink] FOREIGN KEY([DrinkID])
REFERENCES [dbo].[Drink] ([ProductID])
GO
ALTER TABLE [dbo].[MenuDrink] CHECK CONSTRAINT [FK_MenuDrink_Drink]
GO
ALTER TABLE [dbo].[MenuDrink]  WITH CHECK ADD  CONSTRAINT [FK_MenuDrink_Menu] FOREIGN KEY([MenuID])
REFERENCES [dbo].[Menu] ([MenuID])
GO
ALTER TABLE [dbo].[MenuDrink] CHECK CONSTRAINT [FK_MenuDrink_Menu]
GO
ALTER TABLE [dbo].[MenuProduct]  WITH CHECK ADD  CONSTRAINT [FK_MenuFood_Food] FOREIGN KEY([Product])
REFERENCES [dbo].[Food] ([ProductID])
GO
ALTER TABLE [dbo].[MenuProduct] CHECK CONSTRAINT [FK_MenuFood_Food]
GO
ALTER TABLE [dbo].[MenuProduct]  WITH CHECK ADD  CONSTRAINT [FK_MenuFood_Menu] FOREIGN KEY([MenuID])
REFERENCES [dbo].[Menu] ([MenuID])
GO
ALTER TABLE [dbo].[MenuProduct] CHECK CONSTRAINT [FK_MenuFood_Menu]
GO
ALTER TABLE [dbo].[MenuProduct]  WITH CHECK ADD  CONSTRAINT [FK_MenuProduct_Drink] FOREIGN KEY([Product])
REFERENCES [dbo].[Drink] ([ProductID])
GO
ALTER TABLE [dbo].[MenuProduct] CHECK CONSTRAINT [FK_MenuProduct_Drink]
GO
ALTER TABLE [dbo].[Participant]  WITH CHECK ADD  CONSTRAINT [FK_Participant_Event] FOREIGN KEY([EventID])
REFERENCES [dbo].[Event] ([EventID])
GO
ALTER TABLE [dbo].[Participant] CHECK CONSTRAINT [FK_Participant_Event]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Event] FOREIGN KEY([EventID])
REFERENCES [dbo].[Event] ([EventID])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_Event]
GO
