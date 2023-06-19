<?php
include_once "./classes/nfldb.php";
$db = new nfldb();
?>

<!DOCTYPE html>
<html>
<head>
    <title>Overview</title>
    <link rel="stylesheet" href="./style/style.css">
</head>
<body>
<header class="header">
    <h1>nfl overzicht<h1>
</header>
<table>
        <tr>
            <th>ID</th>
            <th>voornaam</th>
            <th>achternaam</th>
            <th>college</th>
            <th>TeamID</th>
        </tr>

        <?php
        $rows = $db->selectplayers();

        foreach($rows as $row)
        {
            echo "<tr>   
                    <td class='border_bottom'>$row[PlayerID]</td>
                    <td class='border_bottom'>$row[voornaam]</td>
                    <td class='border_bottom'>$row[achternaam]</td>
                    <td class='border_bottom'>$row[college]</td>
                    <td class='border_bottom'>$row[TeamID]</td>
                    <td>
                    </tr>";
        }
        ?>
    </table>
    <a href="2page.php">
        <button>
        players
        </button>
        
    </a>
</div>
</body>
</html>