using BridgePattern.ConcreteImplementor;
using BridgePattern.Data;
using BridgePattern.RefinedAbstraction;
using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var exception = new CustomException().GetException();

            Console.WriteLine("Mongo Logger");
            WriteToMongo(exception);

            Console.WriteLine("\n=================================================\n");

            Console.WriteLine("SQL Logger");
            WriteToSql(exception);

            Console.WriteLine("\n=================================================\n");

            Console.WriteLine("Text File Logger");
            WriteToTextFile(exception);

            Console.ReadLine();
        }

        private static void WriteToMongo(Exception exception)
        {
            var mongoLogger = new MongoDbLogger(new DefaultError());
            mongoLogger.Write(exception);
        }

        private static void WriteToSql(Exception exception)
        {
            var sqlLogger = new SqlLogger(new DetailedError());
            sqlLogger.Write(exception);
        }

        private static void WriteToTextFile(Exception exception)
        {
            var textFileLogger = new TextFileLogger(new SpecificError());
            textFileLogger.Write(exception);
        }
    }
}
