using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Classes
{
    internal class LibraryItem
    {
        public int ItemId { get; set; }
        public bool IsAvailable { get; private set; } = true;

        public void CheckOut()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine("Item checked out successfully.");
            }
            else
            {
                Console.WriteLine("Item is not checked out.");
            }
        }

        public void ReturnItem()
        {
            if (!IsAvailable)
            {
                IsAvailable = true;
                Console.WriteLine("Item returned successfully.");
            }
            else
            {
                Console.WriteLine("Item is not available.");
            }
        }
    }
}
