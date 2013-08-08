using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_3
{
    public class Book : BorrowableItem, IDetailed
    {
        private string _Author;
        public string Author
        {
            get { return _Author; }
            set { _Author = value; }
        }

        private string _Publisher;
        public string Publisher
        {
            get { return _Publisher; }
            set { _Publisher = value; }
        }

        public Book(string title, string author, string publisher)
            : base(title)
        {
            _Author = author;
            _Publisher = publisher;
        }

        public string GetDetails()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("      Title: {0}", base.ToString()));
            sb.AppendLine(string.Format("     Author: {0}", _Author));
            sb.AppendLine(string.Format("  Publisher: {0}", _Publisher));
            if (BorrowedBy != null)
                sb.AppendLine(string.Format("\tBorrowed By: {0}", BorrowedBy.Patron.ToString()));

            return sb.ToString();
        }
    }
}
