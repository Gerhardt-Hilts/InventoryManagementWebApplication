using System;

namespace InventoryManagementAPI.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public string Name { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string ContactAddress { get; set; }
        public Boolean Active { get; set; }
    }
}