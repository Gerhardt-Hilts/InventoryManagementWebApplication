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

        public List<Item> QueryItems()
        {
            var command = _databaseInstance.CreateCommand(SqlCommands.GetItems);
            var reader = command.ExecuteReader();
            return reader.Cast<Item>().ToList();
        }
        
        // TODO check if correct tables exist
        // TODO create methods for reading table
        
    }
}