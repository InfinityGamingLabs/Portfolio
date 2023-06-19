@extends('layouts.regular')
@section('style')
<style>
        *{
            font-family: Calibri;
        }
        .buttons{
            display: flex;
        }
        main{
            padding-left: 35px;
        }
        .titleNews{
            padding-left: 10px;
        }
        .tijd{
            font-weight: bold;
        }
        .titleNews, .tijd{
            margin: 0;
        }
        .beschrijvingNews{
            padding-left: 10px;
            margin: 0;
            margin-bottom: 15px;
        }
        .leesartikelBT,.editartikelBT{
            margin-left: 10px;
            color: white;
            border-radius: 40px;
            font-size: 20px;
            font-weight: bold;
            padding-left: 20px;
            padding-right: 20px;
            border: none;
            cursor: pointer;
        }
        .leesartikelBT{
            background-color: blue;
        }

        .editartikelBT{
            background-color: orange;
        }

        .nieuwscontainer{
            display: grid;
            grid-template-columns: 44% 6% 44%;
        }
        .nieuwsbericht{
            width: 100%;
        }
        .nieuwartikel{
            background-color: green;
            border-radius: 40px;
            width: 150px;
            cursor: pointer;
        }
        button>a{
            color: white;
        }
        #line{
            grid-column: 2;
            background: gray;
            width: 2px;
            height: 100%;
            grid-row-start: 1;
            grid-row-end: 15;
            margin: 10px auto;
        }
        .titelsartikel{
            display: flex;
            flex-direction: row;
            justify-content: space-between;
        }
        textarea{
            width: 400px;
            height: 220px;
        }
        input{
            width: 400px;
        }
    </style>
@endsection
@section('nav')
    <a href="{{route('home')}}">Home</a>
    <a href="{{route('forums.index')}}">Forum</a>
    <a href="{{route('artikelen.index')}}">Nieuws</a>
@endsection
@section('content')
<form action="{{route('artikelen.update',  ['artikel' => $artikel->id])}}" method="POST">
        @csrf
        @method('PUT')
        <h1>Maak een nieuwsartikel aan</h1>
        <label>Titel</label><br>
        <input type="text" name="titel" value="{{$artikel->titel}}"><br>
        <label>Bericht</label><br>
        <textarea name="beschrijving">{{$artikel->beschrijving}}</textarea><br>
        <button type="submit">artikel aanpassen</button>
    </form>

@endsection
