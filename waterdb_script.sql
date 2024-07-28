USE [waterdb]
GO
/****** Object:  Table [dbo].[tblbottle]    Script Date: 7/24/2024 4:16:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblbottle](
	[BID] [int] IDENTITY(1,1) NOT NULL,
	[rbottle] [nvarchar](50) NULL,
	[onshop] [bit] NULL,
	[deliver] [nvarchar](50) NULL,
	[CID] [int] NULL,
	[SID] [int] NULL,
	[date] [datetime] NULL,
 CONSTRAINT [PK_tblbottle] PRIMARY KEY CLUSTERED 
(
	[BID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblcustomer]    Script Date: 7/24/2024 4:16:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblcustomer](
	[CID] [int] IDENTITY(1,1) NOT NULL,
	[cname] [nvarchar](50) NULL,
	[cell] [nvarchar](50) NULL,
	[address] [nvarchar](max) NULL,
 CONSTRAINT [PK_tblcustomer] PRIMARY KEY CLUSTERED 
(
	[CID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbleorderdetail]    Script Date: 7/24/2024 4:16:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbleorderdetail](
	[ODID] [int] IDENTITY(1,1) NOT NULL,
	[OID] [int] NULL,
	[PID] [int] NULL,
	[price] [int] NULL,
	[qty] [int] NULL,
	[total] [int] NULL,
	[date] [datetime] NULL,
 CONSTRAINT [PK_tbleorderdetail] PRIMARY KEY CLUSTERED 
(
	[ODID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblorder]    Script Date: 7/24/2024 4:16:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblorder](
	[OID] [int] IDENTITY(1,1) NOT NULL,
	[SID] [int] NULL,
	[CID] [int] NULL,
	[onumber] [nvarchar](50) NULL,
	[date] [datetime] NULL,
	[UID] [int] NULL,
 CONSTRAINT [PK_tblorder] PRIMARY KEY CLUSTERED 
(
	[OID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblpayment]    Script Date: 7/24/2024 4:16:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblpayment](
	[PYID] [int] IDENTITY(1,1) NOT NULL,
	[UID] [int] NULL,
	[CID] [int] NULL,
	[amount] [int] NULL,
	[date] [datetime] NULL,
 CONSTRAINT [PK_tblpayment] PRIMARY KEY CLUSTERED 
(
	[PYID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblproduct]    Script Date: 7/24/2024 4:16:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblproduct](
	[PID] [int] IDENTITY(1,1) NOT NULL,
	[pname] [nvarchar](50) NULL,
	[unit] [nvarchar](50) NULL,
	[price] [int] NULL,
 CONSTRAINT [PK_tblproduct] PRIMARY KEY CLUSTERED 
(
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblsalesman]    Script Date: 7/24/2024 4:16:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblsalesman](
	[SID] [int] IDENTITY(1,1) NOT NULL,
	[sname] [nvarchar](50) NULL,
	[cell] [nvarchar](50) NULL,
	[address] [nvarchar](max) NULL,
 CONSTRAINT [PK_tblsalesman] PRIMARY KEY CLUSTERED 
(
	[SID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbluser]    Script Date: 7/24/2024 4:16:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbluser](
	[UID] [int] IDENTITY(1,1) NOT NULL,
	[uname] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[utype] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbluser] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblbottle]  WITH CHECK ADD  CONSTRAINT [FK_tblbottle_tblcustomer] FOREIGN KEY([CID])
REFERENCES [dbo].[tblcustomer] ([CID])
GO
ALTER TABLE [dbo].[tblbottle] CHECK CONSTRAINT [FK_tblbottle_tblcustomer]
GO
ALTER TABLE [dbo].[tblbottle]  WITH CHECK ADD  CONSTRAINT [FK_tblbottle_tblsalesman] FOREIGN KEY([SID])
REFERENCES [dbo].[tblsalesman] ([SID])
GO
ALTER TABLE [dbo].[tblbottle] CHECK CONSTRAINT [FK_tblbottle_tblsalesman]
GO
ALTER TABLE [dbo].[tbleorderdetail]  WITH CHECK ADD  CONSTRAINT [FK_tbleorderdetail_tblorder] FOREIGN KEY([OID])
REFERENCES [dbo].[tblorder] ([OID])
GO
ALTER TABLE [dbo].[tbleorderdetail] CHECK CONSTRAINT [FK_tbleorderdetail_tblorder]
GO
ALTER TABLE [dbo].[tbleorderdetail]  WITH CHECK ADD  CONSTRAINT [FK_tbleorderdetail_tblproduct] FOREIGN KEY([PID])
REFERENCES [dbo].[tblproduct] ([PID])
GO
ALTER TABLE [dbo].[tbleorderdetail] CHECK CONSTRAINT [FK_tbleorderdetail_tblproduct]
GO
ALTER TABLE [dbo].[tblorder]  WITH CHECK ADD  CONSTRAINT [FK_tblorder_tblcustomer] FOREIGN KEY([CID])
REFERENCES [dbo].[tblcustomer] ([CID])
GO
ALTER TABLE [dbo].[tblorder] CHECK CONSTRAINT [FK_tblorder_tblcustomer]
GO
ALTER TABLE [dbo].[tblorder]  WITH CHECK ADD  CONSTRAINT [FK_tblorder_tblsalesman] FOREIGN KEY([SID])
REFERENCES [dbo].[tblsalesman] ([SID])
GO
ALTER TABLE [dbo].[tblorder] CHECK CONSTRAINT [FK_tblorder_tblsalesman]
GO
ALTER TABLE [dbo].[tblpayment]  WITH CHECK ADD  CONSTRAINT [FK_tblpayment_tblcustomer] FOREIGN KEY([CID])
REFERENCES [dbo].[tblcustomer] ([CID])
GO
ALTER TABLE [dbo].[tblpayment] CHECK CONSTRAINT [FK_tblpayment_tblcustomer]
GO
