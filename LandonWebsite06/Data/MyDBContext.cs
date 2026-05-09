using LandonWebsite06.Models;
using Microsoft.EntityFrameworkCore;

namespace LandonWebsite06.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }

        public DbSet<SpecialGuests> SpecialGuests { get; set; }
        public DbSet<Companies>    Companies      { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed exhibitor companies.
            // To apply schema changes, delete Event.db and restart the app.
            modelBuilder.Entity<Companies>().HasData(
                new Companies { ID = 101, companyName = "Microsoft",            boothnumber = 101 },
                new Companies { ID = 102, companyName = "Amazon Web Services",  boothnumber = 102 },
                new Companies { ID = 103, companyName = "Google",               boothnumber = 103 },
                new Companies { ID = 104, companyName = "NVIDIA",               boothnumber = 104 },
                new Companies { ID = 105, companyName = "Epic Games",           boothnumber = 105 },
                new Companies { ID = 106, companyName = "Intel",                boothnumber = 106 }
            );

            // Seed special guests with realistic tech industry profiles
            modelBuilder.Entity<SpecialGuests>().HasData(
                new SpecialGuests
                {
                    ID = 1, guestName = "Dr. Sarah Chen",
                    Title   = "Director of AI Research",
                    Company = "Microsoft",
                    Bio     = "Leading researcher in machine learning and natural language processing with over 15 years of industry experience."
                },
                new SpecialGuests
                {
                    ID = 2, guestName = "James Rodriguez",
                    Title   = "Chief Technology Officer",
                    Company = "Amazon Web Services",
                    Bio     = "Architect of large-scale cloud infrastructure serving millions of customers worldwide."
                },
                new SpecialGuests
                {
                    ID = 3, guestName = "Priya Patel",
                    Title   = "Lead Software Engineer",
                    Company = "Google",
                    Bio     = "Full-stack engineer specializing in distributed systems and developer tooling."
                },
                new SpecialGuests
                {
                    ID = 4, guestName = "Marcus Williams",
                    Title   = "Head of DevOps",
                    Company = "NVIDIA",
                    Bio     = "Pioneer in GPU-accelerated computing pipelines and continuous delivery at scale."
                },
                new SpecialGuests
                {
                    ID = 5, guestName = "Dr. Emily Foster",
                    Title   = "Cybersecurity Advisor",
                    Company = "CISA",
                    Bio     = "Former NSA analyst turned public-sector cybersecurity educator and policy expert."
                },
                new SpecialGuests
                {
                    ID = 6, guestName = "Alex Thompson",
                    Title   = "Senior Game Developer",
                    Company = "Epic Games",
                    Bio     = "Unreal Engine contributor and game systems architect with credits on multiple AAA titles."
                }
            );
        }
    }
}
