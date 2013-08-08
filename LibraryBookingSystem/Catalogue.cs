using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Assignment_3
{
    public class Catalogue
    {
        #   region Patron Members
        private SortedList<string, Patron> _Patrons = new SortedList<string, Patron>();
        public IList<Patron> Patrons
        {
            get { return _Patrons.Values; }
        }

        public void AddPatron(Patron patron)
        {
            try
            {
                _Patrons.Add(patron.FullName, patron);
            }
            catch (ModifyPatronException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DeletePatron(Patron patron)
        {
            try
            {
                List<Borrowing> tempList = new List<Borrowing>(patron.BorrowedBooks);
                foreach (Borrowing b in tempList)
                    b.ReturnBook();
                if (_Patrons.ContainsValue(patron))
                    _Patrons.Remove(patron.FullName);
            }
            catch (DeletePatronException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public Menu GetPatronList()
        {
            
            MenuOption[] patronList = new MenuOption[_Patrons.Count];
            try
            {
                int i = 0;
                foreach (Patron p in _Patrons.Values)
                {
                    patronList[i] = new MenuOption(p.ToString(), p, null, null);
                    i++;
                }
            }
            catch (DisplayPatronException e)
            {
                Console.WriteLine(e.Message);
            }
            return new Menu(null, patronList, MenuOption.Cancel);
        }
        #endregion
        #region Book Members
        private SortedList<string, BorrowableItem> _Books = new SortedList<string, BorrowableItem>();
        public IList<BorrowableItem> Books
        {
            get { return _Books.Values; }
        }

        public void AddBook(Book book)
        {
            try
            {
                _Books.Add(book.Title, book);
            }
            catch (ModifyBookException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DeleteBook(Book b)
        {
            try
            {
                if (b.BorrowedBy != null)
                    b.BorrowedBy.ReturnBook();
                if (_Books.ContainsValue(b))
                    _Books.Remove(b.Title);
            }
            catch (DeleteBookException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public Menu GetBookList()
        {
            MenuOption[] bookList = new MenuOption[_Books.Count];
            try
            {
                int i = 0;
                foreach (BorrowableItem b in _Books.Values)
                {
                    bookList[i] = new MenuOption(b.ToString(), b, null, null);
                    i++;
                }
            }
            catch (DisplayBookException e)
            {
                Console.WriteLine(e.Message);
            }
            return new Menu(null, bookList, MenuOption.Cancel);
        }
        #endregion
        #region Borrowing Members
        private SortedList<string, Borrowing> _RecordOfBorrowings = new SortedList<string, Borrowing>();
        public IList<Borrowing> RecordOfBorrowings
        {
            get { return _RecordOfBorrowings.Values; }
        }

        public void BorrowBook(Patron patron, BorrowableItem book)
        {
            try
            {
                Borrowing b = Borrowing.Issue(patron, book);
                _RecordOfBorrowings.Add(book.Title, b);
            }
            catch (BookBorrowedException e) 
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidBorrowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IssueBookException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void ReturnBook(Borrowing borrowing)
        {
            try
            {
                borrowing.ReturnBook();
                _RecordOfBorrowings.Remove(borrowing.Item.Title);
            }
            catch (ReturnBookException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public Menu GetBorrowingsList()
        {
            MenuOption[] borrowingsList = new MenuOption[_RecordOfBorrowings.Count];
            try
            {
                int i = 0;
                foreach (Borrowing b in _RecordOfBorrowings.Values)
                {
                    borrowingsList[i] = new MenuOption(b.Item.ToString(), b, null, null);
                    i++;
                }
            }
            catch (RecordCustomerException e)
            {
                Console.WriteLine(e.Message);
            }
            return new Menu(null, borrowingsList, MenuOption.Cancel);
        }
        #endregion
    }
}
