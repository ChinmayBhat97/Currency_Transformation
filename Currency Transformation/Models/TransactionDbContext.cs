using Microsoft.EntityFrameworkCore;

namespace Currency_Transformation.Models
{
    public class TransactionDbContext:DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext>options): base(options)
        {

        }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
