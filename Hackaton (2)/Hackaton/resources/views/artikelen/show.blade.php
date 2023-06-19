@extends('layouts.regular')
@section('style')
    <style>
        *{
            font-family: Calibri;
        }
        h1, p{
            padding-left: 20px;
        }
    </style>
@endsection
@section('nav')
    <a href="{{route('home')}}">Home</a>
    <a href="{{route('forums.index')}}">Forum</a>
    <a href="{{route('artikelen.index')}}">Nieuws</a>
@endsection
@section('content')
    <h1>{{$artikel->titel}}</h1>
    <p>{{$artikel->beschrijving}}</p>
@endsection
