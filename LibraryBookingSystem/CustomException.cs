using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_3
{
    public abstract class CustomException : Exception
    {
        public CustomException()
            : base()
        {
        }

        public CustomException(string message)
            : base(message)
        {
        }

        public CustomException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

    #region Book Exceptions
    public class DisplayBookException : CustomException
    {
        public DisplayBookException()
            : base("Display Book: Object is not a Book")
        {
        }

        public DisplayBookException(string message)
            : base(message)
        {
        }

        public DisplayBookException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
    public class ModifyBookException : CustomException
    {
        public ModifyBookException()
            : base("Modify Book: Object is not a Book")
        {
        }

        public ModifyBookException(string message)
            : base(message)
        {
        }

        public ModifyBookException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
    public class DeleteBookException : CustomException
    {
        public DeleteBookException()
            : base("Delete Book: Object is not a Book")
        {
        }

        public DeleteBookException(string message)
            : base(message)
        {
        }

        public DeleteBookException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
    #endregion
    #region Patron Exceptions
    public class DisplayPatronException : CustomException
        {
        public DisplayPatronException()
            : base("Display Patron: Object is not a Patron")
        {
        }

        public DisplayPatronException(string message)
            : base(message)
        {
        }

        public DisplayPatronException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
    public class ModifyPatronException : CustomException
        {
        public ModifyPatronException()
            : base("Modify Patron: Object is not a Patron")
        {
        }

        public ModifyPatronException(string message)
            : base(message)
        {
        }

        public ModifyPatronException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
    public class DeletePatronException : CustomException
        {
        public DeletePatronException()
            : base("Delete Patron: Object is not a Patron")
        {
        }

        public DeletePatronException(string message)
            : base(message)
        {
        }

        public DeletePatronException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
    #endregion
    #region Borrowing Exceptions
    public class RecordCustomerException : CustomException
    {
        public RecordCustomerException()
            : base("Record Selected Customer: Object is not a Patron")
        {
        }

        public RecordCustomerException(string message)
            : base(message)
        {
        }

        public RecordCustomerException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
    public class IssueBookException : CustomException
        {
        public IssueBookException()
            : base("Issue Book: Object is not a Borrowable Item")
        {
        }

        public IssueBookException(string message)
            : base(message)
        {
        }

        public IssueBookException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
    public class ReturnBookException : CustomException
        {
        public ReturnBookException()
            : base("Return Book: Object is not a Borrowing")
        {
        }

        public ReturnBookException(string message)
            : base(message)
        {
        }

        public ReturnBookException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
    public class BookBorrowedException : CustomException
    {
        public BookBorrowedException()
            : base("Book already borrowed")
        {
        }

        public BookBorrowedException(string message)
            : base(message)
        {
        }

        public BookBorrowedException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
    public class InvalidBorrowException : CustomException
    {
        public InvalidBorrowException()
            : base("Invalid Borrowing")
        {
        }

        public InvalidBorrowException(string message)
            : base(message)
        {
        }

        public InvalidBorrowException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
    #endregion
    
}

