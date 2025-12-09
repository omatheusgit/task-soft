drop database if exists tasksoftbd;
create database tasksoftbd;

use tasksoftbd;

create table if not exists setorEmpresa (
codSet int primary key,
nomeSet varchar(25) not null unique
);
#INSERÇÃO MANUAL DOS SETORES NO BANCO DE DADOS
insert into tasksoftbd.setorempresa(codSet,nomeSet) values(00,'Gerencia');
insert into tasksoftbd.setorempresa(codSet,nomeSet) values(1,'Contabilidade');
insert into tasksoftbd.setorempresa(codSet,nomeSet) values(2,'Recursos Humanos');
insert into tasksoftbd.setorempresa(codSet,nomeSet) values(3,'Fiscal');
insert into tasksoftbd.setorempresa(codSet,nomeSet) values(4,'Faturamento');
insert into tasksoftbd.setorempresa(codSet,nomeSet) values(5,'Produção e Estoque');
insert into tasksoftbd.setorempresa(codSet,nomeSet) values(6,'Financeiro');

create table if not exists pessUsu(
codUsu int auto_increment primary key,
codSet int,
nomePess varchar(40) not null,
endPess varchar(60) not null,
emailPess varchar(40) not null,
telPess varchar(14) not null,
cpfPess varchar(11) not null unique,
idUsu varchar(15) not null unique,
senhaUsu varchar(10) not null,
tipoUsu int(1) not null,
constraint fk_pessUsu_setorEmpresa foreign key (codSet) references setorEmpresa(codSet)
);
#INSERÇÃO AUTOMATICA DO ADMINISTRADOR PADRÃO
insert into tasksoftbd.pessUsu(nomePess,endPess,emailPess,telPess,cpfPess,idUsu,senhaUsu,tipoUsu,codSet) values ('Administrador Padrão','Administrador Padrão','admin@gmail.com',0,0,'admin','admin',1,00);
#INSERÇÃO AUTOMATICA DO GERENTE PADRÃO
insert into tasksoftbd.pessUsu(nomePess,endPess,emailPess,telPess,cpfPess,idUsu,senhaUsu,tipoUsu,codSet) values ('Gerente Padrão','Gerente Padrão','ger@hotmail.com',1,1,'ger_01','ger',2,1);
#INSERÇÃO AUTOMATICA DE FUNCIONÁRIO DO GERENTE PADRÃO
insert into tasksoftbd.pessUsu(nomePess,endPess,emailPess,telPess,cpfPess,idUsu,senhaUsu,tipoUsu,codSet) values ('Funcionário Padrão','Funcionário Padrão','fun@hotmail.com',2,2,'fun_01','fun',3,1);

create table if not exists metas(
codMeta int auto_increment primary key,
codSet int,
codUsu int,
prazoMeta varchar(60) not null,
justificativaMeta varchar(100),
descMeta varchar(400) not null,
entregaMeta varchar(80),
constraint fk_metas_setorEmpresa foreign key (codSet) references setorEmpresa(codSet),
constraint fk_metas_pessUsu foreign key (codUsu) references pessUsu(codUsu)
);

/*create table if not exists relatorio (
codRel int auto_increment primary key,
codMeta int, 
constraint fk_relatorio_meta foreign key (codMeta) references metas(codMeta)
);*/

create table if not exists desenvolvimento (
	codDes int auto_increment primary key,
    codSet int,
	gastoDes double(13,2) not null,
    dataDes varchar(15) not null, 
	constraint fk_desenvolvimento_setorEmpresa foreign key (codSet) references setorEmpresa(codSet)
);

create table if not exists patrimonio (
	codPatri int primary key,
    codSet int,
    descPatri varchar(50) not null,
    dataPatri varchar(20) not null,
    qtdePatri bigint(11) not null,
    valorPatri double(10,2) not null,
    constraint fk_patrimonio_setorEmpresa foreign key (codSet) references setorEmpresa(codSet)
);

insert into patrimonio (codPatri, codSet, descPatri, dataPatri, qtdePatri, valorPatri) values (1,2,'Notebook','09/06/2017',3,2000.00);

# FUNÇÕES E PROCEDURES

-- Função de Verficar Login

USE `tasksoftbd`;
DROP function IF EXISTS `fVerificaLogin`;

