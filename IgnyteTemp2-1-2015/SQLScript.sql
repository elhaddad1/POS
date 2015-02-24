-- Developer's comment header
-- VUserRoles.sql
-- 
-- history:   1/2/2015 2:16:07 AM
--
--

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_VUserRoles_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_VUserRoles_SelectByPrimaryKey]
GO


/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : gsp_VUserRoles_SelectByPrimaryKey
						
AUTHOR	:	Ignyte Software ©
DATE	:	1/2/2015 2:16:07 AM

INPUTS	: 
		@UserID int 
		@GroupID int 
		@Expr1 int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table 'VUserRoles' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[gsp_VUserRoles_SelectByPrimaryKey]
@UserID int ,
@GroupID int ,
@Expr1 int ,
@dlgErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[UserID],[GroupID],[GroupName],[RoleName],[RolePath],[Expr1]
FROM	[dbo].[VUserRoles]
WHERE
	[UserID] = @UserID
AND [GroupID] = @GroupID
AND [Expr1] = @Expr1


-- Get the Error Code for the statment just executed
SET @dlgErrorCode = @@ERROR


GO
				
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_VUserRoles_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_VUserRoles_SelectAll]
GO


/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : gsp_VUserRoles_SelectAll
						
AUTHOR	:	Ignyte Software ©
DATE	:	1/2/2015 2:16:07 AM

INPUTS	: 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select all rows from the table 'VUserRoles' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[gsp_VUserRoles_SelectAll]
@dlgErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT all row(s) from the table
declare @Query nvarchar(max);
set @Query='SELECT	[UserID],[GroupID],[GroupName],[RoleName],[RolePath],[Expr1]
			FROM	[dbo].[VUserRoles]'

 exec (@Query)
  
 select @dlgErrorCode = @@ERROR


-- Get the Error Code for the statment just executed
SET @dlgErrorCode = @@ERROR


GO
				
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_VUserRoles_SelectAllPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_VUserRoles_SelectAllPaged]
GO


/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : gsp_VUserRoles_SelectAllPaged
						
AUTHOR	:	Ignyte Software ©
DATE	:	1/2/2015 2:16:07 AM

INPUTS	: 
		@PageSize int
		@SkipPages int
		@OrderByStatement varchar(100)
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select the specified number of entries from the specified record number in the table 'VUserRoles'
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[gsp_VUserRoles_SelectAllPaged]
@PageSize int=null,
@SkipPages int=null,
@OrderByStatement varchar(100)=null,
@dlgErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT all row(s) from the table
DECLARE @Query nvarchar(max);

if(@PageSize is null or @PageSize='' or @SkipPages is null or @SkipPages='' or @OrderByStatement is null or @OrderByStatement='')
begin
Exec gsp_VUserRoles_SelectAll @dlgErrorCode=@dlgErrorCode
end
else
begin
SET @Query='SELECT	[UserID],[GroupID],[GroupName],[RoleName],[RolePath],[Expr1], ROW_NUMBER() OVER(ORDER BY ['+ @OrderByStatement+']) AS SortRow 
			FROM	[dbo].[VUserRoles]'

if(@PageSize is not null and @PageSize<>'')
	SET @Query='SELECT TOP ' + CONVERT(varchar(max), @PageSize) + ' * FROM (' + @Query + ') AS query 
	WHERE query.SortRow > ' + CONVERT(varchar(max), @SkipPages * @PageSize)
end
 EXEC (@Query)
  
 SELECT @dlgErrorCode = @@ERROR


-- Get the Error Code for the statment just executed
SET @dlgErrorCode = @@ERROR


GO
				
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_VUserRoles_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_VUserRoles_SelectByField]
GO


/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : gsp_VUserRoles_SelectByField
						
AUTHOR	:	Ignyte Software ©
DATE	:	1/2/2015 2:16:07 AM

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)
		@Value2 varchar(1000)
		@Operation varchar(10)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select row(s) from the table 'VUserRoles' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[gsp_VUserRoles_SelectByField]
