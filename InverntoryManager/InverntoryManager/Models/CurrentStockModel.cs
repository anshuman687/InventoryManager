using System;
using System.Collections.Generic;

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
    public class CurrentStockModelList : List<CurrentStockModel>
    {
        public string Heading { get; set; }
        public List<CurrentStockModel> CurrentStockModel => this;
    }
}
