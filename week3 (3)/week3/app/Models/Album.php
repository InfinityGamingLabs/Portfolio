<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Album extends Model
{
    use HasFactory;
    protected $fillable = ['name', 'year','times_sold'];

    public function songs()
    {
        return $this->belongsToMany(Song::class);
    }


    public function band()
    {
        return $this->belongsTo(Band::class);
    }
}
