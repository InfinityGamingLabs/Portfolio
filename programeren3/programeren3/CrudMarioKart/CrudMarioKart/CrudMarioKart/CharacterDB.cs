using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace CrudMarioKart
{
    class CharacterDB
    {
        #region fields
        MySqlConnection _connection = new MySqlConnection("Server=localhost;Database=nfl;Uid=root;Pwd=;");
        #endregion

        #region methods/functions
        public DataTable selectteams()
        {
            DataTable result = new DataTable();
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT * FROM teams;";
                MySqlDataReader reader = command.ExecuteReader();
                result.Load(reader);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }
            return result;
        }

        public bool InsertCharacter(string playerID, string name, string color, string attack, string carid)
        {
            bool succes = false;
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "INSERT INTO `teams` (`TeamID`, `naam`, `coach`, `stadion`, `opgericht`) VALUES (@TeamID, @name, @coach, @stadion, @opgericht) ";
                command.Parameters.AddWithValue("@TeamID", playerID);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@coach", color);
                command.Parameters.AddWithValue("@stadion", attack);
                command.Parameters.AddWithValue("@opgericht", carid);
                int nrOfRowsAffected = command.ExecuteNonQuery();
                succes = (nrOfRowsAffected != 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }
            return succes;
        }

        public bool UpdateCharacter(string characterid, string name, string color, string attack, string carid)
        {
            bool succes = false;
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "UPDATE `teams` SET `naam` = @name, `coach` = @coach, `stadion` = @stadion, `opgericht` = @opgericht WHERE `TeamID` = @id; ";
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@coach", color);
                command.Parameters.AddWithValue("@stadion", attack);
                command.Parameters.AddWithValue("@opgericht", carid);
                command.Parameters.AddWithValue("@id", characterid);
                int nrOfRowsAffected = command.ExecuteNonQuery();
                succes = (nrOfRowsAffected != 0);
            }
            catch (Exception)
            {
                //Problem with the database
            }
            finally
            {
                _connection.Close();
            }
            return succes;
        }

        public bool DeleteCharacter(string characterid)
        {
            bool succes = false;
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "DELETE FROM `teams` WHERE TeamID = @id;";
                command.Parameters.AddWithValue("@id", characterid);
                int nrOfRowsAffected = command.ExecuteNonQuery();
                succes = (nrOfRowsAffected != 0);
            }
            catch (Exception)
            {
                //Problem with the database
            }
            finally
            {
                _connection.Close();
            }
            return succes;
        }

        //car database

        public DataTable SelectCar()
        {
            DataTable result = new DataTable();
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT * FROM players;";
                MySqlDataReader reader = command.ExecuteReader();
                result.Load(reader);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }
            return result;
        }

        public bool InsertCar(string carid, string kart, string speed, string acceleration, string weight)
        {
            bool succes = false;
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "INSERT INTO `players` (`PlayerID`, `voornaam`, `achternaam`, `college`, `TeamID`) VALUES (@id, @voornaam, @achternaam, @college, @TeamID) ";
                command.Parameters.AddWithValue("@id", carid);
                command.Parameters.AddWithValue("@voornaam", kart);
                command.Parameters.AddWithValue("@achternaam", speed);
                command.Parameters.AddWithValue("@college", acceleration);
                command.Parameters.AddWithValue("@TeamID", weight);
                int nrOfRowsAffected = command.ExecuteNonQuery();
                succes = (nrOfRowsAffected != 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }
            return succes;
        }

        public bool UpdateCar(string carid, string kart, string speed, string acceleration, string weight)
        {
            bool succes = false;
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "UPDATE `players` SET `voornaam` = @voornaam, `achternaam` = @achternaam, `college` = @college, `TeamID` = @TeamID WHERE `PlayerID` = @PlayerID; ";
                command.Parameters.AddWithValue("@voornaam", kart);
                command.Parameters.AddWithValue("@achternaam", speed);
                command.Parameters.AddWithValue("@college", acceleration);
                command.Parameters.AddWithValue("@TeamID", weight);
                command.Parameters.AddWithValue("@PlayerID", carid);
                int nrOfRowsAffected = command.ExecuteNonQuery();
                succes = (nrOfRowsAffected != 0);
            }
            catch (Exception)
            {
                //Problem with the database
            }
            finally
            {
                _connection.Close();
            }
            return succes;
        }

        public bool DeleteCar(string carid)
        {
            bool succes = false;
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "DELETE FROM `players` WHERE `PlayerID` = @id;";
                command.Parameters.AddWithValue("@id", carid);
                int nrOfRowsAffected = command.ExecuteNonQuery();
                succes = (nrOfRowsAffected != 0);
            }
            catch (Exception)
            {
                //Problem with the database
            }
            finally
            {
                _connection.Close();
            }
            return succes;
        }
        #endregion
    }
}
