using System;

namespace CustomException
{
    class MyCustomException : Exception
    {
        public string Message { get; set; }
        public MyCustomException(string message)
        {
            Message = message;
        }
    }
}
