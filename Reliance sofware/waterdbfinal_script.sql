USE [waterdb]
GO
/****** Object:  Table [dbo].[tblcustomer]    Script Date: 8/6/2024 5:05:00 PM ******/
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
/****** Object:  Table [dbo].[tblorder]    Script Date: 8/6/2024 5:05:00 PM ******/
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
/****** Object:  Table [dbo].[tbleorderdetail]    Script Date: 8/6/2024 5:05:00 PM ******/
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
/****** Object:  Table [dbo].[tblproduct]    Script Date: 8/6/2024 5:05:00 PM ******/
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
/****** Object:  View [dbo].[SaleView]    Script Date: 8/6/2024 5:05:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[SaleView]
AS
SELECT        dbo.tblcustomer.CID, dbo.tblcustomer.cname, dbo.tblorder.onumber, dbo.tblorder.date, dbo.tbleorderdetail.total, dbo.tbleorderdetail.qty, dbo.tbleorderdetail.price, dbo.tblproduct.PID, dbo.tblproduct.pname
FROM            dbo.tblcustomer INNER JOIN
                         dbo.tblorder ON dbo.tblcustomer.CID = dbo.tblorder.CID INNER JOIN
                         dbo.tbleorderdetail ON dbo.tblorder.OID = dbo.tbleorderdetail.OID INNER JOIN
                         dbo.tblproduct ON dbo.tbleorderdetail.PID = dbo.tblproduct.PID
GO
/****** Object:  Table [dbo].[tblsalesman]    Script Date: 8/6/2024 5:05:00 PM ******/
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
/****** Object:  Table [dbo].[tblbottle]    Script Date: 8/6/2024 5:05:00 PM ******/
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
/****** Object:  View [dbo].[SalesmanView]    Script Date: 8/6/2024 5:05:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[SalesmanView]
AS
SELECT        dbo.tblbottle.date, dbo.tblbottle.deliver, dbo.tblbottle.onshop, dbo.tblbottle.rbottle, dbo.tblsalesman.SID, dbo.tblsalesman.sname, dbo.tblcustomer.CID, dbo.tblcustomer.cname
FROM            dbo.tblsalesman INNER JOIN
                         dbo.tblbottle ON dbo.tblsalesman.SID = dbo.tblbottle.SID INNER JOIN
                         dbo.tblcustomer ON dbo.tblbottle.CID = dbo.tblcustomer.CID
GO
/****** Object:  Table [dbo].[tblpayment]    Script Date: 8/6/2024 5:05:00 PM ******/
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
	[source] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblpayment] PRIMARY KEY CLUSTERED 
(
	[PYID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[PaymentView]    Script Date: 8/6/2024 5:05:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[PaymentView]
AS
SELECT        dbo.tblcustomer.CID, dbo.tblcustomer.cname, dbo.tblpayment.date, dbo.tblpayment.amount, dbo.tblpayment.source, dbo.tblpayment.PYID, dbo.tblpayment.UID
FROM            dbo.tblcustomer INNER JOIN
                         dbo.tblpayment ON dbo.tblcustomer.CID = dbo.tblpayment.CID
GO
/****** Object:  Table [dbo].[tbluser]    Script Date: 8/6/2024 5:05:00 PM ******/
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
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
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
         Begin Table = "tblcustomer"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 170
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tblpayment"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 176
               Right = 416
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'PaymentView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'PaymentView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
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
         Begin Table = "tblsalesman"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 144
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tblcustomer"
            Begin Extent = 
               Top = 3
               Left = 538
               Bottom = 140
               Right = 708
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tblbottle"
            Begin Extent = 
               Top = 12
               Left = 286
               Bottom = 196
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'SalesmanView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'SalesmanView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
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
         Begin Table = "tblcustomer"
            Begin Extent = 
               Top = 7
               Left = 13
               Bottom = 137
               Right = 183
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tblorder"
            Begin Extent = 
               Top = 57
               Left = 252
               Bottom = 187
               Right = 422
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "tbleorderdetail"
            Begin Extent = 
               Top = 21
               Left = 525
               Bottom = 151
               Right = 695
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "tblproduct"
            Begin Extent = 
               Top = 10
               Left = 809
               Bottom = 144
               Right = 979
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'SaleView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'SaleView'
GO
