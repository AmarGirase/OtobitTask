
Create Database Otobit_Task
--------------------------------------
Create TABLE User_Table
(
UserId int identity(1,1),
UserName varchar(50),
Email varchar(50),
Password Varchar(50)
)
---------------------------------------
Create Proc Submit_All_Details
@UserName Varchar(50),
@Email varchar(50),
@Password varchar(50)
as
begin

insert into User_Table (UserName,Email,[Password])
values(@UserName,@Email,@Password)
end 

----------------------------------------------------
create proc Update_Email
@UserId int, 
@Email varchar(50)
as
begin
update User_Table set UserId=@UserId ,Email=@Email
end

select * from User_Table

create proc SP_GetEmpUserByID
@UserId int
as
begin
select * from User_Table where UserId=@UserId
end
GO
-----------------------------------------------------
Create proc SP_Get_ProfileData

as
begin
select * From User_Table 
end
GO
--------------------------------------------------------
create proc SP_GetUserIDName
as
begin
select UserId,UserName from User_Table
end
GO
---------------------------------------------------------