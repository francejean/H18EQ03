use prj_hotel;

/***********************************************************
	Table "TRX"
***********************************************************/

CREATE TABLE trx
(
    IdTrx   	int(4)      	NOT NULL identity(1,1),
    DateTrx     date(8) 		NULL,
    MontantTrx  decimal(10,2)   NULL,
    Reportee    tinyint(1) 		NULL,
	
	CodTypTrx   varchar(2)      NULL,
	IdReser     int(4)          NULL,
	NoCham      varchar(3)      NULL,
	IdCli       int(4)          NULL,
	IdArrive    int(4)			NULL,
	
    PRIMARY KEY (IdTrx),
	
	FOREIGN KEY (CodTypTrx) REFERENCES TYPETRX(CodTypTrx),
    FOREIGN KEY (IdReser)   REFERENCES RESERVATION(IdReser),
    FOREIGN KEY (NoCham)    REFERENCES CHAMBRE(NoCham),
	FOREIGN KEY (IdCli)     REFERENCES CLIENT(IdCli),
	FOREIGN KEY (IdArrive)  REFERENCES ARRIVE(IdArrive),
	
)
/*ENGINE=INNODB;*/


/***********************************************************
	Table "TYPETRX"
***********************************************************/

CREATE TABLE typetrx
(
    CodTypTrx    varchar(2)    NOT   NULL,
    DescTrx      varchar(25)   NULL,
    Nature     	 varchar(25)   NULL,
)

/*ENGINE=INNODB;*/

/*SOURCE SQL_ScriptInsertion_TRX.sql;
SOURCE SQL_ScriptRequeteTest_TRX.sql;*/