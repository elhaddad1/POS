-- Developer's comment header
-- ADGroupRole.sql
-- 
-- history:   12/27/2014 11:07:46 PM
--
--

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_ADGroupRole_Insert_WithDefaultValues]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_ADGroupRole_Insert_WithDefaultValues]
GO


/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : gsp_ADGroupRole_Insert
						
AUTHOR	:	Ignyte Software ©
DATE	:	12/27/2014 11:07:46 PM

INPUTS	: 
		@GroupID int  
		@RoleID int  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table 'ADGroupRole' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[gsp_ADGroupRole_Insert_WithDefaultValues]
@GroupID int , 
@RoleID int , 
@dlgErrorCode int OUTPUT

AS

SET NOCOUNT ON

         
          -- create Table variable for columns default
          declare @____TEMP____TABLE___ table
          (
 	          column_name nvarchar(128),
 	          column_def nvarchar(4000)
          )
          insert into @____TEMP____TABLE___ SELECT column_name,column_default
          FROM INFORMATION_SCHEMA.COLUMNS (nolock) where table_Name ='ADGroupRole'
      
          --prepare temporary variable to iterate over default values.
          declare @___t nvarchar(4000)   
          declare @___s nvarchar(4000)

          --variables for substring calculation to remove starting and ending parentheses is exist
          declare @__i bigint
          declare @__j bigint
          declare @__len bigint
          
          declare @____temp_execution_result___ table /*temp table*/
          (result nvarchar (4000))

          ---declare this once in every insertion stored procedure
          declare @___GUIDTable Table
          (
          [Key] [uniqueidentifier] NOT NULL DEFAULT (newsequentialid())
          )
          
          --test if the passes parameter is null to get its default
          if @GroupID is null
          begin
            set @___t=(select column_def from @____TEMP____TABLE___ where column_name='GroupID')
            --trim default value from leading and ending parentheses.
            set @__i=charindex ('(',@___t);
            set @__len = len (@___t)
            set @__j = charindex (')',@___t,@__len);

            if @__i= 1 AND @__j =@__len
            begin
              set @___t=substring( @___t,2,@__len-2);
            end
            
          
            set @___t = 'select '+@___t      
            -- execute the default value expression
            insert into @____temp_execution_result___ execute sp_executesql @___t
            set @GroupID =  convert ( int,(select result from @____temp_execution_result___));
            
            --clears temp table data to be ready for next insertion (for other procedure params)
            delete  from @____temp_execution_result___ 
               

          end        
          --test if the passes parameter is null to get its default
          if @RoleID is null
          begin
            set @___t=(select column_def from @____TEMP____TABLE___ where column_name='RoleID')
            --trim default value from leading and ending parentheses.
            set @__i=charindex ('(',@___t);
            set @__len = len (@___t)
            set @__j = charindex (')',@___t,@__len);

            if @__i= 1 AND @__j =@__len
            begin
              set @___t=substring( @___t,2,@__len-2);
            end
            
          
            set @___t = 'select '+@___t      
            -- execute the default value expression
            insert into @____temp_execution_result___ execute sp_executesql @___t
            set @RoleID =  convert ( int,(select result from @____temp_execution_result___));
            
            --clears temp table data to be ready for next insertion (for other procedure params)
            delete  from @____temp_execution_result___ 
               

          end        
            


          
          -- INSERT a new row in the table
          INSERT INTO [dbo].[ADGroupRole]( [GroupID],[RoleID] )
          VALUES ( @GroupID,@RoleID )


          -- Get the Error Code for the statment just executed
          SET @dlgErrorCode = @@ERROR


GO
				
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_ADGroupRole_Insert_WithDefaultValues_AndReturn]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_ADGroupRole_Insert_WithDefaultValues_AndReturn]
GO


/*

OBJECT NAME : gsp_ADGroupRole_Insert_WithDefaultValues_AndReturn
						
AUTHOR	:	Ignyte Software ©
DATE	:	12/27/2014 11:07:46 PM

INPUTS	: 
		@GroupRoleID int = null  
		@GroupID int = null  
		@RoleID int = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table 'ADGroupRole' and return back the entire row
(with the default values inserted)

*/
CREATE PROCEDURE [dbo].[gsp_ADGroupRole_Insert_WithDefaultValues_AndReturn]
@GroupRoleID int = null , 
@GroupID int = null , 
@RoleID int = null , 
@dlgErrorCode int OUTPUT

