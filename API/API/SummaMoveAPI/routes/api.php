<?php

use App\Http\Controllers\AuthenticationController;
use App\Http\Controllers\ExercisesController;
use App\Http\Controllers\ExercisesDoneController;
use App\Http\Controllers\UsersController;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| API Routes
|--------------------------------------------------------------------------
|
| Here is where you can register API routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| is assigned the "api" middleware group. Enjoy building your API!
|
*/

Route::middleware(['auth:sanctum'])->get('/user', function (Request $request) {
    return $request->user();
});

Route::get('exercises', [ExercisesController::class, 'index']);
Route::get('exercises/{id}', [ExercisesController::class, 'show']);

Route::post('/register', [AuthenticationController::class, 'register']);
Route::post('/login', [AuthenticationController::class, 'login']);

Route::group(['middleware' => ['auth:sanctum']], function () {
    Route::post('exercises', [ExercisesController::class, 'store']);
    Route::put('exercises/{id}', [ExercisesController::class, 'update']);
    Route::delete('exercises/{id}', [ExercisesController::class, 'destroy']);

    Route::get('users/{id}/exercises', [UsersController::class, 'getExercisesByUser']);
    Route::get('users/{id}', [UsersController::class, 'show']);
    //There is no post request for users, because in the register route, they will be saved in the database
    Route::put('users/{id}', [UsersController::class, 'update']);
    Route::delete('users/{id}', [UsersController::class, 'destroy']);

    Route::get('exercisesdone/{id}', [ExercisesDoneController::class, 'show']);
    Route::post('exercisesdone', [ExercisesDoneController::class, 'store']);
    Route::put('exercisesdone/{id}', [ExercisesDoneController::class, 'update']);
    Route::delete('exercisesdone/{id}', [ExercisesDoneController::class, 'destroy']);
});

