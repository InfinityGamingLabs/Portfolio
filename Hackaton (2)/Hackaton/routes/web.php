<?php

use App\Http\Controllers\ReactiesController;
use App\Http\Controllers\ForumsController;
use App\Http\Controllers\ArtikelController;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider and all of them will
| be assigned to the "web" middleware group. Make something great!
|
*/

Route::get('/', [ForumsController::class, 'home'])->name('home');

Route::resource('forums', ForumsController::class)->only(['index', 'show', 'create', 'store', 'update']);

Route::resource('reacties', ReactiesController::class)->parameters(['reacties' => 'reactie'])->only(['show', 'store', 'update']);

Route::resource('artikelen', ArtikelController::class)->parameters(['artikelen' => 'artikel'])->only(['index', 'create', 'show', 'store','edit','update']);
