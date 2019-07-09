namespace InventoryManagementAPI.Models
{
    public enum ResultCode
    {
        Success,
        Failure
    }
    
    public class RequestResult
    {
        public string Info { get; set; }
        public ResultCode Code { get; set; }
    }
}