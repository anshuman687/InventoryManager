using System;
using System.Collections.Generic;

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

    public class StockTakeModelList : List<StockTakeModel>
        {
        public string Heading { get; set; }
        public List<StockTakeModel> StockTakeModels => this;
    }
}
