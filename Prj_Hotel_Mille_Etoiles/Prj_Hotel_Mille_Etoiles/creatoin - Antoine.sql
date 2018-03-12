
CREATE TABLE CLIENT
(
  IdCli     int NOT NULL,
  Nom       varchar(25) NULL,
  Adresse   varchar(25) NULL,
  Telephone varchar(10) NULL,
  NoCarte   varchar(16) NULL,
  TypeCarte varchar(15) NULL,
  DatExp    date(8) NULL,
  SoldeDu   decimal(12.2) NULL,
  PRIMARY KEY (IdCli)
)
ENGINE=INNODB;

CREATE TABLE ARRIVE
(
  IdArrive int NOT NULL,
  DateArrive  date(8) NULL,
  ClientIdCli int NOT NULL,
  ReservationIdReser int NOT NULL,
  ChambreNoCham varvhar(3) NOT NULL
  PRIMARY KEY (IdArrive),
  FOREIGN KEY (ReservationIdReser) REFERENCES reservation(IdReser),
  FOREIGN KEY (ChambreNoCham) REFERENCES chambre(NoCham)

)