@Field varchar(100),
@Value varchar(1000),
@Value2 varchar(1000)='',
@Operation varchar(10),
@dlgErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT row(s) from the table
DECLARE @Query varchar(2000)

if @Value2 is not null and @Value2 <> ''
SET @Query = 'SELECT [UserID],[GroupID],[GroupName],[RoleName],[RolePath],[Expr1]
			FROM [dbo].[VUserRoles] WHERE [' +replace(@Field,']',']]') + '] BETWEEN  ''' + @Value + ''' And '''+ @Value2+''''
else
SET @Query = 'SELECT [UserID],[GroupID],[GroupName],[RoleName],[RolePath],[Expr1]
			FROM [dbo].[VUserRoles] WHERE [' +replace(@Field,']',']]') + ']'+@Operation+ '''' + @Value + ''''

EXEC(@Query)


-- Get the Error Code for the statment just executed
SET @dlgErrorCode = @@ERROR


GO
				
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_VUserRoles_SelectByFieldPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_VUserRoles_SelectByFieldPaged]
GO


/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : gsp_VUserRoles_SelectByFieldPaged
						
AUTHOR	:	Ignyte Software ©
DATE	:	1/2/2015 2:16:07 AM

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)
		@Value2 varchar(1000)
		@Operation varchar(10)
		@PageSize int
		@SkipPages int
		@OrderByStatement varchar(100)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select the specified number of entries from the specified record number in the table'VUserRoles' 
				using the value of the field specified
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[gsp_VUserRoles_SelectByFieldPaged]
@Field varchar(100),
@Value varchar(1000),
@Value2 varchar(1000)='',
@Operation varchar(10),
@PageSize int,
@SkipPages int,
@OrderByStatement varchar(100),
@dlgErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT row(s) from the table
DECLARE @Query nvarchar(max);

IF @Value2 IS NOT NULL AND @Value2 <> ''
	SET @Query = 'SELECT [UserID],[GroupID],[GroupName],[RoleName],[RolePath],[Expr1], ROW_NUMBER() OVER(ORDER BY ['+ @OrderByStatement+']) AS SortRow
			FROM [dbo].[VUserRoles] WHERE [' + REPLACE(@Field,']',']]') + '] BETWEEN  ''' + @Value + ''' AND '''+ @Value2+''''
ELSE
	SET @Query = 'SELECT [UserID],[GroupID],[GroupName],[RoleName],[RolePath],[Expr1], ROW_NUMBER() OVER(ORDER BY ['+ @OrderByStatement + ']) AS SortRow
			FROM [dbo].[VUserRoles] WHERE [' + REPLACE(@Field,']',']]') + ']' + @Operation + '''' + @Value + ''''

IF(@PageSize IS NOT NULL AND @PageSize<>'')
	set @Query='SELECT TOP '+ CONVERT(varchar(max), @PageSize) + ' * FROM (' + @Query + ') AS query 
	WHERE query.SortRow > ' + CONVERT(varchar(max), @SkipPages * @PageSize)

EXEC(@Query)


-- Get the Error Code for the statment just executed
SET @dlgErrorCode = @@ERROR


GO
				
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_VUserRoles_SelectAllCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_VUserRoles_SelectAllCount]
GO


/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : gsp_VUserRoles_SelectAllCount
						
AUTHOR	:	Ignyte Software ©
DATE	:	1/2/2015 2:16:07 AM

INPUTS	: 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select all rows count from the table 'VUserRoles' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[gsp_VUserRoles_SelectAllCount]
@dlgErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT all row(s) count from the table
declare @Query nvarchar(max);
set @Query='SELECT	Count(*)
			FROM	[dbo].[VUserRoles]'

 exec (@Query)
  
 select @dlgErrorCode = @@ERROR


-- Get the Error Code for the statment just executed
SET @dlgErrorCode = @@ERROR


GO
				






