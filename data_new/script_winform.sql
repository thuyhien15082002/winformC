USE [winform]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 1/9/2024 1:01:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[Account_ID] [nvarchar](255) NOT NULL,
	[Account_Name] [nvarchar](100) NOT NULL,
	[Phone] [nvarchar](15) NOT NULL,
	[Gender] [nvarchar](10) NOT NULL,
	[Date_of_Birth] [datetime2](7) NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[Account_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bills]    Script Date: 1/9/2024 1:01:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bills](
	[Bill_ID] [nvarchar](255) NOT NULL,
	[User_ID] [nvarchar](255) NOT NULL,
	[Account_ID] [nvarchar](255) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[Status] [nvarchar](max) NOT NULL,
	[Total_Amount] [decimal](18, 2) NOT NULL,
	[Note] [nvarchar](255) NOT NULL,
	[Discount] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Bills] PRIMARY KEY CLUSTERED 
(
	[Bill_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorys]    Script Date: 1/9/2024 1:01:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorys](
	[Category_ID] [nvarchar](255) NOT NULL,
	[Category_Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Categorys] PRIMARY KEY CLUSTERED 
(
	[Category_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detail_Orders]    Script Date: 1/9/2024 1:01:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detail_Orders](
	[Detail_Order_ID] [nvarchar](255) NOT NULL,
	[Product_ID] [nvarchar](255) NOT NULL,
	[Bill_ID] [nvarchar](255) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Output_Price] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Detail_Orders] PRIMARY KEY CLUSTERED 
(
	[Detail_Order_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 1/9/2024 1:01:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Product_ID] [nvarchar](255) NOT NULL,
	[Product_Name] [nvarchar](100) NOT NULL,
	[Category_ID] [nvarchar](255) NOT NULL,
	[Input_Price] [decimal](18, 2) NOT NULL,
	[Output_Price] [decimal](18, 2) NOT NULL,
	[Status] [nvarchar](100) NOT NULL,
	[Input_Date] [datetime2](7) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Sell] [int] NOT NULL,
	[Material] [nvarchar](100) NOT NULL,
	[Origin] [nvarchar](100) NOT NULL,
	[Image] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Product_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Quyen]    Script Date: 1/9/2024 1:01:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Quyen](
	[iMaQuyen] [int] IDENTITY(1,1) NOT NULL,
	[sTenQuyen] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[iMaQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_taikhoan]    Script Date: 1/9/2024 1:01:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_taikhoan](
	[sMaTK] [int] IDENTITY(1,1) NOT NULL,
	[sTaiKhoan] [nvarchar](50) NOT NULL,
	[sMatKhau] [nvarchar](50) NULL,
	[sEmail] [nvarchar](100) NULL,
	[FK_iMaQuyen] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[sMaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 1/9/2024 1:01:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[User_ID] [nvarchar](255) NOT NULL,
	[User_Name] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](255) NOT NULL,
	[Role] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[User_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [FK_Bills_Accounts_Account_ID] FOREIGN KEY([Account_ID])
REFERENCES [dbo].[Accounts] ([Account_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [FK_Bills_Accounts_Account_ID]
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [FK_Bills_Users_User_ID] FOREIGN KEY([User_ID])
REFERENCES [dbo].[Users] ([User_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [FK_Bills_Users_User_ID]
GO
ALTER TABLE [dbo].[Detail_Orders]  WITH CHECK ADD  CONSTRAINT [FK_Detail_Orders_Bills_Bill_ID] FOREIGN KEY([Bill_ID])
REFERENCES [dbo].[Bills] ([Bill_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Detail_Orders] CHECK CONSTRAINT [FK_Detail_Orders_Bills_Bill_ID]
GO
ALTER TABLE [dbo].[Detail_Orders]  WITH CHECK ADD  CONSTRAINT [FK_Detail_Orders_Products_Product_ID] FOREIGN KEY([Product_ID])
REFERENCES [dbo].[Products] ([Product_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Detail_Orders] CHECK CONSTRAINT [FK_Detail_Orders_Products_Product_ID]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categorys_Category_ID] FOREIGN KEY([Category_ID])
REFERENCES [dbo].[Categorys] ([Category_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categorys_Category_ID]
GO
/****** Object:  StoredProcedure [dbo].[proc_logic]    Script Date: 1/9/2024 1:01:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_logic]
@user nvarchar(50),
@pass nvarchar(50)
as
begin
select * from tbl_taikhoan where sTaiKhoan = @user and sMatKhau = @pass
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Retrieve_User]    Script Date: 1/9/2024 1:01:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_Retrieve_User]
as
begin
    select * from tbl_taikhoan
end
GO
/****** Object:  StoredProcedure [dbo].[SP_SuaNhanVien]    Script Date: 1/9/2024 1:01:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_SuaNhanVien]
@sMaTK int,
@sTaiKhoan nvarchar(50), 
@sMatKhau nvarchar(50),
@sEmail nvarchar(100)
as
begin
    update tbl_taikhoan 
    set sTaiKhoan =@sTaiKhoan,
        sMatKhau = @sMatKhau,
		sEmail = @sEmail
    where sMaTK = @sMaTK
end
GO
/****** Object:  StoredProcedure [dbo].[SP_ThemNhanVien]    Script Date: 1/9/2024 1:01:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_ThemNhanVien]
@sTaiKhoan nvarchar(50),
@sMatKhau nvarchar(100),
@sEmail  nvarchar(100)
as
begin
     select * from tbl_taikhoan
end
GO
/****** Object:  StoredProcedure [dbo].[SP_XoaNhanVien]    Script Date: 1/9/2024 1:01:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_XoaNhanVien]
@sMaTK int
as
begin
    delete tbl_taikhoan where sMaTK = @sMaTK
end
GO
