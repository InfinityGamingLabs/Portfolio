using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eindopdracht.Models
{
    public class landenDB
    {
        public static string ok = "ok";
        public static string methodResult = "unknown";
        public static string NOTFOUND = "NOTFOUND";



        private string connString =
        ConfigurationManager.ConnectionStrings["Lj2Dd1En2Conn"].ConnectionString;


        public string GetPeople(ICollection<persons> people)
        {
            if (people == null)
            {
                throw new ArgumentException("Ongeldig argument bij gebruik van GetMeals");
            }

            using (MySqlConnection conn = new(connString))
            {
                try
                {
                    conn.Open(); MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"SELECT * FROM persons;";
                    MySqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        persons person = new persons()
                        {
                            PersonId = (int)reader["PersonId"],
                            Name = (string)reader["Name"],
                        }; people.Add(person);


                    }
                    methodResult = "ok";

                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(GetPeople)); Console.Error.WriteLine(e.Message); methodResult = e.Message;
                }
            }
            return methodResult;
        }

        public string CreatePeople(persons person)
        {
            if (person == null || string.IsNullOrEmpty(person.Name))
            {
                throw new ArgumentException("Ongeldig argument bij gebruik van CreateIngredient");
            }

            string methodResult = "unknown";

            using (MySqlConnection conn = new(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"
                     INSERT INTO persons
                    (PersonId, Name)
                     VALUES (NULL, @Name);";
                    sql.Parameters.AddWithValue("@Name", person.Name);
                    if (sql.ExecuteNonQuery() == 1)
                    {
                        methodResult = ok;
                    }
                    else
                    {
                        methodResult = $"Ingrediënt {person.Name} kon niet toegevoegd worden.";
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(CreatePeople));
                    Console.Error.WriteLine(e.Message);
                    methodResult = e.Message;
                }
            }
            return methodResult;

        }








        public string UpdatePeople(int PersonId, persons person)
        {
            if (person == null || string.IsNullOrEmpty(person.Name))
            {
                throw new ArgumentException("Ongeldig argument bij gebruik van UpdateIngredient");
            }
            string methodResult = "unknown";
            using (MySqlConnection conn = new(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"
                UPDATE Persons
                SET Name = @Name
                WHERE PersonId = @PersonId";

                    sql.Parameters.AddWithValue("@PersonId", PersonId);
                    sql.Parameters.AddWithValue("@Name", person.Name);
                    if (sql.ExecuteNonQuery() == 1)
                    {
                        methodResult = ok;
                    }
                    else
                    {
                        methodResult = $"Ingrediënt {person.Name} kon niet gewijzigd worden.";
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(UpdatePeople));
                    Console.Error.WriteLine(e.Message);
                    methodResult = e.Message;
                }
            }
            return methodResult;
        }


















        public string DeletePeople(int PersonId)
        {
            string methodResult = "unknown";
            using (MySqlConnection conn = new(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"
                    DELETE
                    FROM Persons
                    WHERE PersonId = @PersonId";

                    sql.Parameters.AddWithValue("@PersonId", PersonId);
                    if (sql.ExecuteNonQuery() == 1)
                    {
                        methodResult = ok;
                    }
                    else
                    {
                        methodResult = $"Ingredient met id {PersonId} kon niet verwijderd worden.";
                    }
                }
                catch (Exception e)
                {

                    Console.Error.WriteLine(nameof(DeletePeople));
                    Console.Error.WriteLine(e.Message);
                    methodResult = e.Message;
                }
            }
            return methodResult;
        }

        public string GetCountry(ICollection<countries> country)
        {
            if (country == null)
            {
                throw new ArgumentException("Ongeldig argument bij gebruik van GetIngredients");
            }
            string methodResult = "unknown";

            using (MySqlConnection conn = new(connString))
            {
                try
                {
                    conn.Open(); MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"SELECT * FROM `countries`";
                    MySqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        countries unit = new countries()
                        {
                            CountryId = (int)reader["countryId"],
                            Country = (string)reader["Country"],
                        }; country.Add(unit);


                    }
                    methodResult = "ok";

                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(GetCountry)); Console.Error.WriteLine(e.Message); methodResult = e.Message;
                }
            }
            return methodResult;
          }

        public string CreateCountry(countries country)
        {
            if (country == null || string.IsNullOrEmpty(country.Country))
            {
                throw new ArgumentException("Ongeldig argument bij gebruik van CreateIngredient");
            }

            string methodResult = "unknown";

            using (MySqlConnection conn = new(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"
                     INSERT INTO countries
                    (CountryId, Country)
                     VALUES (NULL, @Name);";
                    sql.Parameters.AddWithValue("@Country", country.Country);
                    if (sql.ExecuteNonQuery() == 1)
                    {
                        methodResult = ok;
                    }
                    else
                    {
                        methodResult = $"Ingrediënt {country.Country} kon niet toegevoegd worden.";
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(CreateCountry));
                    Console.Error.WriteLine(e.Message);
                    methodResult = e.Message;
                }
            }
            return methodResult;

        }








        public string UpdateCountry(int CountryId, countries country)
        {
            if (country == null || string.IsNullOrEmpty(country.Country))
            {
                throw new ArgumentException("Ongeldig argument bij gebruik van UpdateIngredient");
            }
            string methodResult = "unknown";
            using (MySqlConnection conn = new(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"
                UPDATE countries
                SET Country = @Country
                WHERE CountryId = @CountryId";

                    sql.Parameters.AddWithValue("@CountryId", CountryId);
                    sql.Parameters.AddWithValue("@Country", country.Country);
                    if (sql.ExecuteNonQuery() == 1)
                    {
                        methodResult = ok;
                    }
                    else
                    {
                        methodResult = $"Ingrediënt {country.Country} kon niet gewijzigd worden.";
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(UpdatePeople));
                    Console.Error.WriteLine(e.Message);
                    methodResult = e.Message;
                }
            }
            return methodResult;
        }


















        public string DeleteCountry(int CountryId)
        {
            string methodResult = "unknown";
            using (MySqlConnection conn = new(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"
                    DELETE
                    FROM countries
                    WHERE CountryId = @CountryId";

                    sql.Parameters.AddWithValue("@CountryId", CountryId);
                    if (sql.ExecuteNonQuery() == 1)
                    {
                        methodResult = ok;
                    }
                    else
                    {
                        methodResult = $"Ingredient met id {CountryId} kon niet verwijderd worden.";
                    }
                }
                catch (Exception e)
                {

                    Console.Error.WriteLine(nameof(DeleteCountry));
                    Console.Error.WriteLine(e.Message);
                    methodResult = e.Message;
                }
            }
            return methodResult;
        }
    }
}
