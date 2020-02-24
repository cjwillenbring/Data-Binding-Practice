using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShoppingList
{
    /// <summary>
    /// Interaction logic for ShoppingListItems.xaml
    /// </summary>
    public partial class ShoppingListItems : UserControl
    {
        public ShoppingListItems()
        {
            InitializeComponent();
        }

        public void OnRemoveitem(object sender, RoutedEventArgs e)
        {
            if(DataContext is ShoppingListData data)
            {
                if(sender is Button s)
                {
                    data.Remove(s.DataContext.ToString());
                }
            }
        }
    }
}
