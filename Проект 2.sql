use dbRBT
go
create table tbl_TypeUser
(
	Id int identity primary key,
	[TypeIndex] int null,
	[Name] nvarchar(250) not null,
	[Surname] nvarchar(250) not null,
	[E-mail] varchar(50) not null,
	[Gender] nvarchar(15) not null,
	[Username] nvarchar(60) not null,
	[Passsword] nvarchar(50) not null,
	[ConfirmPassword] nvarchar(50) not null
); 

drop table tbl_TypeUser

alter table tbl_TypeUser
add constraint DF_tbl_TypeUser_Username_Unique UNIQUE(Username)
go

use dbRBT
go
alter table tbl_TypeUser
with check add constraint FK_tbl_WS2_tbl_TypeUser foreign key (TypeIndex)
references tbl_WS2 (UserId)
on update cascade
on delete cascade
go

alter table tbl_WS2
alter column UserId int not null
go