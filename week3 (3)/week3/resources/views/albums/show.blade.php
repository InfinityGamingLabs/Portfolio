<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    @vite('resources/css/app.css')
</head>

<body>
    <ul>
        <P class="font-mono text-blue-600">albums:</P>
        {{ $album->name }}
        {{ $album->year }}
        {{ $album->time_sold }}
        @foreach ($album->songs as $song)
        <p>songs:</p>
        {{ $song->title }}
        @endforeach
        <br><h2>Band(s)</h2>
        {{ $band->name }}
    </ul> 
</body>

</html>











{{-- die laat de gecoplt albums an songs zien  --}}