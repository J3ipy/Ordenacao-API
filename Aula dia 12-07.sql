--- DDL ---
use bdTarefas;

go
Create table Pessoa(

	PESID int not null identity(1,1) primary key,
	NOME varchar(100) not null

)
go
Create table Tarefa(

	TARID int not null identity(1,1) primary key,
	TARDESCRICAO varchar(200) not null,
	TARDATA datetime not null default getdate(),
	TARFEITO bit not null default 0,
	PESID int not null,
	FOREIGN KEY (PESID) REFERENCES Pessoa(PESID)

)

--- DML ---

Select * from Pessoa
Select * from Tarefa

Insert Pessoa values ('JP')
Insert Pessoa values ('Regys')
Insert Pessoa values ('Adson')
Insert Pessoa values ('Kauan')
Insert Pessoa values ('Rose')

-- delete from pessoa
-- where PESID in (3)

Insert Tarefa values ('Dormir','2022-06-01', 1, 1)
Insert Tarefa values ('Acordar','2022-19-02', 1, 2)
Insert Tarefa values ('Comer','2022-02-04', 0, 7)
Insert Tarefa values ('Programar','2022-06-12', 1, 8)
Insert Tarefa values ('Viajar','2022-08-10', 1, 9)

select t.*, p.NOME from Tarefa t
join pessoa p on t.PESID=p.PESID

select p.nome as 'Nome', t.TARDESCRICAO 'Tarefa',
t.TARDATA 'Data', t.TARFEITO 'Feito'
from Tarefa t join Pessoa p on t.PESID=p.PESID

select * from Tarefa
where TARID=2 or TARID=4

select * from tarefa
where TARID in (2,4)

delete from Tarefa