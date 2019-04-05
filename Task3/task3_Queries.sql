USE ThermoObjects

/* 1. Вывести список сетевых районов, 
отсортированный по количеству объектов теплопотребления в них.*/
select zones.Name as 'Название района', COUNT(*) as 'Количество объектов ТП' from zones, buildings, thermo_objects 
WHERE buildings.Zone_id = zones.id AND thermo_objects.Building_id = buildings.id 
GROUP BY zones.Name ORDER BY COUNT(*) DESC;

/* 2. Вывести топ N объектов теплопотребления с наибольшим количеством участков сети. */
select top 5 thermo_objects.Name as 'Название объекта ТП', COUNT(*) as 'Количество участков сети' from thermo_objects, networks
WHERE networks.Thermo_object_id = thermo_objects.id
GROUP BY thermo_objects.Name ORDER BY  COUNT(*) DESC;

/* 3. Вывести потребителей (контрагентов), у объектов которых больше всего внутренних участков сети. */
select clients.Name as 'Потребитель', COUNT(*) as 'Количество внутренних участков сети' from clients, networks, thermo_objects, types_of_installation
WHERE networks.Thermo_object_id = thermo_objects.id AND thermo_objects.Client_id = clients.id AND networks.TypeOfInstallation_id = types_of_installation.id AND
types_of_installation.Name = 'Внутренний' GROUP BY clients.Name ORDER BY COUNT(*) DESC;

/* 4. Вывести рейтинг типов изоляций участков сети по сетевым районам */
select zones.Name as 'Сетевой район', types_of_isolation.Name as 'Тип изоляции', COUNT(*) as 'Количество' from zones, networks, thermo_objects, buildings, types_of_isolation
WHERE networks.Thermo_object_id = thermo_objects.id AND thermo_objects.Building_id = buildings.id AND
networks.TypeOfIsolation_id = types_of_isolation.id AND buildings.Zone_id=zones.id GROUP BY zones.Name, types_of_isolation.Name

/* 5. Вывести информацию о 5 зданиях, в которых больше всего объектов теплопотребления с наружными участками сети. */
select buildings.Adress as 'Адрес', zones.Name as 'Сетевой район', COUNT(*) as 'Количество наружных участков сети' 
from buildings, networks, thermo_objects, types_of_installation, zones
WHERE buildings.Zone_id = zones.id AND Thermo_object_id = thermo_objects.id AND thermo_objects.Building_id = buildings.id 
AND networks.TypeOfInstallation_id=types_of_installation.id AND types_of_installation.Name='Внутренний' GROUP BY buildings.Adress, zones.Name
ORDER BY COUNT(*) DESC

/*
BACKUP DATABASE ThermoObjects
TO DISK='D:\DB\task3_DB_BACKUP.bak';
*/