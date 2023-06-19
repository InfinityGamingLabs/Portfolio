<?php

namespace App\Http\Controllers;

use App\Models\ExerciseDone;
use Carbon\Carbon;
use Illuminate\Http\Request;

class ExercisesDoneController extends Controller
{
    /**
     * Store a newly created resource in storage.
     */
    public function store(Request $request)
    {
        $request->created_at = Carbon::now();
        $request->updated_at = Carbon::now();

        $request->validate([
            'user_id' => 'required',
            'exercise_id' => 'required',
        ]);
        ExerciseDone::create($request->all());
    }

    /**
     * Display the specified resource.
     */
    public function show(string $id)
    {
        return ExerciseDone::find($id);
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(Request $request, string $id)
    {
        $request->updated_at = Carbon::now();

        $request->validate([
            'user_id' => 'required',
            'exercise_id' => 'required',
        ]);
        ExerciseDone::find($id)->update($request->all());
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(string $id)
    {
        ExerciseDone::destroy($id);
    }
}
