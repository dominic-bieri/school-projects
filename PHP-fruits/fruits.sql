DROP DATABASE IF EXISTS kurseictbz_30714;
CREATE DATABASE kurseictbz_30714;
USE kurseictbz_30714;

CREATE TABLE fruits
(
    fruitsId int NOT NULL AUTO_INCREMENT,
    fruitName varchar(30) NOT NULL,
    PRIMARY KEY (fruitsId)
);

INSERT INTO fruits (fruitName) VALUES
('Ananas'),
('Äpfel'),
('Aprikosen'),
('Avocado'),
('Bananen'),
('Birnen'),
('Blondorangen'),
('Blutorangen'),
('Brombeeren'),
('Clementinen'),
('Erdbeeren'),
('Feigen frisch'),
('Grapefruits'),
('Heidelbeeren'),
('Himbeeren'),
('Johannisbeeren'),
('Kaki'),
('Kirschen'),
('Kiwi'),
('Kiwi Bio Schweiz'),
('Limetten'),
('Litschis'),
('Mango'),
('Melonen'),
('Mirabellen'),
('Nektarinen'),
('Papaya'),
('Pfirsiche'),
('Pflaumen'),
('Preiselbeeren'),
('Quitten'),
('Stachelbeeren'),
('Trauben'),
('Kirschen'),
('Zwetschgen');


CREATE TABLE users
(
    userId int NOT NULL AUTO_INCREMENT,
    userEmail varchar(50) NOT NULL,
    userTelephone varchar(20),
    userFirstName varchar(30),
    userLastName varchar(50),
    userDisplay tinyint(1),
    PRIMARY KEY (userId)
);

CREATE TABLE drys
(
    dryId int NOT NULL AUTO_INCREMENT,
    dryStatus tinyint(1) NOT NULL DEFAULT 1,
    dryQuantity int,
    dryDate DATE,
    fk_fruitsId int,
    dryDisplay tinyint(1),
    PRIMARY KEY (dryId),
    FOREIGN KEY (fk_fruitsid) REFERENCES fruits (fruitsId)
);

CREATE TABLE orders
(
    orderId int NOT NULL AUTO_INCREMENT,
    fk_userId int,
    fk_dryId int,
    orderDisplay tinyint(1),
    PRIMARY KEY (orderId),
    FOREIGN KEY (fk_userId) REFERENCES users (userId),
    FOREIGN KEY (fk_dryId) REFERENCES drys (dryId)
);

INSERT INTO users (userEmail, userTelephone, userFirstName, userLastName, userDisplay) VALUES ('test@test.de', '05129361063', 'Reiner', 'Zufall', 1);
INSERT INTO users (userEmail, userTelephone, userFirstName, userLastName, userDisplay) VALUES ('hallo@gmx.de', '12341253', 'Test', 'Person', 1);
INSERT INTO users (userEmail, userTelephone, userFirstName, userLastName, userDisplay) VALUES ('blabla@gmx.de', '', 'Hallo', 'Welt', 1);

INSERT INTO drys (dryStatus, dryQuantity, fk_fruitsid, dryDisplay) VALUES ('1', '12', '13', 1);
INSERT INTO drys (dryStatus, dryQuantity, fk_fruitsid, dryDisplay) VALUES ('1', '4', '7', 1);
INSERT INTO drys (dryStatus, dryQuantity, fk_fruitsid, dryDisplay) VALUES ('1', '20', '3', 1);

INSERT INTO orders (fk_userId, fk_dryId, orderDisplay) VALUES ('3', '1', 1);
INSERT INTO orders (fk_userId, fk_dryId, orderDisplay) VALUES ('2', '3', 1);
