using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_3
{
    public class BorrowableItem
    {
        private string _Title;
        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        private Borrowing _BorrowedBy;
        public Borrowing BorrowedBy
        {
            get { return _BorrowedBy; }
            set { _BorrowedBy = value; }
        }

        public BorrowableItem(string title)
        {
            _Title = title;
        }

        public override string ToString()
        {
            return string.Format("{0}{1}", _Title, (_BorrowedBy == null ? "" : string.Format(" (due: {0})", _BorrowedBy.DueDate.ToShortDateString())));
        }
    }
}