USE [master]
GO
/****** Object:  Database [Game_DB]    Script Date: 22/11/23 01:20:24 PM ******/
CREATE DATABASE [Game_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Game_DB', FILENAME = N'C:\Users\Asus\Desktop\SQL servrer\MSSQL16.SQLEXPRESS\MSSQL\DATA\Game_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Game_DB_log', FILENAME = N'C:\Users\Asus\Desktop\SQL servrer\MSSQL16.SQLEXPRESS\MSSQL\DATA\Game_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Game_DB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Game_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Game_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Game_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Game_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Game_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Game_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [Game_DB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Game_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Game_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Game_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Game_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Game_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Game_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Game_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Game_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Game_DB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Game_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Game_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Game_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Game_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Game_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Game_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Game_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Game_DB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Game_DB] SET  MULTI_USER 
GO
ALTER DATABASE [Game_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Game_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Game_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Game_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Game_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Game_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Game_DB] SET QUERY_STORE = ON
GO
ALTER DATABASE [Game_DB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Game_DB]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 22/11/23 01:20:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[AdminID] [nvarchar](50) NOT NULL,
	[AdName] [nvarchar](255) NULL,
	[PassWord] [nvarchar](255) NULL,
	[FirstName] [nvarchar](255) NULL,
	[LastName] [nvarchar](255) NULL,
	[IsActive] [nvarchar](255) NULL,
	[DateOfBirth] [date] NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[AdminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 22/11/23 01:20:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CateID] [nvarchar](50) NOT NULL,
	[CateName] [nvarchar](255) NULL,
	[CateDes] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 22/11/23 01:20:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[UID] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](255) NOT NULL,
	[LastName] [nvarchar](255) NOT NULL,
	[UserName] [nvarchar](255) NOT NULL,
	[PassWord] [nvarchar](255) NOT NULL,
	[Email] [nvarchar](255) NULL,
	[Phone] [nvarchar](12) NULL,
	[Image] [nvarchar](255) NULL,
	[Balance] [int] NULL,
	[IsActive] [nvarchar](10) NULL,
	[DayOfBirth] [date] NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Developer]    Script Date: 22/11/23 01:20:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Developer](
	[Dev_ID] [nvarchar](50) NOT NULL,
	[Developer] [nvarchar](255) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Logo] [nvarchar](255) NULL,
	[IsActive] [nvarchar](10) NULL,
 CONSTRAINT [PK_Developer] PRIMARY KEY CLUSTERED 
(
	[Dev_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Discount]    Script Date: 22/11/23 01:20:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discount](
	[DiscountID] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](255) NULL,
	[DiscountType] [nvarchar](50) NULL,
	[DiscountValue] [int] NOT NULL,
	[Code] [nvarchar](255) NULL,
	[AdminID] [nvarchar](50) NULL,
 CONSTRAINT [PK_Discount] PRIMARY KEY CLUSTERED 
