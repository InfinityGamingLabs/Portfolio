<?php

namespace Database\Seeders;

use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\DB;
use Illuminate\Support\Facades\Hash;
use Illuminate\Support\Str;

class AlbumsTableSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        {
            DB::table('albums')->insert([
                'name' => 'voor het kiezen',
                'year' => '2022',
                'times_sold' => '195.902',
                'band_id' => '1',

            ]);
        }

        {
            DB::table('albums')->insert([
                'name' => 'Alleen',
                'year' => '2017',
                'times_sold' => '194.302',
                'band_id' => '1',
            ]);
        }

        {
            DB::table('albums')->insert([
                'name' => 'Gewoon Boef',
                'year' => '2016',
                'times_sold' => '194.301', 
                'band_id' => '2',
            ]);
        }
        {
            DB::table('albums')->insert([
                'name' => 'Lares',
                'year' => '2021',
                'times_sold' => '194.201', 
                'band_id' => '2',
            ]);
        }
        {
            DB::table('albums')->insert([
                'name' => 'Breezy',
                'year' => '2022',
                'times_sold' => '194.101', 
                'band_id' => '2',
            ]);
        }
    }
}
