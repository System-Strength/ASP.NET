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

create table tbl_cliente(
	id_cli int primary key auto_increment,
    cpf_cli varchar(14) not null,
    nm_cli varchar(50) not null,
    end_cli varchar(50) not null,
    tel_cli varchar(15) not null
);
alter table tbl_cliente add comple_cli varchar(100);


create table tbl_produto(
	id_prod int primary key auto_increment,
    nm_prod varchar(100) not null,
    qntd_prod int not null,
    cat_prod varchar(50) not null,
    data_prod date
);
alter table tbl_produto add preco_prod decimal(6, 2) not null;

select * from tbl_cliente;