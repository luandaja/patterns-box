using System;

namespace BridgePattern.Implementor
{
    public interface IError
    {
        string GetErrorMessage(Exception ex);
    }
}
