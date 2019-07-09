namespace InventoryManagementAPI.Controllers.InventoryManagement
{
    internal static class SqlCommands
    {
        internal const string GetItems = "SELECT * FROM items";

        internal const string CreateItemsTable =
            @"CREATE TABLE items (
                Id SERIAL PRIMARY KEY, 
                Uuid VARCHAR(255) UNIQUE NOT NULL, 
                ItemCondition VARCHAR(255) NOT NULL, 
                Holder VARCHAR(255) NOT NULL
            )";
    }
}