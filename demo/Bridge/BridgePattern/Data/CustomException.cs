using System;

namespace BridgePattern.Data
{
    public class CustomException : Exception
    {
        public Exception GetException()
        {
            return new Exception("This is a custom exception generated for tests purposes.", new DataMisalignedException());
        }
    }
}
