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
    <h1 class="welcome">Edit</h1>
    <a href="enter">Neue Aufträge erstellen</a><br><br>
    <a href="view">Bestehenden Aufträge anzeigen</a><br><br><br>
    <?php /** @var TYPE_NAME $result */
    foreach ($result as $res): ?>
        <br>
        <form action="edit/update" method="post">
            <table>
                <tr>
                    <th>Informationen</th>
                    <th>Daten</th>
                    <th></th>
                <tr>
                    <td>
                        <label for="id">Id:</label><br>
                    </td>
                    <td>
                        <input readonly type="text" id="userId" name="userId" value="<?php echo $res['userId']; ?>">
                    </td>
                    <td><a href=<?php echo "edit/done&id=" . $res['userId'] ?>>Dörrung ist fertig</a></td>
                <tr>
                    <td>
                        <label for="fname">Vorname:</label><br>
                    </td>
                    <td>
                        <input type="text" id="userFirstName" name="userFirstName"
                               value="<?php echo $res['userFirstName']; ?>">
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>
                        <label for="lname">Nachname:</label><br>
                    </td>
                    <td>
                        <input type="text" id="userLastName" name="userLastName"
                               value="<?php echo $res['userLastName']; ?>">
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>
                        <label for="email">Email:</label><br>
                    </td>
                    <td>
                        <input type="text" id="userEmail" name="userEmail" value="<?php echo $res['userEmail']; ?>">
                    <td></td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label for="telefon">Telefon:</label><br>
                    </td>
                    <td>
                        <input type="text" id="userTelephone" name="userTelephone"
                               value="<?php echo $res['userTelephone']; ?>">
                    <td></td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label for="fruit">Fruit:</label><br>
                    </td>
                    <td>
                        <select name="fruit" id="fruit">
                            <?php /** @var TYPE_NAME $fruits */
                            foreach ($fruits as $fruit): ?>
                                <option value="<?= $fruit['fruitsId'] ?>"><?= $fruit['fruitName'] ?></option>
                            <?php endforeach; ?>
                        </select>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>
                        <label for="fruit">Mengen-Kategorie:</label><br>
                    </td>
                    <td>
                        <input type="text" id="dryQuantity" name="dryQuantity"
                               value=" <?php echo $res['dryQuantity']; ?>"
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td>
                        <button type="submit" name="form-submit">Submit</button>
                    </td>
                </tr>
                </tablebody>
            </table>
        </form>
        <br>
    <?php endforeach; ?>
    <script src="public/js/app.js"></script>
</div>
</body>
</body>
</html>
