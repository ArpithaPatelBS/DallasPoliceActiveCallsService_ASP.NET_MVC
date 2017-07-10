USE [DallasPolice]
GO

/****** Object:  Table [dbo].[Dallas_Police_Active_Calls]    Script Date: 12/18/2015 1:50:34 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Dallas_Police_Active_Calls](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IncidentNumber] [varchar](10) NOT NULL,
	[Division] [varchar](100) NOT NULL,
	[NatureOfCall] [nchar](10) NOT NULL,
	[Priority] [int] NOT NULL,
	[DateTime] [datetime] NOT NULL,
	[UnitNumber] [varchar](50) NULL,
	[Block] [int] NULL,
	[Location] [varchar](100) NULL,
	[Beat] [int] NULL,
	[ReportingArea] [int] NULL,
	[Status] [varchar](30) NULL,
 CONSTRAINT [PK_Dallas_Police_Active_Calls] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