AS

SET NOCOUNT ON

         
          -- create Table variable for columns default
          declare @____TEMP____TABLE___ table
          (
 	          column_name nvarchar(128),
 	          column_def nvarchar(4000)
          )
          insert into @____TEMP____TABLE___ SELECT column_name,column_default
          FROM INFORMATION_SCHEMA.COLUMNS   (nolock) where table_Name ='ADGroupRole'
      
          --prepare temporary variable to iterate over default values.
          declare @___t nvarchar(4000)   


          --variables for substring calculation to remove starting and ending parentheses is exist
          declare @__i bigint
          declare @__j bigint
          declare @__len bigint
          
          declare @____temp_execution_result___ table /*temp table*/
          (result nvarchar (4000))

          ---declare this once in every insertion stored procedure
          declare @___GUIDTable Table
          (
          [Key] [uniqueidentifier] NOT NULL DEFAULT (newsequentialid())
          )
          
          --test if the passes parameter is null to get its default
          if @GroupID is null
          begin
            set @___t=(select column_def from @____TEMP____TABLE___ where column_name='GroupID')
            --trim default value from leading and ending parentheses.
            set @__i=charindex ('(',@___t);
            set @__len = len (@___t)
            set @__j = charindex (')',@___t,@__len);

            if @__i= 1 AND @__j =@__len
            begin
              set @___t=substring( @___t,2,@__len-2);
            end
            
          
            set @___t = 'select '+@___t      
            -- execute the default value expression
            insert into @____temp_execution_result___ execute sp_executesql @___t
            set @GroupID =  convert ( int,(select result from @____temp_execution_result___));
            
            --clears temp table data to be ready for next insertion (for other procedure params)
            delete  from @____temp_execution_result___ 
               

          end        
          --test if the passes parameter is null to get its default
          if @RoleID is null
          begin
            set @___t=(select column_def from @____TEMP____TABLE___ where column_name='RoleID')
            --trim default value from leading and ending parentheses.
            set @__i=charindex ('(',@___t);
            set @__len = len (@___t)
            set @__j = charindex (')',@___t,@__len);

            if @__i= 1 AND @__j =@__len
            begin
              set @___t=substring( @___t,2,@__len-2);
            end
            
          
            set @___t = 'select '+@___t      
            -- execute the default value expression
            insert into @____temp_execution_result___ execute sp_executesql @___t
            set @RoleID =  convert ( int,(select result from @____temp_execution_result___));
            
            --clears temp table data to be ready for next insertion (for other procedure params)
            delete  from @____temp_execution_result___ 
               

          end        
            


          /* INSERT a new row in the table*/

              
INSERT INTO [dbo].[ADGroupRole]( [GroupID],[RoleID] )
OUTPUT Inserted.*
VALUES (   @GroupID,@RoleID  ) ; 






/* Get the Error Code for the statment just executed*/
SET @dlgErrorCode = @@ERROR


GO
				
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_ADGroupRole_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_ADGroupRole_Insert]
GO


/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : gsp_ADGroupRole_Insert
						
AUTHOR	:	Ignyte Software ©
DATE	:	12/27/2014 11:07:46 PM

INPUTS	: 
		@GroupID int  
		@RoleID int  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table 'ADGroupRole' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[gsp_ADGroupRole_Insert]
@GroupID int , 
@RoleID int , 
@dlgErrorCode int OUTPUT

AS

SET NOCOUNT ON


          -- INSERT a new row in the table
          INSERT INTO [dbo].[ADGroupRole]( [GroupID],[RoleID] )
          VALUES ( @GroupID,@RoleID )


          -- Get the Error Code for the statment just executed
          SET @dlgErrorCode = @@ERROR


GO
				
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_ADGroupRole_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_ADGroupRole_Update]
GO


/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : gsp_ADGroupRole_Update
						
AUTHOR	:	Ignyte Software ©
DATE	:	12/27/2014 11:07:46 PM

