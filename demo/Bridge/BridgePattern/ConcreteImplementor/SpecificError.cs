using BridgePattern.Implementor;
using System;

namespace BridgePattern.ConcreteImplementor
{
    public class SpecificError : IError
    {
        public string GetErrorMessage(Exception ex)
        {
            return $"An exception ocurred in date: { DateTime.Now } with message { ex.Message }";
        }
    }
}
