using System;
using InventoryManagementAPI.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Npgsql;

namespace InventoryManagementAPI
{
    public class PostgresDatabase
    {
        private NpgsqlConnection _connection;
        
        public void ConnectToDb(string connectionString)
        {
            this._connection = new NpgsqlConnection(connectionString);
        }

        public RequestResult TestDatabaseConnection()
        {
            // check if connection is specified
            if (this._connection == null)
            {
                Console.WriteLine("Testing Connection, ", this._connection);
                return new RequestResult()
                {
                    Code = ResultCode.Failure,
                    Info = "Connection not specified! Use 'PostgresDatabase.connectToDb(connectionString)'"
                };
            }

            // open connection
            this._connection.Open();
            
            // check connection state and return result
            if (this._connection.State == System.Data.ConnectionState.Open)
            {
                // close connection and return success if state is open
                this._connection.Close();
                return new RequestResult()
                {
                    Code = ResultCode.Success,
                    Info = "Successfully connected!"
                };
            }

            // close connection and return failure if state is not open
            this._connection.Close();
            return new RequestResult()
            {
                Code = ResultCode.Failure,
                Info = "Could not connect!"
            };
        }
        
        // TODO read configuration for default database connection information file
        // TODO prompt user if configuration file does not exist
        // TODO write configuration file
        // TODO encrypt configuration file
        // TODO decrypt and read configuration file
        
    }
}