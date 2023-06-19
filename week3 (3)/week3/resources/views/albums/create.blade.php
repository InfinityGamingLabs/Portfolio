<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="X-UA-Compatible" content="ie=edge">
        <title>Document</title>
    </head>
    <body>
        <h2>Add a albums:</h2>
        <form action="{{route('Albums.store')}}" method="POST">
            @csrf
            <label>Type the name of the albums that you want to add:</label><br><br>
            <label>name:</label>
            <input type="text" name="name"><br><br>
            <label>year:</label>
            <input type="text" name="year"><br><br>
            <label>times_sold:</label>
            <input type="text" name="times_sold"><br><br>
            <label>Band_id:</label>
            <input type="text" name="band_id"><br><br>

            <input type="submit" value="Add Albums">
        </form>
    </body>
</html>
