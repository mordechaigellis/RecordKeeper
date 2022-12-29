drop table if exists test
create table dbo.test(
testid int not null identity primary key,    
 homeaddress varchar(100),
 mailingaddress varchar(100)
)

go