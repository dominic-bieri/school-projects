<?php
require 'core/bootstrap.php';

$routes = [
    '/hallo/welt' => 'WelcomeController@index',
    '/' => 'HomeController@index',
    '/enter' => 'EnterController@index',
    '/edit' => 'EditController@index',
    '/view' => 'ViewController@index',
    '/enter/insert' => 'EnterController@insert',
    '/edit/done' => 'EditController@done',
    '/edit/update' => 'EditController@update'
];

$db = [
    'name' => 'kurseictbz_30714',
    'username' => 'root',
    'password' => '',
];

$router = new Router($routes);
$router->run($_GET['url'] ?? '');