INPUTS	: 
		@GroupRoleID int  
		@GroupID int  
		@RoleID int  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will update 1 row in the table 'ADGroupRole' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[gsp_ADGroupRole_Update]
@GroupRoleID int , 
@GroupID int , 
@RoleID int , 
@dlgErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- UPDATE a row in the table
UPDATE [dbo].[ADGroupRole]
SET
	[GroupID] = @GroupID ,
	[RoleID] = @RoleID
WHERE
[GroupRoleID] = @GroupRoleID


-- Get the Error Code for the statment just executed
SET @dlgErrorCode = @@ERROR


GO
				
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_ADGroupRole_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_ADGroupRole_Delete]
GO


/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : gsp_ADGroupRole_Delete
						
AUTHOR	:	Ignyte Software ©
DATE	:	12/27/2014 11:07:46 PM

INPUTS	: 
		@GroupRoleID int  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete 1 row from the table 'ADGroupRole' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[gsp_ADGroupRole_Delete]
@GroupRoleID int , 
@dlgErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- DELETE a row from the table
DELETE FROM [dbo].[ADGroupRole]
WHERE
[GroupRoleID] = @GroupRoleID


-- Get the Error Code for the statment just executed
SET @dlgErrorCode = @@ERROR


GO
				
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_ADGroupRole_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_ADGroupRole_DeleteByField]
GO


/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : gsp_ADGroupRole_DeleteByField
						
AUTHOR	:	Ignyte Software ©
DATE	:	12/27/2014 11:07:46 PM

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete row(s) from the table 'ADGroupRole'
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[gsp_ADGroupRole_DeleteByField]
@Field varchar(100),
@Value varchar(1000),
@dlgErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- DELETE row(s) from the table
DECLARE @query varchar(2000)

SET @query = 'DELETE FROM [dbo].[ADGroupRole] WHERE [' + @Field + '] = ''' + @Value + ''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @dlgErrorCode = @@ERROR


GO
				
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_ADGroupRole_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_ADGroupRole_SelectByPrimaryKey]
GO


/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : gsp_ADGroupRole_SelectByPrimaryKey
						
AUTHOR	:	Ignyte Software ©
DATE	:	12/27/2014 11:07:46 PM

INPUTS	: 
		@GroupRoleID int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table 'ADGroupRole' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[gsp_ADGroupRole_SelectByPrimaryKey]
@GroupRoleID int ,
@dlgErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[GroupRoleID],[GroupID],[RoleID]
FROM	[dbo].[ADGroupRole]
WHERE
	[GroupRoleID] = @GroupRoleID


-- Get the Error Code for the statment just executed
SET @dlgErrorCode = @@ERROR


GO
				
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_ADGroupRole_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_ADGroupRole_SelectAll]
GO


/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : gsp_ADGroupRole_SelectAll
						
AUTHOR	:	Ignyte Software ©
DATE	:	12/27/2014 11:07:46 PM

INPUTS	: 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select all rows from the table 'ADGroupRole' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[gsp_ADGroupRole_SelectAll]
@dlgErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT all row(s) from the table
declare @Query nvarchar(max);
set @Query='SELECT	[GroupRoleID],[GroupID],[RoleID]
			FROM	[dbo].[ADGroupRole]'

 exec (@Query)
  
 select @dlgErrorCode = @@ERROR


-- Get the Error Code for the statment just executed
SET @dlgErrorCode = @@ERROR


GO
				
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_ADGroupRole_SelectAllPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_ADGroupRole_SelectAllPaged]
GO


/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : gsp_ADGroupRole_SelectAllPaged
						
AUTHOR	:	Ignyte Software ©
DATE	:	12/27/2014 11:07:46 PM

INPUTS	: 
		@PageSize int
		@SkipPages int
		@OrderByStatement varchar(100)
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select the specified number of entries from the specified record number in the table 'ADGroupRole'
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[gsp_ADGroupRole_SelectAllPaged]
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
Exec gsp_ADGroupRole_SelectAll @dlgErrorCode=@dlgErrorCode
end
else
begin
SET @Query='SELECT	[GroupRoleID],[GroupID],[RoleID], ROW_NUMBER() OVER(ORDER BY ['+ @OrderByStatement+']) AS SortRow 
			FROM	[dbo].[ADGroupRole]'

