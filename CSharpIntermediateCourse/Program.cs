
using System;

namespace CSharpIntermediateCourse
{
    public class IConsoleLogger : ILogger
    {
         public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

        }
    }

    public class DbMigrator
    {
        private readonly ILogger logger;

        public DbMigrator(ILogger logger)
        {
            this.logger = logger;
        }
        public void Migrate()
        {

            logger.LogInfo("Migration starts at {0}" + DateTime.Now);


            logger.LogInfo("Migration ends at {0}" + DateTime.Now);


        }
    }


    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }


    class Program
    {
        static void Main(string[] args)
        {
            var dbmigrator = new DbMigrator(new IConsoleLogger());
            dbmigrator.Migrate();

        }
    }
}
