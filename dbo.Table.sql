USE [user]
GO
/****** Object:  Table [dbo].[tbl_users]    Script Date: 11/05/2016 15:49:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[lastname] [nchar](100) NULL,
	[firstname] [nchar](100) NULL,
	[address] [nchar](200) NULL,
	[mobile] [nchar](15) NULL,
	[telephone] [nchar](15) NULL,
	[email] [nchar](100) NULL,
 CONSTRAINT [PK_tbl_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_users] ON
INSERT [dbo].[tbl_users] ([id], [lastname], [firstname], [address], [mobile], [telephone], [email]) VALUES (4, N'POMPERADA                                                                                           ', N'JACOB                                                                                               ', N'ERORECO SUBD, BACOLOD CITY                                                                                                                                                                              ', N'09173084360    ', N'4335675        ', N'jacob_pomperada@gmail.com                                                                           ')
INSERT [dbo].[tbl_users] ([id], [lastname], [firstname], [address], [mobile], [telephone], [email]) VALUES (5, N'BRYANT                                                                                              ', N'KOBE                                                                                                ', N'LOS ANGELES CALIFORNIA, USA                                                                                                                                                                             ', N'1234567890     ', N'4563423        ', N'kobe@la_lakers.com                                                                                  ')
INSERT [dbo].[tbl_users] ([id], [lastname], [firstname], [address], [mobile], [telephone], [email]) VALUES (6, N'POMPERADA                                                                                           ', N'ALLIE                                                                                               ', N'BACOLOD CITY                                                                                                                                                                                            ', N'0912345623     ', N'4335675        ', N'allie_pomperada@yahoo.com.ph                                                                        ')
INSERT [dbo].[tbl_users] ([id], [lastname], [firstname], [address], [mobile], [telephone], [email]) VALUES (7, N'POMPERADA                                                                                           ', N'JULIANNA RAE                                                                                        ', N'BACOLOD CITY, NEGROS OCCIDENTAL                                                                                                                                                                         ', N'121212121212   ', N'4335081        ', N'iya_pomperada@gmail.com                                                                             ')
INSERT [dbo].[tbl_users] ([id], [lastname], [firstname], [address], [mobile], [telephone], [email]) VALUES (8, N'GATES                                                                                               ', N'BILL                                                                                                ', N'ONE MICROSOFT WAY, USA                                                                                                                                                                                  ', N'1212123434343  ', N'34343434       ', N'bill_gates@microsoft.com                                                                            ')
INSERT [dbo].[tbl_users] ([id], [lastname], [firstname], [address], [mobile], [telephone], [email]) VALUES (10, N'POMPERADA                                                                                           ', N'JAKE                                                                                                ', N'ALIJIS BACOLOD CITY                                                                                                                                                                                     ', N'09173084360    ', N'4335675        ', N'jakerpomperada@yahoo.com                                                                            ')
SET IDENTITY_INSERT [dbo].[tbl_users] OFF
