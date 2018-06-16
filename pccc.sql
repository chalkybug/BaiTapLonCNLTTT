CREATE DATABASE qlPCCC
GO

USE qlPCCC
GO

CREATE TABLE TramCuuHoa(
	id INT  IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL,
	phone VARCHAR(11) NOT NULL,
	address NVARCHAR(100) NOT NULL,
	lat FLOAT NOT NULL,
	lng FLOAT NOT NULL,
);
go
CREATE TABLE XeCuuHoa(
	id INT IDENTITY	PRIMARY KEY,
	name NVARCHAR(100) NOT NULL,
	idTramCuuHoa INT REFERENCES dbo.TramCuuHoa(id), -- thuộc trạm cứu hỏa nào
	capacity FLOAT NOT NULL, -- dung tích chứa được bao nhiêu lít
	maxHeight FLOAT NOT NULL , -- chiều cao tối đa xe có thể phun nước tới	
	size VARCHAR(10) NOT NULL, -- kích thức s,m,l 
	status VARCHAR(10) DEFAULT 'free' -- free and busy
);
go
CREATE TABLE DamChay(
	id INT IDENTITY	PRIMARY KEY,
	level INT NOT NULL  DEFAULT 1,
	city NVARCHAR(50) NOT NULL DEFAULT 'Hà Nội',
	county NVARCHAR(50) NOT NULL DEFAULT 'Cầu Giấy',
	address NVARCHAR(100) NOT NULL,
	damages FLOAT DEFAULT 200, -- đơn vị triệu đồng
	date DATE DEFAULT GETDATE(),
	lat FLOAT NOT NULL,
	lng FLOAT NOT NULL,

);
GO
ALTER TABLE dbo.DamChay ADD image VARCHAR(MAX) 
go
CREATE TABLE TruNuoc(
	id INT IDENTITY	PRIMARY KEY,
	city NVARCHAR(50) DEFAULT 'Hà Nội',
	county NVARCHAR(50) DEFAULT 'Cầu Giấy',
	address NVARCHAR(100) NOT NULL,
	lat FLOAT NOT NULL,
	lng FLOAT NOT NULL,
);


CREATE TABLE Account(
	id INT  IDENTITY PRIMARY KEY,
	username VARCHAR(100) NOT NULL DEFAULT 'admin',
	password VARCHAR(100) NOT NULL DEFAULT '123',
	displayName NVARCHAR(100) NOT NULL DEFAULT 'noname'
);
GO

CREATE TABLE BaoChay(
	id INT IDENTITY	PRIMARY KEY,
	city NVARCHAR(50) DEFAULT 'Hà Nội',
	county NVARCHAR(50)  DEFAULT 'Cầu Giấy',
	address NVARCHAR(100) NOT NULL,
	lat FLOAT NOT NULL,
	lng FLOAT NOT NULL,
);
ALTER TABLE dbo.BaoChay ADD image VARCHAR(MAX) 

