using Microsoft.EntityFrameworkCore;

namespace Test.Data
{
    public class TestDBContext : DbContext
    {
        public TestDBContext(DbContextOptions<TestDBContext> options) : base(options)
        {
        }
        public DbSet<Test.Models.Teacher> teachers {  get; set; }
        public DbSet<Test.Models.studentType> studentTypes {  get; set; }
    }
}