DELIMITER $$
USE `tasksoftbd`$$
CREATE DEFINER=`alunos`@`localhost` FUNCTION `fVerificaLogin`(fidUsu varchar(15), fsenhaUsu varchar(10)) RETURNS varchar(100) CHARSET utf8
BEGIN

if((select codUsu from pessUsu where idUsu = fidUsu and senhaUsu = fsenhaUsu) is not null) then
	select tipoUsu from pessUsu where idUsu = fidUsu into @tipoUsu;
    if(@tipoUsu = 1) then
		RETURN 'Administrador logado com sucesso!';
	else if (@tipoUsu = 2) then
		RETURN 'Gerente logado com sucesso!';
	else if (@tipoUsu = 3) then
		return 'Funcionário logado com sucesso';
	else 
		return 'Login e(ou) senha incorretos';
	end if;
    end if;
    end if;
    else return 'Login e(ou) senha ivalido(s)!';
    end if;

END$$

DELIMITER ;


-- Função de Retornar Nome

USE `tasksoftbd`;
DROP function IF EXISTS `retornaNome`;

DELIMITER $$
USE `tasksoftbd`$$
CREATE DEFINER=`alunos`@`localhost` FUNCTION `retornaNome`(fusuario varchar(15)) RETURNS varchar(60) CHARSET utf8
BEGIN
select nomePess from tasksoftbd.pessUsu where idUsu = fusuario into @nome;
RETURN @nome;
END$$

DELIMITER ;


-- Função de Excluir Gastos

USE `tasksoftbd`;
DROP function IF EXISTS `fExcluirGastos`;

DELIMITER $$
USE `tasksoftbd`$$
CREATE FUNCTION `fExcluirGastos` (fcodigo int)
RETURNS varchar(50) CHARSET utf8
BEGIN
	delete from desenvolvimento where codDes = fcodigo;
RETURN "Exclusão realizada com sucesso!";
END$$

DELIMITER ;


-- Função de Excluir Usuário

USE `tasksoftbd`;
DROP function IF EXISTS `fExcluirUsuario`;

DELIMITER $$
USE `tasksoftbd`$$
CREATE FUNCTION `fExcluirUsuario` (fcodUsu int(5))
RETURNS varchar(100) CHARSET utf8
BEGIN
	delete from pessUsu where codUsu = fcodUsu;
RETURN "Exclusão realizada com sucesso!";
END$$

DELIMITER ;


-- Função excluir Metas

USE `tasksoftbd`;
DROP function IF EXISTS `fExcluirMeta`;

DELIMITER $$
USE `tasksoftbd`$$
CREATE FUNCTION `fExcluirMeta` (fcodMeta int(11)) returns varchar(100)
BEGIN
delete from metas where codMeta = fcodMeta;
RETURN "Exclusão realizada com sucesso";
END$$

DELIMITER ;


-- Stored Procedure de Alterar Metas

USE `tasksoftbd`;
DROP procedure IF EXISTS `spAlterarMetas`;

DELIMITER $$
USE `tasksoftbd`$$
CREATE PROCEDURE `spAlterarMetas` (in pCodMeta int, in pNomeSetor int, in pCodfunc int, in pPrazoMeta varchar(60), in pDescricao varchar(400), out retorno varchar(50))
BEGIN
	update tasksoftbd.metas set codSet = pNomeSetor, codUsu = pCodfunc , prazoMeta = pPrazoMeta, descMeta = pDescricao where codMeta = pCodMeta;
    select 'Alterado com sucesso!!!' into retorno;
END$$

DELIMITER ;


-- Stored Procedure de Inserir Metas

USE `tasksoftbd`;
DROP procedure IF EXISTS `spInserirMetas`;

DELIMITER $$
USE `tasksoftbd`$$
CREATE DEFINER=`alunos`@`localhost` PROCEDURE `spInserirMetas`(in pNomeSetor int, in pCodfunc int, in pPrazoMeta varchar(60), in pDescricao varchar(400), out retorno varchar(50))
BEGIN
	insert into tasksoftbd.metas(codSet, codUsu, prazoMeta, descMeta)  values (pNomeSetor, pCodfunc, pPrazoMeta, pDescricao) ;
        select 'Inserido com sucesso' into retorno;   
END$$

DELIMITER ;


-- Stored Procedure de Inserir Gastos

