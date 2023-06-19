<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Artikel extends Model
{
    use HasFactory;

    public $table = "artikelen";
    protected $fillable = ['titel', 'beschrijving', 'tijd'];
}
