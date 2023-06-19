<?php

namespace App\Http\Controllers;
use App\Models\Band;
use App\Models\Album;
use Illuminate\Http\Request;

class Bandscontroller extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $Bands = Band::all();
        return view('bands.index', ['bands' => $Bands]); //all bands die je ophaalt in de databse zet hij hier in je index pagina
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        //
        return view('bands.create');
        return redirect()->route('bands.index'); // hier gaat die naar de cr pagi gaat en dat dat die van dr cr pagi naar die index 
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
        Band::create([
            'name' => $request->name,
            'genre' => $request->genre,
            'founded' => $request->founded

        ]);
        return redirect()->route('bands.index');
    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        $band = Band::find($id);
        $albums = $band->Album;
        return view('bands.show',['bands' => $band, 'albums' => $albums]);
        //
       // als je op albums klikt dan laat alle gegevenis zien van albums in een andere pagi
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function edit($id)
    {
        //
        $bands = Band::find($id);
        return view('bands.edit', ['bands' => $bands]);// 
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
        //
        $validated = $request->validate([ // 
            'name' => 'required|max:255',
            'genre' => 'max:255',
            'founded' => 'max:4',

        ]);

        Band::find($id)->update($request->only(['name', 'genre','founded']));// hier zorgt die dat upd
        return redirect()->route('bands.index');
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        //
        $bands = Band::find($id);//
        $bands->delete();
        // $song =

        return redirect()->route('bands.index');
    }
}
