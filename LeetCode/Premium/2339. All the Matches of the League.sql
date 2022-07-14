 
SELECT  a.team_name as home_team   , b.team_name    as away_team   
  FROM Teams as a , Teams as b
  where a.team_name <> b.team_name

--  --mysql
--  Runtime: 633 ms, faster than 100.00% of MySQL online submissions for All the Matches of the League.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for All the Matches of the League.


----sql server
--Runtime: 1296 ms, faster than 100.00% of MS SQL Server online submissions for All the Matches of the League.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for All the Matches of the League.



GO
/****** Object:  Table [dbo].[Teams]    Script Date: 07/14/2022 10:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teams](
	[team_name] [nvarchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Teams] ([team_name]) VALUES (N'Leetcode FC')
GO
INSERT [dbo].[Teams] ([team_name]) VALUES (N'Ahly SC ')
GO
INSERT [dbo].[Teams] ([team_name]) VALUES (N'Real Madrid')
GO
