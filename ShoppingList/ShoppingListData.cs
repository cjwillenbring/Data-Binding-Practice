using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ShoppingList
{
    class ShoppingListData : INotifyPropertyChanged
    {
        List<string> items = new List<String>();

        public IEnumerable<string> Items => items.ToArray();

        public event PropertyChangedEventHandler PropertyChanged;

        public void Add(string item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        public void Remove(string item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));

        }
    }
}
