<?php

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;
use App\Http\Controllers\AuthenticationController;
use App\Http\Controllers\GamesController;

/*
|--------------------------------------------------------------------------
| API Routes
|--------------------------------------------------------------------------
|
| Here is where you can register API routes for your application. These
| routes are loaded by the RouteServiceProvider and all of them will
| be assigned to the "api" middleware group. Make something great!
|
*/

Route::post('/register', [AuthenticationController::class, 'register']);
    Route::post('/login', [AuthenticationController::class, 'login']);
    Route::group(['middleware' => ['auth:sanctum']], function () {
        Route::get('profile', function(Request $request) {
            return auth()->user();
        });
        Route::apiResource('games', Gamescontroller::class);
        Route::get('games/{id}', [Gamescontroller::class, 'indexFunctie']);
        Route::delete('games/{id}', [Gamescontroller::class, 'destroyFunctie']);

        Route::post('/logout', [AuthenticationController::class, 'logout']);
    });

