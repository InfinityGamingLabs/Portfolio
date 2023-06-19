<?php

namespace Database\Seeders;

use Carbon\Carbon;
use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\DB;
use Illuminate\Support\Facades\Hash;
use Illuminate\Support\Str;

class UserSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        $password = 'geheim';

        DB::table('users')->insert([
            'username' => 'JorisWulms',
            'firstname' => 'Joris',
            'lastname' => 'Wulms',
            'email' => 'joris@gmail.com',
            'password' => Hash::make($password),
            'dateofbirth' => '2004-10-05',
            'remember_token' => Str::random(60),
            'created_at' => Carbon::now(),
            'updated_at' => Carbon::now(),
        ]);

        DB::table('users')->insert([
            'username' => 'RaúlZande',
            'firstname' => 'Raúl',
            'lastname' => 'van der Zande',
            'email' => 'raúl@gmail.com',
            'password' => Hash::make($password),
            'dateofbirth' => '2000-01-06',
            'remember_token' => Str::random(60),
            'created_at' => Carbon::now(),
            'updated_at' => Carbon::now(),
        ]);

        DB::table('users')->insert([
            'username' => 'MarijnSlaats',
            'firstname' => 'Marijn',
            'lastname' => 'Slaats',
            'email' => 'marijn@gmail.com',
            'password' => Hash::make($password),
            'dateofbirth' => '2003-12-04',
            'remember_token' => Str::random(60),
            'created_at' => Carbon::now(),
            'updated_at' => Carbon::now(),
        ]);
    }
}
