<?php


class EnterController
{
    function index()
    {
        require 'app/Models/EnterModel.php';
        $result = EnterModel::comboBoxInsert();
        require 'app/Views/enter.view.php';
    }

    function insert()
    {
        require 'app/Controllers/ValidationController.php';
        ValidationController::enterValidation();
    }
}