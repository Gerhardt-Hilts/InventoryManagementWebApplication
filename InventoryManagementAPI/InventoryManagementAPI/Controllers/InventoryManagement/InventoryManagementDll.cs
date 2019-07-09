using System.Collections.Generic;
using System.Linq;
using InventoryManagementAPI.Models;

namespace InventoryManagementAPI.Controllers.InventoryManagement
{
    public class InventoryManagementDll
    {
        private readonly PostgresDatabase _databaseInstance;
        
        public InventoryManagementDll(PostgresDatabase databaseInstance)
        {
            _databaseInstance = databaseInstance;
        }

        public void CreateTable()
        {
            try
            {
                _databaseInstance.OpenConnection();
                var command = _databaseInstance.CreateCommand(SqlCommands.CreateItemsTable);
                command.ExecuteNonQuery();
            }
            finally
            {
                _databaseInstance.CloseConnection();
            }
        }

        public List<Item> QueryItems()
        {
            var items = new List<Item>();
            try
            {
                _databaseInstance.OpenConnection();
                var command = _databaseInstance.CreateCommand(SqlCommands.GetItems);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    items.Add(new Item()
                    {
                        Id = reader.GetFieldValue<int>(0),
                        Uuid = reader.GetFieldValue<string>(1),
                        ItemCondition = reader.GetFieldValue<ItemCondition>(2),
                        Holder = reader.GetFieldValue<string>(3)
                    });
                }
            }
            finally
            {
                _databaseInstance.CloseConnection();
            }
            return items;
        }
        // TODO check if correct tables exist
        // TODO create methods for reading table
    }
}