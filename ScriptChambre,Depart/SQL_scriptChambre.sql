DROP DATABASE IF EXISTS test;
CREATE DATABASE test;
USE test;


/*************************************
			Table Commodite
*************************************/

CREATE TABLE Commodite (
	CodCom		varchar(2)	not null,
	DescCom		varchar(25) null,
	PRIMARY KEY (CodCom)
)
engine = innodb;

/*************************************
			Table Localisation
*************************************/

CREATE TABLE Localisation (
	CodLoc		varchar(2)	not null,
	DescLoc		varchar(25) null,
	PRIMARY KEY (CodLoc)
)
engine = innodb;

/*************************************
			Table TypeChambre
*************************************/

CREATE TABLE Typechambre (
	CodTypCham	varchar(2)	not null,
	DescTyp		varchar(25) null,
	NbDispo		int			null,
	PRIMARY KEY (CodTypCham)
)
engine = innodb;

/*************************************
			Table Chambre
*************************************/

CREATE TABLE Chambre (
	NoChamb		varchar(4)	not null,
	Etage		varchar(2)	null,
	Prix		decimal(5,2)null,
	Etat		tinyint		null,
	Memo		varchar(100)null,
	CodLoc		varchar(2)	not null,
	CodTypCham	varchar(2)	not null,
	PRIMARY KEY (NoChamb),
	FOREIGN KEY (CodLoc) REFERENCES Localisation(CodLoc),
	FOREIGN KEY (CodTypCham) REFERENCES Typechambre(CodTypCham)
)
engine = innodb;

/*************************************
			Table Ayant
*************************************/

CREATE TABLE Ayant (
	NoChamb		varchar(4)	not null,
	CodCom		varchar(2)	not null,
	FOREIGN KEY (NoChamb) REFERENCES Chambre (NoChamb),
	FOREIGN KEY (CodCom) REFERENCES Commodite (CodCom)
)
engine = innodb;

source /home/etudiant/ABC/scriptInsertionChambre.sql;
source /home/etudiant/ABC/scriptTest.sql;
