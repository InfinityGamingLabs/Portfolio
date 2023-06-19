<?php

namespace App\Http\Controllers;

use App\Models\Game;
use Illuminate\Support\Facades\Log;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Validator;

class GamesController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index(Request $request)
    {
        $request->user()->currentAccessToken()->delete();
        Log::info(
            'Games index',
            [
                'ip' => $request->ip(),
                'data' => $request->all()
            ]
        );

        if ($request->has('name')) {
            $data = Game::where('game_id' ,' name' ,'rating','released','description_raw','platforms','genres','developers','%' . $request->name . '%')->get();
        } else if ($request->has('sort')) {
            $data =  Game::orderBy($request->sort)->get();
        } else {
            $data = Game::all();
        }

        $response = [
            'success' => true,
            'data'    => $data,
            'access_token' => auth()->user()->createToken('API Token')->plainTextToken,
            'token_type' => 'Bearer'
        ];
        return response()->json($response, 200);
    }


    public function store(Request $request)
    {
        $request->user()->currentAccessToken()->delete();
        $response = [
            'success' => true,
            'data'    => Game::create($request->all()),
            'access_token' => auth()->user()->createToken('API Token')->plainTextToken,
            'token_type' => 'Bearer'
        ];
        return response()->json($response, 200);
    }

    public function show(Request $request, Game $game)
    {
        $request->user()->currentAccessToken()->delete();
        $response = [
            'success' => true,
            'data'    =>  $game,
            'access_token' => auth()->user()->createToken('API Token')->plainTextToken,
            'token_type' => 'Bearer'
        ];
        return response()->json($response, 200);
    }

    public function update(Request $request, Game $game)
    {
        Log::info('update Games', ['ip' => $request->ip(), 'old' => $game, 'new' => $request->all()]);

        $validator = Validator::make($request->all(), [
            'name' => 'required',
        ]);
        if ($validator->fails()) {
            Log::error("Game can not be updated");
            return response('{"Foutmelding":"Data not correct"}', 400)->header('Content-Type', 'application/json');
        }

        $request->user()->currentAccessToken()->delete();
        $game->update($request->all());
        $response = [
            'success' => true,
            'data'    =>  $game,
            'access_token' => auth()->user()->createToken('API Token')->plainTextToken,
            'token_type' => 'Bearer'
        ];
        return response()->json($response, 200);
    }

    public function destroy(Request $request, Game $game)
    {
        Log::info('delete games', ['data' => $game]);
        $request->user()->currentAccessToken()->delete();
        $game->delete();
        $response = [
            'success' => true,
            'access_token' => auth()->user()->createToken('API Token')->plainTextToken,
            'token_type' => 'Bearer'
        ];
        return response()->json($response, 200);
    }

    public function indexFunctie(Request $request, $id)
    {
        $request->user()->currentAccessToken()->delete();    // Verwijder de actuele token

        Log::info(
            'games indexFunctie',
            [
                'ip' => $request->ip(),
                'data' => $request->all(),
                'id' => $id
            ]
        );
        if ($request->has('sort')) {
            $data =  Game::where('game_id', $id)->orderBy($request->sort)->get();
        } else {
            $data = Game::where('game_id', $id)->get();
        }

        $content = [
            'success' => true,
            'data'    => $data,
            'access_token' => auth()->user()->createToken('API Token')->plainTextToken,
            'token_type' => 'Bearer',
        ];
        return response()->json($content, 200);
    }

    public function destroyFunctie(Request $request, $id)
    {
        $request->user()->currentAccessToken()->delete();    // Verwijder de actuele token

        Log::info(
            'games destroyFunctie',
            [
                'ip' => $request->ip(),
                'data' => $request->all(),
                'channel_id' => $id
            ]
        );
        Channel::where('game_id', $id)->delete();

        $content = [
            'success' => true,
            'data'    => $id,
            'access_token' => auth()->user()->createToken('API Token')->plainTextToken,
            'token_type' => 'Bearer',
        ];
        return response()->json($content, 202);
    }
}
