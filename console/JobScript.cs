using System;
using System.IO;
using System.Security.Cryptography;
using model;

namespace console
{
    public class JobScript : DbCommand
    {

        public JobScript()
            : base(
                "JobsScript", "Generate SQL Agent Jobs scripts for the specified server.")
        {
        }

        public override int Run(string[] args)
        {
            var db = CreateDatabase();
            db.LoadJobsScript();
            db.ScriptJobsToDir();

            Console.WriteLine("Create Script Jobs for SQL Agent Jobs successfully created at " + db.Dir);
            return 0;
        }
    }
}
