//Name: Ray Ketcham
//Date: 08/05/2018
//Instructor: Dr. Smithers
//Class: CST-117
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Inv
    {
        private string itemName;
        private string itemStockNum;
        private string itemAmount;
        private int numItems;

        public string Name
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public string StockNum
        {
            get { return itemStockNum; }
            set { itemStockNum = value; }
        }

        public string Amount
        {
            get => itemAmount;
            set { itemAmount = value; }
        }

        public int Qty
        {
            get { return numItems; }
        }

        public Inv()
        {
            itemName = "None";
            itemStockNum = "None";
            itemAmount = "None";
            numItems++;
        }

        public Inv(string itemName, string itemNum, string itemAmount)
        {
            this.itemName = itemName;
            this.itemStockNum = itemNum;
            this.itemAmount = itemAmount;
            numItems++;
        }
    }
}