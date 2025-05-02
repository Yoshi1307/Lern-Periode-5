USE [Cookie_Clicker]
GO

/****** Object:  Table [dbo].[Cookie_Clicker_Spielstand]    Script Date: 02.05.2025 11:28:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cookie_Clicker_Spielstand](
	[SpielstandId] [int] IDENTITY(1,1) NOT NULL,
	[CookieCount] [int] NOT NULL,
	[AutoclickerEarnings] [int] NOT NULL,
	[CursorEarnings] [int] NOT NULL,
	[Level_Autoclicker] [int] NOT NULL,
	[Level_Cursor] [int] NOT NULL,
	[Countdown2x] [int] NOT NULL,
	[Zeitpunkt] [datetime] NULL,
	[AnzahlKauefe2x] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SpielstandId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Cookie_Clicker_Spielstand] ADD  DEFAULT (getdate()) FOR [Zeitpunkt]
GO

