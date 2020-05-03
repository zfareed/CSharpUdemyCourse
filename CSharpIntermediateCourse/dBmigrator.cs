namespace CSharpIntermediateCourse
{
    public class dBmigrator
    {
        private readonly Logger _logger;

        public dBmigrator(Logger logger)
        {
            this._logger = logger;
        }

        public void migrate()
        {
            _logger.Log("We are migrating DB ......");
        }
    }
}
