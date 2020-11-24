using System;
namespace InverntoryManager.Models
{
    public partial class StockTakeModel
    {
        public int ID { get; set; }
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public int SysQty { get; set; }
        public int CheckQty { get; set; }
    }

    public partial class StockTakeModel321
    {
        public int ID { get; set; }
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public int SysQty { get; set; }
        public int CheckQty { get; set; }
    }
}
