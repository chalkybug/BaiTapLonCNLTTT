create database qlPCCC
USE qlPCCC
GO

CREATE TABLE TramCuuHoa(
	id INT identity PRIMARY KEY,
	name NVARCHAR(100) NOT NULL,
	phone VARCHAR(11) NOT NULL,
	address NVARCHAR(100) NOT NULL,
	lat FLOAT NOT NULL,
	lng FLOAT NOT NULL,
);
go
CREATE TABLE XeCuuHoa(
	id INT	identity PRIMARY KEY,
	name NVARCHAR(100) NOT NULL,
	idTramCuuHoa INT REFERENCES dbo.TramCuuHoa(id), -- thuộc trạm cứu hỏa nào
	capacity FLOAT NOT NULL, -- dung tích chứa được bao nhiêu lít
	maxHeight FLOAT NOT NULL , -- chiều cao tối đa xe có thể phun nước tới	
	size VARCHAR(10) NOT NULL, -- kích thức s,m,l 
	status VARCHAR(10) DEFAULT 'free' -- free and busy
);
go
CREATE TABLE DamChay(
	id INT	identity PRIMARY KEY,
	level INT NOT NULL  DEFAULT 1,
	city NVARCHAR(50) NOT NULL DEFAULT 'Hà Nội',
	county NVARCHAR(50) NOT NULL DEFAULT 'Cầu Giấy',
	address NVARCHAR(100) NOT NULL,
	damages FLOAT DEFAULT 200, -- đơn vị triệu đồng
	date DATE DEFAULT GETDATE(),
	lat FLOAT NOT NULL,
	lng FLOAT NOT NULL,

);

go
CREATE TABLE TruNuoc(
	id INT IDENTITY	PRIMARY KEY,
	city NVARCHAR(50) NOT NULL DEFAULT 'Hà Nội',
	county NVARCHAR(50) NOT NULL DEFAULT 'Cầu Giấy',
	address NVARCHAR(100) NOT NULL,
	lat FLOAT NOT NULL,
	lng FLOAT NOT NULL,
);


