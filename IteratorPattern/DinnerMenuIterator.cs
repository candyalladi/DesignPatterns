namespace IteratorPattern
{
    public class DinnerMenuIterator : IIterator
    {
        MenuItem[] menuItems;
        int poistion = 0;

        public DinnerMenuIterator(MenuItem[] menuItems)
        {
            this.menuItems = menuItems;            
        }
        public bool hasNext()
        {
            if (poistion >= menuItems.Length || menuItems[poistion] == null)
            {
                return false;
            }
            return true;
        }

        public object next()
        {
            MenuItem menuItem = menuItems[poistion];
            poistion++;
            return menuItem;
        }
    }
}
