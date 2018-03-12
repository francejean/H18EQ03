
drop table if exists de
drop table if exists depart;
drop table if exists trx;
drop table if exists ayant;
drop table if exists commodite;
drop table if exists arrive;
drop table if exists chambre;
drop table if exists typechambre;
drop table if exists typetrx;
drop table if exists localisation;
drop table if exists reservation;
drop table if exists client;

/***********************************************************
          Table "Reservation"
***********************************************************/

CREATE TABLE reservation
(
    idReser   INT Identity(1,1) NOT NULL,/*PK*/
    dateReser DATE NULL,
    dateDebut DATE NULL,
    dateFin   DATE NULL,
    idCli     INT  NULL, /*FK*/
	
    PRIMARY KEY (idReser)
)

/***********************************************************
          Table "De"
***********************************************************/

CREATE TABLE de
(
    attribuee TINYINT    NULL,
    idReser   INT        NULL,/*FK*/
    noCham    VARCHAR(3) NULL /*FK*/
)

/***********************************************************
          Table "Commodite"
***********************************************************/

CREATE TABLE commodite (
	codCom  VARCHAR(2)  NOT NULL,/*PK*/
	descCom	VARCHAR(25) NULL,

	PRIMARY KEY (codCom)
)

/***********************************************************
          Table "Localisation"
***********************************************************/

CREATE TABLE localisation (
	codLoc  VARCHAR(2)  NOT NULL,/*PK*/
	descLoc VARCHAR(25) NULL,

	PRIMARY KEY (codLoc)
)

/***********************************************************
          Table "TypeChambre"
***********************************************************/

CREATE TABLE typechambre (
	codTypCham VARCHAR(2)  NOT NULL,/*PK*/
	descTyp    VARCHAR(25) NULL,
	nbDispo    INT         NULL,

	PRIMARY KEY (codTypCham)
)

/***********************************************************
          Table "Chambre"
***********************************************************/

CREATE TABLE chambre (
	noChamb    VARCHAR(3)   NOT NULL,/*PK*/
	etage      VARCHAR(2)   NULL,
	prix       DECIMAL(5,2) NULL,
	etat       TINYINT      NULL,
	memo       VARCHAR(100) NULL,
	codLoc     VARCHAR(2)   NULL,/*FK*/
	codTypCham VARCHAR(2)   NULL,/*FK*/

	PRIMARY KEY (noChamb)
)

/***********************************************************
          Table "Ayant"
***********************************************************/

CREATE TABLE ayant (
	noChamb VARCHAR(3) NULL,/*FK*/
	codCom  VARCHAR(2) NULL /*FK*/
)

/***********************************************************
	Table "Trx"
***********************************************************/

CREATE TABLE trx
(
    idTrx      INT IDENTITY(1,1) NOT NULL ,/*PK*/
    dateTrx    DATE              NULL,
    montantTrx DECIMAL(10,2)     NULL,
    reportee   TINYINT           NULL,
	codTypTrx  VARCHAR(2)        NULL,/*FK*/
	idReser    INT               NULL,/*FK*/
	noCham     VARCHAR(3)        NULL,/*FK*/
	idCli      INT               NULL,/*FK*/
	/*idArrive    int			      NULL,*/
	
    PRIMARY KEY (IdTrx)
)

/***********************************************************
	Table "TypeTrx"
***********************************************************/

CREATE TABLE typetrx
(
    CodTypTrx VARCHAR(2)  NOT NULL,/*PK*/
    DescTrx   VARCHAR(25) NULL,
    Nature    VARCHAR(2)  NULL,

	PRIMARY KEY (CodTypTrx)
)

/***********************************************************
	Table "Client"
***********************************************************/

CREATE TABLE client
(
  idCli     INT IDENTITY (1,1) NOT NULL,/*PK*/
  nom       VARCHAR(25)        NULL,
  adresse   VARCHAR(25)        NULL,
  telephone VARCHAR(10)        NULL,
  noCarte   VARCHAR(16)        NULL,
  typeCarte VARCHAR(15)        NULL,
  datExp    DATE               NULL,
  soldeDu   DECIMAL(12,2)      NULL,
  
  PRIMARY KEY (IdCli)
)

/***********************************************************
          Table "Arrive"
***********************************************************/

CREATE TABLE arrive
(
  idArrive           INT IDENTITY(1,1) NOT NULL,/*PK*/
  dateArrive         DATE              NULL,
  clientIdCli        INT               NOT NULL,/*FK*/
  reservationIdReser INT               NOT NULL,/*FK*/
  chambreNoCham      VARCHAR(3)        NOT NULL,/*FK*/
  
  PRIMARY KEY (idArrive),
  FOREIGN KEY (reservationIdReser) REFERENCES reservation(idReser),
  FOREIGN KEY (chambreNoCham)      REFERENCES chambre(noChamb)
)

/***********************************************************
          Table "Depart"
***********************************************************/

CREATE TABLE depart (
	idDepart		INT	IDENTITY(1,1) NOT NULL,/*PK*/
	dateDepart		DATE              NULL,
	confirmerPar 	DECIMAL(5,2)      NULL,
	idReser			INT	              NULL,/*FK*/
	noChamb			VARCHAR(3)        NULL,/*FK*/
	idCli			INT               NULL,/*FK*/

	PRIMARY KEY (idDepart),
	FOREIGN KEY (idReser) REFERENCES reservation(idReser),
	FOREIGN KEY (noChamb) REFERENCES chambre(noChamb),
	FOREIGN KEY (idCli)   REFERENCES client(idCli)
)

ALTER TABLE reservation ADD CONSTRAINT FK  FOREIGN KEY (idCli)   REFERENCES client(idCli);
ALTER TABLE de          ADD CONSTRAINT FK1 FOREIGN KEY (idReser) REFERENCES reservation(idReser);
ALTER TABLE de          ADD CONSTRAINT FK2 FOREIGN KEY (noCham)  REFERENCES chambre(noChamb);

ALTER TABLE chambre ADD CONSTRAINT FK3 FOREIGN KEY (codLoc)     REFERENCES localisation(codLoc);
ALTER TABLE chambre ADD CONSTRAINT FK4 FOREIGN KEY (codTypCham) REFERENCES typechambre(codTypCham);
ALTER TABLE ayant   ADD CONSTRAINT FK5 FOREIGN KEY (noChamb)    REFERENCES chambre(noChamb);
ALTER TABLE ayant   ADD CONSTRAINT FK6 FOREIGN KEY (codCom)     REFERENCES commodite(codCom);

ALTER TABLE trx ADD CONSTRAINT FK7  FOREIGN KEY (codTypTrx) REFERENCES typetrx(codTypTrx);
ALTER TABLE trx ADD CONSTRAINT FK8  FOREIGN KEY (idReser)   REFERENCES reservation(idReser);
ALTER TABLE trx ADD CONSTRAINT FK9  FOREIGN KEY (noCham)    REFERENCES chambre(noChamb);
ALTER TABLE trx ADD CONSTRAINT FK10 FOREIGN KEY (idCli)     REFERENCES client(idCli);
/*ALTER TABLE trx ADD CONSTRAINT FK11 FOREIGN KEY (idArrive)  REFERENCES arrive(idArrive);*/