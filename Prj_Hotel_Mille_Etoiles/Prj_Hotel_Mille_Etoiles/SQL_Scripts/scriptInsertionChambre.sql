

/*************************************
			Table Commodite
*************************************/
INSERT INTO commodite VALUES ('AS','Standard');
INSERT INTO commodite VALUES ('BA','Balcon');
INSERT INTO commodite VALUES ('BT','Bain Tourbillon');
INSERT INTO commodite VALUES ('CC','Chambre Communicante');
INSERT INTO commodite VALUES ('IN','Internet');
INSERT INTO commodite VALUES ('MB','MiniBar');
INSERT INTO commodite VALUES ('HP','Handicaper');
INSERT INTO commodite VALUES ('NF','Non Fumeur');

/*************************************
			Table Localisation
*************************************/
INSERT INTO localisation VALUES ('AR','Arriere');
INSERT INTO localisation VALUES ('AS',"Pres de l'Ascenseur");
INSERT INTO localisation VALUES ('AV','Avant');
INSERT INTO localisation VALUES ('VM','Vue sur Mer');
INSERT INTO localisation VALUES ('SM','Pres salle a Manger');


/*************************************
			Table TypeChambre
*************************************/
INSERT INTO typechambre VALUES ('1J','1 Lit Jumeau','10');
INSERT INTO typechambre VALUES ('2J','2 Lits Jumeau','14');
INSERT INTO typechambre VALUES ('1D','1 Lit Double','08');
INSERT INTO typechambre VALUES ('2D','2 Lits Double','05');
INSERT INTO typechambre VALUES ('LQ','Lit Queen','01');
INSERT INTO typechambre VALUES ('LK','Lit King','05');
INSERT INTO typechambre VALUES ('ST','Suite','23');
INSERT INTO typechambre VALUES ('SR','Salle Reception','02');

/*************************************
			Table Chambre
*************************************/
INSERT INTO chambre VALUES ('0101','01','854.32','1','yolo','AR','1J');
INSERT INTO chambre VALUES ('0102','01','654.65','1','yolo','AS','2J');
INSERT INTO chambre VALUES ('0103','01','854.32','1','yolo','AV','1D');
INSERT INTO chambre VALUES ('0201','02','854.32','1','yolo','VM','2D');
INSERT INTO chambre VALUES ('0301','03','854.32','1','yolo','SM','LQ');
INSERT INTO chambre VALUES ('0401','04','854.32','1','yolo','AR','LK');
INSERT INTO chambre VALUES ('0501','05','854.32','1','yolo','AV','ST');
INSERT INTO chambre VALUES ('0601','06','854.32','0','yolo','SM','SR');
INSERT INTO chambre VALUES ('0701','07','854.32','1','yolo','AS','2D');
INSERT INTO chambre VALUES ('0801','08','854.32','1','yolo','AV','ST');
INSERT INTO chambre VALUES ('0901','09','854.32','0','yolo','AR','1D');
INSERT INTO chambre VALUES ('0811','08','854.32','1','yolo','VM','1J');

/*************************************
			Table Ayant
*************************************/