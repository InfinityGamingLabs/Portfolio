<?php

namespace Database\Seeders;

use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\DB;
use Illuminate\Support\Facades\Hash;
use Illuminate\Support\Str;
use Carbon\carbon;

class BandsTableSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        {
            DB::table('bands')->insert([
                'name' => 'QUEEN',
                'genre' => 'Rock',
                'founded' => '1970', 
                'created_at' => carbon::now(), 
                'updated_at' => carbon::now(), 

            ]);
        }{
            DB::table('bands')->insert([
                'name' => 'One Direction',
                'genre' => 'pop',
                'founded' => '2010', 
                'created_at' => carbon::now(), 
                'updated_at' => carbon::now(), 

            ]);
        }{
            DB::table('bands')->insert([
                'name' => 'Maroon',
                'genre' => 'pop',
                'founded' => '1997', 
                'created_at' => carbon::now(), 
                'updated_at' => carbon::now(), 

            ]);
         
    }
}
}