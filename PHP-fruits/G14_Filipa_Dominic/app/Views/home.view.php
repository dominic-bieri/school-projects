<!DOCTYPE html>
<html lang="de">
<head>
    <meta charset="UTF-8">
    <title>Meine Seite</title>
    <!-- Set base for relative urls to the directory of index.php: -->
    <base href="<?= ROOT_URL ?>/">
    <link rel="stylesheet" href="public/css/app.css">
</head>
<body>
<div class="container">

    <h1 class="welcome">Home</h1>
    <form action="enter" method="post">
        <fieldset>
            <legend>Dörr-Aufträge erfassen</legend>
            <button type="submit" name="form-submit">Erfassen</button>
        </fieldset>
    </form>
    <form action="edit" method="post">
        <fieldset>
            <legend>Aufträge bearbeiten</legend>
            <button type="submit" name="form-submit">Bearbeiten</button>
        </fieldset>
    </form>
    <form action="view" method="post">
        <fieldset>
            <legend>Dörr-Aufträge anzeigen</legend>
            <button type="submit" name="form-submit">Anzeigen</button>
        </fieldset>
    </form>

</div>

<script src="public/js/app.js"></script>
</body>
</html>
