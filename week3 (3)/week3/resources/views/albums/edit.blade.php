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
    <form action="/Albums/{{ $Albums->id }}" method="POST">
        @csrf
        @method('PATCH')
        <label>Type the name of the albums that you want to add:</label><br><br>
        <input type="text" value="{{ $Albums->name }}" name="name"><br><br>
        <input type="text" value="{{ $Albums->year }}" name="year"><br><br>
        <input type="text" value="{{ $Albums->times_sold }}" name="time_sold"><br><br>
        <input type="text" value="{{ $Albums->band_id }}" name="band_id"><br><br>
    </form>
        <label>koppel hier een song:</label><br><br>
        @foreach ($songs as $song)
        <form action="{{ route('album_song.store', ['song' => $song->id, 'album' => $Albums->id]) }}" method="POST">
            <ul>

                <li>
                    @csrf
                    @method('GET')
                    <input type="text" name={{ $song->id }} readonly="readonly" value="{{ $song['title'] }}">
                    <button type="submit">+</button>
                </li>

            </ul>
        </form>
        @endforeach
        <label>ontkoppel hier een song:</label><br><br>

        @foreach ($Albums->songs as $song)

        <form action="{{ route('album_song.destroy', ['song' => $song->id, 'album' => $Albums->id]) }}" method="POST">
            <ul>

                <li>
                    @csrf
                    @method('DELETE')
                    <input type="text" name={{ $song->id }} readonly="readonly" value="{{ $song['title'] }}">
                    <button type="submit">x</button>
                </li>

            </ul>
        </form>
        @endforeach
        <button type="submit">Update</button>
</body>

</html>