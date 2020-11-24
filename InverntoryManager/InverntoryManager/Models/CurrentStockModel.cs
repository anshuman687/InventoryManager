using System;
namespace InverntoryManager.Models
{
    public partial class CurrentStockModel
    {
        public int ID { get; set; }
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public int SysQty { get; set; }
        public string Location { get; set; }
    }

    public partial class CurrentStockModel321
    {
        public int ID { get; set; }
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public int SysQty { get; set; }
        public string Location { get; set; }
    }
}
