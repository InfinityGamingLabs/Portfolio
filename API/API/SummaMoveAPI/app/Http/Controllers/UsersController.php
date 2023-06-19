<?php

namespace App\Http\Controllers;

use App\Models\ExerciseDone;
use App\Models\User;
use Illuminate\Http\Request;
use Illuminate\Support\Carbon;
use Illuminate\Support\Str;

class UsersController extends Controller
{
    /**
     * Display a listing of the resource.
     */

    public function getExercisesByUser(string $id)
    {
        return ExerciseDone::where('user_id', $id)->get();
    }

    /**
     * Display the specified resource.
     */
    public function show(string $id)
    {
        return User::find($id);
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(Request $request, string $id)
    {
        $request->remember_token = Str::random(60);
        $request->updated_at = Carbon::now();

        $request->validate([
            'username' => 'required|max:80',
            'firstname' => 'required|max:50',
            'lastname' => 'required|max:60',
            'email' => 'required|max:90',
            'password' => 'required|max:255',
            'dateofbirth' => 'required',
        ]);
        User::find($id)->update($request->all());
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(string $id)
    {
        User::destroy($id);
    }
}
