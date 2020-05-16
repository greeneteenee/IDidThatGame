using System;
using System.Collections.Generic;
using System.Text;
using IDidThatGame.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IDidThatGame.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ActionItem> Actions { get; set; }
        public DbSet<PlaceItem> Places { get; set; }
        public DbSet<ChallengeItem> Challenges { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.SeedActionItems();
            builder.SeedPlaceItems();
            builder.SeedChallengeItems();
        }

    }
}
