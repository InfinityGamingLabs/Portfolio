<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class album_song extends Model
{
    use HasFactory;

    
    /** The attributes that arent mass assignable.
     *
     * @var array<string>|bool
     */
    protected $fillable = ['album_id', 'song_id'];

    public $timestamps = false;




    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = "album_song";
}
