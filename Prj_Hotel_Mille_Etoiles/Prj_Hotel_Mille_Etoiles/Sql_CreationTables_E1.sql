DROP database IF EXISTS prj_hotel;
CREATE database prj_hotel;
USE prj_hotel;

/***********************************************************
	Table "Reservation"
***********************************************************/

CREATE TABLE hl_reservation
(
    idReser           INT  NOT NULL,/*PK*/
    dateReser         DATE NULL,
    dateDebut         DATE NULL,
    dateFin           DATE NULL,
    
    idCli             INT  NULL, /*FK*/
	
    PRIMARY KEY (idReser)
)
ENGINE=INNODB;

/***********************************************************
	Table "De"
***********************************************************/

CREATE TABLE hl_de
(
    attribuee         TINYINT    NULL,
    idReser           INT        NULL,/*FK*/
    noCham            VARCHAR(3) NULL /*FK*/
)
ENGINE=INNODB;

/***********************************************************
	Table "Client"
***********************************************************/

CREATE TABLE hl_client
(
    /*idCli             INT IDENTITY(1,1) NOT NULL,/*PK*/
    idCli INT not null auto_increment,
    nom               VARCHAR(25)       NULL,
    adresse           VARCHAR(25)       NULL,
    telephone         VARCHAR(10)       NULL,
    noCarte           VARCHAR(16)       NULL,
    typeCarte         VARCHAR(15)       NULL,
    datExp            DATE              NULL, 
    soldeDu           DECIMAL(12,2)     NULL,
    
    PRIMARY KEY (idCli)
)
ENGINE=INNODB;

ALTER TABLE hl_reservation ADD CONSTRAINT pkIdCli FOREIGN KEY (idCli) REFERENCES hl_client(idCli);