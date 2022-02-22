use master
go
create database Complains_DUE
go
use Complains_DUE
go
create table complains
(
	IdStudent varchar(225) null,
	IdComplains int IDENTITY(1,1) not null,
	IdDepartment int null,
	Title nvarchar(225) null,
	Content nvarchar(max) null,
	ContentType nvarchar(100) null,
	[date] datetime null,
	Picture varchar(max) null,
	[status] bit not null,
	reply nvarchar(max) null,
	PRIMARY KEY(IdComplains)
)
create table Departments
(
	Id int IDENTITY(1,1) not null,
	[name] nvarchar(225) null,
	totalstudent int null,
	totalemployee int null,
	phone char(11) null,
	PRIMARY KEY(Id)
)
create table Accounts
(
	[username] varchar(225) not null,
	[password] varchar(225) not null,
	[role] int not null,
	Actived bit not null
	PRIMARY KEY(username)
)
create table Employees
(
	id int IDENTITY(1,1) not null,
	idDepartment int null,
	[name] nvarchar(225) null,
	position nvarchar(225) null,
	picture varchar(max) null,
	[username] varchar(225) null, 
	PRIMARY KEY(id)
)
create table Students
(
	studentcode varchar(225) not null,
	email varchar(256) null,
	phone varchar(11) null,
	[name] nvarchar(max) null,
	class varchar(50) null,
	Department int null,
	PRIMARY KEY(studentcode)
)
go
Alter table complains
Add Foreign key (IdDepartment) References Departments(Id);
go
Alter table complains
Add Foreign key (IdStudent) References students(studentcode);
go
Alter table Employees
Add Foreign key (IdDepartment) References Departments(Id);
go
Alter table Students
Add Foreign Key (studentcode) References Accounts(username) 
go
Alter table Employees
Add Foreign Key (username) References Accounts(username) 
go
Insert into Accounts Values ('181121521137','202cb962ac59075b964b07152d234b70',2,1)
Insert into Accounts Values ('171121521050','202cb962ac59075b964b07152d234b70',2,1)
Insert into Accounts Values ('191154833658','202cb962ac59075b964b07152d234b70',2,1)
Insert into Accounts Values ('181121521136','202cb962ac59075b964b07152d234b70',2,1)
Insert into Accounts Values ('181121521138','202cb962ac59075b964b07152d234b70',2,1)
Insert into Accounts Values ('191123659113','202cb962ac59075b964b07152d234b70',2,1)
Insert into Accounts Values ('201154896335','202cb962ac59075b964b07152d234b70',2,1)
Insert into Accounts Values ('201159871175','202cb962ac59075b964b07152d234b70',2,1)
Insert into Accounts Values ('171122225114','202cb962ac59075b964b07152d234b70',2,1)
Insert into Accounts Values ('181121018316','202cb962ac59075b964b07152d234b70',2,1)
Insert into Accounts Values ('171198422678','202cb962ac59075b964b07152d234b70',2,1)
Insert into Accounts Values ('181121521141','202cb962ac59075b964b07152d234b70',2,1)
Insert into Accounts Values ('danle@due.edu.vn','202cb962ac59075b964b07152d234b70',3,1)
Insert into Accounts Values ('ha.htt@due.edu.vn','202cb962ac59075b964b07152d234b70',3,1)
Insert into Accounts Values ('nhamct@due.edu.vn','202cb962ac59075b964b07152d234b70',3,1)
Insert into Accounts Values ('khuethu@due.edu.vn','202cb962ac59075b964b07152d234b70',3,1)
Insert into Accounts Values ('voquangtri@due.edu.vn','202cb962ac59075b964b07152d234b70',3,1)
Insert into Accounts Values ('danvn@due.edu.vn','202cb962ac59075b964b07152d234b70',3,1)
Insert into Accounts Values ('van.ptb@due.edu.vn','202cb962ac59075b964b07152d234b70',3,1)
Insert into Accounts Values ('thenb@due.edu.vn','202cb962ac59075b964b07152d234b70',3,1)
Insert into Accounts Values ('thuynt@due.edu.vn','202cb962ac59075b964b07152d234b70',3,1)
Insert into Accounts Values ('hieuth@due.edu.vn','202cb962ac59075b964b07152d234b70',3,1)
Insert into Accounts Values ('thaotran@due.edu.vn','202cb962ac59075b964b07152d234b70',3,1)
Insert into Accounts Values ('Admin','21232f297a57a5a743894a0e4a801fc3',6,1)