GO
--//////////////////////////////////////////////////// INSERT
--- đám cháy
--- nam từ liêm
INSERT dbo.DamChay VALUES  ( 1 ,  N'Hà Nội' , N'Nam Từ Liêm' , N'Sân Vận Động Mĩ Đình Đường Lê Đức Thọ, Mỹ Đình' , 200 , '2018-05-15' ,  21.0203787047367 , 105.763943195343  )
INSERT dbo.DamChay VALUES  ( 3 ,  N'Hà Nội' , N'Nam Từ Liêm' , N'Trại Giam Hỏa Lò, Phúc Diễn, Xuân Phương' , 200 , '2018-03-15' ,  21.0229024288996 , 105.752291679382 )
INSERT dbo.DamChay VALUES  ( 2 ,  N'Hà Nội' , N'Nam Từ Liêm' , N'Bảo tàng hà nội ,Phạm Hùng, Mễ Trì' , 400 , '2018-02-15' ,  21.0100430077698 , 105.786334276199 )
INSERT dbo.DamChay VALUES  ( 4 ,  N'Hà Nội' , N'Nam Từ Liêm' , N'Trung tâm hội nghị quốc gia Phạm Hùng, Mễ Trì' , 300 , '2018-01-15' ,  21.0064173319907 , 105.787128210068 )
INSERT dbo.DamChay VALUES  ( 2 ,  N'Hà Nội' , N'Nam Từ Liêm' , N'Liên đoàn bóng đá việt nam, phú đô' , 300 , '2018-02-10' ,  21.0163126148461 , 105.769275426865 )
--
INSERT dbo.DamChay VALUES  ( 1 ,  N'Hà Nội' , N'Nam Từ Liêm' , N'Trường THPT Nguyễn Thị Minh Khai, Phúc Diễn' , 600 , '2018-03-15' ,  21.0467054546092 , 105.751047134399  )
INSERT dbo.DamChay VALUES  ( 2 ,  N'Hà Nội' , N'Nam Từ Liêm' , N'Ký túc xá Mỹ Đình, Hàm Nghi, Mỹ Đình' , 200 , '2018-02-19' ,  21.0342736797851 , 105.766394734383 )
INSERT dbo.DamChay VALUES  ( 2 ,  N'Hà Nội' , N'Nam Từ Liêm' , N'Chi cục thuế Quận Nam Từ Liêm, Số 4 Nguyễn Cơ Thạch Quận Nam, Mỹ Đình ' , 400 , '2018-02-22' ,  21.038379334347 , 105.767183303833 )
INSERT dbo.DamChay VALUES  ( 1 ,  N'Hà Nội' , N'Nam Từ Liêm' , N'Trung Tâm Viettel Nam Từ Liêm, 280 Hồ Tùng Mậu, Cầu Diễn' , 300 , '2018-03-11' ,  21.0409878682762 , 105.765670537949 )
INSERT dbo.DamChay VALUES  ( 1 ,  N'Hà Nội' , N'Nam Từ Liêm' , N'Ngõ 136 Hồ Tùng Mậu' , 300 , '2018-03-10' ,  21.0407275176138 , 105.768052339554 )

--- cầu giấy
INSERT dbo.DamChay VALUES  ( 3 ,  N'Hà Nội' , N'Cầu Giấy' , N'Chợ Nam Trung Yên ' , 300 , '2018-03-11' ,  21.0128172913299, 105.788340568542 )
INSERT dbo.DamChay VALUES  ( 3 ,  N'Hà Nội' , N'Cầu Giấy' , N'Keangnam Hanoi Landmark Tower, Phạm Hùng' , 900 , '2018-03-11' ,  21.0167532801909, 105.783877372742 )
INSERT dbo.DamChay VALUES  ( 4 ,  N'Hà Nội' , N'Cầu Giấy' , N'Trường Đại học Thương mại ,79 Hồ Tùng Mậu, Mai Dịch' , 400 , '2018-03-24' ,  21.0373979930592, 105.774908065796 )
INSERT dbo.DamChay VALUES  ( 2 ,  N'Hà Nội' , N'Cầu Giấy' , N'Truyền Hình CAND ANTV, Lê Đức Thọ, Mai Dịch' , 400 , '2018-03-21' ,  21.0370274849735, 105.771482884884 )
INSERT dbo.DamChay VALUES  ( 1 ,  N'Hà Nội' , N'Cầu Giấy' , N'Bệnh viện 198 , 9 Trần Bình, Mai Dịch,' , 500 , '2018-03-26' , 21.0334124793512, 105.778840184212 )
--
INSERT dbo.DamChay VALUES  ( 3 ,  N'Hà Nội' , N'Cầu Giấy' , N'Trường Cao đẳng Múa Việt Nam , Mai Dịch ' , 300 , '2018-03-17', 21.0381390064661, 105.775541067123 )
INSERT dbo.DamChay VALUES  ( 2 ,  N'Hà Nội' , N'Cầu Giấy' , N'Ngõ 76 Mai Dịch' , 100 , '2018-03-24' ,  21.0408076255584, 105.775964856148 )

