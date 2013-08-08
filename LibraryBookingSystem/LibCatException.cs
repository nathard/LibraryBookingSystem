using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_3
{
    class LibCatException : Exception
    {
        public LibCatException()
            : base()
        {
        }

        public LibCatException(string message)
            : base(message)
        {
        }

        public LibCatException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
