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
            <th>naam</th>
            <th>coach</th>
            <th>stadion</th>
            <th>opgericht</th>
        </tr>

        <?php
        $rows = $db->selectStudents();

        foreach($rows as $row)
        {
            echo "<tr>   
                    <td class='border_bottom'>$row[TeamID]</td>
                    <td class='border_bottom'>$row[naam]</td>
                    <td class='border_bottom'>$row[coach]</td>
                    <td class='border_bottom'>$row[stadion]</td>
                    <td class='border_bottom'>$row[opgericht]</td>
                    <td>
                    </tr>";
        }
        ?>
    </table>
    <a href="home.php">
        <button>
        teams
        </button>
        
    </a>
</div>
</body>
</html>