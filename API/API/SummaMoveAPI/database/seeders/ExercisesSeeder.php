<?php

namespace Database\Seeders;

use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\DB;

class ExercisesSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        DB::table('exercises')->insert([
            'name' => 'Squat',
            'duration' => '5 x 10 keer',
            'description' => 'Je zakt door je benen en gaat weer omhoog',
        ]);

        DB::table('exercises')->insert([
            'name' => 'Push-up',
            'duration' => '3 x 20 keer',
            'description' => 'Ga met je buik op de grond liggen, en druk jezelf omhoog met je armen en laat jezelf weer zakken',
        ]);

        DB::table('exercises')->insert([
            'name' => 'Dip',
            'duration' => '3 x 15 keer',
            'description' => 'Je houd met je armen een stoel vast en je drukt jezelf naar beneden en weer omhoog. Dit is een goede oefening voor je armen',
        ]);

        DB::table('exercises')->insert([
            'name' => 'Plank',
            'duration' => '3 x 60 seconden',
            'description' => 'Ga op je buik liggen en til je hele lichaam op, met alleen je tenen op de grond en je ellebogen op de grond. Houd dit een minuut vol',
        ]);

        DB::table('exercises')->insert([
            'name' => 'Paardentrap',
            'duration' => '3 x 15 keer',
            'description' => 'Ga op ellebogen en knieën op de grond liggen, met je gezicht naar de grond. Strek dan je rechterbeen naar achteren.',
        ]);

        DB::table('exercises')->insert([
            'name' => 'Mountain climber',
            'duration' => '3 x 20 keer',
            'description' => 'Begin in een hoge plank, schouders in lijn met je polsen, bekken opgetrokken en ribben naar heupen getrokken. Duw je rechterknie naar je borst en dan naar links. Trek je rechterknie naar achteren naar je borst en pauzeer. Herhaal het patroon te beginnen met de linkerknie.',
        ]);

        DB::table('exercises')->insert([
            'name' => 'Burpee',
            'duration' => '3 x 20 keer',
            'description' => 'Klap in je handen, en spring naar de push-up positie. Druk een keer op, sta weer op en herhaal dit.',
        ]);

        DB::table('exercises')->insert([
            'name' => 'Lunge',
            'duration' => '3 x 50 keer',
            'description' => 'Beurtelings met je benen vooruit stappen. Dit doe je op een verhoogde bank of traptrede.',
        ]);

        DB::table('exercises')->insert([
            'name' => 'Wall sit',
            'duration' => '3 x 20 keer',
            'description' => 'Begin staand met je rug tegen de muur. Zet je voeten iets naar voren, op schouderbreedte en zak in een squat: je knieën zijn gebogen in een hoek van 90 graden, net als je heupen. Span je buikspieren goed aan en duw je rug tegen de muur.',
        ]);

        DB::table('exercises')->insert([
            'name' => 'Crunch',
            'duration' => '3 x 20 keer',
            'description' => 'Ga liggen met de rug op de vloer, plaats de voeten plat, knieën recht omhoog gericht. Kruis de onderarmen op de borst, breng je borst naar je bekken door de buikspieren aan te spannen. Hou de spanning 1 tot 2 seconden vast. Breng de borst rustig terug naar beneden en achteren.',
        ]);
    }
}
