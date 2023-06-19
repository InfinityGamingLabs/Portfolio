<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="X-UA-Compatible" content="ie=edge">
        <title>Document</title>
    </head>
    <body>
        <h2>Add a bands:</h2>
        <form action="{{route('bands.store')}}" method="POST">
            @csrf
            <label>Type the name of the bands that you want to add:</label><br><br>
            <label>Name:</label>
            <input type="text" name="Name"><br><br>
            <label>Genre:</label>
            <input type="text" name="genre"><br><br>
            <label>Founded:</label>
            <input type="text" name="founded"><br><br>
            <input type="submit" value="Add song">
        </form>
    </body>
</html>