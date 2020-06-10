select * from Rutinas
select * from Clientes
select * from Ejercicios
select * from Descansos;
select * from GruposMusculares;


delete from Ejercicios;

           
DBCC CHECKIDENT ('Ejercicios', RESEED, 0)