@extends('layouts.regular')
@section('style')
<style>
        *{
            font-family: Calibri;
        }
        .nieuwscontainer h1 {
  font-size: 2.5rem;
}
        .buttons{
            display: flex;
        }
        main{
            padding: 0 10px;
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
            padding: 10px 20px;
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
            display: flex;
            flex-direction: column;
            align-items: center;
        }
        .nieuwsbericht{
            width: 100%;
            margin-bottom: 30px;
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
            display: none;
        }
        .titelsartikel{
            display: flex;
            flex-direction: row;
            justify-content: space-between;
            align-items: center;
            margin-bottom: 10px;
        }

        /* Media Queries */
        @media screen and (min-width: 600px) {
          .nieuwscontainer {
            display: grid;
            grid-template-columns: 44% 6% 44%;
            align-items: flex-start;
          }
          .nieuwsbericht {
            margin: 0;
          }
          #line {
            display: block;
          }
          .titelsartikel {
            margin-bottom: 0;
          }
        }
        @media screen and (min-width: 768px) {
          main {
            padding: 0 50px;
          }
          .nieuwscontainer {
            grid-template-columns: repeat(3, 1fr);
          }
        }
</style>
@endsection
@section('nav')
    <a href="{{route('home')}}">Home</a>
    <a href="{{route('forums.index')}}">Forum</a>
    <a href="{{route('artikelen.index')}}">Nieuws</a>
@endsection
@section('content')
    <h1>Nieuws</h1>
    <button class="nieuwartikel"><a href="{{route('artikelen.create')}}">Schrijf een artikel</a></button>
    <br><br>
    <div class="nieuwscontainer">
        <div id="line"></div>
        <?php
        $rowNr = 1;
        ?>
    @foreach($artikelen as $artikel)
        <div style="grid-column: {{$rowNr}};" class="nieuwsbericht">
            <div class="titelsartikel">
                <h3 class="titleNews">{{$artikel->titel}}</h3>
                <p class="tijd">{{date('d-m-Y H:i', strtotime($artikel->created_at))}}</p>
            </div>
            <p class="beschrijvingNews">{{$artikel->beschrijving}}</p>
            <div class="buttons">
                <button class="leesartikelBT"><a href="{{route('artikelen.show', ['artikel' => $artikel->id])}}">Lees artikel</a></button>
                <button class="editartikelBT"><a href="{{route('artikelen.edit', ['artikel' => $artikel->id])}}">bewerken artikel</a></button>
            </div>
            <hr>
                <?php
                if($rowNr == 1)
                {
                    $rowNr = 3;
                }
                else
                {
                    $rowNr = 1;
                }
                ?>
        </div>
    @endforeach
    </div>
@endsection
