USE [Keycost]
GO
/****** Object:  Table [kc_admin].[maBrandType]    Script Date: 15/12/2022 18:54:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [kc_admin].[maBrandType](
	[pkid] [int] NOT NULL,
	[fkBaseBrandType] [int] NOT NULL,
	[BrandTypeName] [varchar](50) NOT NULL,
	[fkLangID] [int] NOT NULL
) ON [PRIMARY]
GO
