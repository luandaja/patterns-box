using BridgePattern.Implementor;
using System;

namespace BridgePattern.ConcreteImplementor
{
    public class DetailedError : IError
    {
        public string GetErrorMessage(Exception ex)
        {
            return $"An exception ocurred in date: { DateTime.Now }. StackTrace: { ex.StackTrace } InnerException: { ex.InnerException } Message: { ex.Message }";
        }
    }
}