go
insert dbo.TruNuoc values (N'Hà Nội', N'Việt Nam', N'Khách sạn Bảo Nam- Đường Phùng Hưng', 20.9631177564783, 105.796194076538);
insert dbo.TruNuoc values (N'Hà Nội', N'Việt Nam', N'Keangnam Hà Nội Landmark Tower- Đường Phạm Hùng', 21.0162925845722, 105.783340930939);
insert dbo.TruNuoc values (N'Hà Nội', N'Việt Nam', N'Nhà hàng vịt nướng Mai Hường- Đường quốc lộ 1A', 20.8227024945699, 105.882319808006);
insert dbo.TruNuoc values (N'Hà Nam', N'Việt Nam', N'Ga Phủ Lý- Đường Lê Hoàn', 20.540414, 105.912754);
insert dbo.TruNuoc values (N'Hưng Yên', N'Việt Nam', N'Việt Phương Car Rental Service- Đường cầu Yên Lệnh', 20.658766, 106.050496);
insert dbo.TruNuoc values (N'Nam Định', N'Việt Nam', N'Big C Nam Định- Quốc lộ 21B', 20.438522, 106.153341);
insert dbo.TruNuoc values (N'Thái Bình', N'Việt Nam', N'Chùa Phúc Minh- Đường Lý Bôn- Vũ Thư', 20.498582, 106.234941);
insert dbo.TruNuoc values (N'Thái Bình', N'Việt Nam', N'Bến xe khách Thái Bình- Đường Trần Thái Tông', 20.449769, 106.333680);
insert dbo.TruNuoc values (N'Hải Dương', N'Việt Nam', N'Quầy thuốc số 6- Đường 38B', 20.770383, 106.231695);
insert dbo.TruNuoc values (N'Hải Dương', N'Việt Nam', N'UBND xã Phương Hưng', 20.866187, 106.292537);
insert dbo.TruNuoc values (N'Hải Dương', N'Việt Nam', N'Điểm bưu điện văn hóa xã Cẩm Định- Cẩm Giàng', 20.961189, 106.234177);
insert dbo.TruNuoc values (N'Bắc Ninh', N'Việt Nam', N'Bệnh viện đa khoa huyện Lương Tài- Đường Hàn Thuyên', 21.023140, 106.208338);
insert dbo.TruNuoc values (N'Bắc Ninh', N'Việt Nam', N'Karaoke Tuân Thanh- Đường 291', 21.149284, 106.151688);
insert dbo.TruNuoc values (N'Bắc Ninh', N'Việt Nam', N'UBND xã Đông Thọ- Đường 295', 21.170248, 105.956942);
insert dbo.TruNuoc values (N'Vĩnh Phúc', N'Việt Nam', N'Nhà nghỉ Hà Linh- Đường 303', 21.225495, 105.606807);
insert dbo.TruNuoc values (N'Vĩnh Phúc', N'Việt Nam', N'Cẩm Vực- Đê tả sông Hồng', 21.184770, 105.525507);
insert dbo.TruNuoc values (N'Hà Nội', N'Việt Nam', N'Bakery Thu Hương- Thượng Mỗ- Đan Phượng', 21.112486, 105.676225);
insert dbo.TruNuoc values (N'Vĩnh Phúc', N'Việt Nam', N'Chợ rưng Tứ Trưng- Tx Sơn Tây', 21.202897, 105.523867);
insert dbo.TruNuoc values (N'Phú Thọ', N'Việt Nam', N'Đền thờ Kinh Dương Vương- Đường Chu Hóa', 21.357846, 105.319026);
insert dbo.TruNuoc values (N'Phú Thọ', N'Việt Nam', N'Chùa Quang Linh- Đường 307', 21.398789, 105.343471);
insert dbo.TruNuoc values (N'Phú Thọ', N'Việt Nam', N'Nhà văn hóa khu 2- Đường 2- Tx Phú Thọ', 21.491579, 105.225519);
insert dbo.TruNuoc values (N'Hà Nội', N'Việt Nam', N'UBND xã Trạch Mĩ Lộc- Đường 82- Phúc Thọ', 21.097457, 105.530977);
insert dbo.TruNuoc values (N'Hà Nội', N'Việt Nam', N'Suri Coffee- Đường Tân Hội- Đan Phượng', 21.093397, 105.700514);
insert dbo.TruNuoc values (N'Thái Nguyên', N'Việt Nam', N'Nhà nghỉ Bình Yên- Quốc lộ 3', 21.561825, 105.823739);
insert dbo.TruNuoc values (N'Thái Nguyên', N'Việt Nam', N'Ga Thái Nguyên- Quang trung', 21.586764, 105.823769);
insert dbo.TruNuoc values (N'Bắc Giang', N'Việt Nam', N'Ngôi nhà hạnh phúc- Ngọc Thiện- Tân Yên', 21.359768, 106.059777);
insert dbo.TruNuoc values (N'Bắc Giang', N'Việt Nam', N'Cửa hàng tạp hóa Nguyễn Thị Hoài- Hoàng Hoa Thám- Nghĩa Trung', 21.333864, 106.135204);
insert dbo.TruNuoc values (N'Bắc Giang', N'Việt Nam', N'Cửa hàng điện nước Thủy Vũ- Đường 293- Yên Dũng', 21.265488, 106.299104);
insert dbo.TruNuoc values (N'Lạng Sơn', N'Việt Nam', N'Trường THCS xã Nhân Lý- Chi Lăng', 21.700196, 106.657656);
insert dbo.TruNuoc values (N'Thái Bình', N'Việt Nam', N'Cửa hàng bán đồ điện tử Lan Lừng- Hưng Hà', 20.590041, 106.262115);


go

