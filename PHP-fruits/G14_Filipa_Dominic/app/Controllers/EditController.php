<?php


class EditController
{
    function index()
    {
        require 'app/Models/EditModel.php';
        $result = EditModel::getUserInfo();
        $fruits = EditModel::comboBoxSelect();
        require 'app/Views/edit.view.php';
    }

    public function done()
    {
        require 'app/Models/EditModel.php';
        EditModel::done();
    }

    function update()
    {
        require 'app/Controllers/ValidationController.php';
        ValidationController::editValidation();
    }

}

?>