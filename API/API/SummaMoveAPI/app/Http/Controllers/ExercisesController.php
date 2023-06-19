<?php

namespace App\Http\Controllers;

use App\Models\Exercise;
use Carbon\Carbon;
use Illuminate\Http\Request;

class ExercisesController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index()
    {
        return Exercise::all();
    }

    /**
     * Store a newly created resource in storage.
     */
    public function store(Request $request)
    {
        $request->validate([
            'name' => 'required|max:40',
            'duration' => 'required|max:40',
            'description' => 'required'
        ]);
        Exercise::create($request->all());
    }

    /**
     * Display the specified resource.
     */
    public function show(string $id)
    {
        return Exercise::find($id);
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(Request $request, string $id)
    {
        $request->validate([
            'name' => 'required|max:40',
            'duration' => 'required|max:40',
            'description' => 'required'
        ]);
        Exercise::find($id)->update($request->all());
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(string $id)
    {
        Exercise::destroy($id);
    }
}
