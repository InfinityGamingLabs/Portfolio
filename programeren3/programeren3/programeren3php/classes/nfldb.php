<?php
    class nfldb
    {
        const DSN = "mysql:host=localhost;dbname=nfl";
        const USER = "root";
        const PASSWD = "";
           
        //Read -> returns the rows. Returns false when error
        function selectStudents(){
            try{
                $pdo = new PDO(self::DSN, self::USER, self::PASSWD);

                $statement = $pdo->prepare("SELECT * FROM teams;");

                $statement->execute();

                $rows = $statement->fetchAll(PDO::FETCH_ASSOC);
                return $rows;
            }
            catch(PDOException $e) {
                return false;
            }
        }

        function selectplayers(){
            try{
                $pdo = new PDO(self::DSN, self::USER, self::PASSWD);

                $statement = $pdo->prepare("SELECT * FROM players;");

                $statement->execute();

                $rows = $statement->fetchAll(PDO::FETCH_ASSOC);
                return $rows;
            }
            catch(PDOException $e) {
                return false;
            }
        }
    }