INSERT dbo.DamChay VALUES  ( 2 ,  N'Hà Nội' , N'Cầu Giấy' , N'Học viện Báo chí và Tuyên truyền, 36 Xuân Thủy, Dịch Vọng Hậu' , 400 , '2018-03-24' , 21.0365618451266 , 105.788823366165 )
INSERT dbo.DamChay VALUES  ( 1 ,  N'Hà Nội' , N'Cầu Giấy' , N'KFC Cầu Giấy , 372-374 Cầu Giấy, Dịch Vọng' , 200 , '2018-03-11' ,  21.0360135898928, 105.79142510891 )
INSERT dbo.DamChay VALUES  ( 1 ,  N'Hà Nội' , N'Cầu Giấy' , N'Chợ Nghĩa Tân,' , 500 , '2018-03-24' , 21.0448780537743, 105.794603526592 )
GO
--------------------- Trạm Chữa Cháy
 INSERT dbo.TramCuuHoa(name, phone, address, lat, lng )
 VALUES  (N'Trạm cứu hỏa Xuân Thủy','0165252525',N'Cầu Giấy', 21.0366619828509, 105.786226987839)
  INSERT dbo.TramCuuHoa( name, phone, address, lat, lng )
 VALUES  (N'Trạm cứu hỏa Trần Đăng Ninh','0154245458',N'Cầu Giấy', 21.0340984359142, 105.792782306671)
  INSERT dbo.TramCuuHoa( name, phone, address, lat, lng )
 VALUES  (N'Trạm cứu hỏa Làng Phú Diễn','0985457457',N'Phú Diễn', 21.0535442406141, 105.761346817017)
  INSERT dbo.TramCuuHoa( name, phone, address, lat, lng )
 VALUES  (N'Trạm cứu hỏa Tân Mỹ','0165252525',N'Mỹ Đình 1', 21.0247250920038, 105.764951705933)
  INSERT dbo.TramCuuHoa( name, phone, address, lat, lng )
 VALUES  (N'Trạm cứu hỏa Trung Tâm Hội Nghị Quốc Gia','0165252525',N'Trần Duy Hưng', 21.0067578688239, 105.787761211395)
  INSERT dbo.TramCuuHoa(  name, phone, address, lat, lng )
 VALUES  ( N'Trạm cứu hỏa chiếu phim quốc gia','0165252525',N'Láng Hạ', 105.787761211395, 105.815613269806)
  INSERT dbo.TramCuuHoa(  name, phone, address, lat, lng )
 VALUES  ( N'Trạm cứu hỏa trung cấp nghề số 10','0165252525',N'Hoàng Văn Thái', 20.9977433965602, 105.820527076721)
  INSERT dbo.TramCuuHoa(  name, phone, address, lat, lng )
 VALUES  ( N'Trạm cứu hỏa y dược cổ truyền','0165252525',N'Phùng Khoang', 20.9845512376912, 105.792599916458)
  INSERT dbo.TramCuuHoa(  name, phone, address, lat, lng )
 VALUES  ( N'Trạm cứu hỏa nghĩa trang văn quán','0165252525',N'Nguyên Khuyến', 20.9748041182997, 105.789697766304)
  INSERT dbo.TramCuuHoa(  name, phone, address, lat, lng )
 VALUES  ( N'Trạm cứu hỏa song phương','0165252525',N'Song Phương', 21.0137687485385, 105.690879821777)
  INSERT dbo.TramCuuHoa(  name, phone, address, lat, lng )
 VALUES  ( N'Trạm cứu hỏa đại học lâm nghiệp','0165252525',N'Xuân Mai', 20.9116979444654, 105.57708978653)
  INSERT dbo.TramCuuHoa(  name, phone, address, lat, lng )
 VALUES  ( N'Trạm cứu hỏa hỏa lò','0165252525',N'Hai Bà Trưng',21.0254160958163, 105.846598148346)
  INSERT dbo.TramCuuHoa(  name, phone, address, lat, lng )
 VALUES  ( N'Trạm cứu hỏa rạp xiếc trung ương','0165252525',N'Trần Nhân Tông', 21.0169836274665, 105.842489004135)
  INSERT dbo.TramCuuHoa(  name, phone, address, lat, lng )
 VALUES  ( N'Trạm cứu hỏa bảo tàng Hồ Chí Minh','0165252525',N'Lê Hồng Phong', 21.0350898128118, 105.8325111866)
  INSERT dbo.TramCuuHoa(  name, phone, address, lat, lng )
 VALUES  ( N'Trạm cứu hỏa khu tập thể giáp bát','0165252525',N'Giải Phóng', 20.9824776488901, 105.840954780579)
  INSERT dbo.TramCuuHoa(  name, phone, address, lat, lng )
 VALUES  ( N'Trạm cứu hỏa RoyalCity','0165252525',N'Nuyễn Trãi', 21.001389315361, 105.817469358444)
  INSERT dbo.TramCuuHoa(  name, phone, address, lat, lng )
 VALUES  ( N'Trạm cứu hỏa làng trẻ hòa bình','0165252525',N'Lê Văn Thiêm', 20.9991657161371, 105.805013179779)
  INSERT dbo.TramCuuHoa(  name, phone, address, lat, lng )
 VALUES  ( N'Trạm cứu hỏa khách sạn Seoul','0165252525',N'Nguyễn Chánh', 21.0085857370728, 105.798296928406)
  INSERT dbo.TramCuuHoa(  name, phone, address, lat, lng )
 VALUES  (N'Trạm cứu hỏa trung tâm dạy nghề ','0165252525',N'Triều Khúc', 20.9860137516128, 105.786226987839)
  INSERT dbo.TramCuuHoa(  name, phone, address, lat, lng )
 VALUES  ( N'Trạm cứu hỏa nguyễn xiển','0165252525',N'Nguyễn Xiển Xa La', 20.9673405807054, 105.802679657936)
  INSERT dbo.TramCuuHoa(  name, phone, address, lat, lng )
 VALUES  ( N'Trạm cứu hỏa văn điển','0165252525',N'Phan Trọng Tuệ', 20.9458695627412, 105.832028388977)
  INSERT dbo.TramCuuHoa(  name, phone, address, lat, lng )
 VALUES  ( N'Trạm cứu hỏa bách khoa','0165252525',N'Đại Cồ Việt', 21.0079998201002, 105.84653377533)
  INSERT dbo.TramCuuHoa(  name, phone, address, lat, lng )
 VALUES  ( N'Trạm cứu hỏa gas station','0165252525',N'Tạ Quang Bửu', 21.0019051455823, 105.849301815033)
  INSERT dbo.TramCuuHoa(  name, phone, address, lat, lng )
 VALUES  ( N'Trạm cứu hỏa bạch mai','0165252525',N'Bạch Mai', 20.999586399612, 105.850897729397)
  INSERT dbo.TramCuuHoa(  name, phone, address, lat, lng )
 VALUES  ( N'Trạm cứu hỏa nhà tang lễ thanh nhàn','0165252525',N'Trần Khát Chân', 21.0053907088931, 105.858796834946)
  INSERT dbo.TramCuuHoa(  name, phone, address, lat, lng )
 VALUES  ( N'Trạm cứu hỏa lãng yên','0165252525',N'Nguyễn Khoái', 21.0366619828509, 105.786226987839)
  INSERT dbo.TramCuuHoa(  name, phone, address, lat, lng )
 VALUES  ( N'Trạm cứu hỏa bảo tàng phụ nữ','0165252525',N'Lý Thường Kiệt', 21.0227021348919, 105.852638483047)
  INSERT dbo.TramCuuHoa(  name, phone, address, lat, lng )
 VALUES  ( N'Trạm cứu hỏa lý thái tổ','0165252525',N'Lê Thạch', 21.027133576924, 105.854934453964)
  INSERT dbo.TramCuuHoa(  name, phone, address, lat, lng )
 VALUES  ( N'Trạm cứu hỏa gia lư','0165252525',N'Đinh Kiệt', 21.0330770103931, 105.851935744286)
  INSERT dbo.TramCuuHoa(  name, phone, address, lat, lng )
 VALUES  (N'Trạm cứu hỏa lãn ông','0165252525',N'Lãn Ông', 21.0352575451193, 105.849551260471)

 GO
 
 ------ trụ nước

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

