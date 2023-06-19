using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace project4.classes
{
    class Pizzadb
    {
        public static string ok = "ok"; 
        public static string methodResult = "unknown";
        public static string NOTFOUND = "NOTFOUND";
        public string totaalprijs = "SELECT SUM(price) FROM pizza_orders";

        private static string connString =
       ConfigurationManager.ConnectionStrings["project4"].ConnectionString;


    public string GetPizzas(ICollection<Pizza> Pizzas)
        {
            if (Pizzas == null)
            {
                throw new ArgumentException("Ongeldig argument bij gebruik van GetPizzas");
            }

            using (MySqlConnection conn = new(connString))
            {
                try
                {
                    conn.Open(); MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"SELECT * FROM pizza";
                    MySqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        Pizza pizza = new Pizza()
                        {
                            pizza_Id = (int)reader["pizza_id"],
                            Name = (string)reader["Name"],
                            Prijs = (int)reader["Prijs"],
                            Aantal = (int)reader["Aantal"],



                        }; Pizzas.Add(pizza);
                    }
                    methodResult = "ok";

                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(GetPizzas)); Console.Error.WriteLine(e.Message); methodResult = e.Message;
                }
            }
            return methodResult;
        }

        public string GetPizzaOrders(ICollection<PizzaOrder> orders)
        {
            if (orders == null)
            {
                throw new ArgumentException("Invalid argument in GetPizzaOrders");
            }

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"SELECT * FROM pizza_orders";
                    MySqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        PizzaOrder order = new PizzaOrder()
                        {
                            OrderId = (int)reader["OrderID"],
                            Name = (string)reader["Name"],
                            Street = (string)reader["Street"],
                            Town = (string)reader["Town"],
                            HouseNumber = (int)reader["HouseNumber"],
                            addition = (string)reader["addition"],
                            PizzaType = (string)reader["PizzaType"],
                            Toppings = (string)reader["toppings"],
                            KlantId = (int)reader["KlantId"],
                            Price = (int)reader["Price"],
                        };
                        orders.Add(order);
                    }
                    return "ok";
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(GetPizzaOrders));
                    Console.Error.WriteLine(e.Message);
                    return e.Message;
                }
            }
        }

        public static string GetPizzaOrdersByKlantId(ICollection<PizzaOrder> orders, int klantId)
        {
            if (orders == null)
            {
                throw new ArgumentException("Invalid argument in GetPizzaOrdersByKlantId");
            }

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"SELECT * FROM pizza_orders WHERE KlantId=@klantId";
                    sql.Parameters.AddWithValue("@klantId", klantId);
                    MySqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        PizzaOrder order = new PizzaOrder()
                        {
                            OrderId = (int)reader["OrderID"],
                            Name = (string)reader["Name"],
                            Street = (string)reader["Street"],
                            Town = (string)reader["Town"],
                            HouseNumber = (int)reader["HouseNumber"],
                            addition = (string)reader["addition"],
                            PizzaType = (string)reader["PizzaType"],
                            Toppings = (string)reader["toppings"],
                            Price = (int)reader["Price"],
                            KlantId = (int)reader["KlantId"],
                        };
                        orders.Add(order);
                    }
                    return "ok";
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(GetPizzaOrdersByKlantId));
                    Console.Error.WriteLine(e.Message);
                    return e.Message;
                }
            }
        }

        public static void CancelPizzaOrder(int orderId)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"DELETE FROM pizza_orders WHERE OrderID=@orderId";
                    sql.Parameters.AddWithValue("@orderId", orderId);
                    int rowsAffected = sql.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        throw new Exception("Order not found");
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(CancelPizzaOrder));
                    Console.Error.WriteLine(e.Message);
                }
            }
        }

        public string GetToppings(ICollection<Toppings> toppings)
        {
            if (toppings == null)
            {
                throw new ArgumentException("Ongeldig argument bij gebruik van GetPizzas");
            }

            using (MySqlConnection conn = new(connString))
            {
                try
                {
                    conn.Open(); MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"SELECT * FROM toppings";
                    MySqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        Toppings topping = new Toppings()
                        {
                            Toppings_id = (int)reader["Toppings_id"],
                            Name = (string)reader["Name"],
                            Prijs = (decimal)reader["Prijs"],
                            Aantal = (int)reader["Aantal"],



                        }; toppings.Add(topping);
                    }
                    methodResult = "ok";

                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(GetToppings)); Console.Error.WriteLine(e.Message); methodResult = e.Message;
                }
            }
            return methodResult;
        }

        public string CreatePizzas(Pizza Pizza)
        {
            if (Pizza == null)

            {
                throw new ArgumentException("Ongeldig argument bij gebruik van CreatePizzas");
            }

            string methodResult = "unknown";

            using (MySqlConnection conn = new(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"
                     INSERT INTO pizza
                    (pizza_Id, Name, Prijs,aantal)
                     VALUES (NULL, @Name, @prijs , @aantal);";
                    sql.Parameters.AddWithValue("@Name", Pizza.Name);
                    sql.Parameters.AddWithValue("@prijs", Pizza.Prijs);
                    sql.Parameters.AddWithValue("@aantal", Pizza.Aantal);

                    if (sql.ExecuteNonQuery() == 1)
                    {
                        methodResult = ok;
                    }
                    else
                    {
                        methodResult = $"Naam {Pizza.Name} kon niet toegevoegd worden.";
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(CreatePizzas));
                    Console.Error.WriteLine(e.Message);
                    methodResult = e.Message;
                }
            }
            return methodResult;

        }

        public string CreateToppings(Toppings toppings)
        {
            if (toppings == null)

            {
                throw new ArgumentException("Ongeldig argument bij gebruik van CreatePizzas");
            }

            string methodResult = "unknown";

            using (MySqlConnection conn = new(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"
                     INSERT INTO toppings
                    (Toppings_id, Name, Prijs,aantal)
                     VALUES (NULL, @Name, @prijs , @aantal);";
                    sql.Parameters.AddWithValue("@Name", toppings.Name);
                    sql.Parameters.AddWithValue("@prijs", toppings.Prijs);
                    sql.Parameters.AddWithValue("@aantal", toppings.Aantal);

                    if (sql.ExecuteNonQuery() == 1)
                    {
                        methodResult = ok;
                    }
                    else
                    {
                        methodResult = $"Naam {toppings.Name} kon niet toegevoegd worden.";
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(CreatePizzas));
                    Console.Error.WriteLine(e.Message);
                    methodResult = e.Message;
                }
            }
            return methodResult;

        }

        public string CreatePizzaOrder(PizzaOrder order)
        {
            if (order == null)
            {
                throw new ArgumentException("Invalid argument when using CreatePizzaOrder");
            }

            string methodResult = "unknown";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"
            INSERT INTO `pizza_orders`(`OrderID`,`Name`, `Street`, `Town`, `HouseNumber`, `addition`,`PizzaType`, `Toppings`, `Price`,`KlantId`) 
             VALUES (NULL,@Name,@Street,@Town,@HouseNumber,@Addition,@PizzaType,@Toppings,15,@klantid)";
                    sql.Parameters.AddWithValue("@Name", order.Name);
                    sql.Parameters.AddWithValue("@Street", order.Street);
                    sql.Parameters.AddWithValue("@Town", order.Town);
                    sql.Parameters.AddWithValue("@HouseNumber", order.HouseNumber);
                    sql.Parameters.AddWithValue("@Addition", order.addition ?? "");
                    sql.Parameters.AddWithValue("@PizzaType", order.PizzaType);
                    sql.Parameters.AddWithValue("@Toppings", order.Toppings);
                    sql.Parameters.AddWithValue("@klantid", order.KlantId);

                    if (sql.ExecuteNonQuery() == 1)
                    {
                        methodResult = "ok";
                    }
                    else
                    {
                        methodResult = "The order could not be added.";
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(CreatePizzaOrder));
                    Console.Error.WriteLine(e.Message);
                    methodResult = e.Message;
                }
            }
            return methodResult;
        }


        public string Updatepizza(int pizza_Id, Pizza Pizza)
        {
            if (Pizza == null || string.IsNullOrEmpty(Pizza.Name))

            {
                throw new ArgumentException("Ongeldig argument bij gebruik van UpdateNaam");
            }
            string methodResult = "unknown";
            using (MySqlConnection conn = new(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"
                       UPDATE 
                      `pizza` 
                       SET `Name`=@Naam,`Prijs`=@Prijs,`aantal`=@aantal 
                       WHERE `pizza_id` = @Pizza_id;";

                    sql.Parameters.AddWithValue("@Pizza_id", pizza_Id);
                    sql.Parameters.AddWithValue("@Naam", Pizza.Name);
                    sql.Parameters.AddWithValue("@Prijs", Pizza.Prijs);
                    sql.Parameters.AddWithValue("@aantal", Pizza.Aantal);

                    if (sql.ExecuteNonQuery() == 1)
                    {
                        methodResult = ok;
                    }
                    else
                    {
                        methodResult = $"Naam {Pizza.Name} kon niet gewijzigd worden.";
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(Updatepizza));
                    Console.Error.WriteLine(e.Message);
                    methodResult = e.Message;
                }
            }
            return methodResult;
        }


        public string UpdateToppings(int Toppings_id, Toppings toppings)
        {
            if (toppings == null || string.IsNullOrEmpty(toppings.Name))

            {
                throw new ArgumentException("Ongeldig argument bij gebruik van UpdateNaam");
            }
            string methodResult = "unknown";
            using (MySqlConnection conn = new(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"
                       UPDATE 
                      `toppings` 
                       SET `Name`=@Naam,`Prijs`=@Prijs,`aantal`=@aantal 
                       WHERE `Toppings_id` = @Toppings_id;";

                    sql.Parameters.AddWithValue("@Toppings_id", Toppings_id);
                    sql.Parameters.AddWithValue("@Naam", toppings.Name);
                    sql.Parameters.AddWithValue("@Prijs", toppings.Prijs);
                    sql.Parameters.AddWithValue("@aantal", toppings.Aantal);

                    if (sql.ExecuteNonQuery() == 1)
                    {
                        methodResult = ok;
                    }
                    else
                    {
                        methodResult = $"Naam {toppings.Name} kon niet gewijzigd worden.";
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(UpdateToppings));
                    Console.Error.WriteLine(e.Message);
                    methodResult = e.Message;
                }
            }
            return methodResult;
        }

        public string Deletepizza(int Pizza_id)
        {
            string methodResult = "unknown";
            using (MySqlConnection conn = new(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"
                    DELETE FROM `pizza` WHERE `pizza_id` = @pizza_id ";

                    sql.Parameters.AddWithValue("@pizza_id", Pizza_id);
                    if (sql.ExecuteNonQuery() == 1)
                    {
                        methodResult = ok;
                    }
                    else
                    {
                        methodResult = $"Naam met id {Pizza_id} kon niet verwijderd worden.";
                    }
                }
                catch (Exception e)
                {

                    Console.Error.WriteLine(nameof(Deletepizza));
                    Console.Error.WriteLine(e.Message);
                    methodResult = e.Message;
                }
            }
            return methodResult;
        }

        public string DeleteToppings(int Toppings_id)
        {
            string methodResult = "unknown";
            using (MySqlConnection conn = new(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"
                    DELETE FROM `toppings` WHERE `Toppings_id` = @Toppings_id ";

                    sql.Parameters.AddWithValue("@Toppings_id", Toppings_id);
                    if (sql.ExecuteNonQuery() == 1)
                    {
                        methodResult = ok;
                    }
                    else
                    {
                        methodResult = $"Naam met id {Toppings_id} kon niet verwijderd worden.";
                    }
                }
                catch (Exception e)
                {

                    Console.Error.WriteLine(nameof(DeleteToppings));
                    Console.Error.WriteLine(e.Message);
                    methodResult = e.Message;
                }
            }
            return methodResult;
        }

        public string GetMedewerkers(ICollection<Medewerkers> medewerkers)
        {
            if (medewerkers == null)

            {
                throw new ArgumentException("Ongeldig argument bij gebruik van GetMedewerkers");
            }

            using (MySqlConnection conn = new(connString))
            {
                try
                {
                    conn.Open(); MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"SELECT * FROM medewerkers";
                    MySqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        Medewerkers Medewerkers = new Medewerkers()
                        {
                            Medewerkers_id = (int)reader["Medewerkers_id"],
                            Name = (string)reader["Name"],
                            Woonplaats = (string)reader["Woonplaats"],
                            Telefoonnummer = (int)reader["Telefoonnummer"],



                        }; medewerkers.Add(Medewerkers);
                    }
                    methodResult = "ok";

                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(GetMedewerkers)); Console.Error.WriteLine(e.Message); methodResult = e.Message;
                }
            }
            return methodResult;
        }

        public string GetUnit(ICollection<Unit> units)
        {
            if (units == null)
            {
                throw new ArgumentException("Ongeldig argument bij gebruik van GetPizzas");
            }

            using (MySqlConnection conn = new(connString))
            {
                try
                {
                    conn.Open(); MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"SELECT * FROM unit";
                    MySqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        Unit unit = new Unit()
                        {
                            Unit_id = (int)reader["Unit_id"],
                            Name = (string)reader["Name"],
                            Prijs = (int)reader["Prijs"],
                            Aantal = (int)reader["Aantal"],



                        }; units.Add(unit);
                    }
                    methodResult = "ok";

                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(GetUnit)); Console.Error.WriteLine(e.Message); methodResult = e.Message;
                }
            }
            return methodResult;
        }

        public string CreateMedewerkers(Medewerkers medewerkers)
        {
            if (medewerkers == null)

            {
                throw new ArgumentException("Ongeldig argument bij gebruik van CreateMedewerkers");
            }

            string methodResult = "unknown";

            using (MySqlConnection conn = new(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"
                     INSERT INTO medewerkers
                    (Medewerkers_id, Name, Woonplaats,Telefoonnummer)
                     VALUES (NULL, @Name, @Woonplaats , @Telefoonnummer);";
                    sql.Parameters.AddWithValue("@Name", medewerkers.Name);
                    sql.Parameters.AddWithValue("@Woonplaats", medewerkers.Woonplaats);
                    sql.Parameters.AddWithValue("@Telefoonnummer", medewerkers.Telefoonnummer);

                    if (sql.ExecuteNonQuery() == 1)
                    {
                        methodResult = ok;
                    }
                    else
                    {
                        methodResult = $"Naam {medewerkers.Name} kon niet toegevoegd worden.";
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(CreateMedewerkers));
                    Console.Error.WriteLine(e.Message);
                    methodResult = e.Message;
                }
            }
            return methodResult;

        }
        public string CreateUnit(Unit unit)
        {
            if (unit == null)

            {
                throw new ArgumentException("Ongeldig argument bij gebruik van CreatePizzas");
            }

            string methodResult = "unknown";

            using (MySqlConnection conn = new(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"
                     INSERT INTO unit
                    (Unit_id, Name, Prijs,aantal)
                     VALUES (NULL, @Name, @prijs , @aantal);";
                    sql.Parameters.AddWithValue("@Name", unit.Name);
                    sql.Parameters.AddWithValue("@prijs", unit.Prijs);
                    sql.Parameters.AddWithValue("@aantal", unit.Aantal);

                    if (sql.ExecuteNonQuery() == 1)
                    {
                        methodResult = ok;
                    }
                    else
                    {
                        methodResult = $"Naam {unit.Name} kon niet toegevoegd worden.";
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(CreateUnit));
                    Console.Error.WriteLine(e.Message);
                    methodResult = e.Message;
                }
            }
            return methodResult;

        }

        public string UpdateMedewerkers(int Medewerkers_id, Medewerkers medewerkers)
        {
            if (medewerkers == null || string.IsNullOrEmpty(medewerkers.Name))

            {
                throw new ArgumentException("Ongeldig argument bij gebruik van UpdateMedewerkers");
            }
            string methodResult = "unknown";
            using (MySqlConnection conn = new(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"
                       UPDATE 
                      `medewerkers` 
                       SET `Name`=@Naam,`Woonplaats`=@Woonplaats,`Telefoonnummer`=@Telefoonnummer 
                       WHERE `Medewerkers_id` = @Medewerkers_id;";

                    sql.Parameters.AddWithValue("@Medewerkers_id", Medewerkers_id);
                    sql.Parameters.AddWithValue("@Naam", medewerkers.Name);
                    sql.Parameters.AddWithValue("@Woonplaats", medewerkers.Woonplaats);
                    sql.Parameters.AddWithValue("@Telefoonnummer", medewerkers.Telefoonnummer);

                    if (sql.ExecuteNonQuery() == 1)
                    {
                        methodResult = ok;
                    }
                    else
                    {
                        methodResult = $"Naam {medewerkers.Name} kon niet gewijzigd worden.";
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(UpdateMedewerkers));
                    Console.Error.WriteLine(e.Message);
                    methodResult = e.Message;
                }
            }
            return methodResult;
        }



        public string UpdateUnit(int Unit_id, Unit unit)
        {
            if (unit == null || string.IsNullOrEmpty(unit.Name))

            {
                throw new ArgumentException("Ongeldig argument bij gebruik van UpdateNaam");
            }
            string methodResult = "unknown";
            using (MySqlConnection conn = new(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"
                       UPDATE 
                      `unit` 
                       SET `Name`=@Naam,`Prijs`=@Prijs,`aantal`=@aantal 
                       WHERE `Unit_id` = @Unit_id;";

                    sql.Parameters.AddWithValue("@Unit_id", Unit_id);
                    sql.Parameters.AddWithValue("@Naam", unit.Name);
                    sql.Parameters.AddWithValue("@Prijs", unit.Prijs);
                    sql.Parameters.AddWithValue("@aantal", unit.Aantal);

                    if (sql.ExecuteNonQuery() == 1)
                    {
                        methodResult = ok;
                    }
                    else
                    {
                        methodResult = $"Naam {unit.Name} kon niet gewijzigd worden.";
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(Updatepizza));
                    Console.Error.WriteLine(e.Message);
                    methodResult = e.Message;
                }
            }
            return methodResult;
        }

        public string DeleteMedewerkers(int Medewerkers_id)
        {
            string methodResult = "unknown";
            using (MySqlConnection conn = new(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"
                    DELETE FROM `medewerkers` WHERE `Medewerkers_id` = @Medewerkers_id ";

                    sql.Parameters.AddWithValue("@Medewerkers_id", Medewerkers_id);
                    if (sql.ExecuteNonQuery() == 1)
                    {
                        methodResult = ok;
                    }
                    else
                    {
                        methodResult = $"Naam met id {Medewerkers_id} kon niet verwijderd worden.";
                    }
                }
                catch (Exception e)
                {

                    Console.Error.WriteLine(nameof(DeleteMedewerkers));
                    Console.Error.WriteLine(e.Message);
                    methodResult = e.Message;
                }
            }
            return methodResult;
        }



        public string DeleteUnit(int Unit_id)
        {
            string methodResult = "unknown";
            using (MySqlConnection conn = new(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"
                    DELETE FROM `unit` WHERE `Unit_id` = @Unit_id	 ";

                    sql.Parameters.AddWithValue("@Unit_id", Unit_id);
                    if (sql.ExecuteNonQuery() == 1)
                    {
                        methodResult = ok;
                    }
                    else
                    {
                        methodResult = $"Naam met id {Unit_id} kon niet verwijderd worden.";
                    }
                }
                catch (Exception e)
                {

                    Console.Error.WriteLine(nameof(DeleteUnit));
                    Console.Error.WriteLine(e.Message);
                    methodResult = e.Message;
                }
            }
            return methodResult;
        }


    }
}


