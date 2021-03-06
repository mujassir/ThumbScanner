USE [suiph1]
GO
/****** Object:  Table [dbo].[fmf]    Script Date: 07/20/2013 12:05:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[fmf](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[acc_cd] [varchar](7) NOT NULL,
	[name] [varchar](50) NULL,
	[f_name] [varchar](35) NULL,
	[desg] [varchar](20) NULL,
	[template1] [varbinary](max) NULL,
	[template2] [varbinary](max) NULL,
	[template3] [varbinary](max) NULL,
	[finger1] [numeric](1, 0) NULL,
	[finger2] [numeric](1, 0) NULL,
	[finger3] [numeric](1, 0) NULL,
	[finger4] [numeric](1, 0) NULL,
	[finger5] [numeric](1, 0) NULL,
	[finger6] [numeric](1, 0) NULL,
	[finger7] [numeric](1, 0) NULL,
	[finger8] [numeric](1, 0) NULL,
	[finger9] [numeric](1, 0) NULL,
	[finger10] [numeric](1, 0) NULL,
 CONSTRAINT [PK_fmf] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
