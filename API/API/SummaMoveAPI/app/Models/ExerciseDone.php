<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class ExerciseDone extends Model
{
    use HasFactory;
    protected $table = 'exercises_done';
    protected $fillable = ['user_id', 'exercise_id', 'count'];
}