GO

---- xe cứu hỏa
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
GO
-- thêm account
INSERT dbo.Account
        ( username, password, displayName )
VALUES  ( 'admin', -- username - varchar(100)
          'admin', -- password - varchar(100)
          N'ADMIN'  -- displayName - nvarchar(100)
          )

INSERT dbo.Account
        ( username, password, displayName )
VALUES  ( 'admin1', -- username - varchar(100)
          'admin1', -- password - varchar(100)
          N'ADMIN1'  -- displayName - nvarchar(100)
          )

go
--thủ tục
CREATE PROC ThongKeTungKhu(@date1 DATETIME,@date2 DATETIME, @khuvuc NVARCHAR(50))
AS
BEGIN
	SELECT address AS diachi ,COUNT(*) AS sovuchay, SUM(damages) AS thiethai  FROM dbo.DamChay 
	WHERE  date BETWEEN  @date1 AND @date2 AND county=@khuvuc
	GROUP BY address
END
GO 
CREATE PROC ThongKeTatCaKhu(@date1 DATETIME,@date2 DATETIME)
AS
BEGIN
	SELECT county AS diachi,COUNT(*) AS sovuchay , SUM(damages) AS thiethai FROM dbo.DamChay WHERE  date BETWEEN  @date1 AND @date2
