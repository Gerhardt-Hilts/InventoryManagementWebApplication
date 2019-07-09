namespace InventoryManagementAPI.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public ItemCondition ItemCondition { get; set; }
        public string Holder { get; set; }
    }
}