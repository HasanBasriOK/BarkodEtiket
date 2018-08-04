

CREATE TABLE [dbo].[Kayitlar](
	[DataID] [int] IDENTITY(1,1) NOT NULL,
	[Alan1] [nchar](10) NULL,
	[Alan2] [nchar](10) NULL,
	[Alan3] [nchar](10) NULL,
	[Alan4] [nchar](10) NULL,
	[Alan5] [nchar](10) NULL,
	[Alan6] [nchar](10) NULL,
	[Alan7] [nchar](10) NULL,
	[Alan8] [nchar](10) NULL,
	[Alan9] [nchar](10) NULL,
	[Alan10] [nchar](10) NULL,
 CONSTRAINT [PK_Kayitlar] PRIMARY KEY CLUSTERED 
(
	[DataID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


