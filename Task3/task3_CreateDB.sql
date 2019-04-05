--���������� ������� ��������� ���� ������ ThermoObjects
USE ThermoObjects 

--�������, ���������� ������� ������
CREATE TABLE zones
(
	id int PRIMARY KEY IDENTITY NOT NULL,
	Name nvarchar(50) NOT NULL,
)

--�������, ���������� ������, ����������� � ������� �������
CREATE TABLE buildings
(
	id int PRIMARY KEY IDENTITY NOT NULL,
	Adress nvarchar(100) NOT NULL,
	Zone_id int NOT NULL,
)

--�������, ��������� ������������
CREATE TABLE clients
(
	id int PRIMARY KEY IDENTITY NOT NULL,
	Name nvarchar(50) NOT NULL,
)

--�������, ���������� ������� ����������������, ������� ��������� � ������
--������ ������ ���������������� �������� � �����������
CREATE TABLE thermo_objects
(
	id int PRIMARY KEY IDENTITY NOT NULL,
	Name nvarchar(50) NOT NULL,
	Building_id int NOT NULL,
	Client_id int NOT NULL,
)

--���� ��������
CREATE TABLE types_of_isolation
(
	id int PRIMARY KEY IDENTITY NOT NULL,
	Name nvarchar(50) NOT NULL,
)

--���� ��������� ������� ����
CREATE TABLE types_of_installation
(
	id int PRIMARY KEY IDENTITY NOT NULL,
	Name nvarchar(50) NOT NULL,
)

--�������, ���������� ������� ����
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

INSERT INTO zones VALUES ('��������������'), ('���������������'), ('�����������������'), ('�����������')

INSERT INTO buildings VALUES 
('��. ��������,  �.28',1), ('��. ����������, �.24',1), ('��. ���������, �.88',1), 
('��. ����������, �.49',2), ('��. ���������, �.8',2), ('��. ����, �.30',2), 
('��. ����������, �.15',3), ('���. �����������, �.44',3), ('��. ���������, �.60',3),
('��. ��������, �.12',4), ('��. ����������, �.10',4), ('��. ��������, �.1',4)

INSERT INTO clients VALUES
('��� �4'), ('�������'), ('���������'), ('�������'), ('��������'), ('���'), ('���')

INSERT INTO thermo_objects VALUES
('�������Ϲ4',10,1),('������������',1,2), ('��������������',2,3),('������������',5,4), ('�������������',7,5), ('��������',6,6), ('��������',11,7)

INSERT INTO types_of_isolation VALUES
('��������������'), ('�����������-�������'), ('�������������')

INSERT INTO types_of_installation VALUES
('�������'), ('����������')

INSERT INTO networks VALUES
(1,1,1), (1,2,1), (2,1,1), (3,1,1), (2,1,1),
(1,1,2), (1,2,2), (2,2,2), (3,1,2), (3,1,2), (3,2,2),
(1,1,3), (1,2,3), (2,1,3), (2,2,3), (3,1,3), (2,1,3), (3,2,3),
(1,1,4), (1,1,4), (1,1,4), (1,2,4), (2,1,4), (2,2,4), (3,1,4), (3,2,4),
(1,1,5), (1,1,5), (2,1,5), (3,2,5), (2,2,5), (2,2,5), (1,2,5),
(1,1,6), (1,1,6), (2,1,6), (3,2,6), (3,2,6), (1,2,6),
(1,2,7), (1,2,7), (2,1,7), (3,2,7), (2,1,7)