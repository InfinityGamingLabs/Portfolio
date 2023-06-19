<?php

namespace App\Http\Controllers;

use App\Models\Song;
use App\Models\album_song;
use App\Models\album;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Http;

class Songcontroller extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        // $songs = ['Living on a prayer', 'Nothing else matters', 'Thunderstruck', 'Back in black', 'Ace of spades'];
        $song = Song::all();
        return view('songs.index', ['songs' => $song]);
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create(Request $request)
    {
        $songsFromAPI = [];
        if ($request->query->has('title')) {
            $api_key = '5d83d3a8f6baa5062c4bab238335ae1b';
            $title = $request->query('title');
            $response = Http::get('http://ws.audioscrobbler.com/2.0/?method=track.search&track=' . $title . '&api_key=' . $api_key . '&format=json')->json();
            $songsFromAPI = $response["results"]["trackmatches"]["track"];
        }
    
        return view('songs.create', ['songsFromAPI' => $songsFromAPI]);
        // return view('songs.create');
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
        Song::create([
            'title' => $request->title,
            'singer' => $request->singer
        ]);
        return redirect()->route('songs.index');
        // return $request;
    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        // if($id == 0){
        //     $id = 1;
        // }
        // $songs = ['Living on a prayer', 'Nothing else matters', 'Thunderstruck', 'Back in black', 'Ace of spades'];
        $song = Song::find($id);
        return view('songs.show', ['songs' => $song]);
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function edit($id)
    {
        // if($id == 0){
        //     $id = 1;
        // }
        // $songs = ['Living on a prayer', 'Nothing else matters', 'Thunderstruck', 'Back in black', 'Ace of spades'];
        $albums = album::all();
        $song = Song::find($id);
        return view('songs.edit', ['songs' => $song, 'albums' => $albums]);
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
        $validated = $request->validate([
            'title' => 'required|max:100',
            'singer' => 'max:50',
        ]);


        Song::find($id)->update($request->only(['title', 'singer']));
        if($request->album_id != null)
        {
            $albumsong = new Album_Song(['album_id' => $request->album_id, 'song_id' => $id]);
            $albumsong->save();
        }
        return redirect()->route('songs.index');
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        $songs = song::find($id);
        $songs->delete();
        // $song =

        return redirect()->route('songs.index');
    }
}
