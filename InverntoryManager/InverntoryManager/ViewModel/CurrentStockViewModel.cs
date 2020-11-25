using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using InverntoryManager.Models;

namespace InverntoryManager.ViewModel
{
    public class CurrentStockViewModel
    {
        private List<CurrentStockModelList> _currentStockModelList;
        public List<CurrentStockModelList> ListOfCurrentstock
        {
            get { return _currentStockModelList; }
            set { _currentStockModelList = value; }
        }
        public CurrentStockViewModel()
        {
            CurrentStockStore();
        }
        public void CurrentStockStore()
        {
            var AList = new CurrentStockModelList()
    {
        new CurrentStockModel() {
                    ItemCode = "WW01",
                    Description = "BOC",
                    SysQty = 12,
                    Location = "Store3" },

        new CurrentStockModel() {
                    ItemCode = "WW02",
                    Description = "eld",
                    SysQty = 7,
                    Location = "Store1"},
         new CurrentStockModel() {
                    ItemCode = "WW03",
                    Description = "eld",
                    SysQty = 7,
                    Location = "Store8"},
    };
            AList.Heading = "Item Group: WW";

            var SList = new CurrentStockModelList()
    {
       new CurrentStockModel() {
            ItemCode = "SG001",
                    Description = "weld",
                    SysQty = 8,
                    Location = "Store4" },
        new CurrentStockModel() {
            ItemCode = "SG002",
                    Description = "Stock",
                    SysQty = 6,
                   Location = "Store5" },

    };
            SList.Heading = "Item Group: SG";
            var list = new List<CurrentStockModelList>()
    {
        AList,
        SList
    };
            ListOfCurrentstock = list;
        }
    }
}
