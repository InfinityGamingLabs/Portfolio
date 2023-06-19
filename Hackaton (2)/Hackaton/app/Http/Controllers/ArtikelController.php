<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\Artikel;
use Carbon\Carbon;

class ArtikelController extends Controller
{
    public function index()
    {
        $artikelen = Artikel::all();
        return view('artikelen.index', ['artikelen' => $artikelen]);
    }

    /**
     * Show the form for creating a new resource.
     */
    public function create()
    {
        return view('artikelen.create');
    }

    /**
     * Store a newly created resource in storage.
     */
    public function store(Request $request)
{
    $request->validate([
        'titel'=>'required|max:100',
        'beschrijving'=>'required|max:20000',
    ]);

    $now = (new \DateTime('now', new \DateTimeZone('Europe/Amsterdam')))->format('Y-m-d H:i:s');
    Artikel::create([
        'titel' => $request->input('titel'),
        'beschrijving' => $request->input('beschrijving'),
        'created_at' => $now,
        'updated_at' => $now,
    ]);

    return redirect()->route('artikelen.index');
}

    

    /**
     * Display the specified resource.
     */
    public function show($id)
    {
        $artikel = Artikel::find($id);
        return view('artikelen.show', ['artikel' => $artikel]);
    }

    /**
     * Show the form for editing the specified resource.
     */
    public function edit($id)
    {
        $artikel = Artikel::find($id);
        return view('artikelen.edit', ['artikel' => $artikel]);
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(Request $request, string $id)
    {
        $request->validate([
            'titel'=>'required|max:100',
            'beschrijving'=>'required|max:20000',
        ]);

        Artikel::find($id)->update($request->only(['titel', 'beschrijving']));
        return redirect()->route('artikelen.index');
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy($id)
    {
        Artikel::destroy($id);
        $artikelen = Artikel::all();
        return view('artikelen.index', ['artikelen' => $artikelen]);
    }
}
