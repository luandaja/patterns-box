using BridgePattern.Implementor;
using System;

namespace BridgePattern.Abstraction
{
    public abstract class Logger
    {
        public readonly IError _customMessage;

        public Logger(IError customMessage)
        {
            _customMessage = customMessage;
        }

        public abstract void Write(Exception ex);
    }
}
