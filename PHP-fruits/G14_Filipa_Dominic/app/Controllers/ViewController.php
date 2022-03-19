<?php


class ViewController
{
    function index()
    {
        require 'app/Models/ViewModel.php';
        $result = ViewModel::view();
        require 'app/Views/view.view.php';
    }
}
