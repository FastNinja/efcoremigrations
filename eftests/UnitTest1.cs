using System;
using Xunit;
using efcore;
namespace eftests
{
    public class UnitTest1
    {
        [Fact]
        public void LetsCreateADatabase_ShallWe()
        {
            var connextionString = Environment.GetEnvironmentVariable("POSTGRES_CONNECTION_STRING");
            if(string.IsNullOrEmpty(connextionString)){
                throw new Exception("missing posgress connection string in env POSTGRES_CONNECTION_STRING " );
            }
            Console.WriteLine(connextionString);

            var ctx = new BloggingContext(connextionString);
            ctx.MigrateSchema();

        }
    }
}
