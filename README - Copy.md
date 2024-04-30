DB set up

Connect to postgesql console:

create database interview;
\c interview;
create user app SUPERUSER PASSWORD 'app';

#####

Go to vs Package Manager Console

Set defaul project to DataAccess

> Add-Migration InitialCreate

> Update-Database

######

Go back to postgesql console:

INSERT INTO "Group" VALUES (1, 'GroupA');
INSERT INTO "Group" VALUES (2, 'GroupB');
INSERT INTO "Group" VALUES (3, 'GroupC');
INSERT INTO "Group" VALUES (4, 'GroupD');

INSERT INTO "People" VALUES (1,4,'id@egestasAliquam.org','Murphy','Bentley','+380003739862');
INSERT INTO "People" VALUES (2,3,'ullamcorper.Duis.cursus@nec.org','Gannon','Mendoza','+380422584773');
INSERT INTO "People" VALUES (3,4,'magna.Ut@Namnullamagna.co.uk','Yoshio','Sampson','+380086877592');
INSERT INTO "People" VALUES (4,3,'congue@eu.net','Jin','Mcgee','+380653403075');
INSERT INTO "People" VALUES (5,3,'magna.Phasellus.dolor@nisisemsemper.co.uk','George','Witt','+380008179635');
INSERT INTO "People" VALUES (6,4,'Quisque.porttitor.eros@Donec.org','Cairo','Levy','+380508380729');
INSERT INTO "People" VALUES (7,2,'interdum@ante.co.uk','Herman','Hardy','+380669418573');
INSERT INTO "People" VALUES (8,4,'in@ornarelectusante.edu','Mannix','Sloan','+380392136919');
INSERT INTO "People" VALUES (9,3,'posuere@consectetuer.ca','Victor','Flores','+380797313590');
INSERT INTO "People" VALUES (10,4,'sociis.natoque.penatibus@tellusAenean.net','Timon','Padilla','+380201860006');
INSERT INTO "People" VALUES (11,2,'a.aliquet@estMauris.org','Ezekiel','Jacobson','+380374843407');
INSERT INTO "People" VALUES (12,1,'ipsum@Nulla.co.uk','Reese','Cooke','+380532826573');
INSERT INTO "People" VALUES (13,1,'aliquet@quis.com','Sawyer','Nelson','+380572861083');
INSERT INTO "People" VALUES (14,2,'In@ametrisus.ca','Julian','Gray','+380989074226');
INSERT INTO "People" VALUES (15,4,'Nullam.velit@magna.com','Judah','Fuentes','+380717425647');
