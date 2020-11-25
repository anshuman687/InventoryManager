using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using InverntoryManager.Models;
using Xamarin.Forms;

namespace InverntoryManager.ViewModel
{
    public class StockTakeViewModel
    {
        private List<StockTakeModelList> _stockTakeModelList;
        public List<StockTakeModelList> ListOfStockTake
        {
            get { return _stockTakeModelList; }
            set { _stockTakeModelList = value; }
        }

        public StockTakeViewModel()
        {
            StockTakeStore();
        }
        public void StockTakeStore()
        {
            var AList = new StockTakeModelList()
    {
        new StockTakeModel() {
                    ItemCode = "AG01",
                    Description = "weld",
                    SysQty = 12,
                    CheckQty = 5 },
        new StockTakeModel() {
                    ItemCode = "AG02",
                    Description = "weld",
                    SysQty = 2,
                    CheckQty = 1 },
    };
            AList.Heading = "StoreID: AG";

            var SList = new StockTakeModelList()
    {
       new StockTakeModel() {
            ItemCode = "SG01",
                    Description = "weld",
                    SysQty = 8,
                    CheckQty = 5 },
        new StockTakeModel() {
            ItemCode = "SG02",
                    Description = "Stock",
                    SysQty = 6,
                    CheckQty = 3 },
         new StockTakeModel() {
            ItemCode = "SG03",
                    Description = "weld",
                    SysQty = 2,
                    CheckQty = 1 },

    };
            SList.Heading = "StoreID: SG";
            var list = new List<StockTakeModelList>()
    {
        AList,
        SList
    };

            ListOfStockTake = list;
        }
    }
}
