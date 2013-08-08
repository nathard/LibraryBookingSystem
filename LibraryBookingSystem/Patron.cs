using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Assignment_3
{
    public class Patron : IDetailed
    {
        private string _ID;
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        
        private string _FamilyName;
        public string FamilyName
        {
            get { return _FamilyName; }
            set { _FamilyName = value; }
        }

        private string _GivenNames;
        public string GivenNames
        {
            get { return _GivenNames; }
            set { _GivenNames = value; }
        }

        public string FullName
        {
            get { return String.Format("{0}, {1}", _FamilyName, _GivenNames); }
        }

        private List<Borrowing> _BorrowedBooks = new List<Borrowing>();
        public List<Borrowing> BorrowedBooks
        {
            get
            {
                return _BorrowedBooks;
            }
        }

        //public abstract int DUE_DAYS();       

        private int DUE_DAYS
        {
            get
            {
                int i = 0;
                if (_ID.Length < 7) i = 28;
                else i = 7;
                return i;
            }
        }

        public DateTime GetDueDate()
        {
            DateTime ret = DateTime.Now;
            ret += new TimeSpan(DUE_DAYS, 23 - ret.Hour, 59 - ret.Minute, 59 - ret.Second, 999 - ret.Millisecond);
            return ret;
        }

        public Patron(string id, string familyName, string givenNames)
        {
            _ID = id;
            _FamilyName = familyName;
            _GivenNames = givenNames;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} (ID {2})", _FamilyName, _GivenNames, _ID);
        }

        public string GetDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("         ID: {0}", _ID));
            sb.AppendLine(string.Format("Family Name: {0}", _FamilyName));
            sb.AppendLine(string.Format("Given Names: {0}", _GivenNames));
            if (_BorrowedBooks.Count > 0)
            {
                sb.AppendLine(" Borrowings:");
                foreach (Borrowing b in _BorrowedBooks)
                    sb.AppendLine(string.Format("\t{0}", b.Item.ToString()));
            }
            return sb.ToString();
        }
    }
    public class Student : Patron
    {
        public Student(string id, string familyName, string givenNames) : base(id, familyName, givenNames) { }

       // public override int DUE_DAYS()
       // {
       //     return 7;
       // }

        public override string ToString()
        {
            return string.Format("{0}", base.ToString());
        }
    }
    public class Staff : Patron
    {
        public Staff(string id, string familyName, string givenNames)
            : base(id, familyName, givenNames)
        {

        }
        //public override int DUE_DAYS()
        //{
        //    return 28;
        //}

        public override string ToString()
        {
            return string.Format("{0}", base.ToString());
        }
    }
}
