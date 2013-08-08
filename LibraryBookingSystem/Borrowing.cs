using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_3
{
    public class Borrowing
    {
        private Patron _Patron;
        public Patron Patron
        {
            get { return _Patron; }
        }

        private BorrowableItem _Item;
        public BorrowableItem Item
        {
            get { return _Item; }
        }

        private DateTime _DueDate;
        public DateTime DueDate
        {
            get { return _DueDate; }
        }

        private Borrowing(Patron patron, BorrowableItem item)
        {
            _Item = item;
            _Patron = patron;
            _DueDate = patron.GetDueDate();
        }

        public static Borrowing Issue(Patron patron, BorrowableItem item)
        {

            Borrowing ret = null;

            if (item.BorrowedBy != null)
                throw new BookBorrowedException();

            ret = new Borrowing(patron, item);
            item.BorrowedBy = ret;
            patron.BorrowedBooks.Add(ret);

            return ret;
        }

        public void ReturnBook()
        {
            if (_Item.BorrowedBy != this || _Patron.BorrowedBooks.Contains(this) == false)
                throw new InvalidBorrowException();

            _Item.BorrowedBy = null;
            _Patron.BorrowedBooks.Remove(this);
        }
    }
}
