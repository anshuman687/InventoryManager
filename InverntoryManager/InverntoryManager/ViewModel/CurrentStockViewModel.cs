using System;
using System.Collections.ObjectModel;
using InverntoryManager.Models;

namespace InverntoryManager.ViewModel
{
    public class CurrentStockViewModel
    {
        private ObservableCollection<CurrentStockModel> items;
        public ObservableCollection<CurrentStockModel> Items
        {
            get { return items; }
            set
            {
                items = value;
            }
        }
        private ObservableCollection<CurrentStockModel321> items321;
        public ObservableCollection<CurrentStockModel321> Items321
        {
            get { return items321; }
            set
            {
                items321 = value;
            }
        }
        public CurrentStockViewModel()
        {
            CurrentStockStore123();
            CurrentStockStore321();
        }
        public void CurrentStockStore123()
        {
            Items = new ObservableCollection<CurrentStockModel>() {
                new CurrentStockModel()
                {
                    ItemCode = "WW01",
                    Description = "BOC",
                    SysQty = 12,
                    Location = "Store1"
                },
                  new CurrentStockModel()
                {
                    ItemCode = "WW02",
                    Description = "eld",
                    SysQty = 7,
                    Location = "Store1"
                },

            };
        }
        public void CurrentStockStore321()
        {
            Items321 = new ObservableCollection<CurrentStockModel321>() {
                new CurrentStockModel321()
                {
                    ItemCode = "AG01",
                    Description = "Makita1",
                    SysQty = 1,
                    Location = "Store1"
                },
                  new CurrentStockModel321()
                {
                    ItemCode = "AG02",
                    Description = "Makita1",
                    SysQty = 7,
                    Location = "Store1"
                },
                  new CurrentStockModel321()
                {
                    ItemCode = "AG03",
                    Description = "Makita1",
                    SysQty = 9,
                    Location = "Work"
                }

            };
        }
    }
}
