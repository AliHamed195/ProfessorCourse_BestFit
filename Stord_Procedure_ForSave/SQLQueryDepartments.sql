USE [CourseProfessor]
GO
/****** Object:  StoredProcedure [dbo].[my_InsertUpdateDelete_Department]    Script Date: 8/28/2022 1:24:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[my_InsertUpdateDelete_Department]  
@DepartmentID INT = NULL  
,@DepartmentName NVARCHAR(100) = NULL  
,@UserID INT = NULL 
,@Query INT  
AS  
BEGIN  
IF (@Query = 1)  
BEGIN  
INSERT INTO Department(  
Dep_Name  
,User_Id
)  
VALUES (  
@DepartmentName 
,@UserID
)  
IF (@@ROWCOUNT > 0)  
BEGIN  
SELECT 'Insert'  
END  
END  
IF (@Query = 2)  
BEGIN  
UPDATE Department  
SET Dep_Name = @DepartmentName  
,User_Id = @UserID
WHERE Department.Dep_Id = @DepartmentID  
SELECT 'Update'  
END  
IF (@Query = 3)  
BEGIN  
DELETE  
FROM Department  
WHERE Department.Dep_Id = @DepartmentID  
SELECT 'Deleted'  
END  
IF (@Query = 4)  
BEGIN  
SELECT *  
FROM Department  
END  
END  
IF (@Query = 5)  
BEGIN  
SELECT *  
FROM Department  
WHERE  Department.Dep_Id = @DepartmentID  
END  
