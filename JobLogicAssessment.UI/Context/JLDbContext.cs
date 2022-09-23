using JobLogicAssessment.UI.Models;
using Microsoft.EntityFrameworkCore;

namespace JobLogicAssessment.UI.Context
{
    public class JLDbContext : DbContext
    {
        public JLDbContext(DbContextOptions<JLDbContext> options) : base(options)
        {

        }
        public DbSet<CustomerInfo> CustomerInfos { get; set; }
    }
}
