using System.Collections.Generic;
using InventoryManagementAPI.Controllers.InventoryManagement;
using InventoryManagementAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    
    public class InventoryManagementController : ControllerBase
    {
        // TODO remove hardcoded local test database, use configuration file
        private static readonly PostgresDatabase Db = new PostgresDatabase("Host=localhost;Username=postgres;Password=ohsphinxofblackquartzjudgemyvow89031276;Database=inventory_management");
        private static readonly InventoryManagementDll Dll = new InventoryManagementDll(Db);

        [HttpGet("testDbConnection")]
        public RequestResult TestDbConnection()
        {
            return Db.TestDatabaseConnection();
        }
        
        [HttpGet("getItems")]
        public List<Item> GetItems()
        {
            return Dll.QueryItems();
        }
    }
}