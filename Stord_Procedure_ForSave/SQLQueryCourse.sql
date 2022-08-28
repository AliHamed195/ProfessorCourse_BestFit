USE [CourseProfessor]
GO
/****** Object:  StoredProcedure [dbo].[my_InsertUpdateDelete_Course]    Script Date: 8/28/2022 2:00:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[my_InsertUpdateDelete_Course] 
@CourseID INT = NULL  
,@CourseCode NVARCHAR(100) = NULL 
,@CourseName NVARCHAR(100) = NULL  
,@CourseDateStart date = NULL 
,@CourseDuration INT = NULL 
,@Query INT  
AS  
BEGIN  
IF (@Query = 1)  
BEGIN  
INSERT INTO Course(  
Code
,CName
,CreatedOn
,Duration
)  
VALUES (  
@CourseCode 
,@CourseName
,@CourseDateStart
,@CourseDuration
)  
IF (@@ROWCOUNT > 0)  
BEGIN  
SELECT 'Insert'  
END  
END  
IF (@Query = 2)  
BEGIN  
UPDATE Course  
SET Code = @CourseCode
,CName = @CourseName
,CreatedOn = @CourseDateStart
,Duration = @CourseDuration
WHERE Course.CId = @CourseID  
SELECT 'Update'  
END  
IF (@Query = 3)  
BEGIN  
DELETE  
FROM Course  
WHERE Course.CId = @CourseID  
SELECT 'Deleted'  
END  
IF (@Query = 4)  
BEGIN  
SELECT *  
FROM Course  
END  
END  
IF (@Query = 5)  
BEGIN  
SELECT *  
FROM Course  
WHERE  Course.CId = @CourseID   
END  
