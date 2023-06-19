<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Songs</title>
    @vite('resources/css/app.css')
</head>
<ul>
    <li><a href="/bands">bands</a></li>
    <li><a href="/Albums">Albums</a></li>
    <li><a href="/songs">Songs</a></li>
  </ul>
<body class="bg-slate-100 grid grid-cols-3">
    @auth
    <div>
        <P class="font-mono text-blue-600">Songs:</P>
        <br>
        @foreach ($songs as $song)
            <div>
                <form action="/songs/{{ $song->id }}" method="POST">
                    <div><a href="songs/{{ $song->id }}">{{ $song->title }}</a></div>
                    <div><a class="text-blue-600" href="songs/{{ $song->id }}/edit">edit</a></div><br>
                    @csrf
                    @method('DELETE')
                    <div><button class="text-red-600" type="submit">delete</button></div>
                    <br>
                </form>
            </div>
        @endforeach
        <div><a class="text-blue-900" href="{{ route('songs.create', $song) }}"> Create a new
                song:</a>
        </div>
    @endauth
    
    @guest
    <div>
        <P class="font-mono text-blue-600">Songs:</P>
        <br>
        @foreach ($songs as $song)
            <div>
                <form action="/songs/{{ $song->id }}" method="POST">
                    <div><a href="songs/{{ $song->id }}">{{ $song->title }}</a></div>
                    @csrf
                    <br>
                </form>
            </div>
        @endforeach
    @endguest
</body>

</html>
