using System;

namespace GuestBook.Types.Exceptions
{
    [Serializable]
    public class DatabaseException : ApplicationException
    {
        public DatabaseException()
        {
        }

        public DatabaseException(string message)
            : base(message)
        {
        }

        public DatabaseException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
