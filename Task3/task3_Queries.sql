USE ThermoObjects

/* 1. ������� ������ ������� �������, 
��������������� �� ���������� �������� ���������������� � ���.*/
select zones.Name as '�������� ������', COUNT(*) as '���������� �������� ��' from zones, buildings, thermo_objects 
WHERE buildings.Zone_id = zones.id AND thermo_objects.Building_id = buildings.id 
GROUP BY zones.Name ORDER BY COUNT(*) DESC;

/* 2. ������� ��� N �������� ���������������� � ���������� ����������� �������� ����. */
select top 5 thermo_objects.Name as '�������� ������� ��', COUNT(*) as '���������� �������� ����' from thermo_objects, networks
WHERE networks.Thermo_object_id = thermo_objects.id
GROUP BY thermo_objects.Name ORDER BY  COUNT(*) DESC;

/* 3. ������� ������������ (������������), � �������� ������� ������ ����� ���������� �������� ����. */
select clients.Name as '�����������', COUNT(*) as '���������� ���������� �������� ����' from clients, networks, thermo_objects, types_of_installation
WHERE networks.Thermo_object_id = thermo_objects.id AND thermo_objects.Client_id = clients.id AND networks.TypeOfInstallation_id = types_of_installation.id AND
types_of_installation.Name = '����������' GROUP BY clients.Name ORDER BY COUNT(*) DESC;

/* 4. ������� ������� ����� �������� �������� ���� �� ������� ������� */
select zones.Name as '������� �����', types_of_isolation.Name as '��� ��������', COUNT(*) as '����������' from zones, networks, thermo_objects, buildings, types_of_isolation
WHERE networks.Thermo_object_id = thermo_objects.id AND thermo_objects.Building_id = buildings.id AND
networks.TypeOfIsolation_id = types_of_isolation.id AND buildings.Zone_id=zones.id GROUP BY zones.Name, types_of_isolation.Name

/* 5. ������� ���������� � 5 �������, � ������� ������ ����� �������� ���������������� � ��������� ��������� ����. */
select buildings.Adress as '�����', zones.Name as '������� �����', COUNT(*) as '���������� �������� �������� ����' 
from buildings, networks, thermo_objects, types_of_installation, zones
WHERE buildings.Zone_id = zones.id AND Thermo_object_id = thermo_objects.id AND thermo_objects.Building_id = buildings.id 
AND networks.TypeOfInstallation_id=types_of_installation.id AND types_of_installation.Name='����������' GROUP BY buildings.Adress, zones.Name
ORDER BY COUNT(*) DESC

/*
BACKUP DATABASE ThermoObjects
TO DISK='D:\DB\task3_DB_BACKUP.bak';
*/