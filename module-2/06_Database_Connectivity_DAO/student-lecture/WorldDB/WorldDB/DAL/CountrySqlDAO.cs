using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using WorldDB.Models;
namespace WorldDB.DAL
{
  public  class CountrySqlDAO
    {

        //create a countrysqlDAO class (GetCountries, GetCountries(continent), GetCountry(code))
        private string connectionString;

        public CountrySqlDAO(string connString)
        {
            this.connectionString = connString;
        }

        public IList<Country> GetCountries()
        {
            //Declare the result variable
            List<Country> list = new List<Country>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    //open the connection
                    conn.Open();

                    //create the command for the sql statement
                    string sql = "Select * from country";
                    SqlCommand cmd = new SqlCommand(sql, conn);


                    SqlDataReader rdr = cmd.ExecuteReader();
                    //Execute teh query and get teh result set in a reader


                    //for each row, create a new country and add it to the list

                    while (rdr.Read())
                    {
                        Country country = new Country();
                        country.code = Convert.ToString(rdr["code"]);
                        country.Name = Convert.ToString(rdr["Name"]);
                        country.Continent = Convert.ToString(rdr["Continent"]);
                        country.Region = Convert.ToString(rdr["Region"]);
                        country.GovernmentForm = Convert.ToString(rdr["GovernmentForm"]);
                        country.HeadOfState = Convert.ToString(rdr["HeadOfState"]);
                        country.LocalName = Convert.ToString(rdr["LocalName"]);
                        country.Code2 = Convert.ToString(rdr["Code2"]);
                        country.SurfaceArea = Convert.ToDouble(rdr["SurfaceArea"]);

                        if (rdr["indepyear"] is DBNull)
                        {
                            country.IndependenceYear = null;
                        }
                        else
                        {
                            country.IndependenceYear = Convert.ToInt32(rdr["indepyear"]);
                        }

                        country.Population = Convert.ToInt32(rdr["population"]);



                        if (rdr["lifeexpectency"] is DBNull)
                        {
                            country.LifeExpectancy = null;
                        }
                        else
                        {
                            country.LifeExpectancy = Convert.ToDouble(rdr["Lifeexpectancy"]);
                        }



                        if (rdr["capital"] is DBNull)
                        {
                            country.CapitalId = null;
                        }
                        else
                        {
                            country.CapitalId = Convert.ToInt32(rdr["capital"]);
                        }


                        if (rdr["gnp"] is DBNull)
                        {
                            country.gnp = null;
                        }
                        else
                        {
                            country.gnp = Convert.ToDecimal(rdr["gnp"]);
                        }

                        country.Population = Convert.ToInt32(rdr["population"]);

                        list.Add(country);

                    }


                }
            

            }
            catch (SqlException ex)
            {
                //we should log this somewhere
                Console.WriteLine(ex.Message);
            }

            return list;
        }
    }
}
