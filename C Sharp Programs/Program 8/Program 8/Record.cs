//Record: class used to serialize and hold workshop data
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_8
{
    [Serializable]
    class Record
    {
        public readonly string workshop;

        //created with a name form that gives it a string
        public Record(string w)
        {
            workshop = w;
        }

        //struct used to hold each item
        [Serializable]
        public struct Item
        {
            public string itemName;
            public int itemAmount;
            public double price;

            public Item(string n, int a, double p)
            {
                itemName = n;
                itemAmount = a;
                price = p;
            }
        }

        //list of items that holds the entire list of items
        public List<Item> itemList = new List<Item>();

        //creates an item and adds it to the list
        public void Add(string name, int amount, double price)
        {
            Item newItem = new Item(name, amount, price);
            itemList.Add(newItem);
        }

        //deletes and item from the list
        public void Delete(int index)
        {
                itemList.RemoveAt(index);
        }

        //returns the size of the list
        public int listSize()
        {
            return itemList.Count;
        }

        //returns a string for the listbox of the form
        public string ItemInfo(int pos)
        {
            string listItem = String.Format("{0, 0} {1, 48} {2,32}",
            itemList[pos].itemName, itemList[pos].itemAmount, itemList[pos].price);
            return listItem;
        }
    }
}
