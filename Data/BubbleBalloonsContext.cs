using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using BubbleBalloons.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleBalloons.Data
{
    public class BubbleBalloonsContext : IdentityDbContext
    {
        public BubbleBalloonsContext(DbContextOptions<BubbleBalloonsContext> options)
            : base(options)
        {
        }
        public DbSet<Balloon> Balloon { get; set; }
    }
}
