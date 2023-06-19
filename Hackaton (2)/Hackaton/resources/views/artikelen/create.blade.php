@extends('layouts.regular')
@section('style')
    <style>
        *{
            font-family: Calibri;
        }
        label{
            font-size: 20px;
            font-weight: bolder;
        }
        main{
            padding-left: 35px;
        }
        input{
            width: 60%;
            font-size: 15px;
        }
        textarea{
            width: 60%;
            height: 45vh;
        }
    </style>
@endsection
@section('nav')
    <a href="{{route('home')}}">Home</a>
    <a href="{{route('forums.index')}}">Forum</a>
    <a href="{{route('artikelen.index')}}">Nieuws</a>
@endsection
@section('content')
    <form action="{{route('artikelen.store')}}" method="POST">
        @csrf
        <h1>Maak een nieuwsartikel aan</h1>
        <label>Titel</label><br>
        <input type="text" name="titel" value=""><br>
        <label>Bericht</label><br>
        <textarea name="beschrijving"></textarea><br>
        <button type="submit">Voeg artikel toe</button>
    </form>
@endsection
