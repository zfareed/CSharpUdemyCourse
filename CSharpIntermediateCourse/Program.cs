using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediateCourse
{



    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new dBmigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.migrate();
            installer.Install();

           

        }
    }
}
