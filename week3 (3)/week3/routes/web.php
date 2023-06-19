<?php

use App\Http\Controllers\ProfileController;
use Illuminate\Support\Facades\Route;
use App\Http\Controllers\SongController;
use App\Http\Controllers\Albumscontroller;
use App\Http\Controllers\AlbumSongController;
use App\Http\Controllers\Bandscontroller;
use App\Http\Controllers\SongAlbumController;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', function () {
    return view('welcome');
});

Route::get('/dashboard', function () {
    return view('dashboard');
})->middleware(['auth', 'verified'])->name('dashboard'); 

Route::middleware('auth')->group(function () {
    Route::get('/profile', [ProfileController::class, 'edit'])->name('profile.edit'); // 
    Route::patch('/profile', [ProfileController::class, 'update'])->name('profile.update');
    Route::delete('/profile', [ProfileController::class, 'destroy'])->name('profile.destroy');
});

Route::resource('songs', SongController::class); 

Route::resource('Albums', Albumscontroller::class);// die zorgt dat je naar web kan 

Route::resource('bands', Bandscontroller::class); 

Route::get('/songs/{song}/albums/{album}', [SongAlbumController::class, 'store'])->name('song_album.store');// hier cop een album aan de song 
Route::delete('/songs/{song}/albums/{album}', [SongAlbumController::class, 'destroy'])->name('song_album.destroy');//

Route::get('/albums/{album}/songs/{song}', [AlbumSongController::class, 'store'])->name('album_song.store');//hier cop een songaan de album
Route::delete('/albums/{album}/songs/{song}', [AlbumSongController::class, 'destroy'])->name('album_song.destroy');


require __DIR__.'/auth.php'; 
