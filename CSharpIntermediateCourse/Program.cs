
namespace CSharpIntermediateCourse
{
    public class DbMugrator
    {
        private readonly ILogger logger;

        public DbMugrator(ILogger logger)
        {
            this.logger = logger;
        }
        public void Migrate()
        {
            System.Console.WriteLine("Migration Started...");
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


        }
    }
}
