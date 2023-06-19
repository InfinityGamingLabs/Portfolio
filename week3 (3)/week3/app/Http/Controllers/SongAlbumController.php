<?php

namespace App\Http\Controllers;

use App\Models\Album;
use App\Models\Song;
use Illuminate\Http\Request;

class SongAlbumController extends Controller
{
    public function store(Album $album, Song $song)
    {
        $song->songs()->attach($album);
        return redirect()->route('songs.edit',[$song]);
    }
    public function destroy(Album $album, Song $song)
    {
        $song->songs()->detach($album);
        return redirect()->route('songs.edit',[$song]);
    }
}
