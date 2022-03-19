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
    <h1 class="welcome">View</h1>
    <a href="enter">Neue Aufträge erstellen</a><br><br>
    <a href="edit">Bestehenden Aufträge bearbeiten</a>
    <br><br><br>
    <table>
        <tablebody>
            <th>Vorname</th>
            <th>Nachname</th>
            <th>Art der Frucht</th>
            <th>Zeit</th>
            <th>Status</th>
            <?php foreach ($result as $res): ?>
                <tr>
                    <td><?php echo $res['userFirstName'] ?></td>
                    <td><?php echo $res['userLastName'] ?></td>
                    <td><?php echo $res['fruitName'] ?></td>
                    <td><?php
                        $datum = $res['dryDate'];
                        $date = new DateTime($datum);


                        if ($res['dryQuantity'] <= 5) {
                            $date->add(new DateInterval('P5D'));
                            echo $date->format('Y-m-d') . "\n";
                        } else if ($res['dryQuantity'] <= 10) {
                            $date->add(new DateInterval('P8D'));
                            echo $date->format('Y-m-d') . "\n";
                        } else if ($res['dryQuantity'] <= 15) {
                            $date->add(new DateInterval('P12D'));
                            echo $date->format('Y-m-d') . "\n";
                        } else if ($res['dryQuantity'] <= 20) {
                            $date->add(new DateInterval('P18D'));
                            echo $date->format('Y-m-d') . "\n";
                        }
                        ?>
                    </td>
                    <td>
                        <?php

                        if ($res['dryStatus'] == 0) {
                            echo "🥔" . "\n";
                        } else {
                            echo "🍎" . "\n";
                        }
                        ?>
                    </td>
                </tr>
            <?php endforeach; ?>
        </tablebody>
    </table>
</div>

<script src="public/js/app.js"></script>
</body>
</html>
