create database rebpin
use rebpin
create table project_description(project_id int primary key identity(1,1), project_name nvarchar(225), project_name_link nvarchar(225),
image_link nvarchar(225),image_link_name nvarchar(225), project_location nvarchar(225), 
price_range nvarchar(225), Built_Up_Area nvarchar(225), EMI nvarchar(225), RERA int, marketed_by nvarchar(225), owner_name nvarchar(225),
         Owner_link nvarchar(225), Owner_type nvarchar(225), description nvarchar(225), nearBy_facility nvarchar(225))

select * from project_description

insert into project_description(project_name) values('mona')

declare @myname nvarchar(20) = 'av'
print(@myname)