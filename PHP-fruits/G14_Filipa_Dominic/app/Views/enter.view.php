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
    <h1 class="welcome">Enter</h1>
    <a href="edit">Bestehende Aufträge bearbeiten</a><br><br>
    <a href="view">Bestehenden Aufträge anzeigen</a><br><br><br>
    <form method="post" action="enter/insert">
        <table>
            <tablebody>
                <th>Informationen</th>
                <th>Ihre Daten</th>
                <tr>
                    <td><label for="fname">Vorname</label></td>
                    <td><input type="text" id="fname" name="fname" required></td>
                </tr>
                <tr>
                    <td><label for="lname">Nachname</label></td>
                    <td><input type="text" id="lname" name="lname" required></td>
                </tr>
                <tr>
                    <td><label for="email">Email</label></td>
                    <td><input type="email" id="email" name="email" required></td>
                </tr>
                <tr>
                    <td><label for="telefon">Telefon</label></td>
                    <td><input type="text" id="telefon" name="telefon"></td>
                </tr>
                <tr>
                    <td><label for="quantity">Mengen (in kg)</label></td>
                    <td><input type="number" id="quantity" name="quantity" min="1" max="20" required></td>
                </tr>
                <tr>
                    <td for="fruit">Frucht</td>
                    <td>
                        <select name="fruit" id="fruit">
                            <?php /** @var TYPE_NAME $result */
                            foreach ($result as $res): ?>
                                <?php echo "<option value='" . $res['fruitsId'] . "'>" . $res['fruitName'] . "</option>"; ?>
                            <?php endforeach; ?>>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td><input type="submit" value="Submit"></td>
                </tr>
            </tablebody>
        </table>
    </form>
</div>
<script src="public/js/app.js"></script>
</body>
</html>