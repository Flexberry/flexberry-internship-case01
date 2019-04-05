--Используем заранее созданную базу данных ThermoObjects
USE ThermoObjects 

--Таблица, содержащая сетевые районы
CREATE TABLE zones
(
	id int PRIMARY KEY IDENTITY NOT NULL,
	Name nvarchar(50) NOT NULL,
)

--Таблица, содержащая здания, привязанные к сетевым районам
CREATE TABLE buildings
(
	id int PRIMARY KEY IDENTITY NOT NULL,
	Adress nvarchar(100) NOT NULL,
	Zone_id int NOT NULL,
)

--Таблица, содержаща потребителей
CREATE TABLE clients
(
	id int PRIMARY KEY IDENTITY NOT NULL,
	Name nvarchar(50) NOT NULL,
)

--Таблица, содержащая объекты термопотребления, которые находятся в здании
--Каждый объект теплопотребления привязан к потребителю
CREATE TABLE thermo_objects
(
	id int PRIMARY KEY IDENTITY NOT NULL,
	Name nvarchar(50) NOT NULL,
	Building_id int NOT NULL,
	Client_id int NOT NULL,
)

--Типы изоляции
CREATE TABLE types_of_isolation
(
	id int PRIMARY KEY IDENTITY NOT NULL,
	Name nvarchar(50) NOT NULL,
)

--Типы прокладки участка сети
CREATE TABLE types_of_installation
(
	id int PRIMARY KEY IDENTITY NOT NULL,
	Name nvarchar(50) NOT NULL,
)

--Таблица, содержащая участки сети
CREATE TABLE networks
(
	id int PRIMARY KEY IDENTITY NOT NULL,
	TypeOfIsolation_id int NOT NULL,
	TypeOfInstallation_id int NOT NULL,
	Thermo_object_id int NOT NULL,
)

ALTER TABLE buildings ADD CONSTRAINT 
FK_buildings_zones FOREIGN KEY (Zone_id) REFERENCES zones (id) 
ON DELETE CASCADE    
ON UPDATE CASCADE   

ALTER TABLE thermo_objects ADD CONSTRAINT 
FK_thermo_objects_buildings FOREIGN KEY (Building_id) REFERENCES buildings (id) 
ON DELETE CASCADE    
ON UPDATE CASCADE   

ALTER TABLE thermo_objects ADD CONSTRAINT 
FK_thermo_objects_clients FOREIGN KEY (Client_id) REFERENCES clients (id) 
ON DELETE CASCADE    
ON UPDATE CASCADE

ALTER TABLE networks ADD CONSTRAINT 
FK_networks_types_of_isolation FOREIGN KEY (TypeOfIsolation_id) REFERENCES types_of_isolation (id) 
ON DELETE CASCADE    
ON UPDATE CASCADE  

ALTER TABLE networks ADD CONSTRAINT 
FK_networks_types_of_installation FOREIGN KEY (TypeOfInstallation_id) REFERENCES types_of_installation (id) 
ON DELETE CASCADE    
ON UPDATE CASCADE 

ALTER TABLE networks ADD CONSTRAINT 
FK_networks_thermo_objects FOREIGN KEY (Thermo_object_id) REFERENCES thermo_objects (id) 
ON DELETE CASCADE    
ON UPDATE CASCADE 

INSERT INTO zones VALUES ('Индустриальный'), ('Мотовилихинский'), ('Орджоникидзевский'), ('Дзержинский')

INSERT INTO buildings VALUES 
('ул. Свиязева,  д.28',1), ('ул. Чердынская, д.24',1), ('ул. Рязанская, д.88',1), 
('ул. Пушкарская, д.49',2), ('ул. Макаренко, д.8',2), ('ул. Юрша, д.30',2), 
('ул. Ольховская, д.15',3), ('пер. Пограничный, д.44',3), ('ул. Наумушина, д.60',3),
('ул. Куфонина, д.12',4), ('ул. Строителей, д.10',4), ('пр. Парковый, д.1',4)

INSERT INTO clients VALUES
('ГКП №4'), ('ТехПром'), ('ТеплоПрод'), ('УралСиб'), ('АгроТехн'), ('УрС'), ('ПНБ')

INSERT INTO thermo_objects VALUES
('ОТдляГКП№4',10,1),('ОТдляТехПром',1,2), ('ОТдляТеплоПрод',2,3),('ОТдляУралСиб',5,4), ('ОТдляАгроТехн',7,5), ('ОТдляУрС',6,6), ('ОТдляПНБ',11,7)

INSERT INTO types_of_isolation VALUES
('Пенополиуретан'), ('Пенополимер-минерал'), ('Армапенобетон')

INSERT INTO types_of_installation VALUES
('Внешний'), ('Внутренний')

INSERT INTO networks VALUES
(1,1,1), (1,2,1), (2,1,1), (3,1,1), (2,1,1),
(1,1,2), (1,2,2), (2,2,2), (3,1,2), (3,1,2), (3,2,2),
(1,1,3), (1,2,3), (2,1,3), (2,2,3), (3,1,3), (2,1,3), (3,2,3),
(1,1,4), (1,1,4), (1,1,4), (1,2,4), (2,1,4), (2,2,4), (3,1,4), (3,2,4),
(1,1,5), (1,1,5), (2,1,5), (3,2,5), (2,2,5), (2,2,5), (1,2,5),
(1,1,6), (1,1,6), (2,1,6), (3,2,6), (3,2,6), (1,2,6),
(1,2,7), (1,2,7), (2,1,7), (3,2,7), (2,1,7)