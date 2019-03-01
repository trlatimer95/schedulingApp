﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace SchedulingApp
{
    class DataInterface
    {
        private static int currentUserID;
        private static string currentUserName;
        private static List<int> userIDList = new List<int>();
        private static List<int> customerIDList = new List<int>();
        private static List<int> countryIDList = new List<int>();
        private static List<int> cityIDList = new List<int>();
        private static List<int> addressIDList = new List<int>();
        public static string connectionString = "server=52.206.157.109;userid=U05Csd;database=U05Csd;password=53688462289";
        public static MySqlConnection conn = new MySqlConnection(connectionString);
        public static MySqlCommand cmd;
        public static MySqlDataReader reader;

        public static int getCurrentUserID()
        {
            return currentUserID;
        }

        public static string getCurrentUserName()
        {
            return currentUserName;
        }

        public static List<int> getCustomerIDList()
        {
            return customerIDList;
        }

        public static void setCurrentUserID(int userID)
        {
            currentUserID = userID;
        }

        public static void setCurrentUserName(string userName)
        {
            currentUserName = userName;
        }

        public static int getNextUserID()
        {
            int nextUserID = 0;
            DBOpen();
            cmd = new MySqlCommand("SELECT userId FROM user", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                userIDList.Add(Convert.ToInt32(reader[0]));
            }
            reader.Close();
            DBClose();
            foreach (int ID in userIDList)
            {
                if (ID > nextUserID)
                {
                    nextUserID = ID;
                } 
            }
            nextUserID++;
            return nextUserID;
        }

        public static string getCurrentDateTime()
        {
            string currentDateTime = DateTime.Now.ToString("u");
            return currentDateTime;
        }

        public static void DBOpen()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
            }
            else
            {
                DBClose();
                DBOpen();
            }
        }

        public static void DBClose()
        {
            conn.Close();
        }

        // Build Dictionary object for customer
        public static Dictionary<string, string> getCustomerInfo(int customerID)
        {
            // Retrieve details from customer table that match customerID
            string query = $"SELECT * FROM customer WHERE customerId = '{customerID.ToString()}'";
            DBOpen();
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();
            reader.Read();

            // Build customer dictionary object from customer table
            Dictionary<string, string> Customer = new Dictionary<string, string>();
            string addressID = reader[2].ToString();
            Customer.Add("ID", reader[0].ToString());
            Customer.Add("Name", reader[1].ToString());
            Customer.Add("Active", reader[3].ToString());
            reader.Close();

            // Obtain information from address table by address ID corresponding to customer
            query = $"SELECT * FROM address WHERE addressId = '{addressID}'";
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();
            reader.Read();

            // Add customer data from adddress table
            string cityID = reader[3].ToString();
            Customer.Add("Address", reader[1].ToString());
            Customer.Add("Address2", reader[2].ToString());
            Customer.Add("ZipCode", reader[4].ToString());
            Customer.Add("Phone", reader[5].ToString());
            reader.Close();

            // Obtain information from city table by corresponding cityId
            query = $"SELECT * FROM city WHERE cityId = '{cityID}'";
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();
            reader.Read();

            // Add customer data from city table
            string countryID = reader[2].ToString();
            Customer.Add("City", reader[1].ToString());
            reader.Close();

            // Obtain informatoin from country table by corresponding countryId
            query = $"SELECT * FROM country WHERE countryId = '{countryID}'";
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();
            reader.Read();

            // Add customer data from country table
            Customer.Add("Country", reader[1].ToString());
            reader.Close();
            DBClose();

            return Customer;
        }

        // Create a new user
        public static void createUser(string username, string password, int active, string creator)
        {
            int id = getNextUserID();
            string currentDateTime = getCurrentDateTime();
            String sqlString = $"INSERT INTO user(userId, userName, password, active, createBy, createDate, lastUpdatedBy) VALUES ('{id}', '{username}', '{password}', '{active}', '{creator}', '{currentDateTime}', '{creator}');";

            // Establish and open database connection
            DBOpen();
            cmd = new MySqlCommand(sqlString, conn);
            cmd.ExecuteNonQuery();
            DBClose();
        }

        // Create a new customer
        public static void createCustomer(string name, string address, string city, string country, string zipcode, string phoneNumber, int active, string creator, string secondAddress = " ")
        {
            // TODO Refactor
           
            int id = getNextID("customerId", "customer", customerIDList);
            int addressID;
            int cityID;
            int countryID;
            String currentDateTime = getCurrentDateTime();

            if (conn.State == ConnectionState.Open)
            {
                DBClose();
            }

            DBOpen();
            
            // Check if country exists, if not, create a new one
            String query = $"SELECT countryId FROM country WHERE country = '{country}';";
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                countryID = Convert.ToInt32(reader[0]);
                reader.Close();
            }
            else
            {
                DBClose();
                countryID = getNextID("countryId", "country", countryIDList);
                String sqlString = $"INSERT INTO country(countryId, country, createDate, createdBy, lastUpdateBy) VALUES ('{countryID}', '{country}', '{currentDateTime}', '{creator}', '{creator}');";

                // Establish and open database connection
                DBOpen();
                cmd = new MySqlCommand(sqlString, conn);
                cmd.ExecuteNonQuery();
            }
            reader.Close();
            DBClose();

            DBOpen();
            // Check if city exists, if not, create a new one
            query = $"SELECT cityId FROM city WHERE city = '{city}'";
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                cityID = Convert.ToInt32(reader[0]);
            }
            else
            {
                cityID = getNextID("cityId", "city", cityIDList);
                query = $"INSERT INTO city (cityId, city, countryId, createDate, createdBy, lastUpdateBy) VALUES ('{cityID}', '{city}', '{countryID}', '{currentDateTime}', '{creator}', '{creator}');";
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            reader.Close();

            // Check if address exists, if not, create a new one
            query = $"SELECT addressId FROM address WHERE address = '{address}'";
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                addressID = Convert.ToInt32(reader[0]);
            }
            else
            {
                addressID = getNextID("addressId", "address", addressIDList);
                query = $"INSERT INTO address (addressId, address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdateBy) VALUES ('{addressID}', '{address}', '{secondAddress}', '{cityID}', '{zipcode}', '{phoneNumber}', '{currentDateTime}', '{creator}', '{creator}');";
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            reader.Close();

            // Create new customer
            query = $"INSERT INTO customer(customerId, customerName, addressId, active, createDate, createdBy, lastUpdateBy) VALUES ('{id}', '{name}', '{addressID}', '{active}', '{currentDateTime}', '{creator}', '{creator}');";
            cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            DBClose();
        }

        // Obtain next ID
        public static int getNextID(string nameOfID, string table, List<int> list)
        {
            int nextID = 0;
            string query = $"SELECT {nameOfID} FROM {table}";
            DBOpen();
            cmd = new MySqlCommand(query, conn);
            reader.Close();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(Convert.ToInt32(reader[0]));
            }
            reader.Close();
            DBClose();
            foreach (int ID in list)
            {
                if (ID > nextID)
                {
                    nextID = ID;
                }
            }
            nextID++;
            list.Clear();
            return nextID;
        }

        public static void generatePsuedoData()
        {
            DBOpen();
            // Create Test user
            string query = $"SELECT * FROM user WHERE userName = 'Test' OR userName = 'test'";
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();

            // check if 'Test' User already exists
            if (reader.HasRows)
            {
                // if user exists, exit function
                Console.WriteLine("User 'Test' already exists");
                reader.Close();
                DBClose();
                return;
            }
            else
            {
                // create 'Test' user
                createUser("Test", "Test", 1, "ADMIN");
            }
            reader.Close();

            // Create customers
            createCustomer("John Doe", "1111 Some St", "New York, New York", "United States", "10001", "111-111-1111", 1, "ADMIN");
            createCustomer("Jane Doe", "1112 Some St", "New York, New York", "United States", "10001", "111-111-1112", 1, "ADMIN");


            DBClose();
        }

    }
}
