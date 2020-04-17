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

        public DbSet<IDidThatGame.Models.Action> Actions { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Challenge> Challenges { get; set; }
    }
}
