using System;

namespace IteratorPattern
{
    public class DinnerMenu
    {
        private const int Max_Items = 6;
        int numberOfitems = 0;
        MenuItem[] menuItems;

        public DinnerMenu()
        {
            menuItems = new MenuItem[Max_Items];

            AddItem("Veg BLT", "Bacon with lettuce", true, 2.99);
            AddItem("BLT", "Bacon with lettuce with tomato on whole meat", false, 12.99);
            AddItem("Soup of the Day", "Soup with side of potato salad", true, 3.99);
            AddItem("HotDog", "Hot Dog served with soup", true, 15.99);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem item = new MenuItem(name, description, vegetarian, price);
            if(numberOfitems >= Max_Items)
            {
                Console.WriteLine("Sorry menu is full!, Can't add any more item");
            }
            else
            {
                menuItems[numberOfitems] = item;
                numberOfitems += 1;
            }
        }

        public IIterator CreateIterator()
        {
            return new DinnerMenuIterator(menuItems);
        }

    }
}
