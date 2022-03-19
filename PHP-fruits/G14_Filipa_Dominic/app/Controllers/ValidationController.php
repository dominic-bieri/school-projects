<?php


class ValidationController
{
    public static function enterValidation()
    {
        require 'app/Models/EnterModel.php';
        if ($_SERVER['REQUEST_METHOD'] === 'POST') {

            $firstname = trim($_POST['fname']);
            $lastname = trim($_POST['lname']);
            $email = trim($_POST['email']);
            $telephone = trim($_POST['telefon']);
            $quantity = trim($_POST['quantity']);

            $errors = [
                'errorCount' => 0,
                'firstname' => '',
                'lastname' => '',
                'telephone' => '',
                'email' => '',
                'quantity' => '',
            ];

            if (!preg_match('/^([a-zA-Z]+(ö[a-zA-Z]+)+)$/i', $firstname) && strlen($firstname) < 1) {
                $errors['errorCount']++;
                $errors['firstname'] = '<br>Der Vorname muss mindestens 1 Zeichen beinhalten!';
            }

            if (!preg_match('/^([a-zA-Z]+(ö[a-zA-Z]+)+)$/i', $lastname) && strlen($lastname) < 1) {
                $errors['errorCount']++;
                $errors['lastname'] = '<br>Der Nachname muss mindestens 1 Zeichen beinhalten!';
            }

            if (!preg_match('/^[\+\-\/ 0-9]+$/', $telephone) && strlen($telephone) > 0) {
                $errors['errorCount']++;
                $errors['telephone'] = '<br>Die Telefonnummer muss ein + beinhalten und aus den Nummern [0-9] bestehen!';
            }

            if (!preg_match('/^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,})$/i', $email)) {
                $errors['errorCount']++;
                $errors['email'] = '<br>Die Email muss aus einer validen Email-Addresse bestehen!';
            }

            if (!preg_match('/^[0-9]+$/i', $quantity)) {
                $errors['errorCount']++;
                $errors['quantity'] = '<br>Die Menge muss aus ganzen Zahlen bestehen!';
            }

            if ($errors['errorCount'] === 0) {
                EnterModel::insertUser();
            } else {
                echo $errors['firstname'];
                echo $errors['lastname'];
                echo $errors['telephone'];
                echo $errors['email'];
                echo $errors['quantity'];
            }
        } else {
            echo "Da hat wohl etwas nicht geklappt";
        }
    }

    public static function editValidation()
    {
        require 'app/Models/EditModel.php';
        if ($_SERVER['REQUEST_METHOD'] === 'POST') {

            $firstname = trim($_POST['userFirstName']);
            $lastname = trim($_POST['userLastName']);
            $email = trim($_POST['userEmail']);
            $telephone = trim($_POST['userTelephone']);
            $quantity = trim($_POST['dryQuantity']);

            $errors = [
                'errorCount' => 0,
                'firstname' => '',
                'lastname' => '',
                'telephone' => '',
                'email' => '',
                'quantity' => '',
            ];

            if (!preg_match('/^([a-zA-Z]+(ö[a-zA-Z]+)+)$/i', $firstname) && strlen($firstname) < 1) {
                $errors['errorCount']++;
                $errors['firstname'] = '<br>Der Vorname muss mindestens 1 Zeichen beinhalten!';
            }

            if (!preg_match('/^([a-zA-Z]+(ö[a-zA-Z]+)+)$/i', $lastname) && strlen($lastname) < 1) {
                $errors['errorCount']++;
                $errors['lastname'] = '<br>Der Nachname muss mindestens 1 Zeichen beinhalten!';
            }

            if (!preg_match('/^[\+\-\/ 0-9]+$/', $telephone) && strlen($telephone) > 0) {
                $errors['errorCount']++;
                $errors['telephone'] = '<br>Die Telefonnummer muss ein + beinhalten und aus den Nummern [0-9] bestehen!';
            }

            if (!preg_match('/^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,})$/i', $email)) {
                $errors['errorCount']++;
                $errors['email'] = '<br>Die Email muss aus einer validen Email-Addresse bestehen!';
            }

            if (!preg_match('/^[0-9]+$/i', $quantity)) {
                $errors['errorCount']++;
                $errors['quantity'] = '<br>Die Menge muss aus ganzen Zahlen bestehen!';
            }

            if ($errors['errorCount'] === 0) {
                EditModel::update();
            } else {
                echo $errors['firstname'];
                echo $errors['lastname'];
                echo $errors['telephone'];
                echo $errors['email'];
                echo $errors['quantity'];
            }
        } else {
            echo "Da hat wohl etwas nicht geklappt";
        }
    }
}