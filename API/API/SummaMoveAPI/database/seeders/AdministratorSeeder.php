<?php

namespace Database\Seeders;

use Carbon\Carbon;
use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\DB;
use Illuminate\Support\Facades\Hash;
use Illuminate\Support\Str;
use Illuminate\Testing\Fluent\Concerns\Has;

class AdministratorSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        $password = 'geheim';
        $hashed = Hash::make($password);

        DB::table('administrators')->insert([
            'username' => 'admin',
            'firstname' => 'Admin',
            'lastname' => 'Administrator',
            'email' => 'admin@example.com',
            'password' => $hashed,
            'dateofbirth' => '1992-01-01',
            'remember_token' => Str::random(60),
            'created_at' => Carbon::now(),
            'updated_at' => Carbon::now(),
        ]);
    }
}