USE `tasksoftbd`;
DROP procedure IF EXISTS `spInserirGastos`;

DELIMITER $$
USE `tasksoftbd`$$
CREATE DEFINER=`alunos`@`localhost` PROCEDURE `spInserirGastos`(in pCodigoSetor int, in pGasto double(13,2), in pData varchar(15), out retorno varchar(50))
BEGIN
	insert into tasksoftbd.desenvolvimento(codSet, gastoDes, dataDes)  values (pCodigoSetor, pGasto, pData);
        select 'Gasto inserido com sucesso' into retorno;   
END$$

DELIMITER ;


-- Stored Procedure de Alterar usuário

USE `tasksoftbd`;
DROP procedure IF EXISTS `spAlterarUsuario`;

DELIMITER $$
USE `tasksoftbd`$$
CREATE DEFINER=`alunos`@`localhost` PROCEDURE `spAlterarUsuario`(in pcodUsu int(1), in pcodSet int(1), in pnomePess varchar(40), in pendPess varchar(60), in pemailPess varchar(40), in ptelPess varchar(15), in pcpfPess varchar(13), in pidUsu varchar(15), in psenhaUsu varchar (10), in ptipoUsu int(1), out retorno varchar(50))
BEGIN
	UPDATE tasksoftbd.pessusu SET codSet = pcodSet, nomePess = pnomePess, endPess = pendPess, emailPess = pemailPess, telPess = ptelPess, cpfPess = pcpfPess, idUsu =pidUsu, senhaUsu = psenhaUsu, tipoUsu = ptipoUsu WHERE codUsu = pcodUsu;
	select 'Usuário alterado com sucesso' into retorno;
END$$

DELIMITER ;


-- Sotored Proceure de Cadastrar Usuário

USE `tasksoftbd`;
DROP procedure IF EXISTS `spCadastrarUsuario`;

DELIMITER $$
USE `tasksoftbd`$$
CREATE DEFINER=`alunos`@`localhost` PROCEDURE `spCadastrarUsuario`( in pcodSet int(1), in pnomePess varchar(40), in pendPess varchar(60), in pemailPess varchar(40), in ptelPess varchar(15), in pcpfPess varchar(11), in pidUsu varchar(15), in psenhaUsu varchar (10), in ptipoUsu int(1), out aux varchar(100))
BEGIN
if ((Select codUsu from pessUsu Where cpfPess = pcpfPess or idUsu = pidUsu or nomePess = pnomePess)is null) then
	
    insert into TaskSoftBD.pessUsu(nomePess,endPess,emailPess,telPess,cpfPess,idUsu,senhaUsu,tipoUsu,codSet) values (pnomePess,pendPess,pemailPess,ptelPess,pcpfPess,pidUsu,psenhaUsu,ptipoUsu,pcodSet);
	select pidUsu into aux;    
else
	select 'Usuário já existente!' into aux;
    
end if;
END$$

DELIMITER ;


-- Stored Procedure de Alterar Gastos

USE `tasksoftbd`;
DROP procedure IF EXISTS `spAlterarGastos`;

DELIMITER $$
USE `tasksoftbd`$$
CREATE DEFINER=`alunos`@`localhost` PROCEDURE `spAlterarGastos`(in pcodigo int(1), in pdata varchar(15), in pvalor double(13,2), out retorno varchar(50))
BEGIN
	UPDATE tasksoftbd.desenvolvimento SET codDes = pcodigo, gastoDes = pvalor, dataDes = pdata WHERE codDes = pcodigo;
	select 'Gasto alterado com sucesso' into retorno;
END$$

DELIMITER ;


-- Stored Procedure CheckarMetas

USE `tasksoftbd`;
DROP procedure IF EXISTS `spCheckarMetas`;

DELIMITER $$
USE `tasksoftbd`$$
CREATE DEFINER=`alunos`@`localhost` PROCEDURE `spCheckarMetas`(in pCodMeta int, in pDescricao varchar(400), in pPrazo varchar(60), in pEntrega varchar(80), in pJustificativa varchar(100), out retorno varchar(50))
BEGIN
	update tasksoftbd.metas set descMeta = pDescricao, entregaMeta = pEntrega , justificativaMeta = pJustificativa where codMeta = pCodMeta;
    select 'Alterado com sucesso!!!' into retorno;
END$$

DELIMITER ;




