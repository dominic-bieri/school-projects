DROP DATABASE IF EXISTS IPT5_Newsletter;
CREATE DATABASE IPT5_Newsletter;
USE IPT5_Newsletter;

CREATE TABLE userNewsletter(
    userID int NOT NULL AUTO_INCREMENT,
    email varchar(100) NOT NULL,
    userName varchar(100),
    PRIMARY KEY (userID)
);