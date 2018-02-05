/*************************************
			Table Depart
*************************************/

CREATE TABLE Depart (
	IdDepart		int			not null identity(1,1),
	DateDepart		date		null,
	ConfirmerPar 	decimal(5,2)null,
	IdReser			varchar(2)	not null,
	NoChamb			varchar(4)  not null,
	IdCli			int 		not null identity(1,1),
	PRIMARY KEY (IdDepart),
	FOREIGN KEY (IdReser) REFERENCES Reservation(IdReser),
	FOREIGN KEY (NoChamb) REFERENCES Chambre(NoChamb),
	FOREIGN KEY (IdCli) REFERENCES Client(IdCli)
)
engine = innodb;