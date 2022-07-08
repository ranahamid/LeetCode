# Please write a DELETE statement and DO NOT write a SELECT statement.
# Write your MySQL query statement below


  delete p1 
  from Person p1, Person  p2
  where p1.email=p2.email and p2.id<p1.id






  USE [LEET]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 06/23/2022 15:54:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[email] [nvarchar](50) NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Person] ON 
GO
INSERT [dbo].[Person] ([id], [email]) VALUES (1, N'john@example.com')
GO
INSERT [dbo].[Person] ([id], [email]) VALUES (2, N'bob@example.com')
GO
SET IDENTITY_INSERT [dbo].[Person] OFF
GO
