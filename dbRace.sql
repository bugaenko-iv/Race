create database dbRace;
use dbRace;
drop database dbRace;

create table Пользователи(
пользователь_id int primary key auto_increment,
никнейм varchar(255),
пароль varchar(100)
);

select * from Пользователи;