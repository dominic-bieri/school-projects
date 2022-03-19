<?php

class EnterModel
{
    public static function insertUser()
    {
        $pdo = db();

        $statement = $pdo->prepare('INSERT INTO users (userEmail, userTelephone, userFirstName, userLastName, userDisplay) VALUES (:email, :telephone, :firstName, :lastName, 1)');
        $statement->bindParam(':email', $_POST['email']);
        $statement->bindParam(':telephone', $_POST['telefon']);
        $statement->bindParam(':firstName', $_POST['fname']);
        $statement->bindParam(':lastName', $_POST['lname']);
        $statement->execute();
        EnterModel::insertDry($pdo);
    }

    public static function insertDry(PDO $userPDO)
    {

        $dryPDO = db();
        $dryStatus = 0;
        $fruitsId = (int)$_POST['fruit'];
        $dryQuantity = $_POST['quantity'];

        $dateNow = new DateTime("Now");
        $datum = $dateNow->format("Y-m-d");

        $statement = $dryPDO->prepare('INSERT INTO drys (dryStatus, dryQuantity, dryDate, fk_fruitsId) VALUES  (:dryStatus, :dryQuantity, :dryDate, :fruitsId)');
        $statement->bindParam(':dryStatus', $dryStatus);
        $statement->bindParam(':dryQuantity', $dryQuantity);
        $statement->bindParam(':dryDate', $datum);
        $statement->bindParam(':fruitsId', $fruitsId);
        $statement->execute();
        EnterModel::insertOrder($userPDO, $dryPDO);
    }

    public static function insertOrder(PDO $userPDO, PDO $dryPDO)
    {
        $pdo = db();
        $userid = $userPDO->lastInsertId();
        $dryid = $dryPDO->lastInsertId();
        $statement = $pdo->prepare('INSERT INTO orders (fk_userId, fk_dryId) VALUES (:userid, :dryid)');
        $statement->bindParam(':userid', $userid);
        $statement->bindParam(':dryid', $dryid);
        $statement->execute();
        require 'app/Views/home.view.php';
    }

    public static function comboBoxInsert(): array
    {
        $pdo = db();
        $statement = $pdo->prepare('SELECT fruitsId, fruitName FROM fruits');
        $statement->execute();
        return $statement->fetchAll();
    }
}