(
	[DiscountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Game]    Script Date: 22/11/23 01:20:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Game](
	[GameID] [nvarchar](50) NOT NULL,
	[GameName] [nvarchar](255) NULL,
	[GameDes] [nvarchar](max) NULL,
	[Price] [int] NULL,
	[Thumbnail] [nvarchar](255) NULL,
	[Video] [nvarchar](255) NULL,
	[DevID] [nvarchar](50) NULL,
	[PublisherID] [nvarchar](50) NULL,
	[ReleaseDate] [date] NULL,
	[View] [int] NULL,
	[isActive] [nvarchar](10) NULL,
 CONSTRAINT [PK_Game] PRIMARY KEY CLUSTERED 
(
	[GameID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Game_Categories]    Script Date: 22/11/23 01:20:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Game_Categories](
	[GameID] [nvarchar](50) NOT NULL,
	[CateID] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Game_Categories] PRIMARY KEY CLUSTERED 
(
	[GameID] ASC,
	[CateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Game_Image]    Script Date: 22/11/23 01:20:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Game_Image](
	[GameID] [nvarchar](50) NOT NULL,
	[ImageID] [nvarchar](50) NOT NULL,
	[ImageName] [nvarchar](255) NULL,
	[ImageDes] [nvarchar](max) NULL,
	[AdminID] [nvarchar](50) NULL,
 CONSTRAINT [PK_Game_Image] PRIMARY KEY CLUSTERED 
(
	[GameID] ASC,
	[ImageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Libraries]    Script Date: 22/11/23 01:20:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Libraries](
	[UID] [nvarchar](50) NOT NULL,
	[GameID] [nvarchar](50) NOT NULL,
	[isLike] [int] NULL,
	[FeedBack] [nvarchar](255) NULL,
 CONSTRAINT [PK_Libraries] PRIMARY KEY CLUSTERED 
(
	[UID] ASC,
	[GameID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 22/11/23 01:20:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderID] [nvarchar](50) NOT NULL,
	[UID] [nvarchar](50) NOT NULL,
	[OrderDate] [date] NULL,
	[PaymentID] [nvarchar](50) NULL,
	[Amount] [int] NULL,
	[DiscountID] [nvarchar](50) NULL,
	[Total] [int] NULL,
 CONSTRAINT [PK_Order_1] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 22/11/23 01:20:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderID] [nvarchar](50) NOT NULL,
	[GameID] [nvarchar](50) NOT NULL,
	[Prices] [nchar](10) NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[GameID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShoppingCart]    Script Date: 22/11/23 01:20:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShoppingCart](
	[GameID] [nvarchar](50) NOT NULL,
	[UID] [nvarchar](50) NOT NULL,
	[Des] [nvarchar](max) NULL,
 CONSTRAINT [PK_ShoppingCart] PRIMARY KEY CLUSTERED 
(
	[GameID] ASC,
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Categories] ([CateID], [CateName], [CateDes]) VALUES (N'1df21144-63d2-4c4b-ae38-5c2a423757e9', N'FPS', N'Bắn súng góc nhìn người thứ nhất là một thể loại trò chơi điện tử tập trung xung quanh các loại súng và các cuộc chiến dựa trên vũ khí theo góc nhìn người thứ nhất; đó là góc nhìn của người chơi trải nghiệm hành động thông qua mắt của nhân vật chính.')
INSERT [dbo].[Categories] ([CateID], [CateName], [CateDes]) VALUES (N'24441dcb-8608-4637-b1d3-7f600c740aeb', N'Board Game', N'Trò chơi bàn cờ là một trò chơi trên bàn, gồm các quân trên bàn được cho di chuyển hoặc đặt trên một bề mặt phẳng hay bảng được đánh dấu sẵn và thường bao gồm các yếu tố của trò chơi trên bàn, thẻ bài, nhập vai và trò chơi thu nhỏ. Hầu hết là sự cạnh tranh giữa hai hoặc nhiều người chơi.')
INSERT [dbo].[Categories] ([CateID], [CateName], [CateDes]) VALUES (N'4e2f9786-a289-4966-874f-90b2c7d9ea1b', N'RPG', N'Trò chơi nhập vai xuất phát từ trò chơi nhập vai bút-và-giấy Dungeons & Dragons. Người chơi diễn xuất bằng cách tường thuật bằng lời hay văn bản, hoặc bằng cách ra các quyết định theo một cấu trúc đã được định sẵn để phát triển nhân vật hay tình tiết.')
INSERT [dbo].[Categories] ([CateID], [CateName], [CateDes]) VALUES (N'599468af-be7c-4028-8622-17d13d9ba1fd', N'Simulator', N'Trò chơi mô phỏng mô tả một trò chơi video đa dạng, thường được thiết kế để mô phỏng chặt chẽ các hoạt động trong thế giới thực. Một trò chơi mô phỏng cố gắng sao chép các hoạt động khác nhau từ đời thực dưới dạng trò chơi cho các mục đích khác nhau như đào tạo, phân tích hoặc dự đoán.')
INSERT [dbo].[Categories] ([CateID], [CateName], [CateDes]) VALUES (N'5ebf9854-f0d6-4f26-94ba-e276aeac1d0a', N'Action', N'Trò chơi hành động là thể loại trò chơi video nhấn mạnh những thách thức về thể chất, bao gồm phối hợp mắt - tay và thời gian phản ứng. Thể loại này bao gồm rất nhiều thể loại phụ, chẳng hạn như trò chơi chiến đấu, beat ''em up, trò chơi bắn súng và trò chơi platform.')
INSERT [dbo].[Categories] ([CateID], [CateName], [CateDes]) VALUES (N'6c03e4ae-daaa-4adf-bc67-2a4c12786531', N'Shoot ''Em Up', N'Shoot ''em up là một thể loại phụ của trò chơi hành động. Không có sự đồng thuận nào về việc các yếu tố thiết kế nào tạo nên một cảnh quay; một số hạn chế định nghĩa đối với các trò chơi có tàu vũ trụ và một số kiểu chuyển động của nhân vật, trong khi những trò chơi khác cho phép định nghĩa rộng hơn bao gồm các nhân vật ...')
INSERT [dbo].[Categories] ([CateID], [CateName], [CateDes]) VALUES (N'713b6934-becd-419b-a224-8e37c9916601', N'Casual Game', N'Game casual là thể loại game phổ thông, dễ chơi, game thường có độ dài ngắn. Game casual thường được chơi trực tuyến trên các trình duyệt web bằng máy tính hay điện thoại di động. Thời gian gần đây trò chơi loại này cũng được phổ biến trên các máy chơi game.')
INSERT [dbo].[Categories] ([CateID], [CateName], [CateDes]) VALUES (N'75526337-0f52-49cd-bd8d-9cf0de500a1c', N'Adventure', N'Trò chơi phiêu lưu hay trò chơi mạo hiểm là một thể loại video game mà trong đó giả định người chơi là nhân vật chính trong một câu chuyện có tính tương tác tiến triển theo hướng khám phá và vượt qua thử thách.')
INSERT [dbo].[Categories] ([CateID], [CateName], [CateDes]) VALUES (N'895e9a7e-c7ab-43b5-87b3-fe65d2fe95e2', N'Indie', N'Game indie là trò chơi điện tử độc lập (tiếng Anh là Independent video games). Là những trò chơi được phát triển và sản xuất bởi những nhóm nhỏ hoặc các cá nhân, mà không có sự đầu tư lớn về kinh phí cũng như là truyền thông từ các hãng sản xuất trò chơi điện tử lớn trên thế giới. ')
INSERT [dbo].[Categories] ([CateID], [CateName], [CateDes]) VALUES (N'8c079714-b0a5-43e5-85bc-114938d59a92', N'3D', N'Đồ hoạ 3D là quá trình tạo nên một tựa game có không gian ba chiều, bao gồm việc toàn bộ đối tượng và vật thể đều phải được nhìn thấy từ mọi phía.')
INSERT [dbo].[Categories] ([CateID], [CateName], [CateDes]) VALUES (N'991b81b9-106c-49ed-bd73-ef3ead0abb60', N'Soundtrack', N'Soundtrack liên kết với trò chơi trên Steam: nếu trò chơi của bạn được bán trên Steam, soundtrack có thể được tính như nội dung bổ sung cho trò chơi đó, tương tự như DLC. Bạn có thể tạo một soundtrack mới liên kết với trò chơi từ đường dẫn Gói liên kết, DLC, Demo, và Công cụ trên trang đáp ứng dụng.')
INSERT [dbo].[Categories] ([CateID], [CateName], [CateDes]) VALUES (N'aa80ed8e-f115-4b61-8e32-ce1266cab286', N'Roguelike', N'Roguelike là một nhánh con của trò chơi điện tử nhập vai có đặc điểm truyền thống là khám phá ngục tối thông qua các cấp độ được tạo theo thủ tục, lối chơi theo lượt, di chuyển theo lưới và cái chết vĩnh viễn của nhân vật người chơi.')
INSERT [dbo].[Categories] ([CateID], [CateName], [CateDes]) VALUES (N'ad6669c8-ff12-4421-b169-2256cadb4de9', N'MMO', N'Trò chơi nhập vai trực tuyến nhiều người chơi thường gọi là MMORPG là sự kết hợp giữa các trò chơi video nhập vai và các trò chơi trực tuyến nhiều người chơi, trong đó một số lượng rất lớn người chơi tương tác với nhau trong một thế giới ảo.')
INSERT [dbo].[Categories] ([CateID], [CateName], [CateDes]) VALUES (N'ad86757f-b5a4-41de-be07-655b0aae2c51', N'2D', N'Game 2D là game không thể xoay góc quay và không có ấn tượng ba chiều rõ rệt. Game này cuộn bản đồ theo hai chiều là ngang và thẳng. Bên cạnh đó, từ nhân vật, tiền cảnh, hậu cảnh,… của game 2D giống phim hoạt hình cắt giấy (mọi thứ đều từ hình vẽ trên giấy).')
INSERT [dbo].[Categories] ([CateID], [CateName], [CateDes]) VALUES (N'ae23c089-a377-4007-9265-bf37cd3bb3fe', N'Rhythm', N'Trò chơi nhịp điệu là một thể loại trò chơi điện tử âm nhạc thử thách nhịp điệu của người chơi. Các trò chơi trong thể loại này thường tập trung vào nhảy hoặc mô phỏng nốt nhạc, và yêu cầu người chơi nhấn các nút theo trình tự được chỉ định trên màn hình.')
INSERT [dbo].[Categories] ([CateID], [CateName], [CateDes]) VALUES (N'b56b779e-fef0-464c-9a65-39e8a32a97f5', N'DLC', N'Nội dung tải về là những nội dung bổ sung được tạo ra dành cho các trò chơi điện tử đã phát hành và được nhà phát hành của trò chơi đó phân phối qua Internet.')
INSERT [dbo].[Categories] ([CateID], [CateName], [CateDes]) VALUES (N'b8a06cb5-02ae-404d-85a0-a910663d58ba', N'Hack and slash', N'Hack and slash hoặc hack and slay, viết tắt là H&S hay HnS hoặc slash ''em up, đề cập đến thể loại trò chơi video có lối chơi nhấn mạnh đến tính chiến đấu bằng vũ khí cận chiến. Cũng có thể có một số vũ khí dựa trên đạn làm vũ khí phụ.')
INSERT [dbo].[Categories] ([CateID], [CateName], [CateDes]) VALUES (N'd66349f8-3646-47bb-8ac6-06a0339c6781', N'Fighting', N'Trò chơi điện tử đối kháng là một thể loại trò chơi điện tử hay còn gọi là trò chơi đánh nhau. Trò chơi điện tử đối kháng là các trò chơi mà trong đó người chơi điều khiển một nhân vật tham gia một cuộc đấu tay đôi với một nhân vật khác trên một màn hình có giới hạn. Các nhân vật thường sẽ có khả năng ngang nhau.')
INSERT [dbo].[Categories] ([CateID], [CateName], [CateDes]) VALUES (N'f405a161-9570-498a-9447-5f1aeb8e7f57', N'Moba', N'Đấu trường trận chiến trực tuyến nhiều người chơi, cũng biết đến với tên khác là chiến lược hành động thời gian thực là một thể loại con của thể loại trò chơi video chiến lược thời gian thực, trong đó một người chơi có thể điều khiển một nhân vật thuộc một trong hai đội tham gia.')
INSERT [dbo].[Categories] ([CateID], [CateName], [CateDes]) VALUES (N'f76a8a30-7933-4a23-904a-f6c76dadd8b1', N'Online Co-Op', N'Trò chơi điện tử hợp tác, thường được viết tắt là co-op, là một trò chơi điện tử cho phép người chơi làm việc cùng nhau như đồng đội, thường chống lại một hoặc nhiều đối thủ là nhân vật không phải người chơi.')
GO
INSERT [dbo].[Client] ([UID], [FirstName], [LastName], [UserName], [PassWord], [Email], [Phone], [Image], [Balance], [IsActive], [DayOfBirth]) VALUES (N'a29102fc-42da-482d-bd6b-f09147cb3262', N'Phúc', N'Nguyễn Hoàng', N'user1', N'123456', N'hoangphuc@gmail.com', N'01123445781', NULL, 0, N'True', CAST(N'2023-11-16' AS Date))
GO
INSERT [dbo].[Developer] ([Dev_ID], [Developer], [Description], [Logo], [IsActive]) VALUES (N'0a246ba0-bc03-49e8-8f26-f1b0848b12c2', N'Tequila Works', N'', N'string', N'True')
INSERT [dbo].[Developer] ([Dev_ID], [Developer], [Description], [Logo], [IsActive]) VALUES (N'290f37ec-fe10-4ba7-9eeb-a56645764f44', N'Tribute Games Inc.', N'Develops 2d pixel art games.', N'string', N'True')
INSERT [dbo].[Developer] ([Dev_ID], [Developer], [Description], [Logo], [IsActive]) VALUES (N'394b7672-8a3d-46ee-9f8e-d3bc3f36af56', N'DrinkBox Studios', N'Toronto-based game studio behind Nobody Saves the World, Guacamelee! 1+2, Severed, and Mutant Blobs Attack.', N'string', N'True')
INSERT [dbo].[Developer] ([Dev_ID], [Developer], [Description], [Logo], [IsActive]) VALUES (N'3ad8681c-13de-4a79-8891-b8c8f311a1d1', N'Digital Sun', N'Digital Sun is a multi-game studio on a mission to create games that are truly worth playing, and have fun while we’re doing it.', N'string', N'True')
INSERT [dbo].[Developer] ([Dev_ID], [Developer], [Description], [Logo], [IsActive]) VALUES (N'5fa0130c-1164-4c82-84f6-e27c82105b2b', N'Studio MDHR', N'Studio MDHR is an independent video game company founded by brothers Chad & Jared Moldenhauer. Working remotely with a team from across North America, Studio MDHR launched Cuphead on Xbox One and PC.', N'string', N'True')
INSERT [dbo].[Developer] ([Dev_ID], [Developer], [Description], [Logo], [IsActive]) VALUES (N'70e23e58-a592-4c37-b6b7-14ffd7ffa997', N'Dotemu', N'Dotemu is a French video game company specializing in modern releases of beloved retro games.', N'string', N'True')
INSERT [dbo].[Developer] ([Dev_ID], [Developer], [Description], [Logo], [IsActive]) VALUES (N'80cba021-04b4-455b-832b-dad8d4fb7d29', N'Playdead', N'Playdead is an independent game developer and publisher based in Copenhagen, Denmark. We are hard at work on bringing LIMBO and INSIDE to more players - and on making new games.', N'string', N'True')
INSERT [dbo].[Developer] ([Dev_ID], [Developer], [Description], [Logo], [IsActive]) VALUES (N'8ccb9a66-fea7-49ae-b78a-1a8dfbc2efee', N'Arc System Works', N'ACTION. REVOLUTION. CHALLENGE.', N'string', N'True')
INSERT [dbo].[Developer] ([Dev_ID], [Developer], [Description], [Logo], [IsActive]) VALUES (N'8e3f8bbd-7c4a-4be5-9ece-4f6665d0899d', N'HoYoverse', N'Tech Otakus Save The World', N'string', N'True')
INSERT [dbo].[Developer] ([Dev_ID], [Developer], [Description], [Logo], [IsActive]) VALUES (N'9411f62a-2fd3-43a6-a30e-c0527331be11', N'Klei Entertainment', N'It Rhymes With Play', N'string', N'True')
INSERT [dbo].[Developer] ([Dev_ID], [Developer], [Description], [Logo], [IsActive]) VALUES (N'a3453e0e-c108-48bd-ae89-906a94ef9daf', N'Bandai Namco Entertainment', N'Bandai Namco exists to share dreams, fun and inspiration with people around the world. Do you wish to enjoy every single day to the fullest? What we want is for people like you to always have a reason to smile.', N'string', N'True')
INSERT [dbo].[Developer] ([Dev_ID], [Developer], [Description], [Logo], [IsActive]) VALUES (N'a818bfd3-c724-4ca2-aed8-8b000c314afa', N'Massive Monster Games', N'Awoken by a nuclear blast, this colossal game-making monstrosity flattens entire cities underfoot, bringing gaming armageddon to all!', N'string', N'True')
INSERT [dbo].[Developer] ([Dev_ID], [Developer], [Description], [Logo], [IsActive]) VALUES (N'a99583f6-0b16-4254-abf7-759644601f46', N'Devolver Digital', N'Devolver Digital recommends only the most exquisite video games for the distinguished gamer and their refined taste. Voted ''Best Video Game Label Ever'' 2016, 2017, 2021..', N'string', N'True')
INSERT [dbo].[Developer] ([Dev_ID], [Developer], [Description], [Logo], [IsActive]) VALUES (N'e8450ff9-9477-49b9-bead-bc8048876175', N'Team Cherry Games', N'Team Cherry is a small indie games team in Adelaide, South Australia. Our mission is to build crazy and exciting worlds for you to explore and conquer.', N'string', N'True')
INSERT [dbo].[Developer] ([Dev_ID], [Developer], [Description], [Logo], [IsActive]) VALUES (N'f56e5431-4e4f-4003-9488-5432f9cb54d7', N'WayForward', N'Based in Valencia, California, WayForward has been an indie developer and publisher for more than 30 years, and is known for games such as the Shantae series, River City Girls, Mighty Switch Force, and many more.', N'string', N'True')
INSERT [dbo].[Developer] ([Dev_ID], [Developer], [Description], [Logo], [IsActive]) VALUES (N'f67418e8-6845-46a0-8a48-8d4a6079ff12', N'Riot Forge', N'', N'string', N'True')
GO
ALTER TABLE [dbo].[Game]  WITH CHECK ADD  CONSTRAINT [FK_Game_Developer] FOREIGN KEY([DevID])
REFERENCES [dbo].[Developer] ([Dev_ID])
GO
ALTER TABLE [dbo].[Game] CHECK CONSTRAINT [FK_Game_Developer]
GO
ALTER TABLE [dbo].[Game]  WITH CHECK ADD  CONSTRAINT [FK_Game_Developer1] FOREIGN KEY([PublisherID])
REFERENCES [dbo].[Developer] ([Dev_ID])
GO
ALTER TABLE [dbo].[Game] CHECK CONSTRAINT [FK_Game_Developer1]
GO
ALTER TABLE [dbo].[Game_Categories]  WITH CHECK ADD  CONSTRAINT [FK_Game_Categories_Categories] FOREIGN KEY([CateID])
REFERENCES [dbo].[Categories] ([CateID])
GO
ALTER TABLE [dbo].[Game_Categories] CHECK CONSTRAINT [FK_Game_Categories_Categories]
GO
ALTER TABLE [dbo].[Game_Categories]  WITH CHECK ADD  CONSTRAINT [FK_Game_Categories_Game] FOREIGN KEY([GameID])
REFERENCES [dbo].[Game] ([GameID])
GO
ALTER TABLE [dbo].[Game_Categories] CHECK CONSTRAINT [FK_Game_Categories_Game]
GO
ALTER TABLE [dbo].[Game_Image]  WITH CHECK ADD  CONSTRAINT [FK_Game_Image_Game] FOREIGN KEY([GameID])
REFERENCES [dbo].[Game] ([GameID])
GO
ALTER TABLE [dbo].[Game_Image] CHECK CONSTRAINT [FK_Game_Image_Game]
GO
ALTER TABLE [dbo].[Libraries]  WITH CHECK ADD  CONSTRAINT [FK_Libraries_Client] FOREIGN KEY([UID])
REFERENCES [dbo].[Client] ([UID])
GO
ALTER TABLE [dbo].[Libraries] CHECK CONSTRAINT [FK_Libraries_Client]
GO
ALTER TABLE [dbo].[Libraries]  WITH CHECK ADD  CONSTRAINT [FK_Libraries_Game] FOREIGN KEY([GameID])
REFERENCES [dbo].[Game] ([GameID])
GO
ALTER TABLE [dbo].[Libraries] CHECK CONSTRAINT [FK_Libraries_Game]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Client] FOREIGN KEY([UID])
REFERENCES [dbo].[Client] ([UID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Client]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Discount] FOREIGN KEY([DiscountID])
REFERENCES [dbo].[Discount] ([DiscountID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Discount]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Game] FOREIGN KEY([GameID])
REFERENCES [dbo].[Game] ([GameID])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Game]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Order] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Order]
GO
ALTER TABLE [dbo].[ShoppingCart]  WITH CHECK ADD  CONSTRAINT [FK_ShoppingCart_Client] FOREIGN KEY([UID])
REFERENCES [dbo].[Client] ([UID])
GO
ALTER TABLE [dbo].[ShoppingCart] CHECK CONSTRAINT [FK_ShoppingCart_Client]
GO
ALTER TABLE [dbo].[ShoppingCart]  WITH CHECK ADD  CONSTRAINT [FK_ShoppingCart_Game] FOREIGN KEY([GameID])
REFERENCES [dbo].[Game] ([GameID])
GO
ALTER TABLE [dbo].[ShoppingCart] CHECK CONSTRAINT [FK_ShoppingCart_Game]
GO
USE [master]
GO
ALTER DATABASE [Game_DB] SET  READ_WRITE 
GO
