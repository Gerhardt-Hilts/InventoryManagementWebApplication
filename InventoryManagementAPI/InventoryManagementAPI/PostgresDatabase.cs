using System;
using InventoryManagementAPI.Models;
using Npgsql;

namespace InventoryManagementAPI
{
    public class PostgresDatabase
    {
        private NpgsqlConnection _connection;
        
        // Connect to database
        public void ConnectToDb(string connectionString)
        {
            this._connection = new NpgsqlConnection(connectionString);
        }

        // Test database connection
        public RequestResult TestDatabaseConnection()
        {
            Console.WriteLine("Testing Connection...");
            // check if connection is specified
            if (_connection == null)
            {
                return new RequestResult()
                {
                    Code = ResultCode.Failure,
                    Info = "Connection not specified! Use 'PostgresDatabase.connectToDb(connectionString)'"
                };
            }

            // open connection
            _connection.Open();
            
            // check connection state and return result
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                // close connection and return success if state is open
                _connection.Close();
                return new RequestResult()
                {
                    Code = ResultCode.Success,
                    Info = "Successfully connected!"
                };
            }

            // close connection and return failure if state is not open
            _connection.Close();
            return new RequestResult()
            {
                Code = ResultCode.Failure,
                Info = "Could not connect!"
            };
        }

        // create a command to execute against connect database
        public NpgsqlCommand CreateCommand(string command)
        {
            return new NpgsqlCommand(command, _connection);
        }
        
        
        
        // TODO read configuration for default database connection information file
        // TODO prompt user if configuration file does not exist
        // TODO write configuration file
        // TODO encrypt configuration file
        // TODO decrypt and read configuration file
        
    }
}