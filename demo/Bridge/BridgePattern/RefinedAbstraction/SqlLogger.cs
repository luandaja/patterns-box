using BridgePattern.Abstraction;
using BridgePattern.Implementor;
using System;

namespace BridgePattern.RefinedAbstraction
{
    public class SqlLogger : Logger
    {
        public SqlLogger(IError customMessage) : base (customMessage) { }

        public override void Write(Exception ex)
        {
            // SQL write logic goes here
            Console.WriteLine(_customMessage.GetErrorMessage(ex));
        }
    }
}
