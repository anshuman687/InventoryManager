using System;
using System.Collections.ObjectModel;
using InverntoryManager.Models;
using Xamarin.Forms;

namespace InverntoryManager.ViewModel
{
    public class StockTakeViewModel
    {
        private ObservableCollection<StockTakeModel> items;
        public ObservableCollection<StockTakeModel> Items
        {
            get { return items; }
            set
            {
                items = value;
            }
        }
        private ObservableCollection<StockTakeModel321> items321;
        public ObservableCollection<StockTakeModel321> Items321
        {
            get { return items321; }
            set
            {
                items321 = value;
            }
        }
        public StockTakeViewModel()
        {
            StockTakeStore123();
            StockTakeStore321();
        }

        public void StockTakeStore123()
        {
            Items = new ObservableCollection<StockTakeModel>() {
                new StockTakeModel()
                {
                    ItemCode = "WW01",
                    Description = "BOC",
                    SysQty = 12,
                    CheckQty = 5
                },
                  new StockTakeModel()
                {
                    ItemCode = "WW02",
                    Description = "BOC",
                    SysQty = 7,
                    CheckQty = 3
                },
            };
        }

        public void StockTakeStore321()
        {
            Items321 = new ObservableCollection<StockTakeModel321>() {
                new StockTakeModel321()
                {
                    ItemCode = "AG01",
                    Description = "weld",
                    SysQty = 12,
                    CheckQty = 5
                },
                  new StockTakeModel321()
                {
                    ItemCode = "AG02",
                    Description = "weld",
                    SysQty = 7,
                    CheckQty = 3
                },
                  new StockTakeModel321()
                {
                    ItemCode = "AG03",
                    Description = "BOC",
                    SysQty = 9,
                    CheckQty = 4
                }
            };
        }

    }
}
