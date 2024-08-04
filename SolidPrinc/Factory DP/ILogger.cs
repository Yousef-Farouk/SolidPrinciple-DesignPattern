using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinc.Factory_DP
{
    public  interface ILogger
    {
        void Log(string message);

    }

    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            // Implementation for logging to a file
            Console.WriteLine($"FileLogger: {message}");
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            // Implementation for logging to a database
            Console.WriteLine($"DatabaseLogger: {message}");
        }
    }

    public interface LoggerFactory
    {
        public ILogger CreateLogger();
    }

    public class FileLoggerFactory : LoggerFactory
    {
        public ILogger CreateLogger() 
        {
            return new FileLogger();
        }
    }

    public class DatabaseLoggerFactory : LoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new DatabaseLogger();
        }
    }


    public class Client
    {
        private ILogger logger;

        public Client(LoggerFactory factory)
        {
            logger = factory.CreateLogger();
        }

        public ILogger GetLogger()
        {
            return logger;
        }

    }



}