insert dbo.XeCuuHoa values (N'xe 1', 3, 8000, 80, 'l', 'free');
insert dbo.XeCuuHoa values (N'xe 2', 2, 5000, 50, 'm', 'busy');
insert dbo.XeCuuHoa values (N'xe 3', 1, 8000, 80, 'l', 'free');
insert dbo.XeCuuHoa values (N'xe 4', 4, 8000, 80, 'l', 'busy');
insert dbo.XeCuuHoa values (N'xe 5', 5, 8000, 80, 'l', 'free');
insert dbo.XeCuuHoa values (N'xe 6', 6, 8000, 80, 'l', 'free');
insert dbo.XeCuuHoa values (N'xe 7', 8, 8000, 80, 'l', 'free');
insert dbo.XeCuuHoa values (N'xe 8', 7, 5000, 50, 'm', 'free');
insert dbo.XeCuuHoa values (N'xe 9', 10, 5000, 50, 'm', 'busy');
insert dbo.XeCuuHoa values (N'xe 10', 9, 5000, 50, 'm', 'busy');
insert dbo.XeCuuHoa values (N'xe 11', 1, 8000, 80, 'l', 'busy');
insert dbo.XeCuuHoa values (N'xe 12', 1, 5000, 50, 'm', 'busy');
insert dbo.XeCuuHoa values (N'xe 13', 12 ,5000, 50, 'm', 'free');
insert dbo.XeCuuHoa values (N'xe 14', 14, 5000, 50, 'm', 'busy');
insert dbo.XeCuuHoa values (N'xe 15', 2, 5000, 50, 'm', 'free');
insert dbo.XeCuuHoa values (N'xe 16', 3, 8000, 80, 'l', 'free');
insert dbo.XeCuuHoa values (N'xe 17', 5, 8000, 80, 'l', 'busy');
insert dbo.XeCuuHoa values (N'xe 18', 4, 3000, 30, 's', 'free');
insert dbo.XeCuuHoa values (N'xe 19', 9, 8000, 80, 'l', 'busy');
insert dbo.XeCuuHoa values (N'xe 20', 9, 3000, 30, 's', 'busy');
insert dbo.XeCuuHoa values (N'xe 21', 6, 3000, 30, 's', 'free');
insert dbo.XeCuuHoa values (N'xe 22', 8, 8000, 80, 'l', 'free');
insert dbo.XeCuuHoa values (N'xe 23', 7, 8000, 80, 'l', 'free');
insert dbo.XeCuuHoa values (N'xe 24', 9, 8000, 80, 'l', 'free');
insert dbo.XeCuuHoa values (N'xe 25', 15, 8000, 80, 'l', 'busy');
insert dbo.XeCuuHoa values (N'xe 26', 11, 8000, 80, 'l', 'busy');
insert dbo.XeCuuHoa values (N'xe 27', 12, 8000, 80, 'l', 'busy');
insert dbo.XeCuuHoa values (N'xe 28', 5, 8000, 80, 'l', 'free');
insert dbo.XeCuuHoa values (N'xe 29', 3, 8000, 80, 'l', 'busy');
insert dbo.XeCuuHoa values (N'xe 30', 12, 8000, 80, 'l', 'free');
insert dbo.XeCuuHoa values (N'xe 31', 15, 3000, 30, 's', 'free');
insert dbo.XeCuuHoa values (N'xe 32', 12, 3000, 30, 's', 'busy');
insert dbo.XeCuuHoa values (N'xe 33', 11, 3000, 30, 's', 'free');
insert dbo.XeCuuHoa values (N'xe 34', 10, 3000, 30, 's', 'busy');
insert dbo.XeCuuHoa values (N'xe 35', 5, 5000, 50, 'm', 'free');
insert dbo.XeCuuHoa values (N'xe 36', 6, 5000, 50, 'm', 'busy');
insert dbo.XeCuuHoa values (N'xe 37', 8, 8000, 80, 'l', 'busy');
insert dbo.XeCuuHoa values (N'xe 38', 9, 5000, 50, 'm', 'busy');
insert dbo.XeCuuHoa values (N'xe 39', 10, 5000, 50, 'm', 'free');
insert dbo.XeCuuHoa values (N'xe 40', 7, 5000, 50, 'm', 'busy');
insert dbo.XeCuuHoa values (N'xe 41', 7, 5000, 50, 'm', 'busy');
insert dbo.XeCuuHoa values (N'xe 42', 7, 8000, 80, 'l', 'busy');
insert dbo.XeCuuHoa values (N'xe 43', 4, 8000, 80, 'l', 'free');
insert dbo.XeCuuHoa values (N'xe 44', 1, 3000, 30, 's', 'busy');
insert dbo.XeCuuHoa values (N'xe 45', 2, 3000, 30, 's', 'busy');
insert dbo.XeCuuHoa values (N'xe 46', 9, 3000, 30, 's', 'free');
insert dbo.XeCuuHoa values (N'xe 47', 8, 8000, 80, 'l', 'free');
insert dbo.XeCuuHoa values (N'xe 48', 5, 8000, 80, 'l', 'free');
insert dbo.XeCuuHoa values (N'xe 49', 3, 8000, 80, 'l', 'free');
insert dbo.XeCuuHoa values (N'xe 50', 9, 5000, 50, 'm', 'busy');
insert dbo.XeCuuHoa values (N'xe 51', 15, 5000, 50, 'm', 'busy');
insert dbo.XeCuuHoa values (N'xe 52', 14, 5000, 50, 'm', 'busy');
insert dbo.XeCuuHoa values (N'xe 53', 14, 5000, 50, 'm', 'free');
insert dbo.XeCuuHoa values (N'xe 54', 3, 3000, 30, 's', 'free');
insert dbo.XeCuuHoa values (N'xe 55', 1, 5000, 30, 'm', 'free');
insert dbo.XeCuuHoa values (N'xe 56', 4, 3000, 30, 's', 'busy');
insert dbo.XeCuuHoa values (N'xe 57', 5, 8000, 80, 'l', 'free');
insert dbo.XeCuuHoa values (N'xe 58', 6, 8000, 80, 'l', 'busy');
insert dbo.XeCuuHoa values (N'xe 59', 7, 5000, 50, 'm', 'free');
insert dbo.XeCuuHoa values (N'xe 60', 8, 5000, 50, 'm', 'busy');
insert dbo.XeCuuHoa values (N'xe 61', 9, 8000, 80, 'l', 'busy');
insert dbo.XeCuuHoa values (N'xe 62', 10, 3000, 30, 's', 'busy');
insert dbo.XeCuuHoa values (N'xe 63', 7, 5000, 50, 'm', 'free');
insert dbo.XeCuuHoa values (N'xe 64', 8, 5000, 50, 'm', 'busy');
insert dbo.XeCuuHoa values (N'xe 65', 13, 3000, 30, 's', 'free');
go