go
Insert into Departments (name,totalstudent,totalemployee,phone) values (N'Kế toán',1862,25,'02363836987')
Insert into Departments (name,totalstudent,totalemployee,phone) values (N'Quản trị kinh doanh',2103,27,'0914953499')
Insert into Departments (name,totalstudent,totalemployee,phone) values (N'Marketing',1796,23,'02363525358')
Insert into Departments (name,totalstudent,totalemployee,phone) values (N'Du lịch',2195,28,'02363958726')
Insert into Departments (name,totalstudent,totalemployee,phone) values (N'Kinh doanh quốc tế',1574,20,'02363836935')
Insert into Departments (name,totalstudent,totalemployee,phone) values (N'Ngân hàng',1163,17,'02363847001')
Insert into Departments (name,totalstudent,totalemployee,phone) values (N'Tài chính',941,15,'02363525459')
Insert into Departments (name,totalstudent,totalemployee,phone) values (N'Thống kê - Tin học',763,12,'02363950885')
Insert into Departments (name,totalstudent,totalemployee,phone) values (N'Thương mại Điện tử',595,10,'02363985912')
go
Insert into Students values('181121521137','181121521137@due.udn.vn','0352136105',N'Nguyễn Quốc Thiện', '44K21.1',26)
Insert into Students values('171121521050','171121521050@due.udn.vn','0879647136',N'Lê Linh Phương', '43K03.2',21)
Insert into Students values('191154833658','191154833658@due.udn.vn','0539852336',N'Trần Đức Duy Anh', '45K18.3',25)
Insert into Students values('181121521136','181121521136@due.udn.vn','0823682249',N'Nguyễn Quang Thành', '44K21.1',26)
Insert into Students values('181121521138','181121521138@due.udn.vn','0598523694',N'Nguyễn Duy Thông', '44K21.1',26)
Insert into Students values('191123659113','191123659113@due.udn.vn','0793654825',N'Nguyễn Minh', '45K12',23)
Insert into Students values('201154896335','201154896335@due.udn.vn','0483399852',N'Lê Hà Phước', '46K05.2',22)
Insert into Students values('201159871175','201159871175@due.udn.vn','0698736523',N'Nguyễn Thành Đô', '46K22.1',22)
Insert into Students values('171122225114','171122225114@due.udn.vn','0157932554',N'Hồ Tiểu Băng', '43K15',27)
Insert into Students values('181121018316','181121018316@due.udn.vn','0786368412',N'Nguyễn Phương Huế', '44K08.3',19)
Insert into Students values('171198422678','171198422678@due.udn.vn','0872236436',N'Nguyễn Thị Thu Thảo', '43K21.1',20)
Insert into Students values('181121521141','181121521141@due.udn.vn','0947852572',N'Nguyễn Thị Thanh Tuyền', '44K21.1',26)
go
Insert into complains (IdStudent,IdDepartment,title,Content,ContentType,[status],[date]) values ('181121521137',1,N'Phàn nàn về cơ sở vật chất',N'Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học',N'Phàn nàn',0,'02/13/2022')
Insert into complains (IdStudent,IdDepartment,title,Content,ContentType,[status],[date]) values ('181121018316',2,N'Phàn nàn về cơ sở vật chất',N'Chỗ để xe chưa có máy che, gây hại cho tài sản sinh viên, chưa tích hợp công nghệ hóa, vẫn sử dụng phương pháp truyền thống, gây bất tiện cho sinh viên và ùn tắc giờ cao điểm',N'Phàn nàn',0,'02/13/2022')
Insert into complains (IdStudent,IdDepartment,title,Content,ContentType,[status],[date]) values ('181121521137',3,N'Phàn nàn về cơ sở vật chất',N'Thư viện chưa có không gian riêng tư, chưa tạo ra không gian thoải mái khi sinh viên học tập',N'Phàn nàn',0,'02/13/2022')
Insert into complains (IdStudent,IdDepartment,title,Content,ContentType,[status],[date]) values ('181121521138',4,N'Phàn nàn về cơ sở vật chất',N'Một số giảng viên chưa có sự nhiệt huyết',N'Phàn nàn',0,'02/13/2022')
Insert into complains (IdStudent,IdDepartment,title,Content,ContentType,[status],[date]) values ('171121521050',5,N'Phàn nàn về cơ sở vật chất',N'Căn tin ',N'Phàn nàn',0,'02/13/2022')
Insert into complains (IdStudent,IdDepartment,title,Content,ContentType,[status],[date]) values ('181121521137',6,N'Phàn nàn về cơ sở vật chất',N'Nhân viên phòng nước',N'Phàn nàn',0,'02/13/2022')
Insert into complains (IdStudent,IdDepartment,title,Content,ContentType,[status],[date]) values ('201154896335',7,N'Phàn nàn về cơ sở vật chất',N'',N'Phàn nàn',0,'02/13/2022')
Insert into complains (IdStudent,IdDepartment,title,Content,ContentType,[status],[date]) values ('201159871175',8,N'Phàn nàn về cơ sở vật chất',N'Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học',N'Phàn nàn',0,'02/13/2022')
Insert into complains (IdStudent,IdDepartment,title,Content,ContentType,[status],[date]) values ('181121521137',9,N'Phàn nàn về cơ sở vật chất',N'Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học',N'Phàn nàn',0,'02/13/2022')
Insert into complains (IdStudent,IdDepartment,title,Content,ContentType,[status],[date]) values ('191154833658',1,N'Phàn nàn về cơ sở vật chất',N'Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học',N'Phàn nàn',0,'02/13/2022')
Insert into complains (IdStudent,IdDepartment,title,Content,ContentType,[status],[date]) values ('181121521141',2,N'Phàn nàn về cơ sở vật chất',N'Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học',N'Phàn nàn',0,'02/13/2022')
go
Insert into Employees (idDepartment,[name],position,username) values (8, N'Lê Dân', N'Trưởng Khoa Thống kê-Tin học','danle@due.edu.vn')
Insert into Employees (idDepartment,[name],position,username) values (8, N'Hoàng Thị Thanh Hà', N'Phó Khoa Thống kê-Tin học','ha.htt@due.edu.vn')
Insert into Employees (idDepartment,[name],position,username) values (8, N'Cao Thị Nhâm', N'Giảng viên Khoa Thống kê- Tin học','nhamct@due.edu.vn')
Insert into Employees (idDepartment,[name],position,username) values (9, N'Ngô Thị Khuê Thư', N'Phó Khoa Marketing','khuethu@due.edu.vn')
Insert into Employees (idDepartment,[name],position,username) values (9, N'Võ Quang Trí', N'Trưởng Khoa Thương mại điện tử','voquangtri@due.edu.vn')
Insert into Employees (idDepartment,[name],position,username) values (9, N'Văn Ngọc Đàn', N'Giảng viên Khoa Thương mại điện tử','danvn@due.edu.vn')
Insert into Employees (idDepartment,[name],position,username) values (8, N'Phan Thị Bích Vân', N'Giảng viên Khoa Thống kê tin học','van.ptb@due.edu.vn')
Insert into Employees (idDepartment,[name],position,username) values (8, N'Nguyễn Bá Thế', N'Giảng viên Khoa Thống kê tin học','thenb@due.edu.vn')
Insert into Employees (idDepartment,[name],position,username) values (8, N'Nguyễn Thành Thủy', N'Giảng viên Khoa Thống kê tin học','thuynt@due.edu.vn')
Insert into Employees (idDepartment,[name],position,username) values (1, N'Trần Hoàng Hiếu', N'Giảng viên, Nghiên cứu sinh tại Nga','hieuth@due.edu.vn')
Insert into Employees (idDepartment,[name],position,username) values (8, N'Trần Thị Thu Thảo', N'Giảng viên Khoa Thống kê tin học','thaotran@due.edu.vn')

