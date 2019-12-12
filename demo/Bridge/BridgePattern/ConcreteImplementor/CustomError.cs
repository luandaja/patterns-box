using BridgePattern.Implementor;
using System;

namespace BridgePattern.ConcreteImplementor
{
    public class CustomError : IError
    {
        public string GetErrorMessage(Exception ex)
        {
            return $"An exception ocurred in date: { DateTime.Now }.\n - StackTrace: { ex.StackTrace } \n - InnerException: { ex.InnerException } \n - Message: { ex.Message }";
        }
    }
}
