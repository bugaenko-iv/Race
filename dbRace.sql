create database dbRace;
use dbRace;
drop database dbRace;

create table Пользователи(
пользователь_id int primary key auto_increment,
никнейм varchar(255),
пароль varchar(100)
);

create table Администратор(
администратор_id int primary key,
никнейм varchar(255),
пароль varchar(100)
);

insert into Администратор values
(1, "Admin", 444741032);

select * from Пользователи;
select * from Администратор;