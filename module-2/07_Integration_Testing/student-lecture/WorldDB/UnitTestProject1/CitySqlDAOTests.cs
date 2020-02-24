using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Transactions;
using System.IO;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Collections;
using WorldDB.DAL;
using WorldDB.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class CitySqlDAOTests
    {
        private TransactionScope transaction = null;
        private string connectionString = "Server = .\\SqlExpress;Database=World;Trusted_Connection=True;";
        private int newCityId;

        [TestMethod]


        public void GetCitiesByCountryCodeTest()
        {
            //initialize data in the DB
            SetupDatabase();

            //perform our test
            //Arrange
            CitySqlDAO dao = new CitySqlDAO (connectionString);

            //Act
            IList <City> cities= dao.GetCitiesByCountryCode("USA");

            //Assert
            Assert.AreEqual(2, cities.Count);

            //go back to original db values
            CleanupDatabase();
        }

        private void SetupDatabase()
        {
            //open file, read in, send to database to execute, within a transaction
            //start a transaction so we can roll back when we are finished with this test
            
            transaction = new TransactionScope();
            //Open Setup.Sql and read in the script to be executed
            string setupSQL;
            using (StreamReader rdr = new StreamReader("Setup.sql"))
            {
                setupSQL=rdr.ReadToEnd();
            }
            //Connect to the database and execute the script

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();//open connection
                SqlCommand cmd = new SqlCommand(setupSQL, conn);
                SqlDataReader rdr = cmd.ExecuteReader();


                // Get the result (new cityid) and save it for use later in a test
                if (rdr.Read())
                {
                    newCityId = Convert.ToInt32(rdr["newCityId"]);
                }
               
            }



        }
        //Rollback the transaction to get our good data back
      
        private void CleanupDatabase()
        {
            transaction.Dispose();
        }
    }
}
