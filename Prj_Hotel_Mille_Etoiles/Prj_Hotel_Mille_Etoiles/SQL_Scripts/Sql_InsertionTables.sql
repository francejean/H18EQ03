/***********************************************************
          Table "Client"
***********************************************************/

INSERT INTO client(nom, adresse, telephone, noCarte, typeCarte, datExp, soldeDu)
	VALUES('Du con', 'Rue barbe', '4186666666', '1211111111111111', 'Wiza', '2018-12-12', 15.5);
INSERT INTO client(nom, adresse, telephone, noCarte, typeCarte, datExp, soldeDu)
	VALUES('Du con2', '9 3 quart', '4186665555', '1113111111111111', 'Wiza', '2018-12-12', 20.3);
INSERT INTO client(nom, adresse, telephone, noCarte, typeCarte, datExp, soldeDu)
	VALUES('Du con3', 'Rang quart', '4186664444', '1114111111111111', 'Mister Kart', '2018-12-12', 70.4);
INSERT INTO client(nom, adresse, telephone, noCarte, typeCarte, datExp, soldeDu)
	VALUES('Du con4', '123 fausse rue', '4186663333', '1111511111111111', 'Wiza', '2018-12-12', 150.52);

/***********************************************************
          Table "Commodite"
***********************************************************/

INSERT INTO commodite VALUES ('AS','Standard');
INSERT INTO commodite VALUES ('BA','Balcon');
INSERT INTO commodite VALUES ('BT','Bain Tourbillon');
INSERT INTO commodite VALUES ('CC','Chambre Communicante');
INSERT INTO commodite VALUES ('IN','Internet');
INSERT INTO commodite VALUES ('MB','MiniBar');
INSERT INTO commodite VALUES ('HP','Handicaper');
INSERT INTO commodite VALUES ('NF','Non Fumeur');

/***********************************************************
          Table "Localisation"
***********************************************************/

INSERT INTO localisation VALUES ('AR','Arriere');
INSERT INTO localisation VALUES ('AS','Pres de Ascenseur');
INSERT INTO localisation VALUES ('AV','Avant');
INSERT INTO localisation VALUES ('VM','Vue sur Mer');
INSERT INTO localisation VALUES ('SM','Pres salle a Manger');


/***********************************************************
          Table "TypeChambre"
***********************************************************/

INSERT INTO typechambre VALUES ('1J','1 Lit Jumeau','10');
INSERT INTO typechambre VALUES ('2J','2 Lits Jumeau','14');
INSERT INTO typechambre VALUES ('1D','1 Lit Double','08');
INSERT INTO typechambre VALUES ('2D','2 Lits Double','05');
INSERT INTO typechambre VALUES ('LQ','Lit Queen','01');
INSERT INTO typechambre VALUES ('LK','Lit King','05');
INSERT INTO typechambre VALUES ('ST','Suite','23');
INSERT INTO typechambre VALUES ('SR','Salle Reception','02');

/***********************************************************
          Table "Chambre"
***********************************************************/

INSERT INTO chambre VALUES ('101','01','854.32','1','yolo','AR','1J');
INSERT INTO chambre VALUES ('102','01','654.65','1','yolo','AS','2J');
INSERT INTO chambre VALUES ('103','01','854.32','1','yolo','AV','1D');
INSERT INTO chambre VALUES ('201','02','854.32','1','yolo','VM','2D');
INSERT INTO chambre VALUES ('301','03','854.32','1','yolo','SM','LQ');
INSERT INTO chambre VALUES ('401','04','854.32','1','yolo','AR','LK');
INSERT INTO chambre VALUES ('501','05','854.32','1','yolo','AV','ST');
INSERT INTO chambre VALUES ('601','06','854.32','0','yolo','SM','SR');
INSERT INTO chambre VALUES ('701','07','854.32','1','yolo','AS','2D');
INSERT INTO chambre VALUES ('801','08','854.32','1','yolo','AV','ST');
INSERT INTO chambre VALUES ('901','09','854.32','0','yolo','AR','1D');
INSERT INTO chambre VALUES ('811','08','854.32','1','yolo','VM','1J');

/***********************************************************
          Table "Ayant"
***********************************************************/

INSERT INTO ayant VALUES ('101', 'AS');
INSERT INTO ayant VALUES ('101', 'BA');
INSERT INTO ayant VALUES ('102', 'IN');
INSERT INTO ayant VALUES ('103', 'BA');
INSERT INTO ayant VALUES ('201', 'HP');
INSERT INTO ayant VALUES ('301', 'CC');
INSERT INTO ayant VALUES ('401', 'NF');
INSERT INTO ayant VALUES ('501', 'MB');
INSERT INTO ayant VALUES ('601', 'AS');
INSERT INTO ayant VALUES ('701', 'BA');
INSERT INTO ayant VALUES ('801', 'MB');
INSERT INTO ayant VALUES ('811', 'HP');
INSERT INTO ayant VALUES ('901', 'IN');

/***********************************************************
          Table "Reservation"
***********************************************************/

INSERT INTO reservation VALUES('2018-2-9', '2018-2-23', '2018-3-9', 1);
INSERT INTO reservation VALUES('2018-3-9', '2018-3-23', '2018-4-9', 3);
INSERT INTO reservation VALUES('2018-4-9', '2018-4-23', '2018-5-9', 2);
INSERT INTO reservation VALUES('2018-4-9', '2018-4-27', '2018-5-13', 1);
INSERT INTO reservation VALUES('2018-5-9', '2018-5-23', '2018-6-9', 4);

/***********************************************************
          Table "De"
***********************************************************/

INSERT INTO de VALUES(0, 1, '101');
INSERT INTO de VALUES(0, 2, '101');
INSERT INTO de VALUES(0, 3, '101');
INSERT INTO de VALUES(0, 4, '201');
INSERT INTO de VALUES(0, 5, '101');

/***********************************************************
          Table "Arrive"
***********************************************************/

INSERT INTO arrive VALUES ('20180101', 1, 1, '101');
INSERT INTO arrive VALUES ('20180103', 3, 2, '201');
INSERT INTO arrive VALUES ('20180106', 2, 3, '301');

/***********************************************************
          Table "TypeTrx"
***********************************************************/

INSERT INTO typetrx VALUES ('01', 'chambre loué', 'DB');
INSERT INTO typetrx VALUES ('02', 'facture restaurant', 'CR');

/***********************************************************
          Table "Trx"
***********************************************************/

INSERT INTO trx VALUES ('20181102',105.25,'0', '01', 1, '101', 1);
INSERT INTO trx VALUES ('20181102',100.25,'0', '01', 1, '102', 1);
INSERT INTO trx VALUES ('20181102',95.25,'0', '01', 1, '102', 1);
INSERT INTO trx VALUES ('20181102',90.25,'0', '01', 1, '102', 1);
INSERT INTO trx VALUES ('20181102',85.25,'0', '01', 1, '102', 1);
INSERT INTO trx VALUES ('20181102',80.25,'0', '01', 1, '102', 1);
INSERT INTO trx VALUES ('20181102',85.25,'0', '01', 1, '102', 1);
INSERT INTO trx VALUES ('20181102',90.25,'0', '01', 1, '102', 1);
INSERT INTO trx VALUES ('20181102',95.25,'0', '01', 1, '102', 1);
INSERT INTO trx VALUES ('20181102',100.25,'0', '01', 1, '102', 1);