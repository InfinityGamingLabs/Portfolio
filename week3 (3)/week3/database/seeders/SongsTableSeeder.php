<?php

namespace Database\Seeders;

use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\DB;
use Illuminate\Support\Facades\Hash;
use Illuminate\Support\Str;

class SongsTableSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        {
            DB::table('songs')->insert([
                'title' => 'Living on a prayer',
                'singer' => 'Bon Jovi',
            ]);
        }

        {
            DB::table('songs')->insert([
                'title' => 'Nothing else matters',
                'singer' => 'Metallicia',
            ]);
        }

        {
            DB::table('songs')->insert([
                'title' => 'Thunderstruck',
                'singer' => 'AC/DC',
            ]);
        }

        {
            DB::table('songs')->insert([
                'title' => 'Back in black',
                'singer' => 'AC/DC',
            ]);
        }

        {
            DB::table('songs')->insert([
                'title' => 'Ace of spades',
                'singer' => 'Motorhead',
            ]);
        }
 
    }
}
