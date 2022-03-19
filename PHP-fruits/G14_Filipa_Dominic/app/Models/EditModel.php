<?php


class EditModel
{
    public static function done()
    {
        if (isset($_GET['id'])) {
            $id = $_GET['id'];
            $pdo = db();
            $statement = $pdo->prepare('UPDATE users SET userDisplay = 0 WHERE userId=:userId');
            $statement->bindParam(':userId', $id);
            $statement->execute();

            header('Location: ' . ROOT_URL . '/edit');
        }
    }

    public static function getDryId(int $userid)
    {
        $pdo = db();
        $statement = $pdo->prepare('SELECT fk_dryId FROM orders WHERE fk_userId = :id');
        $statement->bindParam(':id', $userid);
        $statement->execute();
        return $statement->fetch();
    }

    public static function updateQuantity(int $userId, int $quantity)
    {
        $dryId = EditModel::getDryId($userId);
        $dryId = (int)$dryId['fk_dryId'];
        var_dump($dryId);
        $pdo = db();
        $statement = $pdo->prepare('UPDATE drys SET dryQuantity = :quantity WHERE dryId = :dryId');
        $statement->bindParam(':quantity', $quantity);
        $statement->bindParam(':dryId', $dryId);
        $statement->execute();
    }

    public static function updateDry(int $dryId)
    {
        $fruitId = (int)$_POST['fruit'];
        $pdo = db();
        $statement = $pdo->prepare('UPDATE drys SET fk_fruitsId = :fruitId, dryDisplay = 1 WHERE dryId = :dryId');
        $statement->bindParam(':dryId', $dryId);
        $statement->bindParam(':fruitId', $fruitId);
        $statement->execute();
    }

    public static function update()
    {
        $id = (int)$_POST['userId'];
        $fruitId = (int)$_POST['fruit'];
        $firstname = $_POST['userFirstName'];
        $lastname = $_POST['userLastName'];
        $email = $_POST['userEmail'];
        $telephone = $_POST['userTelephone'];
        $quantity = (int)$_POST['dryQuantity'];

        $pdo = db();
        $statement = $pdo->prepare('UPDATE users SET userEmail = :email, userTelephone = :telephone, userFirstName = :firstName, userLastName = :lastName WHERE userId = :id');
        $statement->bindParam(':email', $email);
        $statement->bindParam(':telephone', $telephone);
        $statement->bindParam(':firstName', $firstname);
        $statement->bindParam(':lastName', $lastname);
        $statement->bindParam(':id', $id);
        $statement->execute();

        $dryId = EditModel::getDryId($id);
        $dryId = (int)$dryId['fk_dryId'];
        EditModel::updateDry($dryId);
        EditModel::updateQuantity($id, $quantity);
        header('Location: ' . ROOT_URL . '/edit');
    }


    public static function getUserInfo(): array
    {
        $pdo = db();
        $statement = $pdo->prepare('SELECT userId, userFirstName, userLastName, userEmail, userTelephone, fruitName, dryQuantity FROM users JOIN orders ON users.userId = orders.fk_userId JOIN drys ON orders.fk_dryId = drys.dryId JOIN fruits ON drys.fk_fruitsId = fruits.fruitsID WHERE users.userDisplay = 1');
        $statement->execute();
        return $statement->fetchAll();
    }

    public static function comboBoxSelect(): array
    {
        $pdo = db();
        $statement = $pdo->prepare('SELECT fruitsId, fruitName FROM fruits');
        $statement->execute();
        return $statement->fetchAll();
    }
}