<?php

namespace App\Http\Controllers;
use App\Models\Album;
use App\Models\Song;
use App\Models\Band;
use App\Models\song_album;
use App\Models\album_song;
use Illuminate\Http\Request;

class Albumscontroller extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $Albums = Album::all();
        return view('Albums.index', ['Albums' => $Albums]); //all albums die je ophaalt in de databse zet hij hier in je index pagina
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        //
        return view('Albums.create');
        return redirect()->route('Albums.index'); // hier gaat die naar de cr pagi gaat en dat dat die van dr cr pagi naar die index 
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
        Album::create([
            'name' => $request->name,
            'year' => $request->year,
            'times_sold' => $request->times_sold,
            'band_id' => $request->band_id
        ]);
        return redirect()->route('Albums.index');
    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        $album = Album::find($id);
        $bands = Band::all();
        $band = $bands[$album->band_id-1];
        return view('albums.show', compact('album', 'band'));
       // als je op albums klikt dan laat alle gegevenis zien van albums in een andere pagi
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function edit($id)
    {
        //
        $albums = Album::find($id);
        $songs = Song::all();
        return view('Albums.edit', ['Albums' => $albums ,'songs' => $songs]);// 
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function update(Request $request, $id)
    {
        //
        $validated = $request->validate([ // 
            'name' => 'required|max:255',
            'year' => 'max:4',
            'time_sold' => 'max:11',

        ]);

        Album::find($id)->update($request->only(['name', 'year','time_sold']));// hier zorgt die dat upd
        if($request->song_id != null)
        {
            $songalbum = new song_album(['song_id' => $request->song_id, 'album_id' => $id]);
            $songalbum->save();
        }
        return redirect()->route('Albums.index');
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        //
        $albums = Album::find($id);//
        $albums->delete();
        // $song =

        return redirect()->route('Albums.index');
    }
}
