using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using DatabaseAccess.Models;
using System.Data.SqlClient;

namespace DatabaseAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            // Execute a Select using a SQL Connection, Command and ExecuteReader.

            /*****************************************************************************/
            // Get the list of all cities in the world
            IList<City> cities = GetAllCities();
            Console.WriteLine(City.GetHeader());

            foreach (City city in cities)
            {
                Console.WriteLine(city);
            }
            // Print the list 
            Console.WriteLine(City.GetHeader());
            foreach (City city in cities)
            {
                Console.WriteLine(city);
            }
            Console.ReadLine();
            Console.Clear();
            /*****************************************************************************/

            /*****************************************************************************/
            // Get the list of all cities in Ohio
            // Execute a Select with parameters
            IList<City> cities = GetAllCitiesInState("Ohio");
            cities = GetAllCitiesInState("Ohio");
            Console.WriteLine(City.GetHeader());
            foreach (City city in cities)
            {
                Console.WriteLine(city);
            }

            /*****************************************************************************/
            // Execute an Update using ExecuteNonQuery
            UpdateUSPresident("Donald J Trump");


            /*****************************************************************************/
            // Execute an Insert using ExecuteScalar
            AddCity();


            /*****************************************************************************/
            // Execute a Delete using ExecuteNonQuery
            DeleteUSCity("Richfield", "Ohio");

            return;
        }

        private static IList<City> GetAllCities()
        {
            List<City> cities = new List<City>();

            // TODO 02: Add code to list all cities

            using (SqlConnection conn = new SqlConnection(@"Server =.\SqlExpress; Database = World; Trusted_Connection=True;"))//in parenthesis is a connection string
            { conn.Open();
                SqlCommand cmd = new SqlCommand("Select Top 30 * FROM city", conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    City city = new City()
                    {
                        //initializer syntax- reaching into reader and getting various columns out
                        CityId = Convert.ToInt32(rdr["id"]),
                        Name = Convert.ToString(rdr["name"]),
                        CountryCode = Convert.ToString(rdr["countrycode"]),
                        District = Convert.ToString(rdr["district"]),
                        Population = Convert.ToInt32(rdr["population"])
                    };
                    cities.Add(city);

                    //For now, CW. Later we'll create a City objcet
                    //don't need this now Console.WriteLine($"{rdr["id"]} {rdr["name"]} {rdr["countrycode"]}");
                }

            }
            return cities;
        }

        private static IList<City> GetAllCitiesInState(string state)
        {
            List<City> cities = new List<City>();

            // TODO03: Add code to list all cities in the given district of the USA

            using (SqlConnection conn = new SqlConnection(@"Server =.\SqlExpress; Database = World; Trusted_Connection=True;"))//in parenthesis is a connection string
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * FROM city WHERE countrycode = 'USA' AND district =@district", conn);
                //need to bind @district with state
                cmd.Parameters.AddWithValue("@district", state);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    City city = new City()
                    {
                        //initializer syntax- reaching into reader and getting various columns out
                        CityId = Convert.ToInt32(rdr["id"]),
                        Name = Convert.ToString(rdr["name"]),
                        CountryCode = Convert.ToString(rdr["countrycode"]),
                        District = Convert.ToString(rdr["district"]),
                        Population = Convert.ToInt32(rdr["population"])
                    };
                    cities.Add(city);

                    //For now, CW. Later we'll create a City objcet
                    //don't need this now Console.WriteLine($"{rdr["id"]} {rdr["name"]} {rdr["countrycode"]}");
                    return cities;

                }
                private static void UpdateUSPresident(string president)
                {
                    // TODO 04: Add code to update the US President to what was passed into this method
                    string sql = "Update country set headofstate = @headofstate WHERE code = 'USA' ";
                    using (SqlConnection conn = new SqlConnection(connectionstring))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@headofstate", president);
                        int rowsUpdate = cmd.ExecuteNonQuery();
                        if (rowsUpdated == 0)

                        {
                            throw new Exception("Not able to update the prez");
                        }
                        else if (rowsUpdated > 1)
                        {
                            throw new Exception($"Oh, crap!{president} now rules the World!");
                        }
                    }
                    return;
                }

                private static void AddCity()
                {
                    // TODO 05: Add code to add a new city
                    using(SqlConnection conn = new SqlConnection(connectionstring))
                    {
                        conn.Open();//open a connection
                        string sql = @"Insert into city(name, countrycode, district, population) values(@name, @countrycode, @distrcit, @population);";
                    }
                    SqlComand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@name", "Timbucktoo");
                    cmd.Parameters.AddWithValue("@countrycode", 'AUS');
                    cmd.Parameters.AddWithValue("@district", "New South Wales");
                    cmd.Parameters.AddWithValue("@population", 1);
                    int rows = cmd.ExecuteNonQuery();

                    Console.WriteLine($"Added city");
                    return;
                }

                private static void DeleteUSCity(string cityName, string stateName)
                {
                    // TODO 06: Add code to Delete a US city based on parameters passed in
                    return;
                }
            }
        }
    }