--tạo thủ tục thêm sửa xóa bảng XeCuuHoa
go
create proc addXCH(@ten nvarchar(100), @idTCH int, @capa float, @maxH float, @size varchar(10), @stt varchar(10))
as
begin
	insert into XeCuuHoa
	values (@ten, @idTCH, @capa, @maxH, @size, @stt)
end
--
go
create proc delXCH(@ten nvarchar(100), @idTCH int, @capa float, @maxH float, @size varchar(10), @stt varchar(10))
as
begin
	delete from XeCuuHoa
	where idTramCuuHoa=@idTCH
end
--
go
create proc updateXCH (@ten nvarchar(100), @idTCH int, @capa float, @maxH float, @size varchar(10), @stt varchar(10))
as
begin
	update XeCuuHoa
	set name=@ten, idTramCuuHoa=@idTCH, capacity=@capa, maxHeight=@maxH, size=@size, status=@stt
	where idTramCuuHoa=@idTCH
end
--tạo thủ tục thêm sửa xóa cho bảng TruNuoc
go
create proc addTN(@city nvarchar(100), @cou nvarchar(100), @addr nvarchar(150), @lat float, @inq float)
as
begin
	insert into TruNuoc
	values (@city, @cou, @addr, @lat, @inq)
end
--
go
create proc delTN(@city nvarchar(100), @cou nvarchar(100), @addr nvarchar(150), @lat float, @inq float)
as
begin
	delete from TruNuoc
	where 
end