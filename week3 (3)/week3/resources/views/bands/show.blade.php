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
        <P class="font-mono text-blue-600">bands:</P>
        {{ $bands->name }}
        {{ $bands->genre }}
        {{ $bands->founded }}
        @foreach ($albums as $album)
        {{ $album->name }}
        <P class="font-mono text-blue-600">albums:</P>
    @endforeach
    </ul>
</body>

</html>