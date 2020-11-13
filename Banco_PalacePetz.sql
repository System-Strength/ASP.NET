create database db_PalacePetz;

use db_PalacePetz;

create table tbl_func(
	id_func int primary key auto_increment,
    cpf_func varchar(14) not null,
    nm_func varchar(50) not null,
    cg_func varchar(50) not null,
    end_func varchar(50) not null,
    tel_func varchar(15) not null
);