GROUP BY county
END


EXECUTE dbo.ThongKeTungKhu @date1 = '2018-01-1', -- datetime
    @date2 = '2018-05-23 04:04:50', -- datetime
    @khuvuc = N'Nam Từ Liêm' -- nvarchar(50)
	

SELECT id,name,capacity,maxHeight,size,status FROM dbo.XeCuuHoa
WHERE idTramCuuHoa='1' AND status='free'

SELECT * FROM dbo.TramCuuHoa

GO
UPDATE dbo.XeCuuHoa
SET status='busy'
WHERE id=



=======
--EXECUTE dbo.ThongKeTungKhu @date1 = '2018-01-1',  @date2 = '2018-05-23',  @khuvuc = N'Nam Từ Liêm' -- nvarchar(50)


--EXEC	ThongKeTatCaKhu @date1 = '2018-01-1',  @date2 = '2018-05-23 04:04:50' -- datetime


--------query
/*
	SELECT * FROM  dbo.TramCuuHoa
SELECT * FROM dbo.XeCuuHoa
SELECT * FROM dbo.DamChay
SELECT * FROM dbo.Account
SELECT * FROM dbo.BaoChay 
SELECT * FROM dbo.TruNuoc 

*/


-- tạo bảng Notification (được thêm vào khi insert vào bảng báo cháy)

CREATE TABLE notice(
	id INT IDENTITY PRIMARY KEY,
	mess NVARCHAR(100) DEFAULT N'Có cháy'

);

--DROP TABLE dbo.Notification
go
CREATE TRIGGER addNotification ON dbo.BaoChay FOR INSERT
AS
BEGIN
DECLARE @address NVARCHAR(100)

	SELECT @address=(Inserted.address+', '+Inserted.county+', '+Inserted.city) FROM Inserted
	INSERT dbo.notice VALUES  ( @address )
END
GO


	
