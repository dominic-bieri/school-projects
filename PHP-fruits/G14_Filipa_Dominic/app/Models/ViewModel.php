<?php


class ViewModel
{
    public static function view(): array
    {
        $pdo = db();


        $statement = $pdo->prepare('SELECT users.userFirstName, users.userLastName, fruits.fruitName, drys.dryQuantity, drys.dryDate, drys.dryStatus FROM drys JOIN fruits ON drys.fk_fruitsId = fruits.fruitsId JOIN orders ON drys.dryId = orders.fk_dryId JOIN users ON orders.fk_dryId = users.userId');
        $statement->execute();
        return $statement->fetchAll();
    }
}