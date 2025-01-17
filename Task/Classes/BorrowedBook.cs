using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Struct;

namespace Task.Classes
{
    internal class BorrowedBook : LibraryItem
    {
        public Book BookDetails { get; set; }
        public string BorrowerName { get; set; }
        public DateTime BorrowedDate { get; set; }

        public BorrowedBook(int itemId, Book bookDetails, string borrowerName, DateTime borrowedDate)
        {
            ItemId = itemId;
            BookDetails = bookDetails;
            BorrowerName = borrowerName;
            BorrowedDate = borrowedDate;
        }

        public int CalculateBorrowDuration()
        {
            return (DateTime.Now - BorrowedDate).Days;
        }
    }
}