if(@PageSize is not null and @PageSize<>'')
	SET @Query='SELECT TOP ' + CONVERT(varchar(max), @PageSize) + ' * FROM (' + @Query + ') AS query 
	WHERE query.SortRow > ' + CONVERT(varchar(max), @SkipPages * @PageSize)
end
 EXEC (@Query)
  
 SELECT @dlgErrorCode = @@ERROR


-- Get the Error Code for the statment just executed
SET @dlgErrorCode = @@ERROR


GO
				
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_ADGroupRole_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_ADGroupRole_SelectByField]
GO


/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : gsp_ADGroupRole_SelectByField
						
AUTHOR	:	Ignyte Software ©
DATE	:	12/27/2014 11:07:46 PM

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)
		@Value2 varchar(1000)
		@Operation varchar(10)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select row(s) from the table 'ADGroupRole' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[gsp_ADGroupRole_SelectByField]
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
SET @Query = 'SELECT [GroupRoleID],[GroupID],[RoleID]
			FROM [dbo].[ADGroupRole] WHERE [' +replace(@Field,']',']]') + '] BETWEEN  ''' + @Value + ''' And '''+ @Value2+''''
else
SET @Query = 'SELECT [GroupRoleID],[GroupID],[RoleID]
			FROM [dbo].[ADGroupRole] WHERE [' +replace(@Field,']',']]') + ']'+@Operation+ '''' + @Value + ''''

EXEC(@Query)


-- Get the Error Code for the statment just executed
SET @dlgErrorCode = @@ERROR


GO
				
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_ADGroupRole_SelectByFieldPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_ADGroupRole_SelectByFieldPaged]
GO


/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : gsp_ADGroupRole_SelectByFieldPaged
						
AUTHOR	:	Ignyte Software ©
DATE	:	12/27/2014 11:07:46 PM

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

DESCRIPTION : This stored procedure will select the specified number of entries from the specified record number in the table'ADGroupRole' 
				using the value of the field specified
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[gsp_ADGroupRole_SelectByFieldPaged]
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
	SET @Query = 'SELECT [GroupRoleID],[GroupID],[RoleID], ROW_NUMBER() OVER(ORDER BY ['+ @OrderByStatement+']) AS SortRow
			FROM [dbo].[ADGroupRole] WHERE [' + REPLACE(@Field,']',']]') + '] BETWEEN  ''' + @Value + ''' AND '''+ @Value2+''''
ELSE
	SET @Query = 'SELECT [GroupRoleID],[GroupID],[RoleID], ROW_NUMBER() OVER(ORDER BY ['+ @OrderByStatement + ']) AS SortRow
			FROM [dbo].[ADGroupRole] WHERE [' + REPLACE(@Field,']',']]') + ']' + @Operation + '''' + @Value + ''''

IF(@PageSize IS NOT NULL AND @PageSize<>'')
	set @Query='SELECT TOP '+ CONVERT(varchar(max), @PageSize) + ' * FROM (' + @Query + ') AS query 
	WHERE query.SortRow > ' + CONVERT(varchar(max), @SkipPages * @PageSize)

EXEC(@Query)


-- Get the Error Code for the statment just executed
SET @dlgErrorCode = @@ERROR


GO
				
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_ADGroupRole_SelectAllCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_ADGroupRole_SelectAllCount]
GO


/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : gsp_ADGroupRole_SelectAllCount
						
AUTHOR	:	Ignyte Software ©
DATE	:	12/27/2014 11:07:46 PM

INPUTS	: 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select all rows count from the table 'ADGroupRole' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[gsp_ADGroupRole_SelectAllCount]
@dlgErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT all row(s) count from the table
declare @Query nvarchar(max);
set @Query='SELECT	Count(*)
			FROM	[dbo].[ADGroupRole]'

 exec (@Query)
  
 select @dlgErrorCode = @@ERROR


-- Get the Error Code for the statment just executed
SET @dlgErrorCode = @@ERROR


GO
				






