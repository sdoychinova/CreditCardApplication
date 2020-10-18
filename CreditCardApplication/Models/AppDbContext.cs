using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditCardApplication.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Application> Applications { get; set; }
        public DbSet<Card> Cards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>().HasData(new Card() {CardId=1, Type = CardType.BarclayCard, APR = 10, PromotionalMessage = "If you get a card you will also get a free online banking for an year" });
            modelBuilder.Entity<Card>().HasData(new Card() {CardId=2, Type = CardType.Vanquish, APR = 20, PromotionalMessage = "If you order a credit card you can take part in a lottary for five ski vacations in Zillertal." });
        }
    }
}
