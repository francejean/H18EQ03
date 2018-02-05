

/*************************************
			Table Commodite
*************************************/
INSERT INTO Commodite VALUES ('AS','Standard');
INSERT INTO Commodite VALUES ('BA','Balcon');
INSERT INTO Commodite VALUES ('BT','Bain Tourbillon');
INSERT INTO Commodite VALUES ('CC','Chambre Communicante');
INSERT INTO Commodite VALUES ('IN','Internet');
INSERT INTO Commodite VALUES ('MB','MiniBar');
INSERT INTO Commodite VALUES ('HP','Handicaper');
INSERT INTO Commodite VALUES ('NF','Non Fumeur');

/*************************************
			Table Localisation
*************************************/
INSERT INTO Localisation VALUES ('AR','Arriere');
INSERT INTO Localisation VALUES ('AS',"Pres de l'Ascenseur");
INSERT INTO Localisation VALUES ('AV','Avant');
INSERT INTO Localisation VALUES ('VM','Vue sur Mer');
INSERT INTO Localisation VALUES ('SM','Pres salle a Manger');


/*************************************
			Table TypeChambre
*************************************/
INSERT INTO Typechambre VALUES ('1J','1 Lit Jumeau','10');
INSERT INTO Typechambre VALUES ('2J','2 Lits Jumeau','14');
INSERT INTO Typechambre VALUES ('1D','1 Lit Double','08');
INSERT INTO Typechambre VALUES ('2D','2 Lits Double','05');
INSERT INTO Typechambre VALUES ('LQ','Lit Queen','01');
INSERT INTO Typechambre VALUES ('LK','Lit King','05');
INSERT INTO Typechambre VALUES ('ST','Suite','23');
INSERT INTO Typechambre VALUES ('SR','Salle Reception','02');

/*************************************
			Table Chambre
*************************************/
INSERT INTO Chambre VALUES ('0101','01','854.32','1','yolo','AR','1J');
INSERT INTO Chambre VALUES ('0102','01','654.65','1','yolo','AS','2J');
INSERT INTO Chambre VALUES ('0103','01','854.32','1','yolo','AV','1D');
INSERT INTO Chambre VALUES ('0201','02','854.32','1','yolo','VM','2D');
INSERT INTO Chambre VALUES ('0301','03','854.32','1','yolo','SM','LQ');
INSERT INTO Chambre VALUES ('0401','04','854.32','1','yolo','AR','LK');
INSERT INTO Chambre VALUES ('0501','05','854.32','1','yolo','AV','ST');
INSERT INTO Chambre VALUES ('0601','06','854.32','0','yolo','SM','SR');
INSERT INTO Chambre VALUES ('0701','07','854.32','1','yolo','AS','2D');
INSERT INTO Chambre VALUES ('0801','08','854.32','1','yolo','AV','ST');
INSERT INTO Chambre VALUES ('0901','09','854.32','0','yolo','AR','1D');
INSERT INTO Chambre VALUES ('0811','08','854.32','1','yolo','VM','1J');

/*************************************
			Table Ayant
*************************************/