<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="X-UA-Compatible" content="ie=edge">
        <title>Document</title>
    </head>
    <body>
        <h2>Add a song:</h2>
        <form action="{{route('songs.store')}}" method="POST"> 
            @csrf
            <label>Type the name of the song that you want to add:</label><br><br>
            <label>Title:</label>
            <input type="text" name="title"><br><br>
            <label>SInger:</label>
            <input type="text" name="singer"><br><br>
            
            <input type="submit" value="Add song">
            
        </form>
        <div>

            <h1>Zoek een song via de API</h1><br>
                <form action="{{ route('songs.create') }}" method="GET">
                <label for="title">Zoek op song title:</label>
                <input type="text" name="title" id="title"><br><br>
                <button class="bg-blue-500 hover:bg-gray-400 text-gray-900 font-bold py-1.5 px-3 rounded-l" type="submit">Zoek</button>
            </form>
            <br>
    
            @foreach ($songsFromAPI as $song)
                <form action="/songs" method="POST">
                    @csrf
                    <input type="text" name="title" readonly="readonly" value="{{ $song['name'] }}">
                    <input type="text" name="singer" readonly="readonly" value="{{ $song['artist'] }}">
                    <button type="submit">+</button>
                </form>
            @endforeach
                
        </div>
    </body>
</html>


{{--een formulier zorgt dat de gegevenis die je in een formulier zet dat hij die tijdelijk opslaat of oplsaat op de plek die je hebt aangegeven}}































        {{-- Leg mij een keer uit hoe een form request achter de schermen werkt --}}
