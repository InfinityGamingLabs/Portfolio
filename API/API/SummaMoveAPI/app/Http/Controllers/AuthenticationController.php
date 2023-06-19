<?php

namespace App\Http\Controllers;
use Illuminate\Support\Facades\Auth;

use Illuminate\Http\Request;
use App\Models\User;
class AuthenticationController extends Controller
{
    public function register(Request $request)
    {
        $attr = $request->validate([
            'username' => 'required|max:80',
            'firstname' => 'required|max:50',
            'lastname' => 'required|max:60',
            'email' => 'required|max:90',
            'password' => 'required|max:255',
            'dateofbirth' => 'required',
        ]);
        User::create([
            'username' => $attr['username'],
            'firstname' => $attr['firstname'],
            'lastname' => $attr['lastname'],
            'email' => $attr['email'],
            'password' => bcrypt($attr['password']),
            'dateofbirth' => $attr['dateofbirth'],
        ]);
        return response()->json(['message' => 'Registration successful'], 200);
    }
    public function login(Request $request)
    {
        $attr = $request->validate([
            'email' => 'required|email',
            'password' => 'required'
        ]);

        if (!Auth::attempt($attr)) {
            return response()->json(['message' => 'Credentials not match'], 401);
        }
        $response = [
            'access_token' => auth()->user()->createToken('API Token')->plainTextToken,
            'token_type' => 'Bearer',
            'id' => auth()->user()->id
        ];
        return response()->json($response, 200);
    }
    public function logout()
    {
        auth()->user()->tokens()->delete();
        return response()->json(['message' => 'Tokens Revoked'], 200);
    }
}
