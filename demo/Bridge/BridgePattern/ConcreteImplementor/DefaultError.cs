using BridgePattern.Implementor;
using System;

namespace BridgePattern.ConcreteImplementor
{
    public class DefaultError : IError
    {
        public string GetErrorMessage(Exception ex)
        {
            return "An error ocurred in the application";
        }
    }
}
