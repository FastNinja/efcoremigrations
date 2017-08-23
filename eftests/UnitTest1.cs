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
                var ctx = new BloggingContext("Host=localhost;Database=eftry;Username=postgres;Password=postgres");
                ctx.MigrateSchema();

        }
    